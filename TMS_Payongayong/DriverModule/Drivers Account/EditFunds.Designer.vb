<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditFunds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditFunds))
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtFundAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.btnEditFunds = New Telerik.WinControls.UI.RadButton()
        Me.lblIDFundEdit = New Telerik.WinControls.UI.RadLabel()
        Me.Office2010SilverTheme2 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.radioBtnDeduct = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblPrevAmount = New Telerik.WinControls.UI.RadLabel()
        Me.radioBtnAdd = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblremainID = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFundAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditFunds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIDFundEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioBtnDeduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrevAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioBtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblremainID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(100, 88)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(84, 20)
        Me.RadLabel1.TabIndex = 6
        Me.RadLabel1.Text = "Enter Amount"
        '
        'txtFundAmount
        '
        Me.txtFundAmount.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtFundAmount.Location = New System.Drawing.Point(79, 114)
        Me.txtFundAmount.Name = "txtFundAmount"
        Me.txtFundAmount.Size = New System.Drawing.Size(128, 22)
        Me.txtFundAmount.TabIndex = 5
        Me.txtFundAmount.ThemeName = "Office2010Silver"
        '
        'btnEditFunds
        '
        Me.btnEditFunds.Location = New System.Drawing.Point(79, 142)
        Me.btnEditFunds.Name = "btnEditFunds"
        Me.btnEditFunds.Size = New System.Drawing.Size(128, 22)
        Me.btnEditFunds.TabIndex = 4
        Me.btnEditFunds.Text = "Update"
        Me.btnEditFunds.ThemeName = "Office2010Silver"
        '
        'lblIDFundEdit
        '
        Me.lblIDFundEdit.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblIDFundEdit.Location = New System.Drawing.Point(12, 23)
        Me.lblIDFundEdit.Name = "lblIDFundEdit"
        Me.lblIDFundEdit.Size = New System.Drawing.Size(12, 20)
        Me.lblIDFundEdit.TabIndex = 7
        Me.lblIDFundEdit.Text = "_"
        Me.lblIDFundEdit.Visible = False
        '
        'radioBtnDeduct
        '
        Me.radioBtnDeduct.Location = New System.Drawing.Point(169, 49)
        Me.radioBtnDeduct.Name = "radioBtnDeduct"
        Me.radioBtnDeduct.Size = New System.Drawing.Size(56, 18)
        Me.radioBtnDeduct.TabIndex = 9
        Me.radioBtnDeduct.Text = "Deduct"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(73, 25)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel2.TabIndex = 10
        Me.RadLabel2.Text = "Previous Amount :"
        '
        'lblPrevAmount
        '
        Me.lblPrevAmount.Location = New System.Drawing.Point(205, 25)
        Me.lblPrevAmount.Name = "lblPrevAmount"
        Me.lblPrevAmount.Size = New System.Drawing.Size(2, 2)
        Me.lblPrevAmount.TabIndex = 11
        '
        'radioBtnAdd
        '
        Me.radioBtnAdd.Location = New System.Drawing.Point(79, 49)
        Me.radioBtnAdd.Name = "radioBtnAdd"
        Me.radioBtnAdd.Size = New System.Drawing.Size(41, 18)
        Me.radioBtnAdd.TabIndex = 10
        Me.radioBtnAdd.TabStop = True
        Me.radioBtnAdd.Text = "Add"
        Me.radioBtnAdd.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'lblremainID
        '
        Me.lblremainID.Location = New System.Drawing.Point(13, 65)
        Me.lblremainID.Name = "lblremainID"
        Me.lblremainID.Size = New System.Drawing.Size(11, 18)
        Me.lblremainID.TabIndex = 12
        Me.lblremainID.Text = "-"
        Me.lblremainID.Visible = False
        '
        'EditFunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 178)
        Me.Controls.Add(Me.lblremainID)
        Me.Controls.Add(Me.radioBtnAdd)
        Me.Controls.Add(Me.lblPrevAmount)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.radioBtnDeduct)
        Me.Controls.Add(Me.lblIDFundEdit)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtFundAmount)
        Me.Controls.Add(Me.btnEditFunds)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditFunds"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Funds"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFundAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditFunds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIDFundEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioBtnDeduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrevAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioBtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblremainID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtFundAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnEditFunds As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblIDFundEdit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Office2010SilverTheme2 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents radioBtnDeduct As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblPrevAmount As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radioBtnAdd As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblremainID As Telerik.WinControls.UI.RadLabel
End Class

