<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCashAdvance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCashAdvance))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.btnSubmit = New Telerik.WinControls.UI.RadButton()
        Me.btnCancel = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtCashAdvAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.lblReason = New Telerik.WinControls.UI.RadTextBox()
        Me.lblbalID = New System.Windows.Forms.Label()
        Me.lblNoReason = New System.Windows.Forms.PictureBox()
        Me.lblNoAmount = New System.Windows.Forms.PictureBox()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashAdvAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(53, 193)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 24)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.ThemeName = "Office2010Silver"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(158, 193)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(97, 24)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.ThemeName = "Office2010Silver"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(33, 28)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Amount"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'txtCashAdvAmount
        '
        Me.txtCashAdvAmount.Location = New System.Drawing.Point(36, 52)
        Me.txtCashAdvAmount.MaxLength = 6
        Me.txtCashAdvAmount.Name = "txtCashAdvAmount"
        Me.txtCashAdvAmount.Size = New System.Drawing.Size(235, 20)
        Me.txtCashAdvAmount.TabIndex = 3
        Me.txtCashAdvAmount.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(36, 78)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(42, 18)
        Me.RadLabel2.TabIndex = 4
        Me.RadLabel2.Text = "Reason"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'lblReason
        '
        Me.lblReason.AutoSize = False
        Me.lblReason.Location = New System.Drawing.Point(37, 102)
        Me.lblReason.Multiline = True
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(234, 78)
        Me.lblReason.TabIndex = 4
        Me.lblReason.ThemeName = "Office2010Silver"
        '
        'lblbalID
        '
        Me.lblbalID.AutoSize = True
        Me.lblbalID.Location = New System.Drawing.Point(334, 9)
        Me.lblbalID.Name = "lblbalID"
        Me.lblbalID.Size = New System.Drawing.Size(11, 13)
        Me.lblbalID.TabIndex = 5
        Me.lblbalID.Text = "-"
        '
        'lblNoReason
        '
        Me.lblNoReason.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoReason.Location = New System.Drawing.Point(283, 101)
        Me.lblNoReason.Name = "lblNoReason"
        Me.lblNoReason.Size = New System.Drawing.Size(28, 20)
        Me.lblNoReason.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoReason.TabIndex = 29
        Me.lblNoReason.TabStop = False
        Me.lblNoReason.Visible = False
        '
        'lblNoAmount
        '
        Me.lblNoAmount.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoAmount.Location = New System.Drawing.Point(283, 53)
        Me.lblNoAmount.Name = "lblNoAmount"
        Me.lblNoAmount.Size = New System.Drawing.Size(28, 20)
        Me.lblNoAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoAmount.TabIndex = 28
        Me.lblNoAmount.TabStop = False
        Me.lblNoAmount.Visible = False
        '
        'AddCashAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 229)
        Me.Controls.Add(Me.lblNoReason)
        Me.Controls.Add(Me.lblNoAmount)
        Me.Controls.Add(Me.lblbalID)
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.txtCashAdvAmount)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddCashAdvance"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Cash Advance"
        Me.ThemeName = "Office2010Silver"
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashAdvAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents btnSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnCancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtCashAdvAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblReason As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblbalID As System.Windows.Forms.Label
    Friend WithEvents lblNoReason As System.Windows.Forms.PictureBox
    Friend WithEvents lblNoAmount As System.Windows.Forms.PictureBox
End Class

