<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCashAdvance
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
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.txtCashAdvReason = New Telerik.WinControls.UI.RadTextBox()
        Me.txtCashAdvAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnEditCashAdv = New Telerik.WinControls.UI.RadButton()
        Me.lblIDCashAdvEdit = New Telerik.WinControls.UI.RadLabel()
        Me.radioBtnAdd = New Telerik.WinControls.UI.RadRadioButton()
        Me.lblPrevAmount = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.radioBtnDeduct = New Telerik.WinControls.UI.RadRadioButton()
        CType(Me.txtCashAdvReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashAdvAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditCashAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblIDCashAdvEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioBtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrevAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioBtnDeduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCashAdvReason
        '
        Me.txtCashAdvReason.AutoSize = False
        Me.txtCashAdvReason.Location = New System.Drawing.Point(126, 97)
        Me.txtCashAdvReason.Multiline = True
        Me.txtCashAdvReason.Name = "txtCashAdvReason"
        Me.txtCashAdvReason.Size = New System.Drawing.Size(202, 99)
        Me.txtCashAdvReason.TabIndex = 7
        Me.txtCashAdvReason.ThemeName = "Office2010Silver"
        '
        'txtCashAdvAmount
        '
        Me.txtCashAdvAmount.Location = New System.Drawing.Point(126, 71)
        Me.txtCashAdvAmount.Name = "txtCashAdvAmount"
        Me.txtCashAdvAmount.Size = New System.Drawing.Size(202, 20)
        Me.txtCashAdvAmount.TabIndex = 6
        Me.txtCashAdvAmount.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(13, 97)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(42, 18)
        Me.RadLabel2.TabIndex = 8
        Me.RadLabel2.Text = "Reason"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(13, 73)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel1.TabIndex = 5
        Me.RadLabel1.Text = "Enter Amount"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'btnEditCashAdv
        '
        Me.btnEditCashAdv.Location = New System.Drawing.Point(126, 220)
        Me.btnEditCashAdv.Name = "btnEditCashAdv"
        Me.btnEditCashAdv.Size = New System.Drawing.Size(202, 22)
        Me.btnEditCashAdv.TabIndex = 9
        Me.btnEditCashAdv.Text = "Update"
        Me.btnEditCashAdv.ThemeName = "Office2010Silver"
        '
        'lblIDCashAdvEdit
        '
        Me.lblIDCashAdvEdit.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.lblIDCashAdvEdit.Location = New System.Drawing.Point(12, 12)
        Me.lblIDCashAdvEdit.Name = "lblIDCashAdvEdit"
        Me.lblIDCashAdvEdit.Size = New System.Drawing.Size(12, 20)
        Me.lblIDCashAdvEdit.TabIndex = 10
        Me.lblIDCashAdvEdit.Text = "_"
        Me.lblIDCashAdvEdit.Visible = False
        '
        'radioBtnAdd
        '
        Me.radioBtnAdd.Location = New System.Drawing.Point(132, 34)
        Me.radioBtnAdd.Name = "radioBtnAdd"
        Me.radioBtnAdd.Size = New System.Drawing.Size(41, 18)
        Me.radioBtnAdd.TabIndex = 14
        Me.radioBtnAdd.TabStop = True
        Me.radioBtnAdd.Text = "Add"
        Me.radioBtnAdd.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'lblPrevAmount
        '
        Me.lblPrevAmount.Location = New System.Drawing.Point(258, 10)
        Me.lblPrevAmount.Name = "lblPrevAmount"
        Me.lblPrevAmount.Size = New System.Drawing.Size(2, 2)
        Me.lblPrevAmount.TabIndex = 15
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(126, 10)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel3.TabIndex = 13
        Me.RadLabel3.Text = "Previous Amount :"
        '
        'radioBtnDeduct
        '
        Me.radioBtnDeduct.Location = New System.Drawing.Point(222, 34)
        Me.radioBtnDeduct.Name = "radioBtnDeduct"
        Me.radioBtnDeduct.Size = New System.Drawing.Size(56, 18)
        Me.radioBtnDeduct.TabIndex = 12
        Me.radioBtnDeduct.Text = "Deduct"
        '
        'EditCashAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 256)
        Me.Controls.Add(Me.radioBtnAdd)
        Me.Controls.Add(Me.lblPrevAmount)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.radioBtnDeduct)
        Me.Controls.Add(Me.lblIDCashAdvEdit)
        Me.Controls.Add(Me.btnEditCashAdv)
        Me.Controls.Add(Me.txtCashAdvReason)
        Me.Controls.Add(Me.txtCashAdvAmount)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "EditCashAdvance"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditCashAdvance"
        Me.ThemeName = "Office2010Silver"
        CType(Me.txtCashAdvReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashAdvAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditCashAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblIDCashAdvEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioBtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrevAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioBtnDeduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents txtCashAdvReason As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtCashAdvAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnEditCashAdv As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblIDCashAdvEdit As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radioBtnAdd As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents lblPrevAmount As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents radioBtnDeduct As Telerik.WinControls.UI.RadRadioButton
End Class

