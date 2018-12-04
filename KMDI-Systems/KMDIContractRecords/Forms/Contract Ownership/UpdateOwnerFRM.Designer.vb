<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOwnerFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateOwnerFRM))
        Me.RefreshBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.UpdateBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.PODCompanyNameTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.PODOwnersNameTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.PODProjectLabelTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.NODCompanyNameTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.NODOwnersNameTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.NODProjectLabelTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NODFLACompNRBTN = New MetroFramework.Controls.MetroRadioButton()
        Me.NODFLACliNRBTN = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NODABTCompNRBTN = New MetroFramework.Controls.MetroRadioButton()
        Me.NODABTCliNRBTN = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PODFLACompNRBTN = New MetroFramework.Controls.MetroRadioButton()
        Me.PODFLACliNRBTN = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PODABTCompNRBTN = New MetroFramework.Controls.MetroRadioButton()
        Me.PODABTCliNRBTN = New MetroFramework.Controls.MetroRadioButton()
        Me.NODClientsNameTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.PODClientsNameTBOX = New MetroFramework.Controls.MetroTextBox()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RefreshBTN
        '
        Me.RefreshBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshBTN.Image = Nothing
        Me.RefreshBTN.Location = New System.Drawing.Point(401, 456)
        Me.RefreshBTN.Name = "RefreshBTN"
        Me.RefreshBTN.Size = New System.Drawing.Size(109, 30)
        Me.RefreshBTN.Style = MetroFramework.MetroColorStyle.Teal
        Me.RefreshBTN.TabIndex = 4
        Me.RefreshBTN.Text = "Refresh"
        Me.RefreshBTN.UseSelectable = True
        Me.RefreshBTN.UseVisualStyleBackColor = True
        '
        'UpdateBTN
        '
        Me.UpdateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateBTN.Image = Nothing
        Me.UpdateBTN.Location = New System.Drawing.Point(516, 456)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(109, 30)
        Me.UpdateBTN.Style = MetroFramework.MetroColorStyle.Teal
        Me.UpdateBTN.TabIndex = 3
        Me.UpdateBTN.Text = "Update"
        Me.UpdateBTN.UseSelectable = True
        Me.UpdateBTN.UseVisualStyleBackColor = True
        '
        'PODCompanyNameTBOX
        '
        Me.PODCompanyNameTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.PODCompanyNameTBOX.CustomButton.Image = Nothing
        Me.PODCompanyNameTBOX.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.PODCompanyNameTBOX.CustomButton.Name = ""
        Me.PODCompanyNameTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.PODCompanyNameTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PODCompanyNameTBOX.CustomButton.TabIndex = 1
        Me.PODCompanyNameTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PODCompanyNameTBOX.CustomButton.UseSelectable = True
        Me.PODCompanyNameTBOX.CustomButton.Visible = False
        Me.PODCompanyNameTBOX.Lines = New String(-1) {}
        Me.PODCompanyNameTBOX.Location = New System.Drawing.Point(92, 414)
        Me.PODCompanyNameTBOX.MaxLength = 32767
        Me.PODCompanyNameTBOX.Name = "PODCompanyNameTBOX"
        Me.PODCompanyNameTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PODCompanyNameTBOX.ReadOnly = True
        Me.PODCompanyNameTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PODCompanyNameTBOX.SelectedText = ""
        Me.PODCompanyNameTBOX.SelectionLength = 0
        Me.PODCompanyNameTBOX.SelectionStart = 0
        Me.PODCompanyNameTBOX.Size = New System.Drawing.Size(255, 30)
        Me.PODCompanyNameTBOX.Style = MetroFramework.MetroColorStyle.Purple
        Me.PODCompanyNameTBOX.TabIndex = 670
        Me.PODCompanyNameTBOX.TabStop = False
        Me.PODCompanyNameTBOX.UseSelectable = True
        Me.PODCompanyNameTBOX.WaterMark = "Company Name"
        Me.PODCompanyNameTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PODCompanyNameTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PODOwnersNameTBOX
        '
        '
        '
        '
        Me.PODOwnersNameTBOX.CustomButton.Image = Nothing
        Me.PODOwnersNameTBOX.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.PODOwnersNameTBOX.CustomButton.Name = ""
        Me.PODOwnersNameTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.PODOwnersNameTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PODOwnersNameTBOX.CustomButton.TabIndex = 1
        Me.PODOwnersNameTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PODOwnersNameTBOX.CustomButton.UseSelectable = True
        Me.PODOwnersNameTBOX.CustomButton.Visible = False
        Me.PODOwnersNameTBOX.Lines = New String(-1) {}
        Me.PODOwnersNameTBOX.Location = New System.Drawing.Point(92, 342)
        Me.PODOwnersNameTBOX.MaxLength = 32767
        Me.PODOwnersNameTBOX.Name = "PODOwnersNameTBOX"
        Me.PODOwnersNameTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PODOwnersNameTBOX.ReadOnly = True
        Me.PODOwnersNameTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PODOwnersNameTBOX.SelectedText = ""
        Me.PODOwnersNameTBOX.SelectionLength = 0
        Me.PODOwnersNameTBOX.SelectionStart = 0
        Me.PODOwnersNameTBOX.Size = New System.Drawing.Size(255, 30)
        Me.PODOwnersNameTBOX.Style = MetroFramework.MetroColorStyle.Purple
        Me.PODOwnersNameTBOX.TabIndex = 671
        Me.PODOwnersNameTBOX.TabStop = False
        Me.PODOwnersNameTBOX.UseSelectable = True
        Me.PODOwnersNameTBOX.WaterMark = "Owner's Name"
        Me.PODOwnersNameTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PODOwnersNameTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PODProjectLabelTBOX
        '
        Me.PODProjectLabelTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.PODProjectLabelTBOX.CustomButton.Image = Nothing
        Me.PODProjectLabelTBOX.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.PODProjectLabelTBOX.CustomButton.Name = ""
        Me.PODProjectLabelTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.PODProjectLabelTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PODProjectLabelTBOX.CustomButton.TabIndex = 1
        Me.PODProjectLabelTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PODProjectLabelTBOX.CustomButton.UseSelectable = True
        Me.PODProjectLabelTBOX.CustomButton.Visible = False
        Me.PODProjectLabelTBOX.Lines = New String(-1) {}
        Me.PODProjectLabelTBOX.Location = New System.Drawing.Point(92, 306)
        Me.PODProjectLabelTBOX.MaxLength = 32767
        Me.PODProjectLabelTBOX.Name = "PODProjectLabelTBOX"
        Me.PODProjectLabelTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PODProjectLabelTBOX.ReadOnly = True
        Me.PODProjectLabelTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PODProjectLabelTBOX.SelectedText = ""
        Me.PODProjectLabelTBOX.SelectionLength = 0
        Me.PODProjectLabelTBOX.SelectionStart = 0
        Me.PODProjectLabelTBOX.Size = New System.Drawing.Size(255, 30)
        Me.PODProjectLabelTBOX.Style = MetroFramework.MetroColorStyle.Purple
        Me.PODProjectLabelTBOX.TabIndex = 672
        Me.PODProjectLabelTBOX.TabStop = False
        Me.PODProjectLabelTBOX.UseSelectable = True
        Me.PODProjectLabelTBOX.WaterMark = "Project Label"
        Me.PODProjectLabelTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PODProjectLabelTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NODCompanyNameTBOX
        '
        Me.NODCompanyNameTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.NODCompanyNameTBOX.CustomButton.Image = Nothing
        Me.NODCompanyNameTBOX.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.NODCompanyNameTBOX.CustomButton.Name = ""
        Me.NODCompanyNameTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.NODCompanyNameTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NODCompanyNameTBOX.CustomButton.TabIndex = 1
        Me.NODCompanyNameTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NODCompanyNameTBOX.CustomButton.UseSelectable = True
        Me.NODCompanyNameTBOX.CustomButton.Visible = False
        Me.NODCompanyNameTBOX.Lines = New String(-1) {}
        Me.NODCompanyNameTBOX.Location = New System.Drawing.Point(92, 231)
        Me.NODCompanyNameTBOX.MaxLength = 32767
        Me.NODCompanyNameTBOX.Name = "NODCompanyNameTBOX"
        Me.NODCompanyNameTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NODCompanyNameTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NODCompanyNameTBOX.SelectedText = ""
        Me.NODCompanyNameTBOX.SelectionLength = 0
        Me.NODCompanyNameTBOX.SelectionStart = 0
        Me.NODCompanyNameTBOX.Size = New System.Drawing.Size(255, 30)
        Me.NODCompanyNameTBOX.Style = MetroFramework.MetroColorStyle.Purple
        Me.NODCompanyNameTBOX.TabIndex = 2
        Me.NODCompanyNameTBOX.UseSelectable = True
        Me.NODCompanyNameTBOX.WaterMark = "Company Name"
        Me.NODCompanyNameTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NODCompanyNameTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NODOwnersNameTBOX
        '
        '
        '
        '
        Me.NODOwnersNameTBOX.CustomButton.Image = Nothing
        Me.NODOwnersNameTBOX.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.NODOwnersNameTBOX.CustomButton.Name = ""
        Me.NODOwnersNameTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.NODOwnersNameTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NODOwnersNameTBOX.CustomButton.TabIndex = 1
        Me.NODOwnersNameTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NODOwnersNameTBOX.CustomButton.UseSelectable = True
        Me.NODOwnersNameTBOX.CustomButton.Visible = False
        Me.NODOwnersNameTBOX.Lines = New String(-1) {}
        Me.NODOwnersNameTBOX.Location = New System.Drawing.Point(92, 159)
        Me.NODOwnersNameTBOX.MaxLength = 32767
        Me.NODOwnersNameTBOX.Name = "NODOwnersNameTBOX"
        Me.NODOwnersNameTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NODOwnersNameTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NODOwnersNameTBOX.SelectedText = ""
        Me.NODOwnersNameTBOX.SelectionLength = 0
        Me.NODOwnersNameTBOX.SelectionStart = 0
        Me.NODOwnersNameTBOX.Size = New System.Drawing.Size(255, 30)
        Me.NODOwnersNameTBOX.Style = MetroFramework.MetroColorStyle.Purple
        Me.NODOwnersNameTBOX.TabIndex = 0
        Me.NODOwnersNameTBOX.UseSelectable = True
        Me.NODOwnersNameTBOX.WaterMark = "Owner's Name"
        Me.NODOwnersNameTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NODOwnersNameTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NODProjectLabelTBOX
        '
        Me.NODProjectLabelTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.NODProjectLabelTBOX.CustomButton.Image = Nothing
        Me.NODProjectLabelTBOX.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.NODProjectLabelTBOX.CustomButton.Name = ""
        Me.NODProjectLabelTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.NODProjectLabelTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NODProjectLabelTBOX.CustomButton.TabIndex = 1
        Me.NODProjectLabelTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NODProjectLabelTBOX.CustomButton.UseSelectable = True
        Me.NODProjectLabelTBOX.CustomButton.Visible = False
        Me.NODProjectLabelTBOX.Lines = New String(-1) {}
        Me.NODProjectLabelTBOX.Location = New System.Drawing.Point(92, 123)
        Me.NODProjectLabelTBOX.MaxLength = 32767
        Me.NODProjectLabelTBOX.Name = "NODProjectLabelTBOX"
        Me.NODProjectLabelTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NODProjectLabelTBOX.ReadOnly = True
        Me.NODProjectLabelTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NODProjectLabelTBOX.SelectedText = ""
        Me.NODProjectLabelTBOX.SelectionLength = 0
        Me.NODProjectLabelTBOX.SelectionStart = 0
        Me.NODProjectLabelTBOX.Size = New System.Drawing.Size(255, 30)
        Me.NODProjectLabelTBOX.Style = MetroFramework.MetroColorStyle.Purple
        Me.NODProjectLabelTBOX.TabIndex = 0
        Me.NODProjectLabelTBOX.TabStop = False
        Me.NODProjectLabelTBOX.UseSelectable = True
        Me.NODProjectLabelTBOX.WaterMark = "Project Label"
        Me.NODProjectLabelTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NODProjectLabelTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 58)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(277, 25)
        Me.MetroLabel1.TabIndex = 656
        Me.MetroLabel1.Text = "U P D A T E   O W N  E R S H I P"
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(555, 55)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 655
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(43, 95)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(154, 19)
        Me.MetroLabel2.TabIndex = 657
        Me.MetroLabel2.Text = "NEW OWNER DETAILS"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(43, 278)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(185, 19)
        Me.MetroLabel3.TabIndex = 658
        Me.MetroLabel3.Text = "CURRENT OWNER DETAILS"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(353, 123)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(84, 15)
        Me.MetroLabel4.TabIndex = 659
        Me.MetroLabel4.Text = "FILE LABEL AS"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(353, 180)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(129, 15)
        Me.MetroLabel5.TabIndex = 660
        Me.MetroLabel5.Text = "ADDRESS BILLING TO"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NODFLACompNRBTN)
        Me.Panel1.Controls.Add(Me.NODFLACliNRBTN)
        Me.Panel1.Location = New System.Drawing.Point(373, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 24)
        Me.Panel1.TabIndex = 661
        '
        'NODFLACompNRBTN
        '
        Me.NODFLACompNRBTN.AutoSize = True
        Me.NODFLACompNRBTN.Location = New System.Drawing.Point(120, 4)
        Me.NODFLACompNRBTN.Name = "NODFLACompNRBTN"
        Me.NODFLACompNRBTN.Size = New System.Drawing.Size(110, 15)
        Me.NODFLACompNRBTN.TabIndex = 673
        Me.NODFLACompNRBTN.Text = "Company Name"
        Me.NODFLACompNRBTN.UseSelectable = True
        '
        'NODFLACliNRBTN
        '
        Me.NODFLACliNRBTN.AutoSize = True
        Me.NODFLACliNRBTN.Location = New System.Drawing.Point(17, 4)
        Me.NODFLACliNRBTN.Name = "NODFLACliNRBTN"
        Me.NODFLACliNRBTN.Size = New System.Drawing.Size(97, 15)
        Me.NODFLACliNRBTN.TabIndex = 676
        Me.NODFLACliNRBTN.Text = "Client's Name"
        Me.NODFLACliNRBTN.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(353, 363)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(129, 15)
        Me.MetroLabel6.TabIndex = 664
        Me.MetroLabel6.Text = "ADDRESS BILLING TO"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(353, 306)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(84, 15)
        Me.MetroLabel7.TabIndex = 663
        Me.MetroLabel7.Text = "FILE LABEL AS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NODABTCompNRBTN)
        Me.Panel2.Controls.Add(Me.NODABTCliNRBTN)
        Me.Panel2.Location = New System.Drawing.Point(373, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 24)
        Me.Panel2.TabIndex = 665
        '
        'NODABTCompNRBTN
        '
        Me.NODABTCompNRBTN.AutoSize = True
        Me.NODABTCompNRBTN.Location = New System.Drawing.Point(120, 4)
        Me.NODABTCompNRBTN.Name = "NODABTCompNRBTN"
        Me.NODABTCompNRBTN.Size = New System.Drawing.Size(110, 15)
        Me.NODABTCompNRBTN.TabIndex = 674
        Me.NODABTCompNRBTN.Text = "Company Name"
        Me.NODABTCompNRBTN.UseSelectable = True
        '
        'NODABTCliNRBTN
        '
        Me.NODABTCliNRBTN.AutoSize = True
        Me.NODABTCliNRBTN.Location = New System.Drawing.Point(17, 4)
        Me.NODABTCliNRBTN.Name = "NODABTCliNRBTN"
        Me.NODABTCliNRBTN.Size = New System.Drawing.Size(97, 15)
        Me.NODABTCliNRBTN.TabIndex = 675
        Me.NODABTCliNRBTN.Text = "Client's Name"
        Me.NODABTCliNRBTN.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PODFLACompNRBTN)
        Me.Panel3.Controls.Add(Me.PODFLACliNRBTN)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(373, 325)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(252, 24)
        Me.Panel3.TabIndex = 666
        '
        'PODFLACompNRBTN
        '
        Me.PODFLACompNRBTN.AutoSize = True
        Me.PODFLACompNRBTN.Enabled = False
        Me.PODFLACompNRBTN.Location = New System.Drawing.Point(120, 4)
        Me.PODFLACompNRBTN.Name = "PODFLACompNRBTN"
        Me.PODFLACompNRBTN.Size = New System.Drawing.Size(110, 15)
        Me.PODFLACompNRBTN.TabIndex = 678
        Me.PODFLACompNRBTN.Text = "Company Name"
        Me.PODFLACompNRBTN.UseSelectable = True
        '
        'PODFLACliNRBTN
        '
        Me.PODFLACliNRBTN.AutoSize = True
        Me.PODFLACliNRBTN.Enabled = False
        Me.PODFLACliNRBTN.Location = New System.Drawing.Point(17, 4)
        Me.PODFLACliNRBTN.Name = "PODFLACliNRBTN"
        Me.PODFLACliNRBTN.Size = New System.Drawing.Size(97, 15)
        Me.PODFLACliNRBTN.TabIndex = 677
        Me.PODFLACliNRBTN.Text = "Client's Name"
        Me.PODFLACliNRBTN.UseSelectable = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PODABTCompNRBTN)
        Me.Panel4.Controls.Add(Me.PODABTCliNRBTN)
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(373, 384)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(252, 24)
        Me.Panel4.TabIndex = 667
        '
        'PODABTCompNRBTN
        '
        Me.PODABTCompNRBTN.AutoSize = True
        Me.PODABTCompNRBTN.Enabled = False
        Me.PODABTCompNRBTN.Location = New System.Drawing.Point(120, 4)
        Me.PODABTCompNRBTN.Name = "PODABTCompNRBTN"
        Me.PODABTCompNRBTN.Size = New System.Drawing.Size(110, 15)
        Me.PODABTCompNRBTN.TabIndex = 680
        Me.PODABTCompNRBTN.Text = "Company Name"
        Me.PODABTCompNRBTN.UseSelectable = True
        '
        'PODABTCliNRBTN
        '
        Me.PODABTCliNRBTN.AutoSize = True
        Me.PODABTCliNRBTN.Enabled = False
        Me.PODABTCliNRBTN.Location = New System.Drawing.Point(17, 4)
        Me.PODABTCliNRBTN.Name = "PODABTCliNRBTN"
        Me.PODABTCliNRBTN.Size = New System.Drawing.Size(97, 15)
        Me.PODABTCliNRBTN.TabIndex = 679
        Me.PODABTCliNRBTN.Text = "Client's Name"
        Me.PODABTCliNRBTN.UseSelectable = True
        '
        'NODClientsNameTBOX
        '
        Me.NODClientsNameTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.NODClientsNameTBOX.CustomButton.Image = Nothing
        Me.NODClientsNameTBOX.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.NODClientsNameTBOX.CustomButton.Name = ""
        Me.NODClientsNameTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.NODClientsNameTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.NODClientsNameTBOX.CustomButton.TabIndex = 1
        Me.NODClientsNameTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.NODClientsNameTBOX.CustomButton.UseSelectable = True
        Me.NODClientsNameTBOX.CustomButton.Visible = False
        Me.NODClientsNameTBOX.Lines = New String(-1) {}
        Me.NODClientsNameTBOX.Location = New System.Drawing.Point(92, 195)
        Me.NODClientsNameTBOX.MaxLength = 32767
        Me.NODClientsNameTBOX.Name = "NODClientsNameTBOX"
        Me.NODClientsNameTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NODClientsNameTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NODClientsNameTBOX.SelectedText = ""
        Me.NODClientsNameTBOX.SelectionLength = 0
        Me.NODClientsNameTBOX.SelectionStart = 0
        Me.NODClientsNameTBOX.Size = New System.Drawing.Size(255, 30)
        Me.NODClientsNameTBOX.Style = MetroFramework.MetroColorStyle.Purple
        Me.NODClientsNameTBOX.TabIndex = 1
        Me.NODClientsNameTBOX.UseSelectable = True
        Me.NODClientsNameTBOX.WaterMark = "Client's Name"
        Me.NODClientsNameTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.NODClientsNameTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PODClientsNameTBOX
        '
        Me.PODClientsNameTBOX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.PODClientsNameTBOX.CustomButton.Image = Nothing
        Me.PODClientsNameTBOX.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.PODClientsNameTBOX.CustomButton.Name = ""
        Me.PODClientsNameTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.PODClientsNameTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PODClientsNameTBOX.CustomButton.TabIndex = 1
        Me.PODClientsNameTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PODClientsNameTBOX.CustomButton.UseSelectable = True
        Me.PODClientsNameTBOX.CustomButton.Visible = False
        Me.PODClientsNameTBOX.Lines = New String(-1) {}
        Me.PODClientsNameTBOX.Location = New System.Drawing.Point(92, 378)
        Me.PODClientsNameTBOX.MaxLength = 32767
        Me.PODClientsNameTBOX.Name = "PODClientsNameTBOX"
        Me.PODClientsNameTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PODClientsNameTBOX.ReadOnly = True
        Me.PODClientsNameTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PODClientsNameTBOX.SelectedText = ""
        Me.PODClientsNameTBOX.SelectionLength = 0
        Me.PODClientsNameTBOX.SelectionStart = 0
        Me.PODClientsNameTBOX.Size = New System.Drawing.Size(255, 30)
        Me.PODClientsNameTBOX.Style = MetroFramework.MetroColorStyle.Purple
        Me.PODClientsNameTBOX.TabIndex = 669
        Me.PODClientsNameTBOX.TabStop = False
        Me.PODClientsNameTBOX.UseSelectable = True
        Me.PODClientsNameTBOX.WaterMark = "Client's Name"
        Me.PODClientsNameTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PODClientsNameTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'UpdateOwnerFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 499)
        Me.Controls.Add(Me.PODClientsNameTBOX)
        Me.Controls.Add(Me.NODClientsNameTBOX)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.RefreshBTN)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Controls.Add(Me.PODCompanyNameTBOX)
        Me.Controls.Add(Me.PODOwnersNameTBOX)
        Me.Controls.Add(Me.PODProjectLabelTBOX)
        Me.Controls.Add(Me.NODCompanyNameTBOX)
        Me.Controls.Add(Me.NODOwnersNameTBOX)
        Me.Controls.Add(Me.NODProjectLabelTBOX)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.LoadingPB)
        Me.Name = "UpdateOwnerFRM"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Purple
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RefreshBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents UpdateBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents PODCompanyNameTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PODOwnersNameTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PODProjectLabelTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents NODCompanyNameTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents NODOwnersNameTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents NODProjectLabelTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NODFLACompNRBTN As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents NODFLACliNRBTN As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NODABTCompNRBTN As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents NODABTCliNRBTN As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PODFLACompNRBTN As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents PODFLACliNRBTN As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PODABTCompNRBTN As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents PODABTCliNRBTN As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents NODClientsNameTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PODClientsNameTBOX As MetroFramework.Controls.MetroTextBox
End Class
