<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSSSFunds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSSSFunds))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtSSSAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.btnAddSSS = New Telerik.WinControls.UI.RadButton()
        Me.drpdwnPaymentMode = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblNopayment = New System.Windows.Forms.PictureBox()
        Me.lblNoAmount = New System.Windows.Forms.PictureBox()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSSSAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddSSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpdwnPaymentMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNopayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(117, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(84, 20)
        Me.RadLabel1.TabIndex = 5
        Me.RadLabel1.Text = "Enter Amount"
        '
        'txtSSSAmount
        '
        Me.txtSSSAmount.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtSSSAmount.Location = New System.Drawing.Point(68, 37)
        Me.txtSSSAmount.MaxLength = 7
        Me.txtSSSAmount.Name = "txtSSSAmount"
        Me.txtSSSAmount.Size = New System.Drawing.Size(186, 22)
        Me.txtSSSAmount.TabIndex = 4
        Me.txtSSSAmount.ThemeName = "Office2010Silver"
        '
        'btnAddSSS
        '
        Me.btnAddSSS.Location = New System.Drawing.Point(68, 131)
        Me.btnAddSSS.Name = "btnAddSSS"
        Me.btnAddSSS.Size = New System.Drawing.Size(186, 22)
        Me.btnAddSSS.TabIndex = 3
        Me.btnAddSSS.Text = "Submit"
        Me.btnAddSSS.ThemeName = "Office2010Silver"
        '
        'drpdwnPaymentMode
        '
        Me.drpdwnPaymentMode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Cash "
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Cash from Funds"
        RadListDataItem2.TextWrap = True
        Me.drpdwnPaymentMode.Items.Add(RadListDataItem1)
        Me.drpdwnPaymentMode.Items.Add(RadListDataItem2)
        Me.drpdwnPaymentMode.Location = New System.Drawing.Point(68, 94)
        Me.drpdwnPaymentMode.Name = "drpdwnPaymentMode"
        Me.drpdwnPaymentMode.Size = New System.Drawing.Size(186, 20)
        Me.drpdwnPaymentMode.TabIndex = 23
        Me.drpdwnPaymentMode.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(117, 67)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(82, 18)
        Me.RadLabel2.TabIndex = 22
        Me.RadLabel2.Text = "Payment Mode"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'lblNopayment
        '
        Me.lblNopayment.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNopayment.Location = New System.Drawing.Point(266, 95)
        Me.lblNopayment.Name = "lblNopayment"
        Me.lblNopayment.Size = New System.Drawing.Size(28, 20)
        Me.lblNopayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNopayment.TabIndex = 27
        Me.lblNopayment.TabStop = False
        Me.lblNopayment.Visible = False
        '
        'lblNoAmount
        '
        Me.lblNoAmount.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoAmount.Location = New System.Drawing.Point(266, 37)
        Me.lblNoAmount.Name = "lblNoAmount"
        Me.lblNoAmount.Size = New System.Drawing.Size(28, 20)
        Me.lblNoAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoAmount.TabIndex = 26
        Me.lblNoAmount.TabStop = False
        Me.lblNoAmount.Visible = False
        '
        'AddSSSFunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 169)
        Me.Controls.Add(Me.lblNopayment)
        Me.Controls.Add(Me.lblNoAmount)
        Me.Controls.Add(Me.drpdwnPaymentMode)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtSSSAmount)
        Me.Controls.Add(Me.btnAddSSS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddSSSFunds"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add SSS Funds"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSSSAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddSSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpdwnPaymentMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNopayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtSSSAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnAddSSS As Telerik.WinControls.UI.RadButton
    Friend WithEvents drpdwnPaymentMode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblNopayment As System.Windows.Forms.PictureBox
    Friend WithEvents lblNoAmount As System.Windows.Forms.PictureBox
End Class

