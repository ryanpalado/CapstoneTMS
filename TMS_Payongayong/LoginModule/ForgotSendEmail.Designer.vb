<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotSendEmail
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
        Me.mainLabel = New Telerik.WinControls.UI.RadLabel()
        Me.txtForgotEmail = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSubmit = New Telerik.WinControls.UI.RadButton()
        Me.subLabel = New Telerik.WinControls.UI.RadLabel()
        Me.lblResult = New Telerik.WinControls.UI.RadLabel()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        CType(Me.mainLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtForgotEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainLabel
        '
        Me.mainLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainLabel.Location = New System.Drawing.Point(22, 24)
        Me.mainLabel.Name = "mainLabel"
        Me.mainLabel.Size = New System.Drawing.Size(183, 24)
        Me.mainLabel.TabIndex = 0
        Me.mainLabel.Text = "Enter your E-mail Address"
        Me.mainLabel.ThemeName = "Office2010Silver"
        '
        'txtForgotEmail
        '
        Me.txtForgotEmail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForgotEmail.Location = New System.Drawing.Point(22, 89)
        Me.txtForgotEmail.Name = "txtForgotEmail"
        Me.txtForgotEmail.Padding = New System.Windows.Forms.Padding(5)
        Me.txtForgotEmail.Size = New System.Drawing.Size(265, 32)
        Me.txtForgotEmail.TabIndex = 1
        Me.txtForgotEmail.ThemeName = "Office2010Silver"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(293, 89)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(78, 32)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.ThemeName = "Office2010Silver"
        '
        'subLabel
        '
        Me.subLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subLabel.Location = New System.Drawing.Point(22, 44)
        Me.subLabel.Name = "subLabel"
        Me.subLabel.Size = New System.Drawing.Size(273, 19)
        Me.subLabel.TabIndex = 1
        Me.subLabel.Text = "We will send the verification code to your e-mail."
        Me.subLabel.ThemeName = "Office2010Silver"
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.Location = New System.Drawing.Point(22, 68)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(63, 19)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "RadLabel3"
        Me.lblResult.ThemeName = "Office2010Silver"
        Me.lblResult.Visible = False
        '
        'ForgotSendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(391, 168)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.subLabel)
        Me.Controls.Add(Me.mainLabel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtForgotEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ForgotSendEmail"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Recovery"
        Me.ThemeName = "Office2010Silver"
        CType(Me.mainLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtForgotEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainLabel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtForgotEmail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents subLabel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblResult As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
End Class

