<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MKTNG_AddQuantity
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MKTNG_AddQuantity))
        Me.AddBTN = New MetroFramework.Controls.MetroButton()
        Me.QTYTbox = New MetroFramework.Controls.MetroTextBox()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddBTN
        '
        Me.AddBTN.Location = New System.Drawing.Point(234, 75)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(66, 30)
        Me.AddBTN.Style = MetroFramework.MetroColorStyle.Silver
        Me.AddBTN.TabIndex = 7
        Me.AddBTN.Text = "Add"
        Me.AddBTN.UseSelectable = True
        '
        'QTYTbox
        '
        Me.QTYTbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.QTYTbox.CustomButton.Image = Nothing
        Me.QTYTbox.CustomButton.Location = New System.Drawing.Point(177, 2)
        Me.QTYTbox.CustomButton.Name = ""
        Me.QTYTbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.QTYTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.QTYTbox.CustomButton.TabIndex = 1
        Me.QTYTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.QTYTbox.CustomButton.UseSelectable = True
        Me.QTYTbox.CustomButton.Visible = False
        Me.QTYTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.QTYTbox.Lines = New String(-1) {}
        Me.QTYTbox.Location = New System.Drawing.Point(23, 75)
        Me.QTYTbox.MaxLength = 32767
        Me.QTYTbox.Name = "QTYTbox"
        Me.QTYTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QTYTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.QTYTbox.SelectedText = ""
        Me.QTYTbox.SelectionLength = 0
        Me.QTYTbox.SelectionStart = 0
        Me.QTYTbox.Size = New System.Drawing.Size(205, 30)
        Me.QTYTbox.Style = MetroFramework.MetroColorStyle.Silver
        Me.QTYTbox.TabIndex = 6
        Me.QTYTbox.UseSelectable = True
        Me.QTYTbox.WaterMark = "Quantity"
        Me.QTYTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.QTYTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(234, 41)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 613
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'MKTNG_AddQuantity
        '
        Me.AcceptButton = Me.AddBTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 135)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.AddBTN)
        Me.Controls.Add(Me.QTYTbox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MKTNG_AddQuantity"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddBTN As MetroFramework.Controls.MetroButton
    Friend WithEvents QTYTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LoadingPB As PictureBox
End Class
