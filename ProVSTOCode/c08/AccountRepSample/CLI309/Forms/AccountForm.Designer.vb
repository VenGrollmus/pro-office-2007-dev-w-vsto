Option Strict Off
Option Explicit On

Partial Class AccountForm
    Inherits Microsoft.Office.Tools.Outlook.ImportedFormRegion

    Private olkFrameHeader1 As Microsoft.Office.Interop.Outlook.OlkFrameHeader
    Private WithEvents olkCategory1 As Microsoft.Office.Interop.Outlook.OlkCategory
    Private WithEvents olkInfoBar1 As Microsoft.Office.Interop.Outlook.OlkInfoBar
    Private WithEvents olkTextBox1 As Microsoft.Office.Interop.Outlook.OlkTextBox
    Private WithEvents olkLabel1 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private olkFrameHeader2 As Microsoft.Office.Interop.Outlook.OlkFrameHeader
    Private WithEvents olkTextBox2 As Microsoft.Office.Interop.Outlook.OlkTextBox
    Private WithEvents olkLabel2 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private WithEvents olkTextBox3 As Microsoft.Office.Interop.Outlook.OlkTextBox
    Private WithEvents olkLabel3 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private WithEvents olkTextBox4 As Microsoft.Office.Interop.Outlook.OlkTextBox
    Private WithEvents olkLabel4 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private _RecipientControl1 As Microsoft.Office.Interop.Outlook._DRecipientControl
    Private WithEvents olkCommandButton1 As Microsoft.Office.Interop.Outlook.OlkCommandButton
    Private _DocSiteControl1 As Microsoft.Office.Interop.Outlook._DDocSiteControl
    Private olkFrameHeader3 As Microsoft.Office.Interop.Outlook.OlkFrameHeader
    Private WithEvents frame1 As Microsoft.Vbe.Interop.Forms.UserForm
    Private WithEvents olkBusinessCardControl1 As Microsoft.Office.Interop.Outlook.OlkBusinessCardControl

    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(formRegion)
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub InitializeControls()
        Me.olkFrameHeader1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkFrameHeader)("OlkFrameHeader1")
        Me.olkCategory1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkCategory)("OlkCategory1")
        Me.olkInfoBar1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkInfoBar)("OlkInfoBar1")
        Me.olkTextBox1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkTextBox)("OlkTextBox1")
        Me.olkLabel1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkLabel)("OlkLabel1")
        Me.olkFrameHeader2 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkFrameHeader)("OlkFrameHeader2")
        Me.olkTextBox2 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkTextBox)("OlkTextBox2")
        Me.olkLabel2 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkLabel)("OlkLabel2")
        Me.olkTextBox3 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkTextBox)("OlkTextBox3")
        Me.olkLabel3 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkLabel)("OlkLabel3")
        Me.olkTextBox4 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkTextBox)("OlkTextBox4")
        Me.olkLabel4 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkLabel)("OlkLabel4")
        Me._RecipientControl1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook._DRecipientControl)("_RecipientControl1")
        Me.olkCommandButton1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkCommandButton)("OlkCommandButton1")
        Me._DocSiteControl1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook._DDocSiteControl)("_DocSiteControl1")
        Me.olkFrameHeader3 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkFrameHeader)("OlkFrameHeader3")
        Me.frame1 = Me.GetFormRegionControl(Of Microsoft.Vbe.Interop.Forms.UserForm)("Frame1")
        Me.olkBusinessCardControl1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkBusinessCardControl)("OlkBusinessCardControl1")

    End Sub

    Partial Public Class AccountFormFactory
        Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory

        Public Event FormRegionInitializing As System.EventHandler(Of Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs)

        Private _Manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me._Manifest = New Microsoft.Office.Tools.Outlook.FormRegionManifest()
            Me.InitializeManifest()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        ReadOnly Property Manifest() As Microsoft.Office.Tools.Outlook.FormRegionManifest Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Manifest
            Get
                Return Me._Manifest
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function CreateFormRegion(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion) As Microsoft.Office.Tools.Outlook.IFormRegion Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion
            Dim form as AccountForm = New AccountForm(formRegion)
            form.Factory = Me
            Return form
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Function GetFormRegionStorage(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Byte() Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AccountForm))
            Return CType(resources.GetObject("Account"), Byte())
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
                Return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.Ofs
            End Get
        End Property
    End Class

End Class

Partial Class WindowFormRegionCollection

    Friend ReadOnly Property AccountForm() As AccountForm
        Get
            Return Me.FindFirst(Of AccountForm)()
        End Get
    End Property
End Class