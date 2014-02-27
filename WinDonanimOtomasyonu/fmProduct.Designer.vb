<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ContainerImage1 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage()
        Dim HeaderImage7 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim HeaderImage8 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim PanelStyle4 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle()
        Dim ContainerStyle4 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle()
        Dim PanelHeaderStyle7 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Dim PanelHeaderStyle8 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Dim ContainerImage2 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage()
        Dim HeaderImage1 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim HeaderImage2 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim PanelStyle1 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle()
        Dim ContainerStyle1 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle()
        Dim PanelHeaderStyle1 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Dim PanelHeaderStyle2 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Dim ContainerImage3 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage()
        Dim HeaderImage3 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim HeaderImage4 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim PanelStyle2 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle()
        Dim ContainerStyle2 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle()
        Dim PanelHeaderStyle3 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Dim PanelHeaderStyle4 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Dim ContainerImage4 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage()
        Dim HeaderImage5 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim HeaderImage6 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim PanelStyle3 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle()
        Dim ContainerStyle3 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle()
        Dim PanelHeaderStyle5 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Dim PanelHeaderStyle6 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Me.npMain = New PureComponents.NicePanel.NicePanel()
        Me.npProductDetails = New PureComponents.NicePanel.NicePanel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnitPriceDolar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.npProductList = New PureComponents.NicePanel.NicePanel()
        Me.cmnuProducts = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuProducts_Add = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuProducts_Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuProducts_Cancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuProducts_Del = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuProducts_DeleteAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.npCategories = New PureComponents.NicePanel.NicePanel()
        Me.cmbCategories = New System.Windows.Forms.ComboBox()
        Me.npMain.SuspendLayout()
        Me.npProductDetails.SuspendLayout()
        Me.npProductList.SuspendLayout()
        Me.cmnuProducts.SuspendLayout()
        Me.npCategories.SuspendLayout()
        Me.SuspendLayout()
        '
        'npMain
        '
        Me.npMain.BackColor = System.Drawing.Color.Transparent
        Me.npMain.CloseButton = True
        ContainerImage1.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage1.Image = Nothing
        ContainerImage1.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage1.Transparency = 50
        Me.npMain.ContainerImage = ContainerImage1
        Me.npMain.ContextMenuButton = False
        Me.npMain.Controls.Add(Me.npProductDetails)
        Me.npMain.Controls.Add(Me.npProductList)
        Me.npMain.Controls.Add(Me.npCategories)
        Me.npMain.Dock = System.Windows.Forms.DockStyle.Fill
        HeaderImage7.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage7.Image = Nothing
        Me.npMain.FooterImage = HeaderImage7
        Me.npMain.FooterText = "CODEMARMARA BY K.MURAT BAÞEREN"
        Me.npMain.ForeColor = System.Drawing.Color.Black
        HeaderImage8.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage8.Image = Nothing
        Me.npMain.HeaderImage = HeaderImage8
        Me.npMain.HeaderText = "ÜRÜN EKLE / DÜZENLE / SÝL"
        Me.npMain.IsExpanded = True
        Me.npMain.Location = New System.Drawing.Point(0, 0)
        Me.npMain.MinimizeButton = True
        Me.npMain.MouseMoveTarget = PureComponents.NicePanel.MouseMoveTarget.Form
        Me.npMain.Name = "npMain"
        Me.npMain.OriginalFooterVisible = True
        Me.npMain.OriginalHeight = 558
        Me.npMain.Size = New System.Drawing.Size(585, 547)
        ContainerStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle4.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle4.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle4.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle4.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle4.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        ContainerStyle4.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle4.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle4.ForeColor = System.Drawing.Color.Black
        ContainerStyle4.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle4.ContainerStyle = ContainerStyle4
        PanelHeaderStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle7.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle7.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle7.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        PanelHeaderStyle7.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle7.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle7.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle7.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        PanelHeaderStyle7.Size = PureComponents.NicePanel.PanelHeaderSize.Medium
        PanelHeaderStyle7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        PanelStyle4.FooterStyle = PanelHeaderStyle7
        PanelHeaderStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle8.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle8.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle8.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalBackward
        PanelHeaderStyle8.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle8.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle8.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle8.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelHeaderStyle8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        PanelStyle4.HeaderStyle = PanelHeaderStyle8
        Me.npMain.Style = PanelStyle4
        Me.npMain.TabIndex = 2
        '
        'npProductDetails
        '
        Me.npProductDetails.BackColor = System.Drawing.Color.Transparent
        ContainerImage2.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage2.Image = Nothing
        ContainerImage2.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage2.Transparency = 50
        Me.npProductDetails.ContainerImage = ContainerImage2
        Me.npProductDetails.ContextMenuButton = False
        Me.npProductDetails.Controls.Add(Me.btnDel)
        Me.npProductDetails.Controls.Add(Me.btnCancel)
        Me.npProductDetails.Controls.Add(Me.btnSave)
        Me.npProductDetails.Controls.Add(Me.btnAdd)
        Me.npProductDetails.Controls.Add(Me.txtQuantity)
        Me.npProductDetails.Controls.Add(Me.Label6)
        Me.npProductDetails.Controls.Add(Me.txtCategory)
        Me.npProductDetails.Controls.Add(Me.Label2)
        Me.npProductDetails.Controls.Add(Me.txtUnitPriceDolar)
        Me.npProductDetails.Controls.Add(Me.Label4)
        Me.npProductDetails.Controls.Add(Me.txtProductName)
        Me.npProductDetails.Controls.Add(Me.Label3)
        HeaderImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage1.Image = Nothing
        Me.npProductDetails.FooterImage = HeaderImage1
        Me.npProductDetails.FooterText = ""
        Me.npProductDetails.ForeColor = System.Drawing.Color.Black
        HeaderImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage2.Image = Nothing
        Me.npProductDetails.HeaderImage = HeaderImage2
        Me.npProductDetails.HeaderText = "SEÇÝLÝ ÜRÜN BÝLGÝSÝ"
        Me.npProductDetails.IsExpanded = True
        Me.npProductDetails.Location = New System.Drawing.Point(296, 56)
        Me.npProductDetails.Name = "npProductDetails"
        Me.npProductDetails.OriginalFooterVisible = True
        Me.npProductDetails.OriginalHeight = 0
        Me.npProductDetails.Size = New System.Drawing.Size(280, 456)
        ContainerStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle1.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle1.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle1.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle1.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle1.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle1.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle1.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle1.ForeColor = System.Drawing.Color.Black
        ContainerStyle1.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle1.ContainerStyle = ContainerStyle1
        PanelHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle1.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle1.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle1.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle1.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle1.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle1.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle1.FooterStyle = PanelHeaderStyle1
        PanelHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle2.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle2.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle2.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle2.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle2.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle2.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelHeaderStyle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        PanelStyle1.HeaderStyle = PanelHeaderStyle2
        Me.npProductDetails.Style = PanelStyle1
        Me.npProductDetails.TabIndex = 4
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDel.Location = New System.Drawing.Point(144, 384)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(96, 40)
        Me.btnDel.TabIndex = 23
        Me.btnDel.Text = "SÝL"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(144, 336)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 40)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "IPTAL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSave.Location = New System.Drawing.Point(40, 384)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 40)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "KAYDET"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(40, 336)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 40)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "EKLE"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(128, 200)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(144, 25)
        Me.txtQuantity.TabIndex = 17
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Adet :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCategory
        '
        Me.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategory.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(8, 128)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(264, 25)
        Me.txtCategory.TabIndex = 15
        Me.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "...::: KATEGORÝSÝ :::..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUnitPriceDolar
        '
        Me.txtUnitPriceDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnitPriceDolar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtUnitPriceDolar.Location = New System.Drawing.Point(128, 168)
        Me.txtUnitPriceDolar.Name = "txtUnitPriceDolar"
        Me.txtUnitPriceDolar.Size = New System.Drawing.Size(144, 25)
        Me.txtUnitPriceDolar.TabIndex = 5
        Me.txtUnitPriceDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Birim Fiyatý($) :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProductName
        '
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(8, 72)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(264, 25)
        Me.txtProductName.TabIndex = 3
        Me.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "...::: ÜRÜN ADI :::..."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'npProductList
        '
        Me.npProductList.BackColor = System.Drawing.Color.Transparent
        ContainerImage3.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage3.Image = Nothing
        ContainerImage3.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage3.Transparency = 50
        Me.npProductList.ContainerImage = ContainerImage3
        Me.npProductList.ContextMenuButton = False
        Me.npProductList.ContextMenuStrip = Me.cmnuProducts
        Me.npProductList.Controls.Add(Me.lstProducts)
        HeaderImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage3.Image = Nothing
        Me.npProductList.FooterImage = HeaderImage3
        Me.npProductList.FooterText = ""
        Me.npProductList.ForeColor = System.Drawing.Color.Black
        HeaderImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage4.Image = Nothing
        Me.npProductList.HeaderImage = HeaderImage4
        Me.npProductList.HeaderText = "ÜRÜNLER"
        Me.npProductList.IsExpanded = True
        Me.npProductList.Location = New System.Drawing.Point(8, 160)
        Me.npProductList.Name = "npProductList"
        Me.npProductList.OriginalFooterVisible = True
        Me.npProductList.OriginalHeight = 0
        Me.npProductList.Size = New System.Drawing.Size(280, 352)
        ContainerStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle2.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle2.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle2.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle2.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle2.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle2.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle2.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle2.ForeColor = System.Drawing.Color.Black
        ContainerStyle2.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle2.ContainerStyle = ContainerStyle2
        PanelHeaderStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle3.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle3.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle3.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle3.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle3.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle3.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle2.FooterStyle = PanelHeaderStyle3
        PanelHeaderStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle4.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle4.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle4.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle4.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle4.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle4.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle4.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelHeaderStyle4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        PanelStyle2.HeaderStyle = PanelHeaderStyle4
        Me.npProductList.Style = PanelStyle2
        Me.npProductList.TabIndex = 1
        '
        'cmnuProducts
        '
        Me.cmnuProducts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuProducts_Add, Me.cmnuProducts_Update, Me.cmnuProducts_Cancel, Me.ToolStripMenuItem1, Me.cmnuProducts_Del, Me.ToolStripMenuItem2, Me.cmnuProducts_DeleteAll})
        Me.cmnuProducts.Name = "cmnuProducts"
        Me.cmnuProducts.Size = New System.Drawing.Size(146, 126)
        '
        'cmnuProducts_Add
        '
        Me.cmnuProducts_Add.Name = "cmnuProducts_Add"
        Me.cmnuProducts_Add.Size = New System.Drawing.Size(145, 22)
        Me.cmnuProducts_Add.Text = "Ürün Ekle"
        '
        'cmnuProducts_Update
        '
        Me.cmnuProducts_Update.Name = "cmnuProducts_Update"
        Me.cmnuProducts_Update.Size = New System.Drawing.Size(145, 22)
        Me.cmnuProducts_Update.Text = "Ürün Düzenle"
        '
        'cmnuProducts_Cancel
        '
        Me.cmnuProducts_Cancel.Name = "cmnuProducts_Cancel"
        Me.cmnuProducts_Cancel.Size = New System.Drawing.Size(145, 22)
        Me.cmnuProducts_Cancel.Text = "Ýþlem Ýptal"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(142, 6)
        '
        'cmnuProducts_Del
        '
        Me.cmnuProducts_Del.Name = "cmnuProducts_Del"
        Me.cmnuProducts_Del.Size = New System.Drawing.Size(145, 22)
        Me.cmnuProducts_Del.Text = "Ürün Sil"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(142, 6)
        '
        'cmnuProducts_DeleteAll
        '
        Me.cmnuProducts_DeleteAll.Name = "cmnuProducts_DeleteAll"
        Me.cmnuProducts_DeleteAll.Size = New System.Drawing.Size(145, 22)
        Me.cmnuProducts_DeleteAll.Text = "Hepsini Sil"
        '
        'lstProducts
        '
        Me.lstProducts.ContextMenuStrip = Me.cmnuProducts
        Me.lstProducts.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProducts.HorizontalScrollbar = True
        Me.lstProducts.ItemHeight = 17
        Me.lstProducts.Location = New System.Drawing.Point(8, 48)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.ScrollAlwaysVisible = True
        Me.lstProducts.Size = New System.Drawing.Size(264, 276)
        Me.lstProducts.Sorted = True
        Me.lstProducts.TabIndex = 0
        '
        'npCategories
        '
        Me.npCategories.BackColor = System.Drawing.Color.Transparent
        ContainerImage4.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage4.Image = Nothing
        ContainerImage4.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage4.Transparency = 50
        Me.npCategories.ContainerImage = ContainerImage4
        Me.npCategories.ContextMenuButton = False
        Me.npCategories.Controls.Add(Me.cmbCategories)
        HeaderImage5.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage5.Image = Nothing
        Me.npCategories.FooterImage = HeaderImage5
        Me.npCategories.FooterText = ""
        Me.npCategories.ForeColor = System.Drawing.Color.Black
        HeaderImage6.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage6.Image = Nothing
        Me.npCategories.HeaderImage = HeaderImage6
        Me.npCategories.HeaderText = "KATEGORÝLER"
        Me.npCategories.IsExpanded = True
        Me.npCategories.Location = New System.Drawing.Point(8, 56)
        Me.npCategories.Name = "npCategories"
        Me.npCategories.OriginalFooterVisible = True
        Me.npCategories.OriginalHeight = 0
        Me.npCategories.Size = New System.Drawing.Size(280, 96)
        ContainerStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle3.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle3.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle3.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle3.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle3.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle3.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle3.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle3.ForeColor = System.Drawing.Color.Black
        ContainerStyle3.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle3.ContainerStyle = ContainerStyle3
        PanelHeaderStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle5.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle5.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle5.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle5.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle5.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle5.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle5.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle3.FooterStyle = PanelHeaderStyle5
        PanelHeaderStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle6.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle6.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle6.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle6.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle6.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle6.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle6.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelHeaderStyle6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        PanelStyle3.HeaderStyle = PanelHeaderStyle6
        Me.npCategories.Style = PanelStyle3
        Me.npCategories.TabIndex = 0
        '
        'cmbCategories
        '
        Me.cmbCategories.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbCategories.Location = New System.Drawing.Point(8, 48)
        Me.cmbCategories.Name = "cmbCategories"
        Me.cmbCategories.Size = New System.Drawing.Size(264, 25)
        Me.cmbCategories.Sorted = True
        Me.cmbCategories.TabIndex = 2
        Me.cmbCategories.Text = "Seçiniz.."
        '
        'fmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 547)
        Me.Controls.Add(Me.npMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fmProduct"
        Me.Text = "fmProduct"
        Me.npMain.ResumeLayout(False)
        Me.npProductDetails.ResumeLayout(False)
        Me.npProductDetails.PerformLayout()
        Me.npProductList.ResumeLayout(False)
        Me.cmnuProducts.ResumeLayout(False)
        Me.npCategories.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents npMain As PureComponents.NicePanel.NicePanel
    Friend WithEvents npProductDetails As PureComponents.NicePanel.NicePanel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUnitPriceDolar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents npProductList As PureComponents.NicePanel.NicePanel
    Friend WithEvents lstProducts As System.Windows.Forms.ListBox
    Friend WithEvents npCategories As PureComponents.NicePanel.NicePanel
    Friend WithEvents cmbCategories As System.Windows.Forms.ComboBox
    Friend WithEvents cmnuProducts As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuProducts_Add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuProducts_Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuProducts_Cancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuProducts_Del As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuProducts_DeleteAll As System.Windows.Forms.ToolStripMenuItem
End Class
