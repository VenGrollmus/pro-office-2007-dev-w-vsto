'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public Class Workflow1
  Inherits SequentialWorkflowActivity
  Public Sub New()
    MyBase.New()
    InitializeComponent()
  End Sub
  Public workflowProperties As SPWorkflowActivationProperties = New Microsoft.SharePoint.Workflow.SPWorkflowActivationProperties
  Public CreateReviewNoteTask_TaskId As System.Guid = Nothing
  Public CreateReviewNoteTask_TaskProperties As Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties = New Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties
  Public onReviewNoteChanged_AfterProperties As Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties = New Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties
  Private _OpenReviewNote As Boolean = False
  Private Sub IsItDone(ByVal sender As System.Object, _
   ByVal e As System.Workflow.Activities.ConditionalEventArgs)
    Dim item As SPListItem = workflowProperties.Item

    Dim percent As Double = item("PercentComplete")
    If IsNothing(percent) Then percent = 0

    If percent = 1.0 Then
      e.Result = True
    Else
      e.Result = False
    End If
  End Sub

  Private Sub CreateReviewNoteTask_MethodInvoking(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim relatedItem As SPListItem = workflowProperties.Item

    CreateReviewNoteTask_TaskId = Guid.NewGuid
    CreateReviewNoteTask_TaskProperties.Title = "Review Note for: " & relatedItem("Title")
    CreateReviewNoteTask_TaskProperties.DueDate = Date.Now.AddDays(7)
    _OpenReviewNote = True
  End Sub

  Private Sub onReviewNoteChanged_Invoked(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)
    If onReviewNoteChanged_AfterProperties.PercentComplete = 1 Then
      _OpenReviewNote = False
    End If
  End Sub
End Class
