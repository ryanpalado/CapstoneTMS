<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTaxi_vb
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTaxi_vb))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.TabTaxiInfo = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.lblTaxiID = New System.Windows.Forms.Label()
        Me.lblTaxiStatus = New System.Windows.Forms.Label()
        Me.lblCodingDay = New System.Windows.Forms.Label()
        Me.lblYearModel = New System.Windows.Forms.Label()
        Me.lblPlateno = New System.Windows.Forms.Label()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.lblChasisNo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdate_fran = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtreg_date = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtexp_fran = New Telerik.WinControls.UI.RadTextBox()
        Me.txtexp_date = New Telerik.WinControls.UI.RadTextBox()
        Me.lblFranDate = New System.Windows.Forms.Label()
        Me.lblRegDate = New System.Windows.Forms.Label()
        Me.btnEditInfo = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.txtPlateNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtChassisNo = New Telerik.WinControls.UI.RadTextBox()
        Me.txtBrandName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtYearModel = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCoding = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTaxiStatus = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.TabTaxiInfo.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.txtdate_fran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtreg_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtexp_fran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtexp_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlateNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChassisNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBrandName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYearModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCoding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxiStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPageView1
        '
        Me.RadPageView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPageView1.Controls.Add(Me.TabTaxiInfo)
        Me.RadPageView1.Location = New System.Drawing.Point(12, 12)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.TabTaxiInfo
        Me.RadPageView1.Size = New System.Drawing.Size(475, 423)
        Me.RadPageView1.TabIndex = 21
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "Office2010Silver"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
        '
        'TabTaxiInfo
        '
        Me.TabTaxiInfo.Controls.Add(Me.btnSave)
        Me.TabTaxiInfo.Controls.Add(Me.btnEditInfo)
        Me.TabTaxiInfo.Controls.Add(Me.RadGroupBox2)
        Me.TabTaxiInfo.Location = New System.Drawing.Point(12, 40)
        Me.TabTaxiInfo.Name = "TabTaxiInfo"
        Me.TabTaxiInfo.Size = New System.Drawing.Size(451, 371)
        Me.TabTaxiInfo.Text = "Edit Details"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.txtTaxiStatus)
        Me.RadGroupBox2.Controls.Add(Me.txtCoding)
        Me.RadGroupBox2.Controls.Add(Me.txtYearModel)
        Me.RadGroupBox2.Controls.Add(Me.txtBrandName)
        Me.RadGroupBox2.Controls.Add(Me.txtChassisNo)
        Me.RadGroupBox2.Controls.Add(Me.txtPlateNo)
        Me.RadGroupBox2.Controls.Add(Me.lblFranDate)
        Me.RadGroupBox2.Controls.Add(Me.lblRegDate)
        Me.RadGroupBox2.Controls.Add(Me.Label2)
        Me.RadGroupBox2.Controls.Add(Me.Label1)
        Me.RadGroupBox2.Controls.Add(Me.txtdate_fran)
        Me.RadGroupBox2.Controls.Add(Me.txtreg_date)
        Me.RadGroupBox2.Controls.Add(Me.lblTaxiID)
        Me.RadGroupBox2.Controls.Add(Me.lblTaxiStatus)
        Me.RadGroupBox2.Controls.Add(Me.lblCodingDay)
        Me.RadGroupBox2.Controls.Add(Me.lblYearModel)
        Me.RadGroupBox2.Controls.Add(Me.lblPlateno)
        Me.RadGroupBox2.Controls.Add(Me.lblBrandName)
        Me.RadGroupBox2.Controls.Add(Me.lblChasisNo)
        Me.RadGroupBox2.Controls.Add(Me.Label12)
        Me.RadGroupBox2.Controls.Add(Me.Label11)
        Me.RadGroupBox2.Controls.Add(Me.Label10)
        Me.RadGroupBox2.Controls.Add(Me.Label9)
        Me.RadGroupBox2.Controls.Add(Me.Label8)
        Me.RadGroupBox2.Controls.Add(Me.Label7)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.RadGroupBox2.HeaderText = "Details"
        Me.RadGroupBox2.Location = New System.Drawing.Point(9, 58)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(439, 282)
        Me.RadGroupBox2.TabIndex = 3
        Me.RadGroupBox2.Text = "Details"
        Me.RadGroupBox2.ThemeName = "Office2010Silver"
        '
        'lblTaxiID
        '
        Me.lblTaxiID.AutoSize = True
        Me.lblTaxiID.BackColor = System.Drawing.Color.Transparent
        Me.lblTaxiID.Location = New System.Drawing.Point(489, 18)
        Me.lblTaxiID.Name = "lblTaxiID"
        Me.lblTaxiID.Size = New System.Drawing.Size(13, 17)
        Me.lblTaxiID.TabIndex = 20
        Me.lblTaxiID.Text = "_"
        Me.lblTaxiID.Visible = False
        '
        'lblTaxiStatus
        '
        Me.lblTaxiStatus.AutoSize = True
        Me.lblTaxiStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblTaxiStatus.Location = New System.Drawing.Point(143, 159)
        Me.lblTaxiStatus.Name = "lblTaxiStatus"
        Me.lblTaxiStatus.Size = New System.Drawing.Size(13, 17)
        Me.lblTaxiStatus.TabIndex = 19
        Me.lblTaxiStatus.Text = "_"
        '
        'lblCodingDay
        '
        Me.lblCodingDay.AutoSize = True
        Me.lblCodingDay.BackColor = System.Drawing.Color.Transparent
        Me.lblCodingDay.Location = New System.Drawing.Point(143, 132)
        Me.lblCodingDay.Name = "lblCodingDay"
        Me.lblCodingDay.Size = New System.Drawing.Size(13, 17)
        Me.lblCodingDay.TabIndex = 18
        Me.lblCodingDay.Text = "_"
        '
        'lblYearModel
        '
        Me.lblYearModel.AutoSize = True
        Me.lblYearModel.BackColor = System.Drawing.Color.Transparent
        Me.lblYearModel.Location = New System.Drawing.Point(143, 105)
        Me.lblYearModel.Name = "lblYearModel"
        Me.lblYearModel.Size = New System.Drawing.Size(13, 17)
        Me.lblYearModel.TabIndex = 17
        Me.lblYearModel.Text = "_"
        '
        'lblPlateno
        '
        Me.lblPlateno.AutoSize = True
        Me.lblPlateno.BackColor = System.Drawing.Color.Transparent
        Me.lblPlateno.Location = New System.Drawing.Point(143, 29)
        Me.lblPlateno.Name = "lblPlateno"
        Me.lblPlateno.Size = New System.Drawing.Size(13, 17)
        Me.lblPlateno.TabIndex = 16
        Me.lblPlateno.Text = "_"
        '
        'lblBrandName
        '
        Me.lblBrandName.AutoSize = True
        Me.lblBrandName.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandName.Location = New System.Drawing.Point(143, 78)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(13, 17)
        Me.lblBrandName.TabIndex = 15
        Me.lblBrandName.Text = "_"
        '
        'lblChasisNo
        '
        Me.lblChasisNo.AutoSize = True
        Me.lblChasisNo.BackColor = System.Drawing.Color.Transparent
        Me.lblChasisNo.Location = New System.Drawing.Point(143, 53)
        Me.lblChasisNo.Name = "lblChasisNo"
        Me.lblChasisNo.Size = New System.Drawing.Size(13, 17)
        Me.lblChasisNo.TabIndex = 14
        Me.lblChasisNo.Text = "_"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Taxi Status               :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Coding Day               :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Year Model               :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Brand Name             :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Chassis No.                :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Plate No.                   :"
        '
        'txtdate_fran
        '
        Me.txtdate_fran.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdate_fran.Location = New System.Drawing.Point(177, 219)
        Me.txtdate_fran.Name = "txtdate_fran"
        Me.txtdate_fran.Size = New System.Drawing.Size(164, 20)
        Me.txtdate_fran.TabIndex = 129
        Me.txtdate_fran.TabStop = False
        Me.txtdate_fran.Text = "1/25/2015"
        Me.txtdate_fran.Value = New Date(2015, 1, 25, 22, 58, 27, 214)
        Me.txtdate_fran.Visible = False
        '
        'txtreg_date
        '
        Me.txtreg_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtreg_date.Location = New System.Drawing.Point(177, 189)
        Me.txtreg_date.Name = "txtreg_date"
        Me.txtreg_date.Size = New System.Drawing.Size(164, 20)
        Me.txtreg_date.TabIndex = 128
        Me.txtreg_date.TabStop = False
        Me.txtreg_date.Text = "1/25/2015"
        Me.txtreg_date.Value = New Date(2015, 1, 25, 22, 57, 6, 598)
        Me.txtreg_date.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Date of Registration :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Date of Franchise :"
        '
        'txtexp_fran
        '
        Me.txtexp_fran.Enabled = False
        Me.txtexp_fran.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexp_fran.Location = New System.Drawing.Point(647, 144)
        Me.txtexp_fran.Name = "txtexp_fran"
        Me.txtexp_fran.Size = New System.Drawing.Size(164, 20)
        Me.txtexp_fran.TabIndex = 135
        Me.txtexp_fran.ThemeName = "Office2010Silver"
        Me.txtexp_fran.Visible = False
        '
        'txtexp_date
        '
        Me.txtexp_date.Enabled = False
        Me.txtexp_date.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexp_date.Location = New System.Drawing.Point(648, 104)
        Me.txtexp_date.Name = "txtexp_date"
        Me.txtexp_date.Size = New System.Drawing.Size(163, 20)
        Me.txtexp_date.TabIndex = 134
        Me.txtexp_date.ThemeName = "Office2010Silver"
        Me.txtexp_date.Visible = False
        '
        'lblFranDate
        '
        Me.lblFranDate.AutoSize = True
        Me.lblFranDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFranDate.Location = New System.Drawing.Point(148, 219)
        Me.lblFranDate.Name = "lblFranDate"
        Me.lblFranDate.Size = New System.Drawing.Size(13, 17)
        Me.lblFranDate.TabIndex = 137
        Me.lblFranDate.Text = "_"
        '
        'lblRegDate
        '
        Me.lblRegDate.AutoSize = True
        Me.lblRegDate.BackColor = System.Drawing.Color.Transparent
        Me.lblRegDate.Location = New System.Drawing.Point(148, 192)
        Me.lblRegDate.Name = "lblRegDate"
        Me.lblRegDate.Size = New System.Drawing.Size(13, 17)
        Me.lblRegDate.TabIndex = 136
        Me.lblRegDate.Text = "_"
        '
        'btnEditInfo
        '
        Me.btnEditInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditInfo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEditInfo.Location = New System.Drawing.Point(222, 13)
        Me.btnEditInfo.Name = "btnEditInfo"
        Me.btnEditInfo.Size = New System.Drawing.Size(110, 29)
        Me.btnEditInfo.TabIndex = 11
        Me.btnEditInfo.Text = "Edit Details"
        Me.btnEditInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditInfo.ThemeName = "Office2010Silver"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Enabled = False
        Me.btnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.Location = New System.Drawing.Point(338, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 29)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.ThemeName = "Office2010Silver"
        '
        'txtPlateNo
        '
        Me.txtPlateNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlateNo.Location = New System.Drawing.Point(143, 31)
        Me.txtPlateNo.Name = "txtPlateNo"
        Me.txtPlateNo.Size = New System.Drawing.Size(163, 20)
        Me.txtPlateNo.TabIndex = 135
        Me.txtPlateNo.ThemeName = "Office2010Silver"
        Me.txtPlateNo.Visible = False
        '
        'txtChassisNo
        '
        Me.txtChassisNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChassisNo.Location = New System.Drawing.Point(142, 55)
        Me.txtChassisNo.Name = "txtChassisNo"
        Me.txtChassisNo.Size = New System.Drawing.Size(163, 20)
        Me.txtChassisNo.TabIndex = 135
        Me.txtChassisNo.ThemeName = "Office2010Silver"
        Me.txtChassisNo.Visible = False
        '
        'txtBrandName
        '
        Me.txtBrandName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrandName.Location = New System.Drawing.Point(142, 82)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(163, 20)
        Me.txtBrandName.TabIndex = 138
        Me.txtBrandName.ThemeName = "Office2010Silver"
        Me.txtBrandName.Visible = False
        '
        'txtYearModel
        '
        Me.txtYearModel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearModel.Location = New System.Drawing.Point(142, 105)
        Me.txtYearModel.Name = "txtYearModel"
        Me.txtYearModel.Size = New System.Drawing.Size(163, 20)
        Me.txtYearModel.TabIndex = 139
        Me.txtYearModel.ThemeName = "Office2010Silver"
        Me.txtYearModel.Visible = False
        '
        'txtCoding
        '
        Me.txtCoding.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoding.Location = New System.Drawing.Point(142, 129)
        Me.txtCoding.Name = "txtCoding"
        Me.txtCoding.Size = New System.Drawing.Size(163, 20)
        Me.txtCoding.TabIndex = 140
        Me.txtCoding.ThemeName = "Office2010Silver"
        Me.txtCoding.Visible = False
        '
        'txtTaxiStatus
        '
        Me.txtTaxiStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxiStatus.Location = New System.Drawing.Point(142, 159)
        Me.txtTaxiStatus.Name = "txtTaxiStatus"
        Me.txtTaxiStatus.Size = New System.Drawing.Size(163, 20)
        Me.txtTaxiStatus.TabIndex = 141
        Me.txtTaxiStatus.ThemeName = "Office2010Silver"
        Me.txtTaxiStatus.Visible = False
        '
        'ViewTaxi_vb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 439)
        Me.Controls.Add(Me.RadPageView1)
        Me.Controls.Add(Me.txtexp_date)
        Me.Controls.Add(Me.txtexp_fran)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewTaxi_vb"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taxi Information"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.TabTaxiInfo.ResumeLayout(False)
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.txtdate_fran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtreg_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtexp_fran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtexp_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlateNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChassisNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBrandName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYearModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCoding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxiStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents TabTaxiInfo As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lblTaxiStatus As System.Windows.Forms.Label
    Friend WithEvents lblCodingDay As System.Windows.Forms.Label
    Friend WithEvents lblYearModel As System.Windows.Forms.Label
    Friend WithEvents lblPlateno As System.Windows.Forms.Label
    Friend WithEvents lblBrandName As System.Windows.Forms.Label
    Friend WithEvents lblChasisNo As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTaxiID As System.Windows.Forms.Label
    Friend WithEvents txtdate_fran As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txtreg_date As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFranDate As System.Windows.Forms.Label
    Friend WithEvents lblRegDate As System.Windows.Forms.Label
    Friend WithEvents txtexp_fran As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtexp_date As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEditInfo As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtTaxiStatus As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCoding As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtYearModel As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtBrandName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtChassisNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtPlateNo As Telerik.WinControls.UI.RadTextBox
End Class

