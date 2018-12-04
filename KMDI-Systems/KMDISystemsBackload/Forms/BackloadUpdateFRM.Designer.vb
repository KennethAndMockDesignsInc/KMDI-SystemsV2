<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BackloadUpdateFRM
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackloadUpdateFRM))
        Me.BackloadUpdatePNL = New System.Windows.Forms.Panel()
        Me.DateToDismantleDTP = New MetroFramework.Controls.MetroDateTime()
        Me.DateToDismantleTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.ItemClassCBOX = New MetroFramework.Controls.MetroComboBox()
        Me.OtherDetailsTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.UpdateBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.OtherDetailsLBL = New MetroFramework.Controls.MetroLabel()
        Me.StorageLocationTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.BackloadedByTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.BackloadsLBL = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.BackloadUpdatePNL.SuspendLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackloadUpdatePNL
        '
        Me.BackloadUpdatePNL.AutoScroll = True
        Me.BackloadUpdatePNL.Controls.Add(Me.DateToDismantleDTP)
        Me.BackloadUpdatePNL.Controls.Add(Me.DateToDismantleTBOX)
        Me.BackloadUpdatePNL.Controls.Add(Me.ItemClassCBOX)
        Me.BackloadUpdatePNL.Controls.Add(Me.OtherDetailsTBOX)
        Me.BackloadUpdatePNL.Controls.Add(Me.UpdateBTN)
        Me.BackloadUpdatePNL.Controls.Add(Me.OtherDetailsLBL)
        Me.BackloadUpdatePNL.Controls.Add(Me.StorageLocationTBOX)
        Me.BackloadUpdatePNL.Controls.Add(Me.BackloadedByTBOX)
        Me.BackloadUpdatePNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackloadUpdatePNL.Location = New System.Drawing.Point(20, 60)
        Me.BackloadUpdatePNL.Name = "BackloadUpdatePNL"
        Me.BackloadUpdatePNL.Size = New System.Drawing.Size(584, 274)
        Me.BackloadUpdatePNL.TabIndex = 9
        '
        'DateToDismantleDTP
        '
        Me.DateToDismantleDTP.Location = New System.Drawing.Point(536, 48)
        Me.DateToDismantleDTP.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateToDismantleDTP.Name = "DateToDismantleDTP"
        Me.DateToDismantleDTP.Size = New System.Drawing.Size(23, 29)
        Me.DateToDismantleDTP.TabIndex = 3
        Me.DateToDismantleDTP.Visible = False
        '
        'DateToDismantleTBOX
        '
        '
        '
        '
        Me.DateToDismantleTBOX.CustomButton.Image = Nothing
        Me.DateToDismantleTBOX.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.DateToDismantleTBOX.CustomButton.Name = ""
        Me.DateToDismantleTBOX.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.DateToDismantleTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.DateToDismantleTBOX.CustomButton.TabIndex = 1
        Me.DateToDismantleTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.DateToDismantleTBOX.CustomButton.UseSelectable = True
        Me.DateToDismantleTBOX.CustomButton.Visible = False
        Me.DateToDismantleTBOX.Enabled = False
        Me.DateToDismantleTBOX.Lines = New String(-1) {}
        Me.DateToDismantleTBOX.Location = New System.Drawing.Point(323, 48)
        Me.DateToDismantleTBOX.MaxLength = 32767
        Me.DateToDismantleTBOX.Name = "DateToDismantleTBOX"
        Me.DateToDismantleTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DateToDismantleTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DateToDismantleTBOX.SelectedText = ""
        Me.DateToDismantleTBOX.SelectionLength = 0
        Me.DateToDismantleTBOX.SelectionStart = 0
        Me.DateToDismantleTBOX.Size = New System.Drawing.Size(236, 29)
        Me.DateToDismantleTBOX.TabIndex = 630
        Me.DateToDismantleTBOX.TabStop = False
        Me.DateToDismantleTBOX.UseSelectable = True
        Me.DateToDismantleTBOX.Visible = False
        Me.DateToDismantleTBOX.WaterMark = "Date to Dismantle"
        Me.DateToDismantleTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DateToDismantleTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ItemClassCBOX
        '
        Me.ItemClassCBOX.FormattingEnabled = True
        Me.ItemClassCBOX.ItemHeight = 23
        Me.ItemClassCBOX.Items.AddRange(New Object() {"Class A", "Class B", "Class C"})
        Me.ItemClassCBOX.Location = New System.Drawing.Point(323, 12)
        Me.ItemClassCBOX.Name = "ItemClassCBOX"
        Me.ItemClassCBOX.Size = New System.Drawing.Size(236, 29)
        Me.ItemClassCBOX.TabIndex = 2
        Me.ItemClassCBOX.UseSelectable = True
        '
        'OtherDetailsTBOX
        '
        '
        '
        '
        Me.OtherDetailsTBOX.CustomButton.Image = Nothing
        Me.OtherDetailsTBOX.CustomButton.Location = New System.Drawing.Point(419, 1)
        Me.OtherDetailsTBOX.CustomButton.Name = ""
        Me.OtherDetailsTBOX.CustomButton.Size = New System.Drawing.Size(117, 117)
        Me.OtherDetailsTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.OtherDetailsTBOX.CustomButton.TabIndex = 1
        Me.OtherDetailsTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.OtherDetailsTBOX.CustomButton.UseSelectable = True
        Me.OtherDetailsTBOX.CustomButton.Visible = False
        Me.OtherDetailsTBOX.Lines = New String(-1) {}
        Me.OtherDetailsTBOX.Location = New System.Drawing.Point(22, 109)
        Me.OtherDetailsTBOX.MaxLength = 32767
        Me.OtherDetailsTBOX.Multiline = True
        Me.OtherDetailsTBOX.Name = "OtherDetailsTBOX"
        Me.OtherDetailsTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OtherDetailsTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.OtherDetailsTBOX.SelectedText = ""
        Me.OtherDetailsTBOX.SelectionLength = 0
        Me.OtherDetailsTBOX.SelectionStart = 0
        Me.OtherDetailsTBOX.Size = New System.Drawing.Size(537, 119)
        Me.OtherDetailsTBOX.TabIndex = 4
        Me.OtherDetailsTBOX.UseSelectable = True
        Me.OtherDetailsTBOX.WaterMark = "Input other information here including remarks."
        Me.OtherDetailsTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.OtherDetailsTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'UpdateBTN
        '
        Me.UpdateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateBTN.Image = Nothing
        Me.UpdateBTN.Location = New System.Drawing.Point(450, 234)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(109, 30)
        Me.UpdateBTN.Style = MetroFramework.MetroColorStyle.Teal
        Me.UpdateBTN.TabIndex = 5
        Me.UpdateBTN.Text = "Update"
        Me.UpdateBTN.UseSelectable = True
        Me.UpdateBTN.UseVisualStyleBackColor = True
        '
        'OtherDetailsLBL
        '
        Me.OtherDetailsLBL.AutoSize = True
        Me.OtherDetailsLBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.OtherDetailsLBL.Location = New System.Drawing.Point(22, 82)
        Me.OtherDetailsLBL.Name = "OtherDetailsLBL"
        Me.OtherDetailsLBL.Size = New System.Drawing.Size(108, 19)
        Me.OtherDetailsLBL.TabIndex = 623
        Me.OtherDetailsLBL.Text = "OTHER DETAILS:"
        '
        'StorageLocationTBOX
        '
        '
        '
        '
        Me.StorageLocationTBOX.CustomButton.Image = Nothing
        Me.StorageLocationTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.StorageLocationTBOX.CustomButton.Name = ""
        Me.StorageLocationTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.StorageLocationTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.StorageLocationTBOX.CustomButton.TabIndex = 1
        Me.StorageLocationTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.StorageLocationTBOX.CustomButton.UseSelectable = True
        Me.StorageLocationTBOX.CustomButton.Visible = False
        Me.StorageLocationTBOX.Lines = New String(-1) {}
        Me.StorageLocationTBOX.Location = New System.Drawing.Point(21, 48)
        Me.StorageLocationTBOX.MaxLength = 32767
        Me.StorageLocationTBOX.Name = "StorageLocationTBOX"
        Me.StorageLocationTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StorageLocationTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.StorageLocationTBOX.SelectedText = ""
        Me.StorageLocationTBOX.SelectionLength = 0
        Me.StorageLocationTBOX.SelectionStart = 0
        Me.StorageLocationTBOX.Size = New System.Drawing.Size(236, 30)
        Me.StorageLocationTBOX.TabIndex = 1
        Me.StorageLocationTBOX.UseSelectable = True
        Me.StorageLocationTBOX.WaterMark = "Storage Location"
        Me.StorageLocationTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StorageLocationTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BackloadedByTBOX
        '
        '
        '
        '
        Me.BackloadedByTBOX.CustomButton.Image = Nothing
        Me.BackloadedByTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.BackloadedByTBOX.CustomButton.Name = ""
        Me.BackloadedByTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.BackloadedByTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.BackloadedByTBOX.CustomButton.TabIndex = 1
        Me.BackloadedByTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.BackloadedByTBOX.CustomButton.UseSelectable = True
        Me.BackloadedByTBOX.CustomButton.Visible = False
        Me.BackloadedByTBOX.Lines = New String(-1) {}
        Me.BackloadedByTBOX.Location = New System.Drawing.Point(22, 12)
        Me.BackloadedByTBOX.MaxLength = 32767
        Me.BackloadedByTBOX.Name = "BackloadedByTBOX"
        Me.BackloadedByTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BackloadedByTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BackloadedByTBOX.SelectedText = ""
        Me.BackloadedByTBOX.SelectionLength = 0
        Me.BackloadedByTBOX.SelectionStart = 0
        Me.BackloadedByTBOX.Size = New System.Drawing.Size(236, 30)
        Me.BackloadedByTBOX.TabIndex = 0
        Me.BackloadedByTBOX.UseSelectable = True
        Me.BackloadedByTBOX.WaterMark = "Backloaded By"
        Me.BackloadedByTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BackloadedByTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BackloadsLBL
        '
        Me.BackloadsLBL.AutoSize = True
        Me.BackloadsLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.BackloadsLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.BackloadsLBL.Location = New System.Drawing.Point(20, 32)
        Me.BackloadsLBL.Name = "BackloadsLBL"
        Me.BackloadsLBL.Size = New System.Drawing.Size(372, 25)
        Me.BackloadsLBL.TabIndex = 607
        Me.BackloadsLBL.Text = "U P D A T E   B A C K L O A D    R E C O R D"
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(540, 28)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 608
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'BackloadUpdateFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 354)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.BackloadsLBL)
        Me.Controls.Add(Me.BackloadUpdatePNL)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BackloadUpdateFRM"
        Me.Resizable = False
        Me.TopMost = True
        Me.BackloadUpdatePNL.ResumeLayout(False)
        Me.BackloadUpdatePNL.PerformLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackloadUpdatePNL As Panel
    Friend WithEvents OtherDetailsTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents OtherDetailsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents BackloadsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents StorageLocationTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents BackloadedByTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DateToDismantleTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ItemClassCBOX As MetroFramework.Controls.MetroComboBox
    Friend WithEvents UpdateBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents DateToDismantleDTP As MetroFramework.Controls.MetroDateTime
End Class
