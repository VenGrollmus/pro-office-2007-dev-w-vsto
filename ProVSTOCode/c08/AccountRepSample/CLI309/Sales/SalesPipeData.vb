Imports Outlook = Microsoft.Office.Interop.Outlook
Imports System.Data


Public Class SalesPipeData
  Private Shared pipeline As SalesDataDataContext = New SalesDataDataContext


#Region "LINQ Queries"

  Friend Shared Function GetAllCustomers() As Array

    Dim custs = From c In pipeline.Customers Select _
                c.CustomerID, c.CompanyName Order By CompanyName
    Return custs.ToArray
  End Function

  Friend Shared Function GetOpportunity(ByVal OppID As String) As Opportunity
    Dim opp = (From o In pipeline.Opportunities Where _
               o.OpportunityID = OppID).First
    Return opp
  End Function


  Friend Shared Function GetOpportunites() As Array
    Dim opps = From o In pipeline.Opportunities _
               Select o.Customer.CompanyName, o.OpportunityName _
               , o.Service.ServiceName, o.DateCreated _
               , o.EstCloseDate, o.EstStartDate, o.EstEndDate, o.EstRevenue _
               , o.Notes _
               Order By OpportunityName
    Return opps.ToArray

  End Function



  Friend Shared Function GetOpportunitesList() As Array
    Dim opps = From o In pipeline.Opportunities _
               Select o.Customer.CompanyName, o.OpportunityName _
               , o.EstStartDate, o.Closed _
               Where Closed = False _
               Order By OpportunityName
    Return opps.ToArray

  End Function

  Friend Shared Function GetOpportunitesList(ByVal Customer As Integer) As Array
    Dim opps = From o In pipeline.Opportunities _
               Select o.OpportunityName, o.Customer.CompanyName, o.Status  _
               , o.EstStartDate, o.Closed, o.CustomerID,o.OpportunityID _
              Where CustomerID = Customer And (Closed = False) _
               Order By OpportunityName
    Return opps.ToArray

  End Function

  Friend Shared Function GetOpportunitesForChart(ByVal Customer As Integer) As DataTable
    Dim opps = From o In pipeline.Opportunities _
               Where o.CustomerID = Customer And (o.Closed = False) _
               Group By o.Status Into Total = _
               Count(o.OpportunityID)


    Dim a As Array = opps.ToArray

    Dim table As New DataTable
    table.Columns.Add("Status")
    table.Columns.Add("Total")
    For Each result In opps
      table.Rows.Add(result.Status, result.Total)
    Next

    ' Return opps.ToArray
    Return table

  End Function

  Friend Shared Function CloseOpportunity(ByVal OppID As String, _
    ByVal AccountingID As Guid) As Boolean

    Dim opp = (From o In pipeline.Opportunities Where o.OpportunityID = OppID).First
    Try
      With opp
        .Closed = True
        .ActualCloseDate = Now()
        .AccountingGUID = AccountingID
      End With

      pipeline.SubmitChanges()

      Return True
    Catch ex As Exception
      Return False
    End Try


  End Function

  Friend Shared Function UpdateAccount(ByVal SalesSystemID As String, _
                                       ByVal Company As String _
                                       , ByVal FName As String, _
                                       ByVal LName As String, _
                                      ByVal Email As String, _
                                      ByVal BusinessPhone As String, _
                                      ByVal Body As String) As Boolean

    Dim customer = (From c2 In pipeline.Customers Where c2.CustomerID = 1).First

    With customer
      .CompanyName = Company
      .FirstName = FName
      .LastName = LName
      .EmailAddress = Email
      .Phone = BusinessPhone
      .Notes = Body
      .ModifiedDate = Microsoft.VisualBasic.Now

    End With

    pipeline.SubmitChanges()

  End Function

#End Region

#Region "Outlook Related Helper Functions"
  Friend Shared Function ImportSalesAccounts() As Boolean
    Dim accts = From a In pipeline.Customers _
                Select  a.CustomerID, a.CompanyName, a.FirstName, a.LastName _
                , a.Phone, a.EmailAddress, a.Notes, a.ModifiedDate

    Dim fldr As Outlook.Folder = FindFolderFromPath( _
     "\\Personal Folders\Accounts")


    For Each name In accts
      Dim na As Outlook.ContactItem = fldr.Items.Add("IPM.Contact.Account")
      na.MessageClass = "IPM.Contact.Account"
      na.CompanyName = name.CompanyName
      na.FirstName = name.FirstName
      na.LastName = name.LastName
      na.BusinessTelephoneNumber = name.Phone
      na.Email1Address = name.EmailAddress
      na.Body = name.Notes

      Dim up As Outlook.UserProperty = na.UserProperties.Find("SalesSystemID")
      If up Is Nothing Then
        up = na.UserProperties.Add("SalesSystemID", _
             Outlook.OlUserPropertyType.olText, True)
        up.Value = name.CustomerID
      Else
        up.Value = name.CustomerID
      End If


      na.Close(Outlook.OlInspectorClose.olSave)

    Next
  End Function

  Private Shared Function FindFolderFromPath(ByVal FolderPath As String) _
    As Outlook.Folder

    Dim TestFldr As Outlook.Folder
    Dim FoldersArray As Object
    Dim i As Integer


    If Left(FolderPath, 2) = "\\" Then
      FolderPath = Right(FolderPath, Len(FolderPath) - 2)
    End If
    'Convert folderpath to array
    FoldersArray = Split(FolderPath, "\")
    TestFldr = Globals.ThisAddIn.Application.Session.Folders.Item(FoldersArray(0))
    If Not TestFldr Is Nothing Then
      For i = 1 To UBound(FoldersArray, 1)
        Dim SubFolders As Outlook.Folders
        SubFolders = TestFldr.Folders
        TestFldr = SubFolders.Item(FoldersArray(i))
        If TestFldr Is Nothing Then
          Return Nothing
        End If
      Next
    End If
    'Return the TestFolder
    Return TestFldr


  End Function

#End Region

End Class
