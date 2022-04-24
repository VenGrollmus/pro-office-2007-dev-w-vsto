Option Strict Off
Option Explicit On

Partial Class ReadingPane2
    Inherits Microsoft.Office.Tools.Outlook.ImportedFormRegion

    Private WithEvents olkInfoBar1 As Microsoft.Office.Interop.Outlook.OlkInfoBar
    Private message As Microsoft.Office.Interop.Outlook._DDocSiteControl
    Private olkFrameHeader1 As Microsoft.Office.Interop.Outlook.OlkFrameHeader
    Private WithEvents olkLabel1 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private WithEvents olkTextBox1 As Microsoft.Office.Interop.Outlook.OlkTextBox
    Private WithEvents olkLabel2 As Microsoft.Office.Interop.Outlook.OlkLabel
    Private _RecipientControl1 As Microsoft.Office.Interop.Outlook._DRecipientControl

    Public Sub New(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion)
        MyBase.New(formRegion)
    End Sub

    Protected Overrides Sub InitializeControls()
        Me.olkInfoBar1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkInfoBar)("OlkInfoBar1")
        Me.message = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook._DDocSiteControl)("Message")
        Me.olkFrameHeader1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkFrameHeader)("OlkFrameHeader1")
        Me.olkLabel1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkLabel)("OlkLabel1")
        Me.olkTextBox1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkTextBox)("OlkTextBox1")
        Me.olkLabel2 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook.OlkLabel)("OlkLabel2")
        Me._RecipientControl1 = Me.GetFormRegionControl(Of Microsoft.Office.Interop.Outlook._DRecipientControl)("_RecipientControl1")

    End Sub

    Partial Public Class ReadingPane2Factory
        Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory

        Public Event FormRegionInitializing As System.EventHandler(Of Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs)

        Private _Manifest As Microsoft.Office.Tools.Outlook.FormRegionManifest

        Public Sub New()
            Me._Manifest = New Microsoft.Office.Tools.Outlook.FormRegionManifest()
            Me.InitializeManifest()
        End Sub

        ReadOnly Property Manifest() As Microsoft.Office.Tools.Outlook.FormRegionManifest Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Manifest
            Get
                Return Me._Manifest
            End Get
        End Property

        Function CreateFormRegion(ByVal formRegion As Microsoft.Office.Interop.Outlook.FormRegion) As Microsoft.Office.Tools.Outlook.IFormRegion Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion
            Dim form as ReadingPane2 = New ReadingPane2(formRegion)
            form.Factory = Me
            Return form
        End Function

        Function GetFormRegionStorage(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Byte() Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReadingPane2))
            Return CType(resources.GetObject("ReadingPane"), Byte())
        End Function

        Function IsDisplayedForItem(ByVal outlookItem As Object, ByVal formRegionMode As Microsoft.Office.Interop.Outlook.OlFormRegionMode, ByVal formRegionSize As Microsoft.Office.Interop.Outlook.OlFormRegionSize) As Boolean Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem
            Dim cancelArgs As Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs = New Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, False)
            cancelArgs.Cancel = False
            RaiseEvent FormRegionInitializing(Me, cancelArgs)
            Return Not cancelArgs.Cancel
        End Function

        ReadOnly Property Kind() As String Implements Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            Get
                Return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.Ofs
            End Get
        End Property
    End Class

End Class