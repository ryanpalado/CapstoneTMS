<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayShortBoundary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayShortBoundary))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.btnSubmit = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtPayShortBoundary = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.drpdwnPaymentMode = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblNoAmount = New System.Windows.Forms.PictureBox()
        Me.lblNopayment = New System.Windows.Forms.PictureBox()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayShortBoundary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpdwnPaymentMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNopayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(229, 90)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 24)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.ThemeName = "Office2010Silver"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(132, 90)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(89, 24)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(42, 62)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(82, 18)
        Me.RadLabel2.TabIndex = 16
        Me.RadLabel2.Text = "Payment Mode"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'txtPayShortBoundary
        '
        Me.txtPayShortBoundary.Location = New System.Drawing.Point(132, 31)
        Me.txtPayShortBoundary.MaxLength = 7
        Me.txtPayShortBoundary.Name = "txtPayShortBoundary"
        Me.txtPayShortBoundary.Size = New System.Drawing.Size(186, 20)
        Me.txtPayShortBoundary.TabIndex = 17
        Me.txtPayShortBoundary.ThemeName = "Office2010Silver"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(42, 31)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel1.TabIndex = 15
        Me.RadLabel1.Text = "Amount"
        Me.RadLabel1.ThemeName = "Office2010Silver"
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
        Me.drpdwnPaymentMode.Location = New System.Drawing.Point(132, 60)
        Me.drpdwnPaymentMode.Name = "drpdwnPaymentMode"
        Me.drpdwnPaymentMode.NullText = "Select Year"
        Me.drpdwnPaymentMode.Size = New System.Drawing.Size(186, 20)
        Me.drpdwnPaymentMode.TabIndex = 21
        Me.drpdwnPaymentMode.ThemeName = "Office2010Silver"
        '
        'lblNoAmount
        '
        Me.lblNoAmount.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoAmount.Location = New System.Drawing.Point(326, 31)
        Me.lblNoAmount.Name = "lblNoAmount"
        Me.lblNoAmount.Size = New System.Drawing.Size(20, 20)
        Me.lblNoAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoAmount.TabIndex = 24
        Me.lblNoAmount.TabStop = False
        Me.lblNoAmount.Visible = False
        '
        'lblNopayment
        '
        Me.lblNopayment.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNopayment.Location = New System.Drawing.Point(326, 61)
        Me.lblNopayment.Name = "lblNopayment"
        Me.lblNopayment.Size = New System.Drawing.Size(20, 20)
        Me.lblNopayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNopayment.TabIndex = 25
        Me.lblNopayment.TabStop = False
        Me.lblNopayment.Visible = False
        '
        'PayShortBoundary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 145)
        Me.Controls.Add(Me.lblNopayment)
        Me.Controls.Add(Me.lblNoAmount)
        Me.Controls.Add(Me.drpdwnPaymentMode)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txtPayShortBoundary)
        Me.Controls.Add(Me.RadLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PayShortBoundary"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Balances"
        Me.ThemeName = "Office2010Silver"
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayShortBoundary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpdwnPaymentMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNopayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtPayShortBoundary As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpdwnPaymentMode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblNoAmount As System.Windows.Forms.PictureBox
    Friend WithEvents lblNopayment As System.Windows.Forms.PictureBox
End Class

