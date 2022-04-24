Imports Telerik.Charting

Public Class ItemActionPane
  Private _contact As Outlook.ContactItem

  Private Sub ItemActionPane_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim id As Integer = GetUserProperty("SalesSystemID")
    dgOpps.DataSource = SalesPipeData.GetOpportunitesList(id)

    dgOpps.Columns("OpportunityID").Visible = False
    dgOpps.Columns("CompanyName").Visible = False
    dgOpps.Columns("Closed").Visible = False
    dgOpps.Columns("CustomerID").Visible = False

    dgOpps.Columns("OpportunityName").DisplayIndex = 0
    dgOpps.Columns("Status").DisplayIndex = 1
    dgOpps.Columns("EstStartDate").DisplayIndex = 2


    dgOpps.Refresh()

    OppsChart.DataSource = SalesPipeData.GetOpportunitesForChart(id)
    OppsChart.PlotArea.XAxis.DataLabelsColumn = "Status"
    OppsChart.PlotArea.XAxis.Appearance.LabelAppearance.RotationAngle = 300

    OppsChart.DataBind()

  End Sub

  Friend Sub RefreshData()
    dgOpps.DataSource = SalesPipeData.GetOpportunitesList(1)
    dgOpps.Refresh()

    OppsChart.Refresh()

  End Sub


  Private Function GetUserProperty(ByVal UserPropName As String) As String

    Dim userProp As Outlook.UserProperty
    Try
      'Check to determine if Prop exists
      userProp = _contact.UserProperties.Find(UserPropName)

      If (userProp Is Nothing) Then
        Return ""
      End If
      Dim value As String = userProp.Value.ToString()

      Return value
    Catch ex As Exception
      Return Nothing
    End Try

  End Function


#Region "Properties"

  Friend ReadOnly Property OpportunityID() As String
    Get
      Dim oppID As Object
      Dim rowIndex As Integer

      If dgOpps.SelectedCells.Count > 0 Then

        rowIndex = dgOpps.SelectedCells(0).RowIndex
        If (rowIndex + 0 < dgOpps.RowCount) Then

          oppID = dgOpps("OpportunityID", rowIndex).Value
          If oppID IsNot Nothing Then
            Return oppID
          Else
            Return "0"
          End If
        End If
      End If

      Return "0"
    End Get
  End Property

  Friend Property Contact() As Outlook.ContactItem
    Get
      Return _contact
    End Get
    Set(ByVal value As Outlook.ContactItem)
      _contact = value
    End Set
  End Property

#End Region


End Class
