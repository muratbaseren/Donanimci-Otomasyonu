<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmHakkinda
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
        Dim ContainerImage1 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage()
        Dim HeaderImage1 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim HeaderImage2 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage()
        Dim PanelStyle1 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle()
        Dim ContainerStyle1 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle()
        Dim PanelHeaderStyle1 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Dim PanelHeaderStyle2 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle()
        Me.NicePanel1 = New PureComponents.NicePanel.NicePanel()
        Me.lblSorularBaslik = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NicePanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NicePanel1
        '
        Me.NicePanel1.BackColor = System.Drawing.Color.Transparent
        Me.NicePanel1.CloseButton = True
        ContainerImage1.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage1.Image = Nothing
        ContainerImage1.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage1.Transparency = 50
        Me.NicePanel1.ContainerImage = ContainerImage1
        Me.NicePanel1.ContextMenuButton = False
        Me.NicePanel1.Controls.Add(Me.lblSorularBaslik)
        Me.NicePanel1.Controls.Add(Me.Label1)
        Me.NicePanel1.Controls.Add(Me.Label2)
        Me.NicePanel1.Controls.Add(Me.PictureBox1)
        Me.NicePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        HeaderImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage1.Image = Nothing
        Me.NicePanel1.FooterImage = HeaderImage1
        Me.NicePanel1.FooterText = "CODEMARMARA BY K.MURAT BAÞEREN"
        Me.NicePanel1.ForeColor = System.Drawing.Color.Black
        HeaderImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage2.Image = Nothing
        Me.NicePanel1.HeaderImage = HeaderImage2
        Me.NicePanel1.HeaderText = "HAKKINDA"
        Me.NicePanel1.IsExpanded = True
        Me.NicePanel1.Location = New System.Drawing.Point(0, 0)
        Me.NicePanel1.MouseMoveTarget = PureComponents.NicePanel.MouseMoveTarget.Form
        Me.NicePanel1.Name = "NicePanel1"
        Me.NicePanel1.OriginalFooterVisible = True
        Me.NicePanel1.OriginalHeight = 0
        Me.NicePanel1.Size = New System.Drawing.Size(385, 475)
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
        PanelHeaderStyle1.Font = New System.Drawing.Font("Times New Roman", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        PanelHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        PanelHeaderStyle1.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelHeaderStyle1.TextAlign = System.Drawing.ContentAlignment.BottomRight
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
        PanelStyle1.HeaderStyle = PanelHeaderStyle2
        Me.NicePanel1.Style = PanelStyle1
        Me.NicePanel1.TabIndex = 6
        '
        'lblSorularBaslik
        '
        Me.lblSorularBaslik.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblSorularBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSorularBaslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSorularBaslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSorularBaslik.Location = New System.Drawing.Point(16, 392)
        Me.lblSorularBaslik.Name = "lblSorularBaslik"
        Me.lblSorularBaslik.Size = New System.Drawing.Size(352, 32)
        Me.lblSorularBaslik.TabIndex = 2
        Me.lblSorularBaslik.Text = "...::: CodeMarmara - Donaným Otomasyonu v1.0 :::..."
        Me.lblSorularBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(16, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 56)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "...::: CodeMarmara Copyright :::..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(16, 432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "...::: Tüm haklarý saklýdýr :::..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(16, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'fmHakkinda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 475)
        Me.Controls.Add(Me.NicePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fmHakkinda"
        Me.Text = "fmHakkinda"
        Me.NicePanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NicePanel1 As PureComponents.NicePanel.NicePanel
    Friend WithEvents lblSorularBaslik As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
