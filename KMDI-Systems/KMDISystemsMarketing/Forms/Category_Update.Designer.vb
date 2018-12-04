<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category_Update
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Delete_Btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Update_Btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Add_Btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.CategoryTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.CategoryDGV = New MetroFramework.Controls.MetroGrid()
        Me.CategoryCodeCbox = New System.Windows.Forms.ComboBox()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.CategoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Delete_Btn)
        Me.MetroPanel1.Controls.Add(Me.Update_Btn)
        Me.MetroPanel1.Controls.Add(Me.Add_Btn)
        Me.MetroPanel1.Controls.Add(Me.CategoryTbox)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.CategoryDGV)
        Me.MetroPanel1.Controls.Add(Me.CategoryCodeCbox)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(699, 188)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.UseStyleColors = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Delete_Btn
        '
        Me.Delete_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_Btn.Image = Nothing
        Me.Delete_Btn.Location = New System.Drawing.Point(174, 141)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(74, 30)
        Me.Delete_Btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.Delete_Btn.TabIndex = 37
        Me.Delete_Btn.Text = "&Delete"
        Me.Delete_Btn.UseSelectable = True
        Me.Delete_Btn.UseStyleColors = True
        Me.Delete_Btn.UseVisualStyleBackColor = True
        '
        'Update_Btn
        '
        Me.Update_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update_Btn.Image = Nothing
        Me.Update_Btn.Location = New System.Drawing.Point(94, 141)
        Me.Update_Btn.Name = "Update_Btn"
        Me.Update_Btn.Size = New System.Drawing.Size(74, 30)
        Me.Update_Btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.Update_Btn.TabIndex = 36
        Me.Update_Btn.Text = "Updat&e"
        Me.Update_Btn.UseSelectable = True
        Me.Update_Btn.UseVisualStyleBackColor = True
        '
        'Add_Btn
        '
        Me.Add_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Btn.Image = Nothing
        Me.Add_Btn.Location = New System.Drawing.Point(14, 141)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(74, 30)
        Me.Add_Btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.Add_Btn.TabIndex = 35
        Me.Add_Btn.Text = "&Add"
        Me.Add_Btn.UseSelectable = True
        Me.Add_Btn.UseVisualStyleBackColor = True
        '
        'CategoryTbox
        '
        '
        '
        '
        Me.CategoryTbox.CustomButton.Image = Nothing
        Me.CategoryTbox.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.CategoryTbox.CustomButton.Name = ""
        Me.CategoryTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.CategoryTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CategoryTbox.CustomButton.TabIndex = 1
        Me.CategoryTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CategoryTbox.CustomButton.UseSelectable = True
        Me.CategoryTbox.CustomButton.Visible = False
        Me.CategoryTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.CategoryTbox.ForeColor = System.Drawing.Color.Black
        Me.CategoryTbox.Lines = New String(-1) {}
        Me.CategoryTbox.Location = New System.Drawing.Point(14, 106)
        Me.CategoryTbox.MaxLength = 32767
        Me.CategoryTbox.Name = "CategoryTbox"
        Me.CategoryTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CategoryTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CategoryTbox.SelectedText = ""
        Me.CategoryTbox.SelectionLength = 0
        Me.CategoryTbox.SelectionStart = 0
        Me.CategoryTbox.Size = New System.Drawing.Size(246, 29)
        Me.CategoryTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.CategoryTbox.TabIndex = 12
        Me.CategoryTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CategoryTbox.UseCustomBackColor = True
        Me.CategoryTbox.UseCustomForeColor = True
        Me.CategoryTbox.UseSelectable = True
        Me.CategoryTbox.UseStyleColors = True
        Me.CategoryTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CategoryTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(14, 84)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel2.TabIndex = 11
        Me.MetroLabel2.Text = "Category Name"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(14, 16)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel1.TabIndex = 9
        Me.MetroLabel1.Text = "Category Code"
        '
        'CategoryDGV
        '
        Me.CategoryDGV.AllowUserToAddRows = False
        Me.CategoryDGV.AllowUserToDeleteRows = False
        Me.CategoryDGV.AllowUserToOrderColumns = True
        Me.CategoryDGV.AllowUserToResizeRows = False
        Me.CategoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CategoryDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoryDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CategoryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CategoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.CategoryDGV.Dock = System.Windows.Forms.DockStyle.Right
        Me.CategoryDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.CategoryDGV.EnableHeadersVisualStyles = False
        Me.CategoryDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CategoryDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryDGV.Location = New System.Drawing.Point(266, 0)
        Me.CategoryDGV.MultiSelect = False
        Me.CategoryDGV.Name = "CategoryDGV"
        Me.CategoryDGV.ReadOnly = True
        Me.CategoryDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CategoryDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CategoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDGV.Size = New System.Drawing.Size(433, 188)
        Me.CategoryDGV.Style = MetroFramework.MetroColorStyle.Teal
        Me.CategoryDGV.TabIndex = 8
        Me.CategoryDGV.UseStyleColors = True
        '
        'CategoryCodeCbox
        '
        Me.CategoryCodeCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CategoryCodeCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CategoryCodeCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryCodeCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CategoryCodeCbox.FormattingEnabled = True
        Me.CategoryCodeCbox.ItemHeight = 20
        Me.CategoryCodeCbox.Items.AddRange(New Object() {"1M", "2M & 2F", "3M & 3F", "4M & 4F", "5M & 5F", "5F", "6F", "7M", "SPECIAL GIFT", "Office & Stationery", "Safety & Security", "Raffle"})
        Me.CategoryCodeCbox.Location = New System.Drawing.Point(14, 38)
        Me.CategoryCodeCbox.Name = "CategoryCodeCbox"
        Me.CategoryCodeCbox.Size = New System.Drawing.Size(246, 28)
        Me.CategoryCodeCbox.TabIndex = 38
        '
        'Category_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 268)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.Name = "Category_Update"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.CategoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents CategoryDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CategoryTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Delete_Btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Update_Btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Add_Btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents CategoryCodeCbox As ComboBox
End Class
