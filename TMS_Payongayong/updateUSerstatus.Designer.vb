<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUSerstatus
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
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txtstatus = New Telerik.WinControls.UI.RadLabel()
        Me.txtid = New Telerik.WinControls.UI.RadLabel()
        Me.txtfull = New Telerik.WinControls.UI.RadLabel()
        Me.txtuname = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfull, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(12, 12)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(421, 150)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        Me.RadGridView1.ThemeName = "Office2010Silver"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem3.Text = "Active"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Text = "Inactive"
        RadListDataItem4.TextWrap = True
        Me.RadDropDownList1.Items.Add(RadListDataItem3)
        Me.RadDropDownList1.Items.Add(RadListDataItem4)
        Me.RadDropDownList1.Location = New System.Drawing.Point(85, 263)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(125, 20)
        Me.RadDropDownList1.TabIndex = 1
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(38, 263)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(41, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Set as :"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(38, 196)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Fullname"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(38, 172)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(44, 18)
        Me.RadLabel3.TabIndex = 4
        Me.RadLabel3.Text = "USer ID"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(38, 220)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel4.TabIndex = 4
        Me.RadLabel4.Text = "Username"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(291, 182)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(37, 18)
        Me.RadLabel5.TabIndex = 3
        Me.RadLabel5.Text = "Status"
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(334, 182)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(14, 18)
        Me.txtstatus.TabIndex = 4
        Me.txtstatus.Text = "'''"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(123, 172)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(35, 18)
        Me.txtid.TabIndex = 5
        Me.txtid.Text = "txtuid"
        '
        'txtfull
        '
        Me.txtfull.Location = New System.Drawing.Point(123, 196)
        Me.txtfull.Name = "txtfull"
        Me.txtfull.Size = New System.Drawing.Size(34, 18)
        Me.txtfull.TabIndex = 6
        Me.txtfull.Text = "txtfull"
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(123, 220)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(53, 18)
        Me.txtuname.TabIndex = 7
        Me.txtuname.Text = "txtuname"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(252, 263)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 8
        Me.RadButton1.Text = "Update"
        '
        'UpdateUSerstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 327)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.txtfull)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "UpdateUSerstatus"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Fullname"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfull, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtstatus As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtid As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtfull As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtuname As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

