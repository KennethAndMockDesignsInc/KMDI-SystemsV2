<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PD_UpdateCOMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PD_UpdateCOMP))
        Me.Comp_TabControl = New MetroFramework.Controls.MetroTabControl()
        Me.Comp_Tabpage = New MetroFramework.Controls.MetroTabPage()
        Me.CompRemarks_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Save_Btn = New MetroFramework.Controls.MetroButton()
        Me.CompSec_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.CompAddress_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.CompCPno_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.CompName_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPbox = New System.Windows.Forms.PictureBox()
        Me.Comp_TabControl.SuspendLayout()
        Me.Comp_Tabpage.SuspendLayout()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Comp_TabControl
        '
        Me.Comp_TabControl.Controls.Add(Me.Comp_Tabpage)
        Me.Comp_TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Comp_TabControl.Location = New System.Drawing.Point(20, 60)
        Me.Comp_TabControl.Name = "Comp_TabControl"
        Me.Comp_TabControl.SelectedIndex = 0
        Me.Comp_TabControl.Size = New System.Drawing.Size(458, 336)
        Me.Comp_TabControl.TabIndex = 1
        Me.Comp_TabControl.UseSelectable = True
        '
        'Comp_Tabpage
        '
        Me.Comp_Tabpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Comp_Tabpage.Controls.Add(Me.CompRemarks_Tbox)
        Me.Comp_Tabpage.Controls.Add(Me.MetroLabel2)
        Me.Comp_Tabpage.Controls.Add(Me.Save_Btn)
        Me.Comp_Tabpage.Controls.Add(Me.CompSec_Tbox)
        Me.Comp_Tabpage.Controls.Add(Me.CompAddress_Tbox)
        Me.Comp_Tabpage.Controls.Add(Me.CompCPno_Tbox)
        Me.Comp_Tabpage.Controls.Add(Me.CompName_Tbox)
        Me.Comp_Tabpage.Controls.Add(Me.MetroLabel6)
        Me.Comp_Tabpage.Controls.Add(Me.MetroLabel5)
        Me.Comp_Tabpage.Controls.Add(Me.MetroLabel4)
        Me.Comp_Tabpage.Controls.Add(Me.MetroLabel1)
        Me.Comp_Tabpage.HorizontalScrollbarBarColor = True
        Me.Comp_Tabpage.HorizontalScrollbarHighlightOnWheel = False
        Me.Comp_Tabpage.HorizontalScrollbarSize = 10
        Me.Comp_Tabpage.Location = New System.Drawing.Point(4, 38)
        Me.Comp_Tabpage.Name = "Comp_Tabpage"
        Me.Comp_Tabpage.Size = New System.Drawing.Size(450, 294)
        Me.Comp_Tabpage.TabIndex = 0
        Me.Comp_Tabpage.Text = "                                                                                 " &
    "                                        "
        Me.Comp_Tabpage.VerticalScrollbarBarColor = True
        Me.Comp_Tabpage.VerticalScrollbarHighlightOnWheel = False
        Me.Comp_Tabpage.VerticalScrollbarSize = 10
        '
        'CompRemarks_Tbox
        '
        '
        '
        '
        Me.CompRemarks_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompRemarks_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.CompRemarks_Tbox.CustomButton.Location = New System.Drawing.Point(210, 1)
        Me.CompRemarks_Tbox.CustomButton.Name = ""
        Me.CompRemarks_Tbox.CustomButton.Size = New System.Drawing.Size(89, 89)
        Me.CompRemarks_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompRemarks_Tbox.CustomButton.TabIndex = 1
        Me.CompRemarks_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CompRemarks_Tbox.CustomButton.UseSelectable = True
        Me.CompRemarks_Tbox.CustomButton.Visible = False
        Me.CompRemarks_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.CompRemarks_Tbox.ForeColor = System.Drawing.Color.Black
        Me.CompRemarks_Tbox.Lines = New String(-1) {}
        Me.CompRemarks_Tbox.Location = New System.Drawing.Point(130, 155)
        Me.CompRemarks_Tbox.MaxLength = 32767
        Me.CompRemarks_Tbox.Multiline = True
        Me.CompRemarks_Tbox.Name = "CompRemarks_Tbox"
        Me.CompRemarks_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompRemarks_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CompRemarks_Tbox.SelectedText = ""
        Me.CompRemarks_Tbox.SelectionLength = 0
        Me.CompRemarks_Tbox.SelectionStart = 0
        Me.CompRemarks_Tbox.ShowClearButton = True
        Me.CompRemarks_Tbox.Size = New System.Drawing.Size(300, 91)
        Me.CompRemarks_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompRemarks_Tbox.TabIndex = 5
        Me.CompRemarks_Tbox.UseCustomForeColor = True
        Me.CompRemarks_Tbox.UseSelectable = True
        Me.CompRemarks_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CompRemarks_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(44, 155)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(80, 25)
        Me.MetroLabel2.TabIndex = 19
        Me.MetroLabel2.Text = "Remarks:"
        '
        'Save_Btn
        '
        Me.Save_Btn.Location = New System.Drawing.Point(333, 252)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(97, 37)
        Me.Save_Btn.TabIndex = 6
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseSelectable = True
        '
        'CompSec_Tbox
        '
        '
        '
        '
        Me.CompSec_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompSec_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.CompSec_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.CompSec_Tbox.CustomButton.Name = ""
        Me.CompSec_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.CompSec_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompSec_Tbox.CustomButton.TabIndex = 1
        Me.CompSec_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CompSec_Tbox.CustomButton.UseSelectable = True
        Me.CompSec_Tbox.CustomButton.Visible = False
        Me.CompSec_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.CompSec_Tbox.ForeColor = System.Drawing.Color.Black
        Me.CompSec_Tbox.Lines = New String(-1) {}
        Me.CompSec_Tbox.Location = New System.Drawing.Point(130, 119)
        Me.CompSec_Tbox.MaxLength = 32767
        Me.CompSec_Tbox.Name = "CompSec_Tbox"
        Me.CompSec_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompSec_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CompSec_Tbox.SelectedText = ""
        Me.CompSec_Tbox.SelectionLength = 0
        Me.CompSec_Tbox.SelectionStart = 0
        Me.CompSec_Tbox.ShowClearButton = True
        Me.CompSec_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.CompSec_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompSec_Tbox.TabIndex = 4
        Me.CompSec_Tbox.UseCustomForeColor = True
        Me.CompSec_Tbox.UseSelectable = True
        Me.CompSec_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CompSec_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CompAddress_Tbox
        '
        '
        '
        '
        Me.CompAddress_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompAddress_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.CompAddress_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.CompAddress_Tbox.CustomButton.Name = ""
        Me.CompAddress_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.CompAddress_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompAddress_Tbox.CustomButton.TabIndex = 1
        Me.CompAddress_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CompAddress_Tbox.CustomButton.UseSelectable = True
        Me.CompAddress_Tbox.CustomButton.Visible = False
        Me.CompAddress_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.CompAddress_Tbox.ForeColor = System.Drawing.Color.Black
        Me.CompAddress_Tbox.Lines = New String(-1) {}
        Me.CompAddress_Tbox.Location = New System.Drawing.Point(130, 47)
        Me.CompAddress_Tbox.MaxLength = 32767
        Me.CompAddress_Tbox.Name = "CompAddress_Tbox"
        Me.CompAddress_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompAddress_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CompAddress_Tbox.SelectedText = ""
        Me.CompAddress_Tbox.SelectionLength = 0
        Me.CompAddress_Tbox.SelectionStart = 0
        Me.CompAddress_Tbox.ShowClearButton = True
        Me.CompAddress_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.CompAddress_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompAddress_Tbox.TabIndex = 2
        Me.CompAddress_Tbox.UseCustomForeColor = True
        Me.CompAddress_Tbox.UseSelectable = True
        Me.CompAddress_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CompAddress_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CompCPno_Tbox
        '
        Me.CompCPno_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.CompCPno_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompCPno_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.CompCPno_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.CompCPno_Tbox.CustomButton.Name = ""
        Me.CompCPno_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.CompCPno_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompCPno_Tbox.CustomButton.TabIndex = 1
        Me.CompCPno_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CompCPno_Tbox.CustomButton.UseSelectable = True
        Me.CompCPno_Tbox.CustomButton.Visible = False
        Me.CompCPno_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.CompCPno_Tbox.ForeColor = System.Drawing.Color.Black
        Me.CompCPno_Tbox.Lines = New String(-1) {}
        Me.CompCPno_Tbox.Location = New System.Drawing.Point(130, 83)
        Me.CompCPno_Tbox.MaxLength = 32767
        Me.CompCPno_Tbox.Name = "CompCPno_Tbox"
        Me.CompCPno_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompCPno_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CompCPno_Tbox.SelectedText = ""
        Me.CompCPno_Tbox.SelectionLength = 0
        Me.CompCPno_Tbox.SelectionStart = 0
        Me.CompCPno_Tbox.ShowClearButton = True
        Me.CompCPno_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.CompCPno_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompCPno_Tbox.TabIndex = 3
        Me.CompCPno_Tbox.UseCustomForeColor = True
        Me.CompCPno_Tbox.UseSelectable = True
        Me.CompCPno_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CompCPno_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CompName_Tbox
        '
        '
        '
        '
        Me.CompName_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompName_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.CompName_Tbox.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.CompName_Tbox.CustomButton.Name = ""
        Me.CompName_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.CompName_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompName_Tbox.CustomButton.TabIndex = 1
        Me.CompName_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CompName_Tbox.CustomButton.UseSelectable = True
        Me.CompName_Tbox.CustomButton.Visible = False
        Me.CompName_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.CompName_Tbox.ForeColor = System.Drawing.Color.Black
        Me.CompName_Tbox.Lines = New String(-1) {}
        Me.CompName_Tbox.Location = New System.Drawing.Point(130, 11)
        Me.CompName_Tbox.MaxLength = 32767
        Me.CompName_Tbox.Name = "CompName_Tbox"
        Me.CompName_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CompName_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CompName_Tbox.SelectedText = ""
        Me.CompName_Tbox.SelectionLength = 0
        Me.CompName_Tbox.SelectionStart = 0
        Me.CompName_Tbox.ShowClearButton = True
        Me.CompName_Tbox.Size = New System.Drawing.Size(300, 30)
        Me.CompName_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.CompName_Tbox.TabIndex = 1
        Me.CompName_Tbox.UseCustomForeColor = True
        Me.CompName_Tbox.UseSelectable = True
        Me.CompName_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CompName_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(38, 121)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(86, 25)
        Me.MetroLabel6.TabIndex = 7
        Me.MetroLabel6.Text = "Secretary:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(-2, 49)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(126, 25)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Office Address:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 85)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(100, 25)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Mobile No.:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Office Name:"
        '
        'LoadingPbox
        '
        Me.LoadingPbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPbox.BackColor = System.Drawing.Color.Transparent
        Me.LoadingPbox.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPbox.Location = New System.Drawing.Point(413, 65)
        Me.LoadingPbox.Name = "LoadingPbox"
        Me.LoadingPbox.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPbox.TabIndex = 18
        Me.LoadingPbox.TabStop = False
        Me.LoadingPbox.Visible = False
        '
        'PD_UpdateCOMP
        '
        Me.AcceptButton = Me.Save_Btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 416)
        Me.Controls.Add(Me.LoadingPbox)
        Me.Controls.Add(Me.Comp_TabControl)
        Me.MaximizeBox = False
        Me.Name = "PD_UpdateCOMP"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Company"
        Me.Comp_TabControl.ResumeLayout(False)
        Me.Comp_Tabpage.ResumeLayout(False)
        Me.Comp_Tabpage.PerformLayout()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Comp_TabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents Comp_Tabpage As MetroFramework.Controls.MetroTabPage
    Public WithEvents CompRemarks_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Save_Btn As MetroFramework.Controls.MetroButton
    Public WithEvents CompSec_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents CompAddress_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents CompCPno_Tbox As MetroFramework.Controls.MetroTextBox
    Public WithEvents CompName_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingPbox As PictureBox
End Class
