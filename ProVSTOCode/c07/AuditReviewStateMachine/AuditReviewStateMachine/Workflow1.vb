'NOTE: When changing the namespace; please update XmlnsDefinitionAttribute in AssemblyInfo.vb
Public Class Workflow1
  Inherits StateMachineWorkflowActivity
  Public Sub New()
    MyBase.New()
    InitializeComponent()
  End Sub
  Public workflowProperties As SPWorkflowActivationProperties = New Microsoft.SharePoint.Workflow.SPWorkflowActivationProperties
  Public createReviewNote_TaskId As System.Guid = Nothing
  Public createReviewNote_TaskProperties As Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties = New Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties
  Public onReviewNoteChanged_AfterProperties As Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties = New Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties

  Private Sub IsItemInProgress(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ConditionalEventArgs)
    Dim relatedItem As SPListItem = workflowProperties.Item

    Select Case relatedItem("Status")
      Case "Not Started"
        e.Result = False
      Case "Approved"
        e.Result = False
      Case Else
        e.Result = True
    End Select
  End Sub

  Private Sub IsNotStarted(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ConditionalEventArgs)
    Dim relatedItem As SPListItem = workflowProperties.Item

    Select Case relatedItem("Status")
      Case "Not Started"
        e.Result = True
      Case "Approved"
        e.Result = True
      Case Else
        e.Result = False
    End Select

  End Sub

  Private Sub IsComplete(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ConditionalEventArgs)
    Dim relatedItem As SPListItem = workflowProperties.Item

    Select Case relatedItem("Status")
      Case "Ready for Review"
        e.Result = True
      Case Else
        e.Result = False
    End Select

  End Sub
  Public onTaskChanged_AfterProperties As Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties = New Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties


  Private Sub sendInProgressEmail_MethodInvoking(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub onWorkflowItemChanged_Invoked(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)

  End Sub
  Public createReviewNote_TaskProperties1 As Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties = New Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties

  Private Sub onReviewNoteChanged_Invoked(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ExternalDataEventArgs)

  End Sub

  Private Sub createReviewNote_MethodInvoking_1(ByVal sender As System.Object, _
    ByVal e As System.EventArgs)

    Dim relatedItem As SPListItem = workflowProperties.Item
    createReviewNote_TaskId = Guid.NewGuid
    createReviewNote_TaskProperties.Title = "Review: " & relatedItem("Title")

  End Sub
End Class
