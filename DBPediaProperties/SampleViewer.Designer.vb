<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampleViewer
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
        Me.tbSample = New System.Windows.Forms.TextBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbSample
        '
        Me.tbSample.Location = New System.Drawing.Point(12, 12)
        Me.tbSample.Multiline = True
        Me.tbSample.Name = "tbSample"
        Me.tbSample.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbSample.Size = New System.Drawing.Size(857, 427)
        Me.tbSample.TabIndex = 0
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(794, 458)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 1
        Me.btClose.Text = "Close"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'SampleViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btClose
        Me.ClientSize = New System.Drawing.Size(881, 504)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.tbSample)
        Me.Name = "SampleViewer"
        Me.Text = "SampleViewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbSample As System.Windows.Forms.TextBox
    Friend WithEvents btClose As System.Windows.Forms.Button
End Class
