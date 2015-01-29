<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotEnterCode
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
        Me.lblResult = New Telerik.WinControls.UI.RadLabel()
        Me.subLabel = New Telerik.WinControls.UI.RadLabel()
        Me.mainLabel = New Telerik.WinControls.UI.RadLabel()
        Me.btnVerify = New Telerik.WinControls.UI.RadButton()
        Me.txtCode = New Telerik.WinControls.UI.RadTextBox()
        Me.txtForgotEmail = New Telerik.WinControls.UI.RadTextBox()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        CType(Me.lblResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVerify, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtForgotEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.Location = New System.Drawing.Point(21, 69)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(63, 19)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "RadLabel3"
        Me.lblResult.ThemeName = "Office2010Silver"
        Me.lblResult.Visible = False
        '
        'subLabel
        '
        Me.subLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subLabel.Location = New System.Drawing.Point(21, 45)
        Me.subLabel.Name = "subLabel"
        Me.subLabel.Size = New System.Drawing.Size(262, 19)
        Me.subLabel.TabIndex = 5
        Me.subLabel.Text = "Insert the code we sent to your e-mail address."
        Me.subLabel.ThemeName = "Office2010Silver"
        '
        'mainLabel
        '
        Me.mainLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainLabel.Location = New System.Drawing.Point(21, 25)
        Me.mainLabel.Name = "mainLabel"
        Me.mainLabel.Size = New System.Drawing.Size(199, 24)
        Me.mainLabel.TabIndex = 4
        Me.mainLabel.Text = "Enter your Verification Code"
        Me.mainLabel.ThemeName = "Office2010Silver"
        '
        'btnVerify
        '
        Me.btnVerify.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.Location = New System.Drawing.Point(292, 90)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(78, 32)
        Me.btnVerify.TabIndex = 7
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.ThemeName = "Office2010Silver"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(21, 90)
        Me.txtCode.MaxLength = 6
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Padding = New System.Windows.Forms.Padding(5)
        Me.txtCode.Size = New System.Drawing.Size(265, 32)
        Me.txtCode.TabIndex = 6
        Me.txtCode.ThemeName = "Office2010Silver"
        '
        'txtForgotEmail
        '
        Me.txtForgotEmail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForgotEmail.Location = New System.Drawing.Point(21, 90)
        Me.txtForgotEmail.MaxLength = 6
        Me.txtForgotEmail.Name = "txtForgotEmail"
        Me.txtForgotEmail.Padding = New System.Windows.Forms.Padding(5)
        Me.txtForgotEmail.Size = New System.Drawing.Size(265, 32)
        Me.txtForgotEmail.TabIndex = 6
        '
        'ForgotEnterCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(391, 171)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.subLabel)
        Me.Controls.Add(Me.mainLabel)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.txtCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ForgotEnterCode"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Recovery"
        Me.ThemeName = "Office2010Silver"
        CType(Me.lblResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVerify, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtForgotEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResult As Telerik.WinControls.UI.RadLabel
    Friend WithEvents subLabel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mainLabel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnVerify As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtForgotEmail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
End Class

