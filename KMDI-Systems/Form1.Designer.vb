<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LoadingPboxRNP = New System.Windows.Forms.PictureBox()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton2 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton3 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton4 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton5 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton6 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton7 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton8 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton9 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.LoadingPboxRNP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(365, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Transaction"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(347, 161)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 207)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(347, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(365, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "StreamWriter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(365, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 43)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Compare Textbox1 and Textbox2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(365, 119)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 43)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Insert array values on Table"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(365, 168)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 28)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "BGW1"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(365, 202)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 28)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Project_Details.vb"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LoadingPboxRNP
        '
        Me.LoadingPboxRNP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPboxRNP.BackColor = System.Drawing.Color.Transparent
        Me.LoadingPboxRNP.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPboxRNP.Location = New System.Drawing.Point(12, 12)
        Me.LoadingPboxRNP.Name = "LoadingPboxRNP"
        Me.LoadingPboxRNP.Size = New System.Drawing.Size(57, 22)
        Me.LoadingPboxRNP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPboxRNP.TabIndex = 13
        Me.LoadingPboxRNP.TabStop = False
        Me.LoadingPboxRNP.Visible = False
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.Location = New System.Drawing.Point(12, 233)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextButton1.TabIndex = 15
        Me.MetroTextButton1.Text = "Asterisk"
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'MetroTextButton2
        '
        Me.MetroTextButton2.Image = Nothing
        Me.MetroTextButton2.Location = New System.Drawing.Point(93, 233)
        Me.MetroTextButton2.Name = "MetroTextButton2"
        Me.MetroTextButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextButton2.TabIndex = 16
        Me.MetroTextButton2.Text = "Error"
        Me.MetroTextButton2.UseSelectable = True
        Me.MetroTextButton2.UseVisualStyleBackColor = True
        '
        'MetroTextButton3
        '
        Me.MetroTextButton3.Image = Nothing
        Me.MetroTextButton3.Location = New System.Drawing.Point(174, 233)
        Me.MetroTextButton3.Name = "MetroTextButton3"
        Me.MetroTextButton3.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextButton3.TabIndex = 17
        Me.MetroTextButton3.Text = "Exclamation"
        Me.MetroTextButton3.UseSelectable = True
        Me.MetroTextButton3.UseVisualStyleBackColor = True
        '
        'MetroTextButton4
        '
        Me.MetroTextButton4.Image = Nothing
        Me.MetroTextButton4.Location = New System.Drawing.Point(255, 233)
        Me.MetroTextButton4.Name = "MetroTextButton4"
        Me.MetroTextButton4.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextButton4.TabIndex = 18
        Me.MetroTextButton4.Text = "Hand"
        Me.MetroTextButton4.UseSelectable = True
        Me.MetroTextButton4.UseVisualStyleBackColor = True
        '
        'MetroTextButton5
        '
        Me.MetroTextButton5.Image = Nothing
        Me.MetroTextButton5.Location = New System.Drawing.Point(12, 262)
        Me.MetroTextButton5.Name = "MetroTextButton5"
        Me.MetroTextButton5.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextButton5.TabIndex = 19
        Me.MetroTextButton5.Text = "Information"
        Me.MetroTextButton5.UseSelectable = True
        Me.MetroTextButton5.UseVisualStyleBackColor = True
        '
        'MetroTextButton6
        '
        Me.MetroTextButton6.Image = Nothing
        Me.MetroTextButton6.Location = New System.Drawing.Point(93, 262)
        Me.MetroTextButton6.Name = "MetroTextButton6"
        Me.MetroTextButton6.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextButton6.TabIndex = 20
        Me.MetroTextButton6.Text = "None"
        Me.MetroTextButton6.UseSelectable = True
        Me.MetroTextButton6.UseVisualStyleBackColor = True
        '
        'MetroTextButton7
        '
        Me.MetroTextButton7.Image = Nothing
        Me.MetroTextButton7.Location = New System.Drawing.Point(174, 262)
        Me.MetroTextButton7.Name = "MetroTextButton7"
        Me.MetroTextButton7.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextButton7.TabIndex = 21
        Me.MetroTextButton7.Text = "Question"
        Me.MetroTextButton7.UseSelectable = True
        Me.MetroTextButton7.UseVisualStyleBackColor = True
        '
        'MetroTextButton8
        '
        Me.MetroTextButton8.Image = Nothing
        Me.MetroTextButton8.Location = New System.Drawing.Point(255, 262)
        Me.MetroTextButton8.Name = "MetroTextButton8"
        Me.MetroTextButton8.Size = New System.Drawing.Size(75, 23)
        Me.MetroTextButton8.TabIndex = 22
        Me.MetroTextButton8.Text = "Stop"
        Me.MetroTextButton8.UseSelectable = True
        Me.MetroTextButton8.UseVisualStyleBackColor = True
        '
        'MetroTextButton9
        '
        Me.MetroTextButton9.Image = Nothing
        Me.MetroTextButton9.Location = New System.Drawing.Point(336, 233)
        Me.MetroTextButton9.Name = "MetroTextButton9"
        Me.MetroTextButton9.Size = New System.Drawing.Size(75, 52)
        Me.MetroTextButton9.TabIndex = 23
        Me.MetroTextButton9.Text = "Warning"
        Me.MetroTextButton9.UseSelectable = True
        Me.MetroTextButton9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(417, 233)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 52)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "ex.StackTrace"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 294)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.MetroTextButton9)
        Me.Controls.Add(Me.MetroTextButton8)
        Me.Controls.Add(Me.MetroTextButton7)
        Me.Controls.Add(Me.MetroTextButton6)
        Me.Controls.Add(Me.MetroTextButton5)
        Me.Controls.Add(Me.MetroTextButton4)
        Me.Controls.Add(Me.MetroTextButton3)
        Me.Controls.Add(Me.MetroTextButton2)
        Me.Controls.Add(Me.MetroTextButton1)
        Me.Controls.Add(Me.LoadingPboxRNP)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LoadingPboxRNP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents LoadingPboxRNP As PictureBox
    Friend WithEvents MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton2 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton3 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton4 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton5 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton6 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton7 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton8 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton9 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Button7 As Button
End Class
