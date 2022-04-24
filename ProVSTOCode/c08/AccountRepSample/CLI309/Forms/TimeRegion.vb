Imports Microsoft.BusinessSolutions.SmallBusinessAccounting.Loader
Imports Microsoft.BusinessSolutions.SmallBusinessAccounting
Imports System.IO
Imports System.Data
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook

Public Class TimeRegion
  'Dim _ai As Outlook.AppointmentItem
#Region "Form Region Factory"
  '  <Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Task)> _
  <Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Appointment)> _
  <Microsoft.Office.Tools.Outlook.FormRegionName("CLI309.TimeRegion")> _
  Partial Public Class TimeRegionFactory

    ' Occurs before the form region is initialized.
    ' To prevent the form region from appearing, set e.Cancel to true.
    ' Use e.OutlookItem to get a reference to the current Outlook item.
    Private Sub TimeRegionFactory_FormRegionInitializing(ByVal sender As Object, ByVal e As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs) Handles Me.FormRegionInitializing

    End Sub

  End Class

#End Region

  'Occurs before the form region is displayed. 
  'Use Me.OutlookItem to get a reference to the current Outlook item.
  'Use Me.OutlookFormRegion to get a reference to the form region.
  Private Sub TimeRegion_FormRegionShowing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionShowing
    '_ai = DirectCast(Me.OutlookItem, Outlook.AppointmentItem)
    LoadCombos()
    GetPropValues()
    
  End Sub

  'Occurs when the form region is closed.   
  'Use Me.OutlookItem to get a reference to the current Outlook item.
  'Use Me.OutlookFormRegion to get a reference to the form region.
  Private Sub TimeRegion_FormRegionClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FormRegionClosed
    SavePropValues()

    '_ai.Close(Outlook.OlInspectorClose.olSave)
    '_ai = Nothing
  End Sub



#Region "Working With Properties"
  Friend Sub GetPropValues()

    Try
      'Get and Set Employee Object
      Dim emp As IEmployeeAccountV2 = SBATools.GetEmployeeByGUID(GetUserProperty("TimeEmployee"))
      cboEmployee.SelectedItem = emp

      'Get and Set Project/Job Object
      Dim job As IJobAccountV2 = SBATools.GetJobByGUID(GetUserProperty("TimeJob"))
      cboJob.SelectedItem = job

      'Get and Set BillCode Object
      Dim code As IItemAccount = SBATools.GetBillCodeByGUID(GetUserProperty("TimeBillCode"))
      cboBillCode.SelectedItem = code


      txtAcctGUID.Text = GetUserProperty("TimeAcctGUID")
      Dim isBill As String = GetUserProperty("TimeBillable")
      If isBill = "True" Then
        chkBillable.Checked = True
      Else
        chkBillable.Checked = False
      End If
    Catch ex As Exception
      MsgBox(ex.Message)
    End Try


  End Sub

  Friend Sub SavePropValues()

    SaveUserProperty("TimeEmployee", Me.CurrentEmployee.Guid.ToString)
    SaveUserProperty("TimeJob", me.CurrentJob.Guid.ToString)
    SaveUserProperty("TimeBillCode", Me.CurrentServiceItem.Guid.ToString)
    SaveUserProperty("TimeAcctGUID", Me.CurrentAccountGUID.ToString)
    If chkBillable.Checked Then
      SaveUserProperty("TimeBillable", "True")
    Else
      SaveUserProperty("TimeBillable", "False")
    End If
  End Sub

  Private Sub SaveUserProperty(ByVal UserPropName As String, ByVal UserPropValue As String)
    'TODO: Maybe put the next line in SaveUserProperties
    Dim ai = DirectCast(Me.OutlookItem, Outlook.AppointmentItem)
    Dim userProp As Outlook.UserProperty
    Try
      'Check to determine if Prop exists
      userProp = ai.UserProperties.Find(UserPropName)
      If (userProp Is Nothing) Then

        userProp = ai.UserProperties.Add(UserPropName, Outlook.OlUserPropertyType.olText)
        userProp.Value = UserPropValue
      Else
        userProp.Value = UserPropValue
      End If
      ai = Nothing
      'Marshal.ReleaseComObject(ai)
    Catch ex As Exception

    End Try

  End Sub

  Private Function GetUserProperty(ByVal UserPropName As String) As String
    Dim ai = DirectCast(Me.OutlookItem, Outlook.AppointmentItem)
    Dim userProp As Outlook.UserProperty
    Try
      'Check to determine if Prop exists
      userProp = ai.UserProperties.Find(UserPropName)

      If (userProp Is Nothing) Then
        Return ""
      End If
      Dim value As String = userProp.Value.ToString()

      'ai = Nothing
      'Marshal.ReleaseComObject(ai)

      Return value
    Catch ex As Exception
      Return Nothing
    End Try

  End Function
#End Region




#Region "CustomMethods"

  Private Sub LoadCombos()
    SBATools.PopulateList(Me.cboEmployee.Items, SBATools.SBAObjects.EmployeeNames)
    SBATools.PopulateList(Me.cboJob.Items, SBATools.SBAObjects.JobNames)
    SBATools.PopulateServiceItems(Me.cboBillCode)
  End Sub



#End Region

#Region "Control Events"


  Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    Dim ts As ITimeSlip
    Dim ai As Outlook.AppointmentItem = DirectCast(Me.OutlookItem, Outlook.AppointmentItem)
    If Len(txtAcctGUID.Text) = 0 Then
      ts = SBATools.SBAObjects.CreateTimeSlip()
      ts.StartDateTime = ai.Start
      ts.JobAccount = Me.CurrentJob
      ts.ItemAccount = Me.CurrentServiceItem
      ts.EmployeeAccount = Me.CurrentEmployee
      ts.IsBillable = Me.chkBillable.Checked
      ts.Duration = (ai.Duration / 60)
      ts.Comments = ai.Subject
      ts.Description = ai.Body

      Try
        ts.Save()
      Catch ex As Exception
        MsgBox(ex.Message)

      End Try

    Else

      ts = SBATools.SBAObjects.TimeSlips.GetByGuid(Me.CurrentAccountGUID)
      ts.StartDateTime = ai.Start
      ts.JobAccount = Me.CurrentJob
      ts.ItemAccount = Me.CurrentServiceItem
      ts.EmployeeAccount = Me.CurrentEmployee
      ts.IsBillable = Me.chkBillable.Checked
      ts.Duration = (ai.Duration / 60)
      ts.Comments = ai.Subject
      ts.Description = ai.Body
      Try
        ts.Save()
      Catch ex As Exception
        MsgBox(ex.Message)

      End Try
    End If

    txtAcctGUID.Text = ts.Guid.ToString
    ai = Nothing
    ''Marshal.ReleaseComObject(ai)
  End Sub

#End Region

#Region "Form Properties"


  ReadOnly Property CurrentServiceItem() As IItemAccount
    Get
      Return DirectCast(Me.cboBillCode.SelectedItem, IItemAccount)
    End Get
  End Property

  ReadOnly Property CurrentAccountGUID() As Guid
    Get
      If Len(txtAcctGUID.Text) Then
        Dim g As Guid = New Guid(txtAcctGUID.Text)
        Return g
      Else
        Return Nothing


      End If


    End Get
  End Property

  ReadOnly Property CurrentJob() As IJobAccount
    Get
      Return DirectCast(Me.cboJob.SelectedItem, IJobAccountv2)
    End Get
  End Property



  ReadOnly Property CurrentEmployee() As IEmployeeAccount
    Get
      Return DirectCast(Me.cboEmployee.SelectedItem, IEmployeeAccountV2)
    End Get
  End Property


#End Region



End Class
