<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workflow1

  'NOTE: The following procedure is required by the Workflow Designer
  'It can be modified using the Workflow Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Private Sub InitializeComponent()
    Me.CanModifyActivities = True
    Dim correlationtoken1 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken
    Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim activitybind2 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim activitybind3 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
    Dim ruleconditionreference1 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
    Dim correlationtoken2 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken
    Dim activitybind4 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Me.CreateReviewNoteTask = New Microsoft.SharePoint.WorkflowActions.CreateTask
    Me.onReviewNoteChanged = New Microsoft.SharePoint.WorkflowActions.OnTaskChanged
    Me.ifElseBranchActivity2 = New System.Workflow.Activities.IfElseBranchActivity
    Me.IfAuditStepCompleted = New System.Workflow.Activities.IfElseBranchActivity
    Me.whileReviewNoteOpen = New System.Workflow.Activities.WhileActivity
    Me.IfItemComplete = New System.Workflow.Activities.IfElseActivity
    Me.onWorkflowActivated1 = New Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated
    '
    'CreateReviewNoteTask
    '
    correlationtoken1.Name = "ReviewNoteToken"
    correlationtoken1.OwnerActivityName = "Workflow1"
    Me.CreateReviewNoteTask.CorrelationToken = correlationtoken1
    Me.CreateReviewNoteTask.ListItemId = -1
    Me.CreateReviewNoteTask.Name = "CreateReviewNoteTask"
    Me.CreateReviewNoteTask.SpecialPermissions = Nothing
    activitybind1.Name = "Workflow1"
    activitybind1.Path = "CreateReviewNoteTask_TaskId"
    activitybind2.Name = "Workflow1"
    activitybind2.Path = "CreateReviewNoteTask_TaskProperties"
    AddHandler Me.CreateReviewNoteTask.MethodInvoking, AddressOf Me.CreateReviewNoteTask_MethodInvoking
    Me.CreateReviewNoteTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskIdProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
    Me.CreateReviewNoteTask.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskPropertiesProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
    '
    'onReviewNoteChanged
    '
    activitybind3.Name = "Workflow1"
    activitybind3.Path = "onReviewNoteChanged_AfterProperties"
    Me.onReviewNoteChanged.BeforeProperties = Nothing
    Me.onReviewNoteChanged.CorrelationToken = correlationtoken1
    Me.onReviewNoteChanged.Executor = Nothing
    Me.onReviewNoteChanged.Name = "onReviewNoteChanged"
    Me.onReviewNoteChanged.TaskId = New System.Guid("00000000-0000-0000-0000-000000000000")
    AddHandler Me.onReviewNoteChanged.Invoked, AddressOf Me.onReviewNoteChanged_Invoked
    Me.onReviewNoteChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, CType(activitybind3, System.Workflow.ComponentModel.ActivityBind))
    '
    'ifElseBranchActivity2
    '
    Me.ifElseBranchActivity2.Name = "ifElseBranchActivity2"
    '
    'IfAuditStepCompleted
    '
    Me.IfAuditStepCompleted.Activities.Add(Me.CreateReviewNoteTask)
    AddHandler codecondition1.Condition, AddressOf Me.IsItDone
    Me.IfAuditStepCompleted.Condition = codecondition1
    Me.IfAuditStepCompleted.Name = "IfAuditStepCompleted"
    '
    'whileReviewNoteOpen
    '
    Me.whileReviewNoteOpen.Activities.Add(Me.onReviewNoteChanged)
    ruleconditionreference1.ConditionName = "Condition1"
    Me.whileReviewNoteOpen.Condition = ruleconditionreference1
    Me.whileReviewNoteOpen.Name = "whileReviewNoteOpen"
    '
    'IfItemComplete
    '
    Me.IfItemComplete.Activities.Add(Me.IfAuditStepCompleted)
    Me.IfItemComplete.Activities.Add(Me.ifElseBranchActivity2)
    Me.IfItemComplete.Name = "IfItemComplete"
    '
    'onWorkflowActivated1
    '
    correlationtoken2.Name = "workflowToken"
    correlationtoken2.OwnerActivityName = "Workflow1"
    Me.onWorkflowActivated1.CorrelationToken = correlationtoken2
    Me.onWorkflowActivated1.EventName = "OnWorkflowActivated"
    Me.onWorkflowActivated1.Name = "onWorkflowActivated1"
    activitybind4.Name = "Workflow1"
    activitybind4.Path = "workflowProperties"
    Me.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, CType(activitybind4, System.Workflow.ComponentModel.ActivityBind))
    '
    'Workflow1
    '
    Me.Activities.Add(Me.onWorkflowActivated1)
    Me.Activities.Add(Me.IfItemComplete)
    Me.Activities.Add(Me.whileReviewNoteOpen)
    Me.Name = "Workflow1"
    Me.CanModifyActivities = False

  End Sub
  Private whileReviewNoteOpen As System.Workflow.Activities.WhileActivity
  Private onReviewNoteChanged As Microsoft.SharePoint.WorkflowActions.OnTaskChanged
  Private ifElseBranchActivity2 As System.Workflow.Activities.IfElseBranchActivity
  Private IfAuditStepCompleted As System.Workflow.Activities.IfElseBranchActivity
  Private IfItemComplete As System.Workflow.Activities.IfElseActivity
  Private CreateReviewNoteTask As Microsoft.SharePoint.WorkflowActions.CreateTask
  Private onWorkflowActivated1 As Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated


End Class
