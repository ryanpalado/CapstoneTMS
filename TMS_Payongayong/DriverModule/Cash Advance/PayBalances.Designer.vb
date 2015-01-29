<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayBalances
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.txtPayBalAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.drpdwnPaymentMode = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSubmit = New Telerik.WinControls.UI.RadButton()
        Me.lblNopayment = New System.Windows.Forms.PictureBox()
        Me.lblNoAmount = New System.Windows.Forms.PictureBox()
        CType(Me.txtPayBalAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpdwnPaymentMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNopayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPayBalAmount
        '
        Me.txtPayBalAmount.Location = New System.Drawing.Point(132, 29)
        Me.txtPayBalAmount.MaxLength = 6
        Me.txtPayBalAmount.Name = "txtPayBalAmount"
        Me.txtPayBalAmount.Size = New System.Drawing.Size(186, 20)
        Me.txtPayBalAmount.TabIndex = 5
        Me.txtPayBalAmount.ThemeName = "Office2010Silver"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(42, 29)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel1.TabIndex = 4
        Me.RadLabel1.Text = "Amount"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(42, 60)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(82, 18)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "Payment Mode"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'drpdwnPaymentMode
        '
        Me.drpdwnPaymentMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Cash"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "From funds"
        RadListDataItem2.TextWrap = True
        Me.drpdwnPaymentMode.Items.Add(RadListDataItem1)
        Me.drpdwnPaymentMode.Items.Add(RadListDataItem2)
        Me.drpdwnPaymentMode.Location = New System.Drawing.Point(132, 62)
        Me.drpdwnPaymentMode.Name = "drpdwnPaymentMode"
        Me.drpdwnPaymentMode.NullText = "Select Year"
        Me.drpdwnPaymentMode.Size = New System.Drawing.Size(186, 20)
        Me.drpdwnPaymentMode.TabIndex = 6
        Me.drpdwnPaymentMode.ThemeName = "Office2010Silver"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(229, 88)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 24)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.ThemeName = "Office2010Silver"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(132, 88)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(89, 24)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.ThemeName = "Office2010Silver"
        '
        'lblNopayment
        '
        Me.lblNopayment.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNopayment.Location = New System.Drawing.Point(325, 62)
        Me.lblNopayment.Name = "lblNopayment"
        Me.lblNopayment.Size = New System.Drawing.Size(20, 20)
        Me.lblNopayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNopayment.TabIndex = 27
        Me.lblNopayment.TabStop = False
        Me.lblNopayment.Visible = False
        '
        'lblNoAmount
        '
        Me.lblNoAmount.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoAmount.Location = New System.Drawing.Point(325, 27)
        Me.lblNoAmount.Name = "lblNoAmount"
        Me.lblNoAmount.Size = New System.Drawing.Size(20, 20)
        Me.lblNoAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoAmount.TabIndex = 26
        Me.lblNoAmount.TabStop = False
        Me.lblNoAmount.Visible = False
        '
        'PayBalances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 141)
        Me.Controls.Add(Me.lblNopayment)
        Me.Controls.Add(Me.lblNoAmount)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.drpdwnPaymentMode)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtPayBalAmount)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "PayBalances"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Balances"
        Me.ThemeName = "Office2010Silver"
        CType(Me.txtPayBalAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpdwnPaymentMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNopayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents txtPayBalAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpdwnPaymentMode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblNopayment As System.Windows.Forms.PictureBox
    Friend WithEvents lblNoAmount As System.Windows.Forms.PictureBox
End Class

