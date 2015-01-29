<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRecord))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnRecord = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.txtDescrip = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.drpdwnCalcuAmount = New Telerik.WinControls.UI.RadCalculatorDropDown()
        Me.lblNoReason = New System.Windows.Forms.PictureBox()
        Me.lblNoAmount = New System.Windows.Forms.PictureBox()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpdwnCalcuAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoReason, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(47, 19)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Amount"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(82, 174)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(86, 24)
        Me.btnRecord.TabIndex = 1
        Me.btnRecord.Text = "Add Record"
        Me.btnRecord.ThemeName = "Office2010Silver"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(174, 174)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(86, 24)
        Me.RadButton2.TabIndex = 2
        Me.RadButton2.Text = "Cancel"
        Me.RadButton2.ThemeName = "Office2010Silver"
        '
        'txtDescrip
        '
        Me.txtDescrip.AutoSize = False
        Me.txtDescrip.Location = New System.Drawing.Point(47, 90)
        Me.txtDescrip.Multiline = True
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(247, 78)
        Me.txtDescrip.TabIndex = 4
        Me.txtDescrip.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(47, 69)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Description"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'drpdwnCalcuAmount
        '
        Me.drpdwnCalcuAmount.Location = New System.Drawing.Point(47, 43)
        Me.drpdwnCalcuAmount.Name = "drpdwnCalcuAmount"
        Me.drpdwnCalcuAmount.Size = New System.Drawing.Size(247, 20)
        Me.drpdwnCalcuAmount.TabIndex = 5
        Me.drpdwnCalcuAmount.TabStop = False
        Me.drpdwnCalcuAmount.Text = "RadCalculatorDropDown1"
        Me.drpdwnCalcuAmount.ThemeName = "Office2010Silver"
        Me.drpdwnCalcuAmount.Value = "0"
        '
        'lblNoReason
        '
        Me.lblNoReason.Image = Global.TMS_Payongayong.My.Resources.Resources.exclamation_point
        Me.lblNoReason.Location = New System.Drawing.Point(306, 91)
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
        Me.lblNoAmount.Location = New System.Drawing.Point(306, 43)
        Me.lblNoAmount.Name = "lblNoAmount"
        Me.lblNoAmount.Size = New System.Drawing.Size(28, 20)
        Me.lblNoAmount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblNoAmount.TabIndex = 28
        Me.lblNoAmount.TabStop = False
        Me.lblNoAmount.Visible = False
        '
        'AddRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 229)
        Me.Controls.Add(Me.lblNoReason)
        Me.Controls.Add(Me.lblNoAmount)
        Me.Controls.Add(Me.drpdwnCalcuAmount)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.RadLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddRecord"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Record"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpdwnCalcuAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoReason, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnRecord As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtDescrip As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents drpdwnCalcuAmount As Telerik.WinControls.UI.RadCalculatorDropDown
    Friend WithEvents lblNoReason As System.Windows.Forms.PictureBox
    Friend WithEvents lblNoAmount As System.Windows.Forms.PictureBox
End Class

