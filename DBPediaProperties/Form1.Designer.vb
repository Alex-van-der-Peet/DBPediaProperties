<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btRemoveFluffViewInputSample = New System.Windows.Forms.Button()
        Me.btRemoveFluffViewOutputSample = New System.Windows.Forms.Button()
        Me.lblFluffRemovalProgress = New System.Windows.Forms.Label()
        Me.btRemoveFluff = New System.Windows.Forms.Button()
        Me.btFluffRemovalChooseOutputFile = New System.Windows.Forms.Button()
        Me.tbFluffRemovalOutputFile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btFluffRemovalChooseTTLFile = New System.Windows.Forms.Button()
        Me.tbFluffRemovalInputFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btFilterUndesirablesViewInputSample = New System.Windows.Forms.Button()
        Me.btFilterUndesirablesViewOutputSample = New System.Windows.Forms.Button()
        Me.tbFilterUndesirablesSkipPredicates = New System.Windows.Forms.TextBox()
        Me.tbFilterUndesirablesSkipDatatypes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFilterUndesirablesProgress = New System.Windows.Forms.Label()
        Me.btFilterUndesirables = New System.Windows.Forms.Button()
        Me.btFilterUndesirablesChooseOutputFile = New System.Windows.Forms.Button()
        Me.tbFilterUndesirablesOutputFile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btFilterUndesirablesChooseTTLFile = New System.Windows.Forms.Button()
        Me.tbFilterUndesirablesInputFile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btToSCMViewInputSample = New System.Windows.Forms.Button()
        Me.btToSCMViewOutputSample = New System.Windows.Forms.Button()
        Me.lblToScmProgress = New System.Windows.Forms.Label()
        Me.btToSCM = New System.Windows.Forms.Button()
        Me.btToSCMChooseOutputFile = New System.Windows.Forms.Button()
        Me.tbToSCMOutputFile = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btToSCMChooseTTLFile = New System.Windows.Forms.Button()
        Me.tbToSCMInputFile = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btRemoveFluffViewInputSample)
        Me.GroupBox1.Controls.Add(Me.btRemoveFluffViewOutputSample)
        Me.GroupBox1.Controls.Add(Me.lblFluffRemovalProgress)
        Me.GroupBox1.Controls.Add(Me.btRemoveFluff)
        Me.GroupBox1.Controls.Add(Me.btFluffRemovalChooseOutputFile)
        Me.GroupBox1.Controls.Add(Me.tbFluffRemovalOutputFile)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btFluffRemovalChooseTTLFile)
        Me.GroupBox1.Controls.Add(Me.tbFluffRemovalInputFile)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remove fluff"
        '
        'btRemoveFluffViewInputSample
        '
        Me.btRemoveFluffViewInputSample.Location = New System.Drawing.Point(374, 84)
        Me.btRemoveFluffViewInputSample.Name = "btRemoveFluffViewInputSample"
        Me.btRemoveFluffViewInputSample.Size = New System.Drawing.Size(111, 23)
        Me.btRemoveFluffViewInputSample.TabIndex = 14
        Me.btRemoveFluffViewInputSample.Text = "View input sample"
        Me.btRemoveFluffViewInputSample.UseVisualStyleBackColor = True
        '
        'btRemoveFluffViewOutputSample
        '
        Me.btRemoveFluffViewOutputSample.Location = New System.Drawing.Point(491, 84)
        Me.btRemoveFluffViewOutputSample.Name = "btRemoveFluffViewOutputSample"
        Me.btRemoveFluffViewOutputSample.Size = New System.Drawing.Size(111, 23)
        Me.btRemoveFluffViewOutputSample.TabIndex = 13
        Me.btRemoveFluffViewOutputSample.Text = "View output sample"
        Me.btRemoveFluffViewOutputSample.UseVisualStyleBackColor = True
        '
        'lblFluffRemovalProgress
        '
        Me.lblFluffRemovalProgress.AutoSize = True
        Me.lblFluffRemovalProgress.Location = New System.Drawing.Point(19, 80)
        Me.lblFluffRemovalProgress.Name = "lblFluffRemovalProgress"
        Me.lblFluffRemovalProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblFluffRemovalProgress.TabIndex = 7
        '
        'btRemoveFluff
        '
        Me.btRemoveFluff.Location = New System.Drawing.Point(608, 84)
        Me.btRemoveFluff.Name = "btRemoveFluff"
        Me.btRemoveFluff.Size = New System.Drawing.Size(108, 23)
        Me.btRemoveFluff.TabIndex = 6
        Me.btRemoveFluff.Text = "Remove Fluff"
        Me.btRemoveFluff.UseVisualStyleBackColor = True
        '
        'btFluffRemovalChooseOutputFile
        '
        Me.btFluffRemovalChooseOutputFile.Location = New System.Drawing.Point(661, 50)
        Me.btFluffRemovalChooseOutputFile.Name = "btFluffRemovalChooseOutputFile"
        Me.btFluffRemovalChooseOutputFile.Size = New System.Drawing.Size(55, 23)
        Me.btFluffRemovalChooseOutputFile.TabIndex = 5
        Me.btFluffRemovalChooseOutputFile.Text = "..."
        Me.btFluffRemovalChooseOutputFile.UseVisualStyleBackColor = True
        '
        'tbFluffRemovalOutputFile
        '
        Me.tbFluffRemovalOutputFile.Location = New System.Drawing.Point(107, 52)
        Me.tbFluffRemovalOutputFile.Name = "tbFluffRemovalOutputFile"
        Me.tbFluffRemovalOutputFile.Size = New System.Drawing.Size(539, 20)
        Me.tbFluffRemovalOutputFile.TabIndex = 4
        Me.tbFluffRemovalOutputFile.Text = "C:\mappingbased_properties_cleaned_en - NoFluff.ttl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Output file:"
        '
        'btFluffRemovalChooseTTLFile
        '
        Me.btFluffRemovalChooseTTLFile.Location = New System.Drawing.Point(661, 20)
        Me.btFluffRemovalChooseTTLFile.Name = "btFluffRemovalChooseTTLFile"
        Me.btFluffRemovalChooseTTLFile.Size = New System.Drawing.Size(55, 23)
        Me.btFluffRemovalChooseTTLFile.TabIndex = 2
        Me.btFluffRemovalChooseTTLFile.Text = "..."
        Me.btFluffRemovalChooseTTLFile.UseVisualStyleBackColor = True
        '
        'tbFluffRemovalInputFile
        '
        Me.tbFluffRemovalInputFile.Location = New System.Drawing.Point(107, 22)
        Me.tbFluffRemovalInputFile.Name = "tbFluffRemovalInputFile"
        Me.tbFluffRemovalInputFile.Size = New System.Drawing.Size(539, 20)
        Me.tbFluffRemovalInputFile.TabIndex = 1
        Me.tbFluffRemovalInputFile.Text = "C:\mappingbased_properties_cleaned_en.ttl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File (.ttl)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btFilterUndesirablesViewInputSample)
        Me.GroupBox2.Controls.Add(Me.btFilterUndesirablesViewOutputSample)
        Me.GroupBox2.Controls.Add(Me.tbFilterUndesirablesSkipPredicates)
        Me.GroupBox2.Controls.Add(Me.tbFilterUndesirablesSkipDatatypes)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblFilterUndesirablesProgress)
        Me.GroupBox2.Controls.Add(Me.btFilterUndesirables)
        Me.GroupBox2.Controls.Add(Me.btFilterUndesirablesChooseOutputFile)
        Me.GroupBox2.Controls.Add(Me.tbFilterUndesirablesOutputFile)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btFilterUndesirablesChooseTTLFile)
        Me.GroupBox2.Controls.Add(Me.tbFilterUndesirablesInputFile)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(732, 206)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter undesirables"
        '
        'btFilterUndesirablesViewInputSample
        '
        Me.btFilterUndesirablesViewInputSample.Location = New System.Drawing.Point(374, 166)
        Me.btFilterUndesirablesViewInputSample.Name = "btFilterUndesirablesViewInputSample"
        Me.btFilterUndesirablesViewInputSample.Size = New System.Drawing.Size(111, 23)
        Me.btFilterUndesirablesViewInputSample.TabIndex = 15
        Me.btFilterUndesirablesViewInputSample.Text = "View input sample"
        Me.btFilterUndesirablesViewInputSample.UseVisualStyleBackColor = True
        '
        'btFilterUndesirablesViewOutputSample
        '
        Me.btFilterUndesirablesViewOutputSample.Location = New System.Drawing.Point(491, 166)
        Me.btFilterUndesirablesViewOutputSample.Name = "btFilterUndesirablesViewOutputSample"
        Me.btFilterUndesirablesViewOutputSample.Size = New System.Drawing.Size(111, 23)
        Me.btFilterUndesirablesViewOutputSample.TabIndex = 12
        Me.btFilterUndesirablesViewOutputSample.Text = "View output sample"
        Me.btFilterUndesirablesViewOutputSample.UseVisualStyleBackColor = True
        '
        'tbFilterUndesirablesSkipPredicates
        '
        Me.tbFilterUndesirablesSkipPredicates.Location = New System.Drawing.Point(107, 112)
        Me.tbFilterUndesirablesSkipPredicates.Multiline = True
        Me.tbFilterUndesirablesSkipPredicates.Name = "tbFilterUndesirablesSkipPredicates"
        Me.tbFilterUndesirablesSkipPredicates.Size = New System.Drawing.Size(539, 48)
        Me.tbFilterUndesirablesSkipPredicates.TabIndex = 11
        Me.tbFilterUndesirablesSkipPredicates.Text = resources.GetString("tbFilterUndesirablesSkipPredicates.Text")
        '
        'tbFilterUndesirablesSkipDatatypes
        '
        Me.tbFilterUndesirablesSkipDatatypes.Location = New System.Drawing.Point(107, 82)
        Me.tbFilterUndesirablesSkipDatatypes.Name = "tbFilterUndesirablesSkipDatatypes"
        Me.tbFilterUndesirablesSkipDatatypes.Size = New System.Drawing.Size(539, 20)
        Me.tbFilterUndesirablesSkipDatatypes.TabIndex = 10
        Me.tbFilterUndesirablesSkipDatatypes.Text = "number, date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Skip predicates:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Skip datatypes:"
        '
        'lblFilterUndesirablesProgress
        '
        Me.lblFilterUndesirablesProgress.AutoSize = True
        Me.lblFilterUndesirablesProgress.Location = New System.Drawing.Point(19, 175)
        Me.lblFilterUndesirablesProgress.Name = "lblFilterUndesirablesProgress"
        Me.lblFilterUndesirablesProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblFilterUndesirablesProgress.TabIndex = 7
        '
        'btFilterUndesirables
        '
        Me.btFilterUndesirables.Location = New System.Drawing.Point(608, 166)
        Me.btFilterUndesirables.Name = "btFilterUndesirables"
        Me.btFilterUndesirables.Size = New System.Drawing.Size(108, 23)
        Me.btFilterUndesirables.TabIndex = 6
        Me.btFilterUndesirables.Text = "Filter Undesirables"
        Me.btFilterUndesirables.UseVisualStyleBackColor = True
        '
        'btFilterUndesirablesChooseOutputFile
        '
        Me.btFilterUndesirablesChooseOutputFile.Location = New System.Drawing.Point(661, 50)
        Me.btFilterUndesirablesChooseOutputFile.Name = "btFilterUndesirablesChooseOutputFile"
        Me.btFilterUndesirablesChooseOutputFile.Size = New System.Drawing.Size(55, 23)
        Me.btFilterUndesirablesChooseOutputFile.TabIndex = 5
        Me.btFilterUndesirablesChooseOutputFile.Text = "..."
        Me.btFilterUndesirablesChooseOutputFile.UseVisualStyleBackColor = True
        '
        'tbFilterUndesirablesOutputFile
        '
        Me.tbFilterUndesirablesOutputFile.Location = New System.Drawing.Point(107, 52)
        Me.tbFilterUndesirablesOutputFile.Name = "tbFilterUndesirablesOutputFile"
        Me.tbFilterUndesirablesOutputFile.Size = New System.Drawing.Size(539, 20)
        Me.tbFilterUndesirablesOutputFile.TabIndex = 4
        Me.tbFilterUndesirablesOutputFile.Text = "C:\mappingbased_properties_cleaned_en - Filtered.ttl"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Output file:"
        '
        'btFilterUndesirablesChooseTTLFile
        '
        Me.btFilterUndesirablesChooseTTLFile.Location = New System.Drawing.Point(661, 20)
        Me.btFilterUndesirablesChooseTTLFile.Name = "btFilterUndesirablesChooseTTLFile"
        Me.btFilterUndesirablesChooseTTLFile.Size = New System.Drawing.Size(55, 23)
        Me.btFilterUndesirablesChooseTTLFile.TabIndex = 2
        Me.btFilterUndesirablesChooseTTLFile.Text = "..."
        Me.btFilterUndesirablesChooseTTLFile.UseVisualStyleBackColor = True
        '
        'tbFilterUndesirablesInputFile
        '
        Me.tbFilterUndesirablesInputFile.Location = New System.Drawing.Point(107, 22)
        Me.tbFilterUndesirablesInputFile.Name = "tbFilterUndesirablesInputFile"
        Me.tbFilterUndesirablesInputFile.Size = New System.Drawing.Size(539, 20)
        Me.tbFilterUndesirablesInputFile.TabIndex = 1
        Me.tbFilterUndesirablesInputFile.Text = "C:\mappingbased_properties_cleaned_en - NoFluff.ttl"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "File (.ttl)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btToSCMViewInputSample)
        Me.GroupBox3.Controls.Add(Me.btToSCMViewOutputSample)
        Me.GroupBox3.Controls.Add(Me.lblToScmProgress)
        Me.GroupBox3.Controls.Add(Me.btToSCM)
        Me.GroupBox3.Controls.Add(Me.btToSCMChooseOutputFile)
        Me.GroupBox3.Controls.Add(Me.tbToSCMOutputFile)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.btToSCMChooseTTLFile)
        Me.GroupBox3.Controls.Add(Me.tbToSCMInputFile)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(732, 121)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "To SCM"
        '
        'btToSCMViewInputSample
        '
        Me.btToSCMViewInputSample.Location = New System.Drawing.Point(374, 84)
        Me.btToSCMViewInputSample.Name = "btToSCMViewInputSample"
        Me.btToSCMViewInputSample.Size = New System.Drawing.Size(111, 23)
        Me.btToSCMViewInputSample.TabIndex = 16
        Me.btToSCMViewInputSample.Text = "View input sample"
        Me.btToSCMViewInputSample.UseVisualStyleBackColor = True
        '
        'btToSCMViewOutputSample
        '
        Me.btToSCMViewOutputSample.Location = New System.Drawing.Point(491, 84)
        Me.btToSCMViewOutputSample.Name = "btToSCMViewOutputSample"
        Me.btToSCMViewOutputSample.Size = New System.Drawing.Size(111, 23)
        Me.btToSCMViewOutputSample.TabIndex = 13
        Me.btToSCMViewOutputSample.Text = "View output sample"
        Me.btToSCMViewOutputSample.UseVisualStyleBackColor = True
        '
        'lblToScmProgress
        '
        Me.lblToScmProgress.AutoSize = True
        Me.lblToScmProgress.Location = New System.Drawing.Point(19, 80)
        Me.lblToScmProgress.Name = "lblToScmProgress"
        Me.lblToScmProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblToScmProgress.TabIndex = 7
        '
        'btToSCM
        '
        Me.btToSCM.Location = New System.Drawing.Point(608, 84)
        Me.btToSCM.Name = "btToSCM"
        Me.btToSCM.Size = New System.Drawing.Size(108, 23)
        Me.btToSCM.TabIndex = 6
        Me.btToSCM.Text = "Convert to SCM"
        Me.btToSCM.UseVisualStyleBackColor = True
        '
        'btToSCMChooseOutputFile
        '
        Me.btToSCMChooseOutputFile.Location = New System.Drawing.Point(661, 50)
        Me.btToSCMChooseOutputFile.Name = "btToSCMChooseOutputFile"
        Me.btToSCMChooseOutputFile.Size = New System.Drawing.Size(55, 23)
        Me.btToSCMChooseOutputFile.TabIndex = 5
        Me.btToSCMChooseOutputFile.Text = "..."
        Me.btToSCMChooseOutputFile.UseVisualStyleBackColor = True
        '
        'tbToSCMOutputFile
        '
        Me.tbToSCMOutputFile.Location = New System.Drawing.Point(107, 52)
        Me.tbToSCMOutputFile.Name = "tbToSCMOutputFile"
        Me.tbToSCMOutputFile.Size = New System.Drawing.Size(539, 20)
        Me.tbToSCMOutputFile.TabIndex = 4
        Me.tbToSCMOutputFile.Text = "C:\mappingbased_properties_cleaned_en - Filtered.scm"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Output file:"
        '
        'btToSCMChooseTTLFile
        '
        Me.btToSCMChooseTTLFile.Location = New System.Drawing.Point(661, 20)
        Me.btToSCMChooseTTLFile.Name = "btToSCMChooseTTLFile"
        Me.btToSCMChooseTTLFile.Size = New System.Drawing.Size(55, 23)
        Me.btToSCMChooseTTLFile.TabIndex = 2
        Me.btToSCMChooseTTLFile.Text = "..."
        Me.btToSCMChooseTTLFile.UseVisualStyleBackColor = True
        '
        'tbToSCMInputFile
        '
        Me.tbToSCMInputFile.Location = New System.Drawing.Point(107, 22)
        Me.tbToSCMInputFile.Name = "tbToSCMInputFile"
        Me.tbToSCMInputFile.Size = New System.Drawing.Size(539, 20)
        Me.tbToSCMInputFile.TabIndex = 1
        Me.tbToSCMInputFile.Text = "C:\mappingbased_properties_cleaned_en - Filtered.ttl"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "File (.ttl)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 550)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btRemoveFluff As System.Windows.Forms.Button
    Friend WithEvents btFluffRemovalChooseOutputFile As System.Windows.Forms.Button
    Friend WithEvents tbFluffRemovalOutputFile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btFluffRemovalChooseTTLFile As System.Windows.Forms.Button
    Friend WithEvents tbFluffRemovalInputFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblFluffRemovalProgress As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblFilterUndesirablesProgress As System.Windows.Forms.Label
    Friend WithEvents btFilterUndesirables As System.Windows.Forms.Button
    Friend WithEvents btFilterUndesirablesChooseOutputFile As System.Windows.Forms.Button
    Friend WithEvents tbFilterUndesirablesOutputFile As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btFilterUndesirablesChooseTTLFile As System.Windows.Forms.Button
    Friend WithEvents tbFilterUndesirablesInputFile As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbFilterUndesirablesSkipPredicates As System.Windows.Forms.TextBox
    Friend WithEvents tbFilterUndesirablesSkipDatatypes As System.Windows.Forms.TextBox
    Friend WithEvents btRemoveFluffViewOutputSample As System.Windows.Forms.Button
    Friend WithEvents btFilterUndesirablesViewOutputSample As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btToSCMViewOutputSample As System.Windows.Forms.Button
    Friend WithEvents lblToScmProgress As System.Windows.Forms.Label
    Friend WithEvents btToSCM As System.Windows.Forms.Button
    Friend WithEvents btToSCMChooseOutputFile As System.Windows.Forms.Button
    Friend WithEvents tbToSCMOutputFile As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btToSCMChooseTTLFile As System.Windows.Forms.Button
    Friend WithEvents tbToSCMInputFile As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btRemoveFluffViewInputSample As System.Windows.Forms.Button
    Friend WithEvents btFilterUndesirablesViewInputSample As System.Windows.Forms.Button
    Friend WithEvents btToSCMViewInputSample As System.Windows.Forms.Button

End Class
