<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddShortBoundary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddShortBoundary))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.txtShortBoundaryReason = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btnAddRecord = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtShortBoundaryAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.lblNoReason = New System.Windows.Forms.PictureBox()
        Me.lblNoAmount = New System.Windows.Forms.PictureBox()
        CType(Me.txtShortBoundaryReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtShortBoundaryAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtShortBoundaryReason
        '
        Me.txtShortBoundaryReason.AutoSize = False
        Me.txtShortBoundaryReason.Location = New System.Drawing.Point(36, 96)
        Me.txtShortBoundaryReason.Multiline = True
        Me.txtShortBoundaryReason.Name = "txtShortBoundaryReason"
        Me.txtShortBoundaryReason.Size = New System.Drawing.Size(247, 78)
        Me.txtShortBoundaryReason.TabIndex = 10
        Me.txtShortBoundaryReason.ThemeName = "Office2010Silver"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(163, 180)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(86, 24)
        Me.RadButton2.TabIndex = 8
        Me.RadButton2.Text = "Cancel"
        Me.RadButton2.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(36, 75)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(42, 18)
        Me.RadLabel2.TabIndex = 9
        Me.RadLabel2.Text = "Reason"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(71, 180)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(86, 24)
        Me.btnAddRecord.TabIndex = 7
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.ThemeName = "Office2010Silver"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(36, 25)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel1.TabIndex = 6
        Me.RadLabel1.Text = "Amount"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'txtShortBoundaryAmount
        '
        Me.txtShortBoundaryAmount.Location = New System.Drawing.Point(36, 49)
        Me.txtShortBoundaryAmount.MaxLength = 7
        Me.txtShortBoundaryAmount.Name = "txtShortBoundaryAmount"
        Me.txtShortBoundaryAmount.Size = New System.Drawing.Size(247, 20)
        Me.txtShortBoundaryAmount.TabIndex = 12
        Me.txtShortBoundaryAmount.ThemeName = "Office2010Silver"
        '
        'lblNoReason
        '
        Me.lblNoReason.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoReason.Location = New System.Drawing.Point(289, 97)
        Me.lblNoReason.Name = "lblNoReason"
        Me.lblNoReason.Size = New System.Drawing.Size(20, 20)
        Me.lblNoReason.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoReason.TabIndex = 27
        Me.lblNoReason.TabStop = False
        Me.lblNoReason.Visible = False
        '
        'lblNoAmount
        '
        Me.lblNoAmount.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoAmount.Location = New System.Drawing.Point(289, 49)
        Me.lblNoAmount.Name = "lblNoAmount"
        Me.lblNoAmount.Size = New System.Drawing.Size(20, 20)
        Me.lblNoAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoAmount.TabIndex = 26
        Me.lblNoAmount.TabStop = False
        Me.lblNoAmount.Visible = False
        '
        'AddShortBoundary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 229)
        Me.Controls.Add(Me.lblNoReason)
        Me.Controls.Add(Me.lblNoAmount)
        Me.Controls.Add(Me.txtShortBoundaryAmount)
        Me.Controls.Add(Me.txtShortBoundaryReason)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.RadLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddShortBoundary"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Record"
        Me.ThemeName = "Office2010Silver"
        CType(Me.txtShortBoundaryReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtShortBoundaryAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents txtShortBoundaryReason As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnAddRecord As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtShortBoundaryAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblNoReason As System.Windows.Forms.PictureBox
    Friend WithEvents lblNoAmount As System.Windows.Forms.PictureBox
End Class

