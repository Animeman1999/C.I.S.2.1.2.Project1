<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogFileTester
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
        Me.FileTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.FileTypeRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.FileTypeRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonInfoLabel = New System.Windows.Forms.Label()
        Me.AddMockDataButton = New System.Windows.Forms.Button()
        Me.DeleteFileButton = New System.Windows.Forms.Button()
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.ClearResultsButton = New System.Windows.Forms.Button()
        Me.ReadFileButtonButton = New System.Windows.Forms.Button()
        Me.FileTypeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileTypeGroupBox
        '
        Me.FileTypeGroupBox.Controls.Add(Me.FileTypeRadioButton2)
        Me.FileTypeGroupBox.Controls.Add(Me.FileTypeRadioButton1)
        Me.FileTypeGroupBox.Location = New System.Drawing.Point(54, 25)
        Me.FileTypeGroupBox.Name = "FileTypeGroupBox"
        Me.FileTypeGroupBox.Size = New System.Drawing.Size(200, 100)
        Me.FileTypeGroupBox.TabIndex = 0
        Me.FileTypeGroupBox.TabStop = False
        Me.FileTypeGroupBox.Text = "FileTypeGroupBox"
        '
        'FileTypeRadioButton2
        '
        Me.FileTypeRadioButton2.AutoSize = True
        Me.FileTypeRadioButton2.Location = New System.Drawing.Point(7, 62)
        Me.FileTypeRadioButton2.Name = "FileTypeRadioButton2"
        Me.FileTypeRadioButton2.Size = New System.Drawing.Size(130, 17)
        Me.FileTypeRadioButton2.TabIndex = 1
        Me.FileTypeRadioButton2.TabStop = True
        Me.FileTypeRadioButton2.Text = "FileTypeRadioButton2"
        Me.FileTypeRadioButton2.UseVisualStyleBackColor = True
        '
        'FileTypeRadioButton1
        '
        Me.FileTypeRadioButton1.AutoSize = True
        Me.FileTypeRadioButton1.Location = New System.Drawing.Point(7, 29)
        Me.FileTypeRadioButton1.Name = "FileTypeRadioButton1"
        Me.FileTypeRadioButton1.Size = New System.Drawing.Size(130, 17)
        Me.FileTypeRadioButton1.TabIndex = 0
        Me.FileTypeRadioButton1.TabStop = True
        Me.FileTypeRadioButton1.Text = "FileTypeRadioButton1"
        Me.FileTypeRadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButtonInfoLabel
        '
        Me.RadioButtonInfoLabel.AutoSize = True
        Me.RadioButtonInfoLabel.Location = New System.Drawing.Point(51, 144)
        Me.RadioButtonInfoLabel.Name = "RadioButtonInfoLabel"
        Me.RadioButtonInfoLabel.Size = New System.Drawing.Size(110, 13)
        Me.RadioButtonInfoLabel.TabIndex = 1
        Me.RadioButtonInfoLabel.Text = "RadioButtonInfoLabel"
        '
        'AddMockDataButton
        '
        Me.AddMockDataButton.Location = New System.Drawing.Point(54, 193)
        Me.AddMockDataButton.Name = "AddMockDataButton"
        Me.AddMockDataButton.Size = New System.Drawing.Size(200, 23)
        Me.AddMockDataButton.TabIndex = 2
        Me.AddMockDataButton.Text = "AddMockDataButton"
        Me.AddMockDataButton.UseVisualStyleBackColor = True
        '
        'DeleteFileButton
        '
        Me.DeleteFileButton.Location = New System.Drawing.Point(54, 280)
        Me.DeleteFileButton.Name = "DeleteFileButton"
        Me.DeleteFileButton.Size = New System.Drawing.Size(200, 23)
        Me.DeleteFileButton.TabIndex = 3
        Me.DeleteFileButton.Text = "DeleteFileButton"
        Me.DeleteFileButton.UseVisualStyleBackColor = True
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.Location = New System.Drawing.Point(301, 25)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(68, 13)
        Me.ResultsLabel.TabIndex = 4
        Me.ResultsLabel.Text = "ResultsLabel"
        '
        'ClearResultsButton
        '
        Me.ClearResultsButton.Location = New System.Drawing.Point(54, 251)
        Me.ClearResultsButton.Name = "ClearResultsButton"
        Me.ClearResultsButton.Size = New System.Drawing.Size(200, 23)
        Me.ClearResultsButton.TabIndex = 5
        Me.ClearResultsButton.Text = "ClearResultsButton"
        Me.ClearResultsButton.UseVisualStyleBackColor = True
        '
        'ReadFileButtonButton
        '
        Me.ReadFileButtonButton.Location = New System.Drawing.Point(54, 222)
        Me.ReadFileButtonButton.Name = "ReadFileButtonButton"
        Me.ReadFileButtonButton.Size = New System.Drawing.Size(200, 23)
        Me.ReadFileButtonButton.TabIndex = 6
        Me.ReadFileButtonButton.Text = "ReadFileButton"
        Me.ReadFileButtonButton.UseVisualStyleBackColor = True
        '
        'LogFileTester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 537)
        Me.Controls.Add(Me.ReadFileButtonButton)
        Me.Controls.Add(Me.ClearResultsButton)
        Me.Controls.Add(Me.ResultsLabel)
        Me.Controls.Add(Me.DeleteFileButton)
        Me.Controls.Add(Me.AddMockDataButton)
        Me.Controls.Add(Me.RadioButtonInfoLabel)
        Me.Controls.Add(Me.FileTypeGroupBox)
        Me.Name = "LogFileTester"
        Me.Text = "Form1"
        Me.FileTypeGroupBox.ResumeLayout(False)
        Me.FileTypeGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileTypeGroupBox As GroupBox
    Friend WithEvents FileTypeRadioButton2 As RadioButton
    Friend WithEvents FileTypeRadioButton1 As RadioButton
    Friend WithEvents RadioButtonInfoLabel As Label
    Friend WithEvents AddMockDataButton As Button
    Friend WithEvents DeleteFileButton As Button
    Friend WithEvents ResultsLabel As Label
    Friend WithEvents ClearResultsButton As Button
    Friend WithEvents ReadFileButtonButton As Button
End Class
