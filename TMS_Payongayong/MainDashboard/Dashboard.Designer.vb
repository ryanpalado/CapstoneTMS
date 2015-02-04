<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Date")
        Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Details")
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn3 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn4 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn5 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewCommandColumn6 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.CommandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.RadMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.DriverInfoRprt1 = New TMS_Payongayong.DriverInfoRprt()
        Me.RadGridView1 = New Telerik.WinControls.UI.MasterGridViewTemplate()
        Me.driverInfoRprt2 = New TMS_Payongayong.DriverInfoRprt()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.TabDashboard = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView2 = New Telerik.WinControls.UI.RadPageView()
        Me.TabProfile = New Telerik.WinControls.UI.RadPageViewPage()
        Me.lblDate = New Telerik.WinControls.UI.RadLabel()
        Me.lblYear = New Telerik.WinControls.UI.RadLabel()
        Me.lblMonth = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.userName = New Telerik.WinControls.UI.RadLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabNotif = New Telerik.WinControls.UI.RadPageViewPage()
        Me.listNotif = New Telerik.WinControls.UI.RadListView()
        Me.TabDispatch = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadListView1 = New Telerik.WinControls.UI.RadListView()
        Me.TabPayins = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TabDriversMod = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView3 = New Telerik.WinControls.UI.RadPageView()
        Me.tabDriversList = New Telerik.WinControls.UI.RadPageViewPage()
        Me.gridDriver = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtSearchDriver = New Telerik.WinControls.UI.RadTextBox()
        Me.btnNewDriver = New Telerik.WinControls.UI.RadButton()
        Me.tabRemovedDrivers = New Telerik.WinControls.UI.RadPageViewPage()
        Me.gridDriverRemoved = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtSearchDriverRemoved = New Telerik.WinControls.UI.RadTextBox()
        Me.TabTaxisMod = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView4 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.gridTaxi = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txtSearchTaxi = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        Me.RadPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGridView3 = New Telerik.WinControls.UI.RadGridView()
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.TabSchedule = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TabReports = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView5 = New Telerik.WinControls.UI.RadPageView()
        Me.TabDriverInfo = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton7 = New Telerik.WinControls.UI.RadButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RadPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton8 = New Telerik.WinControls.UI.RadButton()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RadPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadPageView6 = New Telerik.WinControls.UI.RadPageView()
        Me.TabDriverFunds = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton9 = New Telerik.WinControls.UI.RadButton()
        Me.CrystalReportViewer3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RadPageViewPage9 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton10 = New Telerik.WinControls.UI.RadButton()
        Me.CrystalReportViewer4 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabTa = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton11 = New Telerik.WinControls.UI.RadButton()
        Me.CrystalReportViewer5 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TabShortBoundary = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton12 = New Telerik.WinControls.UI.RadButton()
        Me.CrystalReportViewer6 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RadPageViewPage12 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.tabSSSPayment = New Telerik.WinControls.UI.RadPageViewPage()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDashboard.SuspendLayout()
        CType(Me.RadPageView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView2.SuspendLayout()
        Me.TabProfile.SuspendLayout()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNotif.SuspendLayout()
        CType(Me.listNotif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDispatch.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDriversMod.SuspendLayout()
        CType(Me.RadPageView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView3.SuspendLayout()
        Me.tabDriversList.SuspendLayout()
        CType(Me.gridDriver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDriver.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.txtSearchDriver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewDriver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRemovedDrivers.SuspendLayout()
        CType(Me.gridDriverRemoved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDriverRemoved.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.txtSearchDriverRemoved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTaxisMod.SuspendLayout()
        CType(Me.RadPageView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView4.SuspendLayout()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.gridTaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTaxi.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.txtSearchTaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage2.SuspendLayout()
        CType(Me.RadGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView3.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReports.SuspendLayout()
        CType(Me.RadPageView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView5.SuspendLayout()
        Me.TabDriverInfo.SuspendLayout()
        CType(Me.RadButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage4.SuspendLayout()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage3.SuspendLayout()
        CType(Me.RadPageView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView6.SuspendLayout()
        Me.TabDriverFunds.SuspendLayout()
        CType(Me.RadButton9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage9.SuspendLayout()
        CType(Me.RadButton10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTa.SuspendLayout()
        CType(Me.RadButton11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabShortBoundary.SuspendLayout()
        CType(Me.RadButton12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommandBarRowElement2
        '
        Me.CommandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
        '
        'RadMenuItem2
        '
        Me.RadMenuItem2.AccessibleDescription = "About"
        Me.RadMenuItem2.AccessibleName = "About"
        Me.RadMenuItem2.Name = "RadMenuItem2"
        Me.RadMenuItem2.Text = "About"
        Me.RadMenuItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMenu1
        '
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItem2, Me.RadMenuItem1})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.Size = New System.Drawing.Size(1067, 23)
        Me.RadMenu1.TabIndex = 2
        Me.RadMenu1.Text = "RadMenu1"
        Me.RadMenu1.ThemeName = "Office2010Silver"
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.TabDashboard)
        Me.RadPageView1.Controls.Add(Me.TabDispatch)
        Me.RadPageView1.Controls.Add(Me.TabPayins)
        Me.RadPageView1.Controls.Add(Me.TabDriversMod)
        Me.RadPageView1.Controls.Add(Me.TabTaxisMod)
        Me.RadPageView1.Controls.Add(Me.TabSchedule)
        Me.RadPageView1.Controls.Add(Me.TabReports)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadPageView1.Location = New System.Drawing.Point(0, 23)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.TabDashboard
        Me.RadPageView1.Size = New System.Drawing.Size(1067, 671)
        Me.RadPageView1.TabIndex = 3
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "Office2010Silver"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.None
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.AccessibleDescription = "Update Status Secretary"
        Me.RadMenuItem1.AccessibleName = "Update Status Secretary"
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "Update Status Secretary"
        Me.RadMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'TabDashboard
        '
        Me.TabDashboard.Controls.Add(Me.RadPageView2)
        Me.TabDashboard.Image = Global.TMS_Payongayong.My.Resources.Resources.computer
        Me.TabDashboard.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabDashboard.Location = New System.Drawing.Point(12, 105)
        Me.TabDashboard.Name = "TabDashboard"
        Me.TabDashboard.Size = New System.Drawing.Size(1043, 554)
        Me.TabDashboard.Text = "Dashboard"
        Me.TabDashboard.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadPageView2
        '
        Me.RadPageView2.Controls.Add(Me.TabProfile)
        Me.RadPageView2.Controls.Add(Me.TabNotif)
        Me.RadPageView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView2.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView2.Name = "RadPageView2"
        Me.RadPageView2.SelectedPage = Me.TabProfile
        Me.RadPageView2.Size = New System.Drawing.Size(1043, 554)
        Me.RadPageView2.TabIndex = 0
        Me.RadPageView2.Text = "RadPageView2"
        Me.RadPageView2.ThemeName = "Office2010Silver"
        CType(Me.RadPageView2.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.RadPageView2.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
        '
        'TabProfile
        '
        Me.TabProfile.Controls.Add(Me.lblDate)
        Me.TabProfile.Controls.Add(Me.lblYear)
        Me.TabProfile.Controls.Add(Me.lblMonth)
        Me.TabProfile.Controls.Add(Me.RadButton2)
        Me.TabProfile.Controls.Add(Me.LinkLabel1)
        Me.TabProfile.Controls.Add(Me.RadButton1)
        Me.TabProfile.Controls.Add(Me.RadLabel2)
        Me.TabProfile.Controls.Add(Me.userName)
        Me.TabProfile.Controls.Add(Me.PictureBox1)
        Me.TabProfile.Location = New System.Drawing.Point(12, 40)
        Me.TabProfile.Name = "TabProfile"
        Me.TabProfile.Size = New System.Drawing.Size(1019, 502)
        Me.TabProfile.Text = "Profile"
        Me.TabProfile.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(1005, 60)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(11, 18)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "-"
        Me.lblDate.Visible = False
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(1008, 36)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(11, 18)
        Me.lblYear.TabIndex = 8
        Me.lblYear.Text = "-"
        Me.lblYear.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.Location = New System.Drawing.Point(1005, 12)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(11, 18)
        Me.lblMonth.TabIndex = 7
        Me.lblMonth.Text = "-"
        Me.lblMonth.Visible = False
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(324, 187)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(79, 24)
        Me.RadButton2.TabIndex = 4
        Me.RadButton2.Text = "Logout"
        Me.RadButton2.ThemeName = "Office2010Silver"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(236, 157)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(164, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "You have 10 new notifications."
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(239, 187)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(79, 24)
        Me.RadButton1.TabIndex = 3
        Me.RadButton1.Text = "Edit Profile"
        Me.RadButton1.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(239, 125)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(79, 17)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "Administrator"
        '
        'userName
        '
        Me.userName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.Location = New System.Drawing.Point(239, 95)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(134, 24)
        Me.userName.TabIndex = 1
        Me.userName.Text = "Celyne Martizano"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.TMS_Payongayong.My.Resources.Resources.profle
        Me.PictureBox1.Location = New System.Drawing.Point(24, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabNotif
        '
        Me.TabNotif.Controls.Add(Me.listNotif)
        Me.TabNotif.Location = New System.Drawing.Point(12, 40)
        Me.TabNotif.Name = "TabNotif"
        Me.TabNotif.Size = New System.Drawing.Size(1011, 514)
        Me.TabNotif.Text = "Notifications"
        Me.TabNotif.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listNotif
        '
        ListViewDetailColumn1.HeaderText = "Date"
        ListViewDetailColumn2.HeaderText = "Details"
        ListViewDetailColumn2.Width = 800.0!
        Me.listNotif.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1, ListViewDetailColumn2})
        Me.listNotif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listNotif.ItemSpacing = -1
        Me.listNotif.Location = New System.Drawing.Point(0, 0)
        Me.listNotif.Name = "listNotif"
        Me.listNotif.Size = New System.Drawing.Size(1011, 514)
        Me.listNotif.TabIndex = 0
        Me.listNotif.Text = "RadListView1"
        Me.listNotif.ThemeName = "Office2010Silver"
        Me.listNotif.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'TabDispatch
        '
        Me.TabDispatch.Controls.Add(Me.RadGroupBox2)
        Me.TabDispatch.Controls.Add(Me.RadButton3)
        Me.TabDispatch.Controls.Add(Me.RadListView1)
        Me.TabDispatch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabDispatch.Image = Global.TMS_Payongayong.My.Resources.Resources.arrow_up
        Me.TabDispatch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabDispatch.Location = New System.Drawing.Point(12, 105)
        Me.TabDispatch.Name = "TabDispatch"
        Me.TabDispatch.Size = New System.Drawing.Size(1043, 554)
        Me.TabDispatch.Text = "Dispatch"
        Me.TabDispatch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabDispatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.RadButton4)
        Me.RadGroupBox2.Controls.Add(Me.RadDateTimePicker1)
        Me.RadGroupBox2.Controls.Add(Me.RadButton5)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.HeaderText = "Date"
        Me.RadGroupBox2.Location = New System.Drawing.Point(810, 11)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(217, 63)
        Me.RadGroupBox2.TabIndex = 6
        Me.RadGroupBox2.Text = "Date"
        Me.RadGroupBox2.ThemeName = "Office2010Silver"
        '
        'RadButton4
        '
        Me.RadButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton4.Image = Global.TMS_Payongayong.My.Resources.Resources.previous
        Me.RadButton4.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton4.Location = New System.Drawing.Point(15, 27)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(38, 22)
        Me.RadButton4.TabIndex = 3
        Me.RadButton4.ThemeName = "Office2010Silver"
        '
        'RadDateTimePicker1
        '
        Me.RadDateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RadDateTimePicker1.Location = New System.Drawing.Point(59, 28)
        Me.RadDateTimePicker1.Name = "RadDateTimePicker1"
        Me.RadDateTimePicker1.Size = New System.Drawing.Size(97, 21)
        Me.RadDateTimePicker1.TabIndex = 5
        Me.RadDateTimePicker1.TabStop = False
        Me.RadDateTimePicker1.Text = "12/24/2014"
        Me.RadDateTimePicker1.ThemeName = "Office2010Silver"
        Me.RadDateTimePicker1.Value = New Date(2014, 12, 24, 16, 40, 52, 988)
        '
        'RadButton5
        '
        Me.RadButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RadButton5.Image = Global.TMS_Payongayong.My.Resources.Resources._next
        Me.RadButton5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton5.Location = New System.Drawing.Point(162, 27)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(38, 22)
        Me.RadButton5.TabIndex = 4
        Me.RadButton5.ThemeName = "Office2010Silver"
        '
        'RadButton3
        '
        Me.RadButton3.Image = Global.TMS_Payongayong.My.Resources.Resources.add
        Me.RadButton3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton3.Location = New System.Drawing.Point(15, 11)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(138, 63)
        Me.RadButton3.TabIndex = 2
        Me.RadButton3.Text = "New Dispatch"
        Me.RadButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadButton3.ThemeName = "Office2010Silver"
        '
        'RadListView1
        '
        Me.RadListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadListView1.Location = New System.Drawing.Point(15, 82)
        Me.RadListView1.Name = "RadListView1"
        Me.RadListView1.Size = New System.Drawing.Size(1012, 464)
        Me.RadListView1.TabIndex = 0
        Me.RadListView1.Text = "RadListView1"
        Me.RadListView1.ThemeName = "Office2010Silver"
        '
        'TabPayins
        '
        Me.TabPayins.Image = Global.TMS_Payongayong.My.Resources.Resources.arrow_down
        Me.TabPayins.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabPayins.Location = New System.Drawing.Point(12, 105)
        Me.TabPayins.Name = "TabPayins"
        Me.TabPayins.Size = New System.Drawing.Size(1043, 554)
        Me.TabPayins.Text = "Pay-ins"
        Me.TabPayins.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabPayins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabDriversMod
        '
        Me.TabDriversMod.Controls.Add(Me.RadPageView3)
        Me.TabDriversMod.Image = Global.TMS_Payongayong.My.Resources.Resources.profle
        Me.TabDriversMod.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabDriversMod.Location = New System.Drawing.Point(12, 105)
        Me.TabDriversMod.Name = "TabDriversMod"
        Me.TabDriversMod.Size = New System.Drawing.Size(1043, 554)
        Me.TabDriversMod.Text = "Driver's Module"
        Me.TabDriversMod.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabDriversMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadPageView3
        '
        Me.RadPageView3.Controls.Add(Me.tabDriversList)
        Me.RadPageView3.Controls.Add(Me.tabRemovedDrivers)
        Me.RadPageView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView3.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView3.Name = "RadPageView3"
        Me.RadPageView3.SelectedPage = Me.tabDriversList
        Me.RadPageView3.Size = New System.Drawing.Size(1043, 554)
        Me.RadPageView3.TabIndex = 0
        Me.RadPageView3.Text = "RadPageView3"
        Me.RadPageView3.ThemeName = "Office2010Silver"
        CType(Me.RadPageView3.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.RadPageView3.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
        '
        'tabDriversList
        '
        Me.tabDriversList.Controls.Add(Me.gridDriver)
        Me.tabDriversList.Controls.Add(Me.RadGroupBox1)
        Me.tabDriversList.Controls.Add(Me.btnNewDriver)
        Me.tabDriversList.Location = New System.Drawing.Point(12, 40)
        Me.tabDriversList.Name = "tabDriversList"
        Me.tabDriversList.Size = New System.Drawing.Size(1019, 502)
        Me.tabDriversList.Text = "List of Drivers"
        Me.tabDriversList.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridDriver
        '
        Me.gridDriver.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDriver.Location = New System.Drawing.Point(14, 95)
        '
        'gridDriver
        '
        Me.gridDriver.MasterTemplate.AllowAddNewRow = False
        Me.gridDriver.MasterTemplate.AllowColumnReorder = False
        GridViewCommandColumn1.AllowHide = False
        GridViewCommandColumn1.AllowReorder = False
        GridViewCommandColumn1.DefaultText = "View Information"
        GridViewCommandColumn1.HeaderText = ""
        GridViewCommandColumn1.Name = "columnView"
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.UseDefaultText = True
        GridViewCommandColumn1.Width = 100
        GridViewCommandColumn2.AllowHide = False
        GridViewCommandColumn2.AllowReorder = False
        GridViewCommandColumn2.AllowResize = False
        GridViewCommandColumn2.DefaultText = "Delete"
        GridViewCommandColumn2.HeaderText = ""
        GridViewCommandColumn2.Name = "columnDelete"
        GridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn2.UseDefaultText = True
        GridViewCommandColumn2.Width = 100
        Me.gridDriver.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn1, GridViewCommandColumn2})
        Me.gridDriver.Name = "gridDriver"
        Me.gridDriver.ReadOnly = True
        Me.gridDriver.Size = New System.Drawing.Size(989, 391)
        Me.gridDriver.TabIndex = 7
        Me.gridDriver.Text = "RadGridView2"
        Me.gridDriver.ThemeName = "Office2010Silver"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.txtSearchDriver)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox1.HeaderText = "Search"
        Me.RadGroupBox1.Location = New System.Drawing.Point(721, 15)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(282, 63)
        Me.RadGroupBox1.TabIndex = 6
        Me.RadGroupBox1.Text = "Search"
        Me.RadGroupBox1.ThemeName = "Office2010Silver"
        '
        'txtSearchDriver
        '
        Me.txtSearchDriver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchDriver.Location = New System.Drawing.Point(10, 26)
        Me.txtSearchDriver.Name = "txtSearchDriver"
        Me.txtSearchDriver.NullText = "Enter Driver's Name"
        Me.txtSearchDriver.Size = New System.Drawing.Size(263, 21)
        Me.txtSearchDriver.TabIndex = 5
        Me.txtSearchDriver.ThemeName = "Office2010Silver"
        '
        'btnNewDriver
        '
        Me.btnNewDriver.Image = Global.TMS_Payongayong.My.Resources.Resources.add
        Me.btnNewDriver.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNewDriver.Location = New System.Drawing.Point(14, 15)
        Me.btnNewDriver.Name = "btnNewDriver"
        Me.btnNewDriver.Size = New System.Drawing.Size(153, 63)
        Me.btnNewDriver.TabIndex = 4
        Me.btnNewDriver.Text = "Add New Driver"
        Me.btnNewDriver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewDriver.ThemeName = "Office2010Silver"
        '
        'tabRemovedDrivers
        '
        Me.tabRemovedDrivers.Controls.Add(Me.gridDriverRemoved)
        Me.tabRemovedDrivers.Controls.Add(Me.RadGroupBox3)
        Me.tabRemovedDrivers.Location = New System.Drawing.Point(12, 40)
        Me.tabRemovedDrivers.Name = "tabRemovedDrivers"
        Me.tabRemovedDrivers.Size = New System.Drawing.Size(1019, 502)
        Me.tabRemovedDrivers.Text = "Removed Driver's"
        Me.tabRemovedDrivers.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridDriverRemoved
        '
        Me.gridDriverRemoved.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDriverRemoved.Location = New System.Drawing.Point(15, 95)
        '
        '
        '
        Me.gridDriverRemoved.MasterTemplate.AllowAddNewRow = False
        Me.gridDriverRemoved.MasterTemplate.AllowColumnReorder = False
        GridViewCommandColumn3.AllowHide = False
        GridViewCommandColumn3.AllowReorder = False
        GridViewCommandColumn3.AllowResize = False
        GridViewCommandColumn3.DefaultText = "Restore"
        GridViewCommandColumn3.HeaderText = ""
        GridViewCommandColumn3.Name = "columnRestore"
        GridViewCommandColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn3.UseDefaultText = True
        GridViewCommandColumn3.Width = 100
        Me.gridDriverRemoved.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn3})
        Me.gridDriverRemoved.Name = "gridDriverRemoved"
        Me.gridDriverRemoved.ReadOnly = True
        Me.gridDriverRemoved.Size = New System.Drawing.Size(989, 391)
        Me.gridDriverRemoved.TabIndex = 9
        Me.gridDriverRemoved.Text = "RadGridView2"
        Me.gridDriverRemoved.ThemeName = "Office2010Silver"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.txtSearchDriverRemoved)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox3.HeaderText = "Search"
        Me.RadGroupBox3.Location = New System.Drawing.Point(15, 14)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(282, 63)
        Me.RadGroupBox3.TabIndex = 8
        Me.RadGroupBox3.Text = "Search"
        Me.RadGroupBox3.ThemeName = "Office2010Silver"
        '
        'txtSearchDriverRemoved
        '
        Me.txtSearchDriverRemoved.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchDriverRemoved.Location = New System.Drawing.Point(10, 26)
        Me.txtSearchDriverRemoved.Name = "txtSearchDriverRemoved"
        Me.txtSearchDriverRemoved.NullText = "Enter Driver's Name"
        Me.txtSearchDriverRemoved.Size = New System.Drawing.Size(263, 21)
        Me.txtSearchDriverRemoved.TabIndex = 5
        Me.txtSearchDriverRemoved.ThemeName = "Office2010Silver"
        '
        'TabTaxisMod
        '
        Me.TabTaxisMod.Controls.Add(Me.RadPageView4)
        Me.TabTaxisMod.Image = Global.TMS_Payongayong.My.Resources.Resources.taxi1
        Me.TabTaxisMod.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabTaxisMod.Location = New System.Drawing.Point(12, 105)
        Me.TabTaxisMod.Name = "TabTaxisMod"
        Me.TabTaxisMod.Size = New System.Drawing.Size(1043, 554)
        Me.TabTaxisMod.Text = "Taxis Module"
        Me.TabTaxisMod.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabTaxisMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadPageView4
        '
        Me.RadPageView4.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView4.Controls.Add(Me.RadPageViewPage2)
        Me.RadPageView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView4.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView4.Name = "RadPageView4"
        Me.RadPageView4.SelectedPage = Me.RadPageViewPage1
        Me.RadPageView4.Size = New System.Drawing.Size(1043, 554)
        Me.RadPageView4.TabIndex = 1
        Me.RadPageView4.Text = "RadPageView4"
        Me.RadPageView4.ThemeName = "Office2010Silver"
        CType(Me.RadPageView4.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.RadPageView4.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.Controls.Add(Me.gridTaxi)
        Me.RadPageViewPage1.Controls.Add(Me.RadGroupBox4)
        Me.RadPageViewPage1.Controls.Add(Me.RadButton6)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(1019, 502)
        Me.RadPageViewPage1.Text = "List of Taxi"
        Me.RadPageViewPage1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridTaxi
        '
        Me.gridTaxi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridTaxi.Location = New System.Drawing.Point(14, 95)
        '
        'gridTaxi
        '
        Me.gridTaxi.MasterTemplate.AllowAddNewRow = False
        Me.gridTaxi.MasterTemplate.AllowColumnReorder = False
        GridViewCommandColumn4.AllowHide = False
        GridViewCommandColumn4.AllowReorder = False
        GridViewCommandColumn4.DefaultText = "View Information"
        GridViewCommandColumn4.HeaderText = ""
        GridViewCommandColumn4.Name = "columnView"
        GridViewCommandColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn4.UseDefaultText = True
        GridViewCommandColumn4.Width = 100
        GridViewCommandColumn5.AllowHide = False
        GridViewCommandColumn5.AllowReorder = False
        GridViewCommandColumn5.AllowResize = False
        GridViewCommandColumn5.DefaultText = "Delete"
        GridViewCommandColumn5.HeaderText = ""
        GridViewCommandColumn5.Name = "columnDelete"
        GridViewCommandColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn5.UseDefaultText = True
        GridViewCommandColumn5.Width = 100
        Me.gridTaxi.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn4, GridViewCommandColumn5})
        Me.gridTaxi.Name = "gridTaxi"
        Me.gridTaxi.ReadOnly = True
        Me.gridTaxi.Size = New System.Drawing.Size(989, 391)
        Me.gridTaxi.TabIndex = 7
        Me.gridTaxi.Text = "RadGridView2"
        Me.gridTaxi.ThemeName = "Office2010Silver"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox4.Controls.Add(Me.txtSearchTaxi)
        Me.RadGroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox4.HeaderText = "Search"
        Me.RadGroupBox4.Location = New System.Drawing.Point(721, 15)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(282, 63)
        Me.RadGroupBox4.TabIndex = 6
        Me.RadGroupBox4.Text = "Search"
        Me.RadGroupBox4.ThemeName = "Office2010Silver"
        '
        'txtSearchTaxi
        '
        Me.txtSearchTaxi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchTaxi.Location = New System.Drawing.Point(10, 26)
        Me.txtSearchTaxi.Name = "txtSearchTaxi"
        Me.txtSearchTaxi.NullText = "Enter Taxi Plate No."
        Me.txtSearchTaxi.Size = New System.Drawing.Size(263, 21)
        Me.txtSearchTaxi.TabIndex = 5
        Me.txtSearchTaxi.ThemeName = "Office2010Silver"
        '
        'RadButton6
        '
        Me.RadButton6.Image = Global.TMS_Payongayong.My.Resources.Resources.add
        Me.RadButton6.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton6.Location = New System.Drawing.Point(14, 15)
        Me.RadButton6.Name = "RadButton6"
        Me.RadButton6.Size = New System.Drawing.Size(153, 63)
        Me.RadButton6.TabIndex = 4
        Me.RadButton6.Text = "Add New Taxi"
        Me.RadButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadButton6.ThemeName = "Office2010Silver"
        '
        'RadPageViewPage2
        '
        Me.RadPageViewPage2.Controls.Add(Me.RadGridView3)
        Me.RadPageViewPage2.Controls.Add(Me.RadGroupBox5)
        Me.RadPageViewPage2.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage2.Name = "RadPageViewPage2"
        Me.RadPageViewPage2.Size = New System.Drawing.Size(1019, 502)
        Me.RadPageViewPage2.Text = "Removed Taxi"
        Me.RadPageViewPage2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadGridView3
        '
        Me.RadGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGridView3.Location = New System.Drawing.Point(15, 95)
        '
        '
        '
        Me.RadGridView3.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView3.MasterTemplate.AllowColumnReorder = False
        GridViewCommandColumn6.AllowHide = False
        GridViewCommandColumn6.AllowReorder = False
        GridViewCommandColumn6.AllowResize = False
        GridViewCommandColumn6.DefaultText = "Restore"
        GridViewCommandColumn6.HeaderText = ""
        GridViewCommandColumn6.Name = "columnRestore"
        GridViewCommandColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn6.UseDefaultText = True
        GridViewCommandColumn6.Width = 100
        Me.RadGridView3.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCommandColumn6})
        Me.RadGridView3.Name = "RadGridView3"
        Me.RadGridView3.ReadOnly = True
        Me.RadGridView3.Size = New System.Drawing.Size(989, 391)
        Me.RadGridView3.TabIndex = 9
        Me.RadGridView3.Text = "RadGridView2"
        Me.RadGridView3.ThemeName = "Office2010Silver"
        '
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Controls.Add(Me.RadTextBox2)
        Me.RadGroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox5.HeaderText = "Search"
        Me.RadGroupBox5.Location = New System.Drawing.Point(15, 14)
        Me.RadGroupBox5.Name = "RadGroupBox5"
        Me.RadGroupBox5.Size = New System.Drawing.Size(282, 63)
        Me.RadGroupBox5.TabIndex = 8
        Me.RadGroupBox5.Text = "Search"
        Me.RadGroupBox5.ThemeName = "Office2010Silver"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox2.Location = New System.Drawing.Point(10, 26)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.NullText = "Enter Taxi Plate No."
        Me.RadTextBox2.Size = New System.Drawing.Size(263, 21)
        Me.RadTextBox2.TabIndex = 5
        Me.RadTextBox2.ThemeName = "Office2010Silver"
        '
        'TabSchedule
        '
        Me.TabSchedule.Image = Global.TMS_Payongayong.My.Resources.Resources.calendar
        Me.TabSchedule.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabSchedule.Location = New System.Drawing.Point(12, 105)
        Me.TabSchedule.Name = "TabSchedule"
        Me.TabSchedule.Size = New System.Drawing.Size(1043, 554)
        Me.TabSchedule.Text = "Scheduling"
        Me.TabSchedule.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabReports
        '
        Me.TabReports.Controls.Add(Me.RadPageView5)
        Me.TabReports.Image = Global.TMS_Payongayong.My.Resources.Resources.document
        Me.TabReports.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabReports.Location = New System.Drawing.Point(12, 105)
        Me.TabReports.Name = "TabReports"
        Me.TabReports.Size = New System.Drawing.Size(1043, 554)
        Me.TabReports.Text = "Reports"
        Me.TabReports.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.TabReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadPageView5
        '
        Me.RadPageView5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPageView5.Controls.Add(Me.TabDriverInfo)
        Me.RadPageView5.Controls.Add(Me.RadPageViewPage4)
        Me.RadPageView5.Controls.Add(Me.RadPageViewPage3)
        Me.RadPageView5.Location = New System.Drawing.Point(3, 3)
        Me.RadPageView5.Name = "RadPageView5"
        Me.RadPageView5.SelectedPage = Me.TabDriverInfo
        Me.RadPageView5.Size = New System.Drawing.Size(1037, 567)
        Me.RadPageView5.TabIndex = 21
        Me.RadPageView5.Text = "RadPageView5"
        Me.RadPageView5.ThemeName = "Office2010Silver"
        CType(Me.RadPageView5.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.RadPageView5.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
        '
        'TabDriverInfo
        '
        Me.TabDriverInfo.Controls.Add(Me.RadButton7)
        Me.TabDriverInfo.Controls.Add(Me.CrystalReportViewer1)
        Me.TabDriverInfo.Location = New System.Drawing.Point(12, 40)
        Me.TabDriverInfo.Name = "TabDriverInfo"
        Me.TabDriverInfo.Size = New System.Drawing.Size(1013, 515)
        Me.TabDriverInfo.Text = "Driver"
        '
        'RadButton7
        '
        Me.RadButton7.Location = New System.Drawing.Point(8, 13)
        Me.RadButton7.Name = "RadButton7"
        Me.RadButton7.Size = New System.Drawing.Size(110, 24)
        Me.RadButton7.TabIndex = 1
        Me.RadButton7.Text = "Show Reports"
        Me.RadButton7.ThemeName = "Office2010Silver"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 51)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1010, 457)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'RadPageViewPage4
        '
        Me.RadPageViewPage4.Controls.Add(Me.RadButton8)
        Me.RadPageViewPage4.Controls.Add(Me.CrystalReportViewer2)
        Me.RadPageViewPage4.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage4.Name = "RadPageViewPage4"
        Me.RadPageViewPage4.Size = New System.Drawing.Size(1013, 515)
        Me.RadPageViewPage4.Text = "Taxi"
        '
        'RadButton8
        '
        Me.RadButton8.Location = New System.Drawing.Point(3, 10)
        Me.RadButton8.Name = "RadButton8"
        Me.RadButton8.Size = New System.Drawing.Size(110, 24)
        Me.RadButton8.TabIndex = 2
        Me.RadButton8.Text = "Show Reports"
        Me.RadButton8.ThemeName = "Office2010Silver"
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(3, 46)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1007, 462)
        Me.CrystalReportViewer2.TabIndex = 0
        '
        'RadPageViewPage3
        '
        Me.RadPageViewPage3.Controls.Add(Me.RadPageView6)
        Me.RadPageViewPage3.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage3.Name = "RadPageViewPage3"
        Me.RadPageViewPage3.Size = New System.Drawing.Size(1013, 515)
        Me.RadPageViewPage3.Text = "Accounts"
        Me.RadPageViewPage3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPageView6
        '
        Me.RadPageView6.Controls.Add(Me.TabDriverFunds)
        Me.RadPageView6.Controls.Add(Me.RadPageViewPage9)
        Me.RadPageView6.Controls.Add(Me.TabTa)
        Me.RadPageView6.Controls.Add(Me.TabShortBoundary)
        Me.RadPageView6.Controls.Add(Me.RadPageViewPage12)
        Me.RadPageView6.Controls.Add(Me.tabSSSPayment)
        Me.RadPageView6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView6.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView6.Name = "RadPageView6"
        Me.RadPageView6.SelectedPage = Me.RadPageViewPage9
        Me.RadPageView6.Size = New System.Drawing.Size(1013, 515)
        Me.RadPageView6.TabIndex = 0
        Me.RadPageView6.ThemeName = "Office2010Silver"
        CType(Me.RadPageView6.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.RadPageView6.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
        '
        'TabDriverFunds
        '
        Me.TabDriverFunds.Controls.Add(Me.RadButton9)
        Me.TabDriverFunds.Controls.Add(Me.CrystalReportViewer3)
        Me.TabDriverFunds.Location = New System.Drawing.Point(12, 40)
        Me.TabDriverFunds.Name = "TabDriverFunds"
        Me.TabDriverFunds.Size = New System.Drawing.Size(989, 463)
        Me.TabDriverFunds.Text = "Driver Funds"
        Me.TabDriverFunds.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadButton9
        '
        Me.RadButton9.Location = New System.Drawing.Point(3, 8)
        Me.RadButton9.Name = "RadButton9"
        Me.RadButton9.Size = New System.Drawing.Size(110, 24)
        Me.RadButton9.TabIndex = 2
        Me.RadButton9.Text = "Show Reports"
        Me.RadButton9.ThemeName = "Office2010Silver"
        '
        'CrystalReportViewer3
        '
        Me.CrystalReportViewer3.ActiveViewIndex = -1
        Me.CrystalReportViewer3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer3.Location = New System.Drawing.Point(3, 43)
        Me.CrystalReportViewer3.Name = "CrystalReportViewer3"
        Me.CrystalReportViewer3.Size = New System.Drawing.Size(983, 420)
        Me.CrystalReportViewer3.TabIndex = 0
        '
        'RadPageViewPage9
        '
        Me.RadPageViewPage9.Controls.Add(Me.RadButton10)
        Me.RadPageViewPage9.Controls.Add(Me.CrystalReportViewer4)
        Me.RadPageViewPage9.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage9.Name = "RadPageViewPage9"
        Me.RadPageViewPage9.Size = New System.Drawing.Size(989, 463)
        Me.RadPageViewPage9.Text = "Cash Advance"
        Me.RadPageViewPage9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadButton10
        '
        Me.RadButton10.Location = New System.Drawing.Point(3, 7)
        Me.RadButton10.Name = "RadButton10"
        Me.RadButton10.Size = New System.Drawing.Size(110, 24)
        Me.RadButton10.TabIndex = 3
        Me.RadButton10.Text = "Show Reports"
        Me.RadButton10.ThemeName = "Office2010Silver"
        '
        'CrystalReportViewer4
        '
        Me.CrystalReportViewer4.ActiveViewIndex = -1
        Me.CrystalReportViewer4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer4.Location = New System.Drawing.Point(3, 41)
        Me.CrystalReportViewer4.Name = "CrystalReportViewer4"
        Me.CrystalReportViewer4.Size = New System.Drawing.Size(983, 419)
        Me.CrystalReportViewer4.TabIndex = 0
        '
        'TabTa
        '
        Me.TabTa.Controls.Add(Me.RadButton11)
        Me.TabTa.Controls.Add(Me.CrystalReportViewer5)
        Me.TabTa.Location = New System.Drawing.Point(12, 40)
        Me.TabTa.Name = "TabTa"
        Me.TabTa.Size = New System.Drawing.Size(989, 463)
        Me.TabTa.Text = "Taxi Damages"
        Me.TabTa.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadButton11
        '
        Me.RadButton11.Location = New System.Drawing.Point(4, 9)
        Me.RadButton11.Name = "RadButton11"
        Me.RadButton11.Size = New System.Drawing.Size(110, 24)
        Me.RadButton11.TabIndex = 4
        Me.RadButton11.Text = "Show Reports"
        Me.RadButton11.ThemeName = "Office2010Silver"
        '
        'CrystalReportViewer5
        '
        Me.CrystalReportViewer5.ActiveViewIndex = -1
        Me.CrystalReportViewer5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer5.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer5.Location = New System.Drawing.Point(4, 43)
        Me.CrystalReportViewer5.Name = "CrystalReportViewer5"
        Me.CrystalReportViewer5.Size = New System.Drawing.Size(982, 417)
        Me.CrystalReportViewer5.TabIndex = 0
        '
        'TabShortBoundary
        '
        Me.TabShortBoundary.Controls.Add(Me.RadButton12)
        Me.TabShortBoundary.Controls.Add(Me.CrystalReportViewer6)
        Me.TabShortBoundary.Location = New System.Drawing.Point(12, 40)
        Me.TabShortBoundary.Name = "TabShortBoundary"
        Me.TabShortBoundary.Size = New System.Drawing.Size(989, 463)
        Me.TabShortBoundary.Text = "Short Boundary"
        '
        'RadButton12
        '
        Me.RadButton12.Location = New System.Drawing.Point(4, 10)
        Me.RadButton12.Name = "RadButton12"
        Me.RadButton12.Size = New System.Drawing.Size(110, 24)
        Me.RadButton12.TabIndex = 5
        Me.RadButton12.Text = "Show Reports"
        Me.RadButton12.ThemeName = "Office2010Silver"
        '
        'CrystalReportViewer6
        '
        Me.CrystalReportViewer6.ActiveViewIndex = -1
        Me.CrystalReportViewer6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer6.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer6.Location = New System.Drawing.Point(4, 43)
        Me.CrystalReportViewer6.Name = "CrystalReportViewer6"
        Me.CrystalReportViewer6.Size = New System.Drawing.Size(982, 417)
        Me.CrystalReportViewer6.TabIndex = 0
        '
        'RadPageViewPage12
        '
        Me.RadPageViewPage12.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage12.Name = "RadPageViewPage12"
        Me.RadPageViewPage12.Size = New System.Drawing.Size(989, 463)
        Me.RadPageViewPage12.Text = "Short Gas"
        Me.RadPageViewPage12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabSSSPayment
        '
        Me.tabSSSPayment.Location = New System.Drawing.Point(12, 40)
        Me.tabSSSPayment.Name = "tabSSSPayment"
        Me.tabSSSPayment.Size = New System.Drawing.Size(989, 463)
        Me.tabSSSPayment.Text = "SSS Funds"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.RadPageView1)
        Me.Controls.Add(Me.RadMenu1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taxi Management System"
        Me.ThemeName = "Office2010Silver"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDashboard.ResumeLayout(False)
        CType(Me.RadPageView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView2.ResumeLayout(False)
        Me.TabProfile.ResumeLayout(False)
        Me.TabProfile.PerformLayout()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNotif.ResumeLayout(False)
        CType(Me.listNotif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDispatch.ResumeLayout(False)
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDriversMod.ResumeLayout(False)
        CType(Me.RadPageView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView3.ResumeLayout(False)
        Me.tabDriversList.ResumeLayout(False)
        CType(Me.gridDriver.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDriver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.txtSearchDriver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewDriver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRemovedDrivers.ResumeLayout(False)
        CType(Me.gridDriverRemoved.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDriverRemoved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.txtSearchDriverRemoved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTaxisMod.ResumeLayout(False)
        CType(Me.RadPageView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView4.ResumeLayout(False)
        Me.RadPageViewPage1.ResumeLayout(False)
        CType(Me.gridTaxi.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        Me.RadGroupBox4.PerformLayout()
        CType(Me.txtSearchTaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage2.ResumeLayout(False)
        CType(Me.RadGridView3.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        Me.RadGroupBox5.PerformLayout()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReports.ResumeLayout(False)
        CType(Me.RadPageView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView5.ResumeLayout(False)
        Me.TabDriverInfo.ResumeLayout(False)
        CType(Me.RadButton7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage4.ResumeLayout(False)
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage3.ResumeLayout(False)
        CType(Me.RadPageView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView6.ResumeLayout(False)
        Me.TabDriverFunds.ResumeLayout(False)
        CType(Me.RadButton9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage9.ResumeLayout(False)
        CType(Me.RadButton10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTa.ResumeLayout(False)
        CType(Me.RadButton11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabShortBoundary.ResumeLayout(False)
        CType(Me.RadButton12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CommandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents RadMenuItem2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents TabDashboard As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabDispatch As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabPayins As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabDriversMod As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabTaxisMod As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabSchedule As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabReports As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageView2 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents TabProfile As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabNotif As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents listNotif As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents userName As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadListView1 As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPageView3 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents tabDriversList As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtSearchDriver As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnNewDriver As Telerik.WinControls.UI.RadButton
    Friend WithEvents tabRemovedDrivers As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.MasterGridViewTemplate
    Friend WithEvents gridDriver As Telerik.WinControls.UI.RadGridView
    Friend WithEvents gridDriverRemoved As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtSearchDriverRemoved As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblYear As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblMonth As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDate As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPageView4 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents gridTaxi As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txtSearchTaxi As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadGridView3 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPageView5 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents TabDriverInfo As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageView6 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents TabDriverFunds As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage9 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabTa As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TabShortBoundary As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage12 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents tabSSSPayment As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RadButton7 As Telerik.WinControls.UI.RadButton
    Friend WithEvents DriverInfoRprt1 As TMS_Payongayong.DriverInfoRprt
    Friend WithEvents driverInfoRprt2 As TMS_Payongayong.DriverInfoRprt
    Friend WithEvents RadButton8 As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RadButton9 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton10 As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalReportViewer4 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RadButton11 As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalReportViewer5 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RadButton12 As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalReportViewer6 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
End Class

