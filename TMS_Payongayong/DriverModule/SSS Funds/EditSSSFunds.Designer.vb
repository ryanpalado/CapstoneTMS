<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSSSFunds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSSSFunds))
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtFundAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.btnAddFunds = New Telerik.WinControls.UI.RadButton()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.radioBtnAdd = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblPrevAmount = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.radioBtnDeduct = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblIDSSSEdit = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFundAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddFunds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioBtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrevAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioBtnDeduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIDSSSEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(115, 84)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(84, 20)
        Me.RadLabel1.TabIndex = 8
        Me.RadLabel1.Text = "Enter Amount"
        '
        'txtFundAmount
        '
        Me.txtFundAmount.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtFundAmount.Location = New System.Drawing.Point(94, 110)
        Me.txtFundAmount.Name = "txtFundAmount"
        Me.txtFundAmount.Size = New System.Drawing.Size(128, 22)
        Me.txtFundAmount.TabIndex = 7
        Me.txtFundAmount.ThemeName = "Office2010Silver"
        '
        'btnAddFunds
        '
        Me.btnAddFunds.Location = New System.Drawing.Point(94, 138)
        Me.btnAddFunds.Name = "btnAddFunds"
        Me.btnAddFunds.Size = New System.Drawing.Size(128, 22)
        Me.btnAddFunds.TabIndex = 6
        Me.btnAddFunds.Text = "Submit"
        Me.btnAddFunds.ThemeName = "Office2010Silver"
        '
        'radioBtnAdd
        '
        Me.radioBtnAdd.Location = New System.Drawing.Point(88, 36)
        Me.radioBtnAdd.Name = "radioBtnAdd"
        Me.radioBtnAdd.Size = New System.Drawing.Size(41, 18)
        Me.radioBtnAdd.TabIndex = 14
        Me.radioBtnAdd.TabStop = True
        Me.radioBtnAdd.Text = "Add"
        Me.radioBtnAdd.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'lblPrevAmount
        '
        Me.lblPrevAmount.Location = New System.Drawing.Point(214, 12)
        Me.lblPrevAmount.Name = "lblPrevAmount"
        Me.lblPrevAmount.Size = New System.Drawing.Size(2, 2)
        Me.lblPrevAmount.TabIndex = 15
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(82, 12)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel2.TabIndex = 13
        Me.RadLabel2.Text = "Previous Amount :"
        '
        'radioBtnDeduct
        '
        Me.radioBtnDeduct.Location = New System.Drawing.Point(178, 36)
        Me.radioBtnDeduct.Name = "radioBtnDeduct"
        Me.radioBtnDeduct.Size = New System.Drawing.Size(56, 18)
        Me.radioBtnDeduct.TabIndex = 12
        Me.radioBtnDeduct.Text = "Deduct"
        '
        'lblIDSSSEdit
        '
        Me.lblIDSSSEdit.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblIDSSSEdit.Location = New System.Drawing.Point(12, 12)
        Me.lblIDSSSEdit.Name = "lblIDSSSEdit"
        Me.lblIDSSSEdit.Size = New System.Drawing.Size(12, 20)
        Me.lblIDSSSEdit.TabIndex = 16
        Me.lblIDSSSEdit.Text = "_"
        Me.lblIDSSSEdit.Visible = False
        '
        'EditSSSFunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 188)
        Me.Controls.Add(Me.lblIDSSSEdit)
        Me.Controls.Add(Me.radioBtnAdd)
        Me.Controls.Add(Me.lblPrevAmount)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.radioBtnDeduct)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtFundAmount)
        Me.Controls.Add(Me.btnAddFunds)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditSSSFunds"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Edit SSS Funds"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFundAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddFunds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioBtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrevAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioBtnDeduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIDSSSEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtFundAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnAddFunds As Telerik.WinControls.UI.RadButton
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents radioBtnAdd As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblPrevAmount As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radioBtnDeduct As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblIDSSSEdit As Telerik.WinControls.UI.RadLabel
End Class

