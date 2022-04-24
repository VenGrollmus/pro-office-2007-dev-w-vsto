<System.ComponentModel.ToolboxItemAttribute(False)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeRegion
    Inherits Microsoft.Office.Tools.Outlook.FormRegionControl

    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(formRegion)
        Me.InitializeComponent()
    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.chkBillable = New System.Windows.Forms.CheckBox
    Me.cboJob = New System.Windows.Forms.ComboBox
    Me.cboBillCode = New System.Windows.Forms.ComboBox
    Me.cboEmployee = New System.Windows.Forms.ComboBox
    Me.btnSave = New System.Windows.Forms.Button
    Me.txtAcctGUID = New System.Windows.Forms.TextBox
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(8, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(155, 20)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Project Time Entry"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(9, 74)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(24, 13)
    Me.Label4.TabIndex = 29
    Me.Label4.Text = "Job"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 101)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(62, 13)
    Me.Label3.TabIndex = 28
    Me.Label3.Text = "Billing Code"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 49)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(53, 13)
    Me.Label2.TabIndex = 27
    Me.Label2.Text = "Employee"
    '
    'chkBillable
    '
    Me.chkBillable.AutoSize = True
    Me.chkBillable.Location = New System.Drawing.Point(300, 49)
    Me.chkBillable.Name = "chkBillable"
    Me.chkBillable.Size = New System.Drawing.Size(65, 17)
    Me.chkBillable.TabIndex = 3
    Me.chkBillable.Text = "Billable?"
    Me.chkBillable.UseVisualStyleBackColor = True
    '
    'cboJob
    '
    Me.cboJob.FormattingEnabled = True
    Me.cboJob.Location = New System.Drawing.Point(82, 74)
    Me.cboJob.Name = "cboJob"
    Me.cboJob.Size = New System.Drawing.Size(185, 21)
    Me.cboJob.TabIndex = 1
    '
    'cboBillCode
    '
    Me.cboBillCode.FormattingEnabled = True
    Me.cboBillCode.Location = New System.Drawing.Point(82, 101)
    Me.cboBillCode.Name = "cboBillCode"
    Me.cboBillCode.Size = New System.Drawing.Size(185, 21)
    Me.cboBillCode.TabIndex = 2
    '
    'cboEmployee
    '
    Me.cboEmployee.FormattingEnabled = True
    Me.cboEmployee.Location = New System.Drawing.Point(82, 49)
    Me.cboEmployee.Name = "cboEmployee"
    Me.cboEmployee.Size = New System.Drawing.Size(185, 21)
    Me.cboEmployee.TabIndex = 0
    '
    'btnSave
    '
    Me.btnSave.Location = New System.Drawing.Point(434, 49)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(100, 69)
    Me.btnSave.TabIndex = 4
    Me.btnSave.Text = "Save"
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'txtAcctGUID
    '
    Me.txtAcctGUID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.txtAcctGUID.Location = New System.Drawing.Point(383, 8)
    Me.txtAcctGUID.Name = "txtAcctGUID"
    Me.txtAcctGUID.Size = New System.Drawing.Size(100, 20)
    Me.txtAcctGUID.TabIndex = 30
    Me.txtAcctGUID.Visible = False
    '
    'TimeRegion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txtAcctGUID)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.chkBillable)
    Me.Controls.Add(Me.cboJob)
    Me.Controls.Add(Me.cboBillCode)
    Me.Controls.Add(Me.cboEmployee)
    Me.Controls.Add(Me.btnSave)
    Me.Controls.Add(Me.Label1)
    Me.Name = "TimeRegion"
    Me.Size = New System.Drawing.Size(549, 150)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  'NOTE: The following procedure is required by the Form Regions Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Shared Sub InitializeManifest(ByVal manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest)
    manifest.FormRegionName = "Time Entry"
    manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.Adjoining
    manifest.Title = "Time Entry"

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents chkBillable As System.Windows.Forms.CheckBox
  Friend WithEvents cboJob As System.Windows.Forms.ComboBox
  Friend WithEvents cboBillCode As System.Windows.Forms.ComboBox
  Friend WithEvents cboEmployee As System.Windows.Forms.ComboBox
  Friend WithEvents btnSave As System.Windows.Forms.Button
  Friend WithEvents txtAcctGUID As System.Windows.Forms.TextBox

    Partial Public Class TimeRegionFactory
        Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory

        Public Event FormRegionInitializing As System.EventHandler(Of Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs)

        Private _Manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest


        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me._Manifest = New Microsoft.Office.Tools.Outlook.FormRegionManifest()
            TimeRegion.InitializeManifest(Me._Manifest)
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        ReadOnly Property Manifest() As Microsoft.Office.Tools.Outlook.FormRegionManifest Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Manifest
            Get
                Return Me._Manifest
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function CreateFormRegion(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion) As Microsoft.Office.Tools.Outlook.IFormRegion Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion
            Dim form as TimeRegion = New TimeRegion(formRegion)
            form.Factory = Me
            Return form
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function GetFormRegionStorage(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Byte() Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage
            Throw New System.NotSupportedException()
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function IsDisplayedForItem(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Boolean Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem
            Dim cancelArgs As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs = New Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, False)
            cancelArgs.Cancel = False
            RaiseEvent FormRegionInitializing(Me, cancelArgs)
            Return Not cancelArgs.Cancel
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        ReadOnly Property Kind() As String Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            Get
                Return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.WindowsForms
            End Get
        End Property
    End Class
End Class

Partial Class WindowFormRegionCollection

    Friend ReadOnly Property TimeRegion() As TimeRegion
        Get
            Return Me.FindFirst(Of TimeRegion)()
        End Get
    End Property
End Class