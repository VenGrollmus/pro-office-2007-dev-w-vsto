Imports Microsoft.BusinessSolutions.SmallBusinessAccounting.Loader
Imports Microsoft.BusinessSolutions.SmallBusinessAccounting
Imports System.IO
Imports System.Data
Imports System.Windows.Forms


Public Class SBATools

  Private Shared ldr As ILoader
  Private Shared sbi As ISmallBusinessInstanceV2

  Shared Sub New()
    InstantiateLoader()
    LoadCompanyFile()

  End Sub

  Private Shared Function InstantiateLoader() As ILoader
    Try
      ldr = LoaderUtil.InstantiateLoader()
      Return ldr
    Catch ex As Exception
      MsgBox("Unable to instantiate Loader object. Application must exit.", _
             MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Load Failure")
      Return Nothing
    End Try
  End Function


  Private Shared Sub LoadCompanyFile()
    Dim sbaFile As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & _
                            Path.DirectorySeparatorChar & "Small Business Accounting\Companies" & _
                            Path.DirectorySeparatorChar & "SampleServiceCompany2008.sbc"

    ldr = InstantiateLoader()
    sbi = DirectCast(ldr.GetSbaObjects(sbaFile).SmallBusinessInstance, ISmallBusinessInstanceV2)
  End Sub


  Friend Shared Function GetEmployeeByGUID(ByVal GUIDString As String) As IEmployeeAccountV2
    Try
      Dim g As Guid = New Guid(GUIDString)

      Dim emp As IEmployeeAccountV2
      emp = sbi.EmployeeAccounts.GetByGuid(g)
      Return emp
    Catch ex As Exception
      Return nothing
    End Try
  End Function


  Friend Shared Function GetJobByGUID(ByVal GUIDString As String) As  _
    IJobAccountV2
    Try
      Dim g As Guid = New Guid(GUIDString)

      Dim job As IJobAccountV2
      job = sbi.JobAccounts.GetByGuid(g)
      Return job
    Catch ex As Exception
      Return Nothing
    End Try
  End Function


  Friend Shared Function GetBillCodeByGUID(ByVal GUIDString As String) As  _
    IItemAccount
    Try
      Dim g As Guid = New Guid(GUIDString)

      Dim code As IItemAccount
      code = sbi.ItemAccounts.GetByGuid(g)
      Return code
    Catch ex As Exception
      Return Nothing
    End Try
  End Function




  Friend Shared Sub PopulateList(ByVal listCollection As  _
    ComboBox.ObjectCollection, ByVal sbaView As IBaseMasterView)

    Dim rowView As DataRowView      ' Loop variable for the DataView
    listCollection.Clear()

    ' Clear the collection if it is not already empty
    If (listCollection.Count > 0) Then
      listCollection.Clear()
    End If

    ' Iterate through the view instance and store the SBA 
    ' object corresponding to each
    '  data row into the ListBox.Items collection
    For Each rowView In sbaView.DataView
      listCollection.Add(sbaView.GetByDataRow(rowView.Row))
    Next

  End Sub


  Friend Shared Sub PopulateServiceItems(ByVal Control As ComboBox)
    Dim rowItem As IItemAccount             ' Object in the IItemView collection
    Dim rowNonKitItem As INonKitItemAccount ' rowItem, cast to INonKitItemAccount
    Dim rowView As DataRowView              ' Loop variable for the DataView


    Control.Items.Clear()

    ' Populate itemListBox with INonKitItemAccount objects from the main IItemView
    '  that have been assigned a PurchaseFinancialAccount

    For Each rowView In SBATools.SBAObjects.ItemAccounts.DataView
      rowItem = DirectCast(SBATools.SBAObjects.ItemAccounts.GetByDataRow( _
        rowView.Row), IItemAccountV2)

      If TypeOf rowItem Is INonKitItemAccount Then
        rowNonKitItem = DirectCast(rowItem, INonKitItemAccount)
        If rowNonKitItem.PurchaseFinancialAccount IsNot Nothing Then
          Control.Items.Add(rowItem)
        End If
      End If
    Next
  End Sub

  Friend Shared Function CreateProject(ByVal Opp As Opportunity) As Guid
    Dim customer As ICustomerAccount

    '1 - check if existing customer


    If Opp.AccountingGUID Is Nothing Then
      '1a - create customer account
      customer = SBAObjects.CreateCustomerAccount
      With customer
        .Name = Opp.Customer.CompanyName
        .Active = True
        .AccountSince = Now
        .Save()
      End With
    Else
      customer = SBAObjects.CustomerAccounts.GetByGuid(Opp.AccountingGUID)
    End If

    '2 - Create Project
    Dim job As IJobAccount
    job = sbi.CreateJobAccount()
    job.Name = Opp.OpportunityName
    job.Customer = customer
    job.Save()

    '3 - Return Project ID
    Return job.Guid


  End Function



  Shared ReadOnly Property SBAObjects() As ISmallBusinessInstanceV2
    Get
      Return sbi
    End Get
  End Property






End Class
