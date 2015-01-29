<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFunds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddFunds))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.btnAddFunds = New Telerik.WinControls.UI.RadButton()
        Me.txtFundAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblNoAmount = New System.Windows.Forms.PictureBox()
        CType(Me.btnAddFunds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFundAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddFunds
        '
        Me.btnAddFunds.Location = New System.Drawing.Point(79, 74)
        Me.btnAddFunds.Name = "btnAddFunds"
        Me.btnAddFunds.Size = New System.Drawing.Size(128, 22)
        Me.btnAddFunds.TabIndex = 0
        Me.btnAddFunds.Text = "Submit"
        Me.btnAddFunds.ThemeName = "Office2010Silver"
        '
        'txtFundAmount
        '
        Me.txtFundAmount.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.txtFundAmount.Location = New System.Drawing.Point(79, 46)
        Me.txtFundAmount.MaxLength = 7
        Me.txtFundAmount.Name = "txtFundAmount"
        Me.txtFundAmount.Size = New System.Drawing.Size(128, 22)
        Me.txtFundAmount.TabIndex = 1
        Me.txtFundAmount.ThemeName = "Office2010Silver"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(100, 20)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(84, 20)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Enter Amount"
        '
        'lblNoAmount
        '
        Me.lblNoAmount.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoAmount.Location = New System.Drawing.Point(221, 47)
        Me.lblNoAmount.Name = "lblNoAmount"
        Me.lblNoAmount.Size = New System.Drawing.Size(28, 20)
        Me.lblNoAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoAmount.TabIndex = 27
        Me.lblNoAmount.TabStop = False
        Me.lblNoAmount.Visible = False
        '
        'AddFunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 119)
        Me.Controls.Add(Me.lblNoAmount)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtFundAmount)
        Me.Controls.Add(Me.btnAddFunds)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddFunds"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Funds"
        Me.ThemeName = "Office2010Silver"
        CType(Me.btnAddFunds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFundAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents btnAddFunds As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtFundAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblNoAmount As System.Windows.Forms.PictureBox
End Class

