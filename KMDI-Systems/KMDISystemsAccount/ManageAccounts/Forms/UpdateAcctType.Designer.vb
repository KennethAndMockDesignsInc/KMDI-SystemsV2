<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateAcctType
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AcctTypeDGV = New MetroFramework.Controls.MetroGrid()
        Me.AcctTypeNameTbox = New MetroFramework.Controls.MetroTextBox()
        Me.AddAcctTypeBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.UpdateAcctTypeBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.DeleteAcctTypeBtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.AcctTypeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AcctTypeDGV
        '
        Me.AcctTypeDGV.AllowUserToAddRows = False
        Me.AcctTypeDGV.AllowUserToDeleteRows = False
        Me.AcctTypeDGV.AllowUserToOrderColumns = True
        Me.AcctTypeDGV.AllowUserToResizeRows = False
        Me.AcctTypeDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcctTypeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AcctTypeDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AcctTypeDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AcctTypeDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.AcctTypeDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AcctTypeDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AcctTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AcctTypeDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.AcctTypeDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.AcctTypeDGV.EnableHeadersVisualStyles = False
        Me.AcctTypeDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.AcctTypeDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AcctTypeDGV.Location = New System.Drawing.Point(340, 27)
        Me.AcctTypeDGV.MultiSelect = False
        Me.AcctTypeDGV.Name = "AcctTypeDGV"
        Me.AcctTypeDGV.ReadOnly = True
        Me.AcctTypeDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AcctTypeDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AcctTypeDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AcctTypeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AcctTypeDGV.Size = New System.Drawing.Size(351, 133)
        Me.AcctTypeDGV.Style = MetroFramework.MetroColorStyle.Silver
        Me.AcctTypeDGV.TabIndex = 7
        Me.AcctTypeDGV.UseStyleColors = True
        '
        'AcctTypeNameTbox
        '
        '
        '
        '
        Me.AcctTypeNameTbox.CustomButton.Image = Nothing
        Me.AcctTypeNameTbox.CustomButton.Location = New System.Drawing.Point(256, 2)
        Me.AcctTypeNameTbox.CustomButton.Name = ""
        Me.AcctTypeNameTbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.AcctTypeNameTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AcctTypeNameTbox.CustomButton.TabIndex = 1
        Me.AcctTypeNameTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AcctTypeNameTbox.CustomButton.UseSelectable = True
        Me.AcctTypeNameTbox.CustomButton.Visible = False
        Me.AcctTypeNameTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.AcctTypeNameTbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.AcctTypeNameTbox.ForeColor = System.Drawing.Color.Black
        Me.AcctTypeNameTbox.Lines = New String(-1) {}
        Me.AcctTypeNameTbox.Location = New System.Drawing.Point(23, 63)
        Me.AcctTypeNameTbox.MaxLength = 32767
        Me.AcctTypeNameTbox.Name = "AcctTypeNameTbox"
        Me.AcctTypeNameTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AcctTypeNameTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AcctTypeNameTbox.SelectedText = ""
        Me.AcctTypeNameTbox.SelectionLength = 0
        Me.AcctTypeNameTbox.SelectionStart = 0
        Me.AcctTypeNameTbox.Size = New System.Drawing.Size(294, 40)
        Me.AcctTypeNameTbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.AcctTypeNameTbox.TabIndex = 8
        Me.AcctTypeNameTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.AcctTypeNameTbox.UseCustomBackColor = True
        Me.AcctTypeNameTbox.UseCustomForeColor = True
        Me.AcctTypeNameTbox.UseSelectable = True
        Me.AcctTypeNameTbox.UseStyleColors = True
        Me.AcctTypeNameTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AcctTypeNameTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'AddAcctTypeBtn
        '
        Me.AddAcctTypeBtn.BackColor = System.Drawing.Color.Black
        Me.AddAcctTypeBtn.ForeColor = System.Drawing.Color.Black
        Me.AddAcctTypeBtn.Image = Nothing
        Me.AddAcctTypeBtn.Location = New System.Drawing.Point(23, 109)
        Me.AddAcctTypeBtn.Name = "AddAcctTypeBtn"
        Me.AddAcctTypeBtn.Size = New System.Drawing.Size(90, 36)
        Me.AddAcctTypeBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.AddAcctTypeBtn.TabIndex = 9
        Me.AddAcctTypeBtn.Text = "&Add"
        Me.AddAcctTypeBtn.UseCustomBackColor = True
        Me.AddAcctTypeBtn.UseCustomForeColor = True
        Me.AddAcctTypeBtn.UseSelectable = True
        Me.AddAcctTypeBtn.UseStyleColors = True
        Me.AddAcctTypeBtn.UseVisualStyleBackColor = False
        '
        'UpdateAcctTypeBtn
        '
        Me.UpdateAcctTypeBtn.BackColor = System.Drawing.Color.Black
        Me.UpdateAcctTypeBtn.ForeColor = System.Drawing.Color.Black
        Me.UpdateAcctTypeBtn.Image = Nothing
        Me.UpdateAcctTypeBtn.Location = New System.Drawing.Point(119, 109)
        Me.UpdateAcctTypeBtn.Name = "UpdateAcctTypeBtn"
        Me.UpdateAcctTypeBtn.Size = New System.Drawing.Size(96, 36)
        Me.UpdateAcctTypeBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.UpdateAcctTypeBtn.TabIndex = 10
        Me.UpdateAcctTypeBtn.Text = "Up&date"
        Me.UpdateAcctTypeBtn.UseCustomBackColor = True
        Me.UpdateAcctTypeBtn.UseCustomForeColor = True
        Me.UpdateAcctTypeBtn.UseSelectable = True
        Me.UpdateAcctTypeBtn.UseStyleColors = True
        Me.UpdateAcctTypeBtn.UseVisualStyleBackColor = False
        '
        'DeleteAcctTypeBtn
        '
        Me.DeleteAcctTypeBtn.BackColor = System.Drawing.Color.Black
        Me.DeleteAcctTypeBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteAcctTypeBtn.Image = Nothing
        Me.DeleteAcctTypeBtn.Location = New System.Drawing.Point(221, 109)
        Me.DeleteAcctTypeBtn.Name = "DeleteAcctTypeBtn"
        Me.DeleteAcctTypeBtn.Size = New System.Drawing.Size(96, 36)
        Me.DeleteAcctTypeBtn.Style = MetroFramework.MetroColorStyle.Teal
        Me.DeleteAcctTypeBtn.TabIndex = 11
        Me.DeleteAcctTypeBtn.Text = "&Delete"
        Me.DeleteAcctTypeBtn.UseCustomBackColor = True
        Me.DeleteAcctTypeBtn.UseCustomForeColor = True
        Me.DeleteAcctTypeBtn.UseSelectable = True
        Me.DeleteAcctTypeBtn.UseStyleColors = True
        Me.DeleteAcctTypeBtn.UseVisualStyleBackColor = False
        '
        'UpdateAcctType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 165)
        Me.Controls.Add(Me.DeleteAcctTypeBtn)
        Me.Controls.Add(Me.UpdateAcctTypeBtn)
        Me.Controls.Add(Me.AddAcctTypeBtn)
        Me.Controls.Add(Me.AcctTypeNameTbox)
        Me.Controls.Add(Me.AcctTypeDGV)
        Me.MaximizeBox = False
        Me.Name = "UpdateAcctType"
        Me.Resizable = False
        CType(Me.AcctTypeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AcctTypeDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents AcctTypeNameTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents AddAcctTypeBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents UpdateAcctTypeBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents DeleteAcctTypeBtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
