<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workflow1

  'NOTE: The following procedure is required by the Workflow Designer
  'It can be modified using the Workflow Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Private Sub InitializeComponent()
    Me.CanModifyActivities = True
    Dim ruleconditionreference1 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
    Dim ruleconditionreference2 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
    Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
    Dim codecondition2 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
    Dim codecondition3 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
    Dim correlationtoken1 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken
    Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim activitybind2 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim activitybind3 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim activitybind4 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim correlationtoken2 As System.Workflow.Runtime.CorrelationToken = New System.Workflow.Runtime.CorrelationToken
    Dim activitybind5 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Me.setStateActivity1 = New System.Workflow.Activities.SetStateActivity
    Me.setStateCompleted = New System.Workflow.Activities.SetStateActivity
    Me.setStateReview = New System.Workflow.Activities.SetStateActivity
    Me.terminateActivity1 = New System.Workflow.ComponentModel.TerminateActivity
    Me.setStateInProgress = New System.Workflow.Activities.SetStateActivity
    Me.ifStillInProgress = New System.Workflow.Activities.IfElseBranchActivity
    Me.ifCompleted = New System.Workflow.Activities.IfElseBranchActivity
    Me.ifElseBranchActivity2 = New System.Workflow.Activities.IfElseBranchActivity
    Me.ifComplete = New System.Workflow.Activities.IfElseBranchActivity
    Me.ifNotInProgress = New System.Workflow.Activities.IfElseBranchActivity
    Me.ifInProgress = New System.Workflow.Activities.IfElseBranchActivity
    Me.createReviewNote = New Microsoft.SharePoint.WorkflowActions.CreateTask
    Me.ifElseActivity1 = New System.Workflow.Activities.IfElseActivity
    Me.onReviewNoteChanged = New Microsoft.SharePoint.WorkflowActions.OnTaskChanged
    Me.ifElseActivity2 = New System.Workflow.Activities.IfElseActivity
    Me.onWorkflowItemChanged = New Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged
    Me.ifElseActivity = New System.Workflow.Activities.IfElseActivity
    Me.onWorkflowActivated1 = New Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated
    Me.stateInitializationActivity2 = New System.Workflow.Activities.StateInitializationActivity
    Me.eventReviewNoteChanged = New System.Workflow.Activities.EventDrivenActivity
    Me.eventAuditProgramStepChanged = New System.Workflow.Activities.EventDrivenActivity
    Me.stateInitializationActivity1 = New System.Workflow.Activities.StateInitializationActivity
    Me.eventWorkflowInitialized = New System.Workflow.Activities.EventDrivenActivity
    Me.stateReview = New System.Workflow.Activities.StateActivity
    Me.stateInProgress = New System.Workflow.Activities.StateActivity
    Me.stateComplete = New System.Workflow.Activities.StateActivity
    Me.stateInitial = New System.Workflow.Activities.StateActivity
    '
    'setStateActivity1
    '
    Me.setStateActivity1.Name = "setStateActivity1"
    Me.setStateActivity1.TargetStateName = "stateInProgress"
    '
    'setStateCompleted
    '
    Me.setStateCompleted.Name = "setStateCompleted"
    Me.setStateCompleted.TargetStateName = "stateComplete"
    '
    'setStateReview
    '
    Me.setStateReview.Name = "setStateReview"
    Me.setStateReview.TargetStateName = "stateReview"
    '
    'terminateActivity1
    '
    Me.terminateActivity1.Name = "terminateActivity1"
    '
    'setStateInProgress
    '
    Me.setStateInProgress.Name = "setStateInProgress"
    Me.setStateInProgress.TargetStateName = "stateInProgress"
    '
    'ifStillInProgress
    '
    Me.ifStillInProgress.Activities.Add(Me.setStateActivity1)
    ruleconditionreference1.ConditionName = "IfStillInProgress"
    Me.ifStillInProgress.Condition = ruleconditionreference1
    Me.ifStillInProgress.Name = "ifStillInProgress"
    '
    'ifCompleted
    '
    Me.ifCompleted.Activities.Add(Me.setStateCompleted)
    ruleconditionreference2.ConditionName = "IfCompleted"
    Me.ifCompleted.Condition = ruleconditionreference2
    Me.ifCompleted.Name = "ifCompleted"
    '
    'ifElseBranchActivity2
    '
    Me.ifElseBranchActivity2.Name = "ifElseBranchActivity2"
    '
    'ifComplete
    '
    Me.ifComplete.Activities.Add(Me.setStateReview)
    AddHandler codecondition1.Condition, AddressOf Me.IsComplete
    Me.ifComplete.Condition = codecondition1
    Me.ifComplete.Name = "ifComplete"
    '
    'ifNotInProgress
    '
    Me.ifNotInProgress.Activities.Add(Me.terminateActivity1)
    AddHandler codecondition2.Condition, AddressOf Me.IsNotStarted
    Me.ifNotInProgress.Condition = codecondition2
    Me.ifNotInProgress.Name = "ifNotInProgress"
    '
    'ifInProgress
    '
    Me.ifInProgress.Activities.Add(Me.setStateInProgress)
    AddHandler codecondition3.Condition, AddressOf Me.IsItemInProgress
    Me.ifInProgress.Condition = codecondition3
    Me.ifInProgress.Description = "IsItemInProgress"
    Me.ifInProgress.Name = "ifInProgress"
    '
    'createReviewNote
    '
    correlationtoken1.Name = "ReviewToken"
    correlationtoken1.OwnerActivityName = "stateReview"
    Me.createReviewNote.CorrelationToken = correlationtoken1
    Me.createReviewNote.ListItemId = -1
    Me.createReviewNote.Name = "createReviewNote"
    Me.createReviewNote.SpecialPermissions = Nothing
    activitybind1.Name = "Workflow1"
    activitybind1.Path = "createReviewNote_TaskId"
    activitybind2.Name = "Workflow1"
    activitybind2.Path = "createReviewNote_TaskProperties1"
    AddHandler Me.createReviewNote.MethodInvoking, AddressOf Me.createReviewNote_MethodInvoking_1
    Me.createReviewNote.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskIdProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
    Me.createReviewNote.SetBinding(Microsoft.SharePoint.WorkflowActions.CreateTask.TaskPropertiesProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
    '
    'ifElseActivity1
    '
    Me.ifElseActivity1.Activities.Add(Me.ifCompleted)
    Me.ifElseActivity1.Activities.Add(Me.ifStillInProgress)
    Me.ifElseActivity1.Name = "ifElseActivity1"
    '
    'onReviewNoteChanged
    '
    activitybind3.Name = "Workflow1"
    activitybind3.Path = "onReviewNoteChanged_AfterProperties"
    Me.onReviewNoteChanged.BeforeProperties = Nothing
    Me.onReviewNoteChanged.CorrelationToken = correlationtoken1
    Me.onReviewNoteChanged.Executor = Nothing
    Me.onReviewNoteChanged.Name = "onReviewNoteChanged"
    activitybind4.Name = "Workflow1"
    activitybind4.Path = "createReviewNote_TaskId"
    AddHandler Me.onReviewNoteChanged.Invoked, AddressOf Me.onReviewNoteChanged_Invoked
    Me.onReviewNoteChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.TaskIdProperty, CType(activitybind4, System.Workflow.ComponentModel.ActivityBind))
    Me.onReviewNoteChanged.SetBinding(Microsoft.SharePoint.WorkflowActions.OnTaskChanged.AfterPropertiesProperty, CType(activitybind3, System.Workflow.ComponentModel.ActivityBind))
    '
    'ifElseActivity2
    '
    Me.ifElseActivity2.Activities.Add(Me.ifComplete)
    Me.ifElseActivity2.Activities.Add(Me.ifElseBranchActivity2)
    Me.ifElseActivity2.Name = "ifElseActivity2"
    '
    'onWorkflowItemChanged
    '
    Me.onWorkflowItemChanged.AfterProperties = Nothing
    Me.onWorkflowItemChanged.BeforeProperties = Nothing
    correlationtoken2.Name = "workflowToken"
    correlationtoken2.OwnerActivityName = "Workflow1"
    Me.onWorkflowItemChanged.CorrelationToken = correlationtoken2
    Me.onWorkflowItemChanged.Name = "onWorkflowItemChanged"
    AddHandler Me.onWorkflowItemChanged.Invoked, AddressOf Me.onWorkflowItemChanged_Invoked
    '
    'ifElseActivity
    '
    Me.ifElseActivity.Activities.Add(Me.ifInProgress)
    Me.ifElseActivity.Activities.Add(Me.ifNotInProgress)
    Me.ifElseActivity.Name = "ifElseActivity"
    '
    'onWorkflowActivated1
    '
    Me.onWorkflowActivated1.CorrelationToken = correlationtoken2
    Me.onWorkflowActivated1.EventName = "OnWorkflowActivated"
    Me.onWorkflowActivated1.Name = "onWorkflowActivated1"
    activitybind5.Name = "Workflow1"
    activitybind5.Path = "workflowProperties"
    Me.onWorkflowActivated1.SetBinding(Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated.WorkflowPropertiesProperty, CType(activitybind5, System.Workflow.ComponentModel.ActivityBind))
    '
    'stateInitializationActivity2
    '
    Me.stateInitializationActivity2.Activities.Add(Me.createReviewNote)
    Me.stateInitializationActivity2.Name = "stateInitializationActivity2"
    '
    'eventReviewNoteChanged
    '
    Me.eventReviewNoteChanged.Activities.Add(Me.onReviewNoteChanged)
    Me.eventReviewNoteChanged.Activities.Add(Me.ifElseActivity1)
    Me.eventReviewNoteChanged.Name = "eventReviewNoteChanged"
    '
    'eventAuditProgramStepChanged
    '
    Me.eventAuditProgramStepChanged.Activities.Add(Me.onWorkflowItemChanged)
    Me.eventAuditProgramStepChanged.Activities.Add(Me.ifElseActivity2)
    Me.eventAuditProgramStepChanged.Name = "eventAuditProgramStepChanged"
    '
    'stateInitializationActivity1
    '
    Me.stateInitializationActivity1.Name = "stateInitializationActivity1"
    '
    'eventWorkflowInitialized
    '
    Me.eventWorkflowInitialized.Activities.Add(Me.onWorkflowActivated1)
    Me.eventWorkflowInitialized.Activities.Add(Me.ifElseActivity)
    Me.eventWorkflowInitialized.Name = "eventWorkflowInitialized"
    '
    'stateReview
    '
    Me.stateReview.Activities.Add(Me.eventReviewNoteChanged)
    Me.stateReview.Activities.Add(Me.stateInitializationActivity2)
    Me.stateReview.Name = "stateReview"
    '
    'stateInProgress
    '
    Me.stateInProgress.Activities.Add(Me.stateInitializationActivity1)
    Me.stateInProgress.Activities.Add(Me.eventAuditProgramStepChanged)
    Me.stateInProgress.Name = "stateInProgress"
    '
    'stateComplete
    '
    Me.stateComplete.Name = "stateComplete"
    '
    'stateInitial
    '
    Me.stateInitial.Activities.Add(Me.eventWorkflowInitialized)
    Me.stateInitial.Description = "Workflow Initialized"
    Me.stateInitial.Name = "stateInitial"
    '
    'Workflow1
    '
    Me.Activities.Add(Me.stateInitial)
    Me.Activities.Add(Me.stateComplete)
    Me.Activities.Add(Me.stateInProgress)
    Me.Activities.Add(Me.stateReview)
    Me.CompletedStateName = "stateComplete"
    Me.DynamicUpdateCondition = Nothing
    Me.InitialStateName = "stateInitial"
    Me.Name = "Workflow1"
    Me.CanModifyActivities = False

  End Sub
  Private setStateActivity1 As System.Workflow.Activities.SetStateActivity
  Private terminateActivity1 As System.Workflow.ComponentModel.TerminateActivity
  Private setStateCompleted As System.Workflow.Activities.SetStateActivity
  Private ifStillInProgress As System.Workflow.Activities.IfElseBranchActivity
  Private ifCompleted As System.Workflow.Activities.IfElseBranchActivity
  Private createReviewNote As Microsoft.SharePoint.WorkflowActions.CreateTask
  Private ifElseActivity1 As System.Workflow.Activities.IfElseActivity
  Private onReviewNoteChanged As Microsoft.SharePoint.WorkflowActions.OnTaskChanged
  Private stateInitializationActivity2 As System.Workflow.Activities.StateInitializationActivity
  Private eventReviewNoteChanged As System.Workflow.Activities.EventDrivenActivity
  Private setStateReview As System.Workflow.Activities.SetStateActivity
  Private setStateInProgress As System.Workflow.Activities.SetStateActivity
  Private stateInitializationActivity1 As System.Workflow.Activities.StateInitializationActivity
  Private stateReview As System.Workflow.Activities.StateActivity
  Private onWorkflowItemChanged As Microsoft.SharePoint.WorkflowActions.OnWorkflowItemChanged
  Private eventAuditProgramStepChanged As System.Workflow.Activities.EventDrivenActivity
  Private ifElseBranchActivity2 As System.Workflow.Activities.IfElseBranchActivity
  Private ifComplete As System.Workflow.Activities.IfElseBranchActivity
  Private ifElseActivity2 As System.Workflow.Activities.IfElseActivity
  Private stateInProgress As System.Workflow.Activities.StateActivity
  Private ifNotInProgress As System.Workflow.Activities.IfElseBranchActivity
  Private ifInProgress As System.Workflow.Activities.IfElseBranchActivity
  Private ifElseActivity As System.Workflow.Activities.IfElseActivity
  Private stateComplete As System.Workflow.Activities.StateActivity
  Private onWorkflowActivated1 As Microsoft.SharePoint.WorkflowActions.OnWorkflowActivated
  Private eventWorkflowInitialized As System.Workflow.Activities.EventDrivenActivity
  Private stateInitial As System.Workflow.Activities.StateActivity


End Class
