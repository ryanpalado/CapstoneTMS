<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTaxi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewTaxi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBrandName = New Telerik.WinControls.UI.RadTextBox()
        Me.txtyear_model = New Telerik.WinControls.UI.RadTextBox()
        Me.txtchassis_no = New Telerik.WinControls.UI.RadTextBox()
        Me.txtplate_no = New Telerik.WinControls.UI.RadTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New Telerik.WinControls.UI.RadLabel()
        Me.txtexp_fran = New Telerik.WinControls.UI.RadTextBox()
        Me.txtexp_date = New Telerik.WinControls.UI.RadTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.btnClear = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.txtreg_date = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.txtdate_fran = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtBrandName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtyear_model, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtchassis_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtplate_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtexp_fran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtexp_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtreg_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdate_fran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdate_fran)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtreg_date)
        Me.GroupBox1.Controls.Add(Me.txtBrandName)
        Me.GroupBox1.Controls.Add(Me.txtyear_model)
        Me.GroupBox1.Controls.Add(Me.txtchassis_no)
        Me.GroupBox1.Controls.Add(Me.txtplate_no)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 282)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Taxi's Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 133
        Me.Label9.Text = "Brand Name"
        '
        'txtBrandName
        '
        Me.txtBrandName.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtBrandName.Location = New System.Drawing.Point(186, 128)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(164, 22)
        Me.txtBrandName.TabIndex = 134
        Me.txtBrandName.ThemeName = "Office2010Silver"
        '
        'txtyear_model
        '
        Me.txtyear_model.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyear_model.Location = New System.Drawing.Point(187, 161)
        Me.txtyear_model.MaxLength = 4
        Me.txtyear_model.Name = "txtyear_model"
        Me.txtyear_model.Size = New System.Drawing.Size(163, 20)
        Me.txtyear_model.TabIndex = 117
        Me.txtyear_model.ThemeName = "Office2010Silver"
        '
        'txtchassis_no
        '
        Me.txtchassis_no.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchassis_no.Location = New System.Drawing.Point(187, 96)
        Me.txtchassis_no.Name = "txtchassis_no"
        Me.txtchassis_no.Size = New System.Drawing.Size(163, 20)
        Me.txtchassis_no.TabIndex = 117
        Me.txtchassis_no.ThemeName = "Office2010Silver"
        '
        'txtplate_no
        '
        Me.txtplate_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtplate_no.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplate_no.Location = New System.Drawing.Point(187, 63)
        Me.txtplate_no.Name = "txtplate_no"
        Me.txtplate_no.Size = New System.Drawing.Size(164, 20)
        Me.txtplate_no.TabIndex = 116
        Me.txtplate_no.ThemeName = "Office2010Silver"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Chassis No. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Plate No. :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Year Model :"
        '
        'lbl_id
        '
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(22, 40)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(17, 18)
        Me.lbl_id.TabIndex = 62
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'txtexp_fran
        '
        Me.txtexp_fran.Enabled = False
        Me.txtexp_fran.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexp_fran.Location = New System.Drawing.Point(603, 123)
        Me.txtexp_fran.Name = "txtexp_fran"
        Me.txtexp_fran.Size = New System.Drawing.Size(164, 20)
        Me.txtexp_fran.TabIndex = 120
        Me.txtexp_fran.ThemeName = "Office2010Silver"
        Me.txtexp_fran.Visible = False
        '
        'txtexp_date
        '
        Me.txtexp_date.Enabled = False
        Me.txtexp_date.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexp_date.Location = New System.Drawing.Point(604, 83)
        Me.txtexp_date.Name = "txtexp_date"
        Me.txtexp_date.Size = New System.Drawing.Size(163, 20)
        Me.txtexp_date.TabIndex = 117
        Me.txtexp_date.ThemeName = "Office2010Silver"
        Me.txtexp_date.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(463, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Expiration of Franchise :"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Date of Franchise :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(461, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Date of Expiration :"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Date of Registration :"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.btnClear.Location = New System.Drawing.Point(200, 326)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 39)
        Me.btnClear.TabIndex = 115
        Me.btnClear.Text = "Clear All"
        Me.btnClear.ThemeName = "Office2010Silver"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.btnCancel.Location = New System.Drawing.Point(309, 326)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 39)
        Me.btnCancel.TabIndex = 116
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.ThemeName = "Office2010Silver"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.btnSave.Location = New System.Drawing.Point(91, 326)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 39)
        Me.btnSave.TabIndex = 114
        Me.btnSave.Text = "Save"
        Me.btnSave.ThemeName = "Office2010Silver"
        '
        'txtreg_date
        '
        Me.txtreg_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtreg_date.Location = New System.Drawing.Point(187, 195)
        Me.txtreg_date.Name = "txtreg_date"
        Me.txtreg_date.Size = New System.Drawing.Size(164, 20)
        Me.txtreg_date.TabIndex = 126
        Me.txtreg_date.TabStop = False
        Me.txtreg_date.Text = "1/25/2015"
        Me.txtreg_date.Value = New Date(2015, 1, 25, 22, 57, 6, 598)
        '
        'txtdate_fran
        '
        Me.txtdate_fran.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdate_fran.Location = New System.Drawing.Point(186, 232)
        Me.txtdate_fran.Name = "txtdate_fran"
        Me.txtdate_fran.Size = New System.Drawing.Size(164, 20)
        Me.txtdate_fran.TabIndex = 127
        Me.txtdate_fran.TabStop = False
        Me.txtdate_fran.Text = "1/25/2015"
        Me.txtdate_fran.Value = New Date(2015, 1, 25, 22, 58, 27, 214)
        '
        'NewTaxi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 377)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtexp_fran)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtexp_date)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewTaxi"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddTaxi"
        Me.ThemeName = "Office2010Silver"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtBrandName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtyear_model, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtchassis_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtplate_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtexp_fran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtexp_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtreg_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdate_fran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtexp_fran As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtexp_date As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtyear_model As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtchassis_no As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtplate_no As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_id As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBrandName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnClear As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtreg_date As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txtdate_fran As Telerik.WinControls.UI.RadDateTimePicker
End Class

