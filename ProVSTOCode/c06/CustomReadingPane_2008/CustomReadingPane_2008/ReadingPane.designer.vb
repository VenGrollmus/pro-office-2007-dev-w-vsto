<System.ComponentModel.ToolboxItemAttribute(False)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadingPane
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
    Me.txtBody = New System.Windows.Forms.TextBox
    Me.btnFile = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'txtBody
    '
    Me.txtBody.Location = New System.Drawing.Point(4, 68)
    Me.txtBody.Multiline = True
    Me.txtBody.Name = "txtBody"
    Me.txtBody.ReadOnly = True
    Me.txtBody.Size = New System.Drawing.Size(593, 329)
    Me.txtBody.TabIndex = 0
    '
    'btnFile
    '
    Me.btnFile.Location = New System.Drawing.Point(522, 5)
    Me.btnFile.Name = "btnFile"
    Me.btnFile.Size = New System.Drawing.Size(75, 59)
    Me.btnFile.TabIndex = 1
    Me.btnFile.Text = "File Message"
    Me.btnFile.UseVisualStyleBackColor = True
    '
    'ReadingPane
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.btnFile)
    Me.Controls.Add(Me.txtBody)
    Me.Name = "ReadingPane"
    Me.Size = New System.Drawing.Size(600, 400)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  'NOTE: The following procedure is required by the Form Regions Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Shared Sub InitializeManifest(ByVal manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest)
    Dim FormRegionCustomAction1 As Microsoft.Office.Tools.Outlook.FormRegionCustomAction = New Microsoft.Office.Tools.Outlook.FormRegionCustomAction
    FormRegionCustomAction1.Name = "formRegionCustomAction1"
    manifest.CustomActions.Add(FormRegionCustomAction1)
    manifest.FormRegionName = "ReadingPane"
    manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.Replacement
    manifest.ShowInspectorCompose = False
    manifest.ShowInspectorRead = False
    manifest.Title = "ReadingPane"

  End Sub
  Friend WithEvents txtBody As System.Windows.Forms.TextBox
  Friend WithEvents btnFile As System.Windows.Forms.Button

    Partial Public Class ReadingPaneFactory
        Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory

        Public Event FormRegionInitializing As System.EventHandler(Of Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs)

        Private _Manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest

        Public Sub New()
            Me._Manifest = New Microsoft.Office.Tools.Outlook.FormRegionManifest()
            ReadingPane.InitializeManifest(Me._Manifest)
        End Sub

        ReadOnly Property Manifest() As Microsoft.Office.Tools.Outlook.FormRegionManifest Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Manifest
            Get
                Return Me._Manifest
            End Get
        End Property

        Function CreateFormRegion(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion) As Microsoft.Office.Tools.Outlook.IFormRegion Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion
            Dim form as ReadingPane = New ReadingPane(formRegion)
            form.Factory = Me
            Return form
        End Function

        Function GetFormRegionStorage(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Byte() Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage
            Throw New System.NotSupportedException()
        End Function

        Function IsDisplayedForItem(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Boolean Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem
            Dim cancelArgs As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs = New Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, False)
            cancelArgs.Cancel = False
            RaiseEvent FormRegionInitializing(Me, cancelArgs)
            Return Not cancelArgs.Cancel
        End Function

        ReadOnly Property Kind() As String Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            Get
                Return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.WindowsForms
            End Get
        End Property
    End Class
End Class