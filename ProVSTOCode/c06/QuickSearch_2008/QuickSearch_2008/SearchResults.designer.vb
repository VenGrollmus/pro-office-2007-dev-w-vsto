<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchResults
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.dgResults = New System.Windows.Forms.DataGridView
    CType(Me.dgResults, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgResults
    '
    Me.dgResults.AllowUserToAddRows = False
    Me.dgResults.AllowUserToDeleteRows = False
    Me.dgResults.AllowUserToOrderColumns = True
    Me.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgResults.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgResults.Location = New System.Drawing.Point(0, 0)
    Me.dgResults.Name = "dgResults"
    Me.dgResults.ReadOnly = True
    Me.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgResults.Size = New System.Drawing.Size(455, 273)
    Me.dgResults.TabIndex = 0
    '
    'SearchResults
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(455, 273)
    Me.Controls.Add(Me.dgResults)
    Me.Name = "SearchResults"
    Me.Text = "SearchResults"
    CType(Me.dgResults, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dgResults As System.Windows.Forms.DataGridView
End Class
