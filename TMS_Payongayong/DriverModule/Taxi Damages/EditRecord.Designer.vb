<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditRecord))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.editdrpdwnCalcuAmount = New Telerik.WinControls.UI.RadCalculatorDropDown()
        Me.txtDescript = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblRecordID = New System.Windows.Forms.Label()
        Me.radioBtnAdd = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblPrevAmount = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.radioBtnDeduct = New Telerik.WinControls.UI.RadRadioButton()
        CType(Me.editdrpdwnCalcuAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescript, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioBtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrevAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioBtnDeduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editdrpdwnCalcuAmount
        '
        Me.editdrpdwnCalcuAmount.Location = New System.Drawing.Point(29, 106)
        Me.editdrpdwnCalcuAmount.Name = "editdrpdwnCalcuAmount"
        Me.editdrpdwnCalcuAmount.Size = New System.Drawing.Size(247, 20)
        Me.editdrpdwnCalcuAmount.TabIndex = 11
        Me.editdrpdwnCalcuAmount.TabStop = False
        Me.editdrpdwnCalcuAmount.Text = "RadCalculatorDropDown1"
        Me.editdrpdwnCalcuAmount.ThemeName = "Office2010Silver"
        Me.editdrpdwnCalcuAmount.Value = "0"
        '
        'txtDescript
        '
        Me.txtDescript.AutoSize = False
        Me.txtDescript.Location = New System.Drawing.Point(29, 153)
        Me.txtDescript.Multiline = True
        Me.txtDescript.Name = "txtDescript"
        Me.txtDescript.Size = New System.Drawing.Size(247, 78)
        Me.txtDescript.TabIndex = 10
        Me.txtDescript.ThemeName = "Office2010Silver"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(156, 237)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(86, 24)
        Me.RadButton2.TabIndex = 8
        Me.RadButton2.Text = "Cancel"
        Me.RadButton2.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(29, 132)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel2.TabIndex = 9
        Me.RadLabel2.Text = "Description"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(64, 237)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(86, 24)
        Me.RadButton1.TabIndex = 7
        Me.RadButton1.Text = "Edit"
        Me.RadButton1.ThemeName = "Office2010Silver"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(29, 82)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel1.TabIndex = 6
        Me.RadLabel1.Text = "Amount"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'lblRecordID
        '
        Me.lblRecordID.AutoSize = True
        Me.lblRecordID.Location = New System.Drawing.Point(285, 9)
        Me.lblRecordID.Name = "lblRecordID"
        Me.lblRecordID.Size = New System.Drawing.Size(11, 13)
        Me.lblRecordID.TabIndex = 12
        Me.lblRecordID.Text = "-"
        Me.lblRecordID.Visible = False
        '
        'radioBtnAdd
        '
        Me.radioBtnAdd.Location = New System.Drawing.Point(80, 36)
        Me.radioBtnAdd.Name = "radioBtnAdd"
        Me.radioBtnAdd.Size = New System.Drawing.Size(41, 18)
        Me.radioBtnAdd.TabIndex = 19
        Me.radioBtnAdd.TabStop = True
        Me.radioBtnAdd.Text = "Add"
        Me.radioBtnAdd.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'lblPrevAmount
        '
        Me.lblPrevAmount.Location = New System.Drawing.Point(206, 12)
        Me.lblPrevAmount.Name = "lblPrevAmount"
        Me.lblPrevAmount.Size = New System.Drawing.Size(2, 2)
        Me.lblPrevAmount.TabIndex = 20
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(74, 12)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel3.TabIndex = 18
        Me.RadLabel3.Text = "Previous Amount :"
        '
        'radioBtnDeduct
        '
        Me.radioBtnDeduct.Location = New System.Drawing.Point(170, 36)
        Me.radioBtnDeduct.Name = "radioBtnDeduct"
        Me.radioBtnDeduct.Size = New System.Drawing.Size(56, 18)
        Me.radioBtnDeduct.TabIndex = 17
        Me.radioBtnDeduct.Text = "Deduct"
        '
        'EditRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 278)
        Me.Controls.Add(Me.radioBtnAdd)
        Me.Controls.Add(Me.lblPrevAmount)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.radioBtnDeduct)
        Me.Controls.Add(Me.lblRecordID)
        Me.Controls.Add(Me.editdrpdwnCalcuAmount)
        Me.Controls.Add(Me.txtDescript)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditRecord"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Edit Record"
        Me.ThemeName = "Office2010Silver"
        CType(Me.editdrpdwnCalcuAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescript, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioBtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrevAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioBtnDeduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents editdrpdwnCalcuAmount As Telerik.WinControls.UI.RadCalculatorDropDown
    Friend WithEvents txtDescript As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblRecordID As System.Windows.Forms.Label
    Friend WithEvents radioBtnAdd As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblPrevAmount As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radioBtnDeduct As Telerik.WinControls.UI.RadRadioButton
End Class

