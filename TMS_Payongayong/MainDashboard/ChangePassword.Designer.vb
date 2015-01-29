<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.lblResult2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.btnSubmit = New Telerik.WinControls.UI.RadButton()
        Me.lblResult = New Telerik.WinControls.UI.RadLabel()
        Me.subLabel = New Telerik.WinControls.UI.RadLabel()
        Me.mainLabel = New Telerik.WinControls.UI.RadLabel()
        Me.txtNewPass = New Telerik.WinControls.UI.RadTextBox()
        Me.txtConfirmPass = New Telerik.WinControls.UI.RadTextBox()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        CType(Me.lblResult2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtConfirmPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResult2
        '
        Me.lblResult2.BackColor = System.Drawing.Color.White
        Me.lblResult2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult2.ForeColor = System.Drawing.Color.Red
        Me.lblResult2.Location = New System.Drawing.Point(21, 154)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(63, 19)
        Me.lblResult2.TabIndex = 22
        Me.lblResult2.Text = "RadLabel3"
        Me.lblResult2.ThemeName = "Office2010Silver"
        Me.lblResult2.Visible = False
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.White
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(21, 132)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(131, 24)
        Me.RadLabel1.TabIndex = 19
        Me.RadLabel1.Text = "Confirm Password"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.White
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(21, 214)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(348, 32)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.ThemeName = "Office2010Silver"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.White
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Red
        Me.lblResult.Location = New System.Drawing.Point(21, 69)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(63, 19)
        Me.lblResult.TabIndex = 21
        Me.lblResult.Text = "RadLabel3"
        Me.lblResult.ThemeName = "Office2010Silver"
        Me.lblResult.Visible = False
        '
        'subLabel
        '
        Me.subLabel.BackColor = System.Drawing.Color.White
        Me.subLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subLabel.Location = New System.Drawing.Point(21, 45)
        Me.subLabel.Name = "subLabel"
        Me.subLabel.Size = New System.Drawing.Size(154, 19)
        Me.subLabel.TabIndex = 20
        Me.subLabel.Text = "Put your desired password."
        Me.subLabel.ThemeName = "Office2010Silver"
        '
        'mainLabel
        '
        Me.mainLabel.BackColor = System.Drawing.Color.White
        Me.mainLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainLabel.Location = New System.Drawing.Point(21, 25)
        Me.mainLabel.Name = "mainLabel"
        Me.mainLabel.Size = New System.Drawing.Size(146, 24)
        Me.mainLabel.TabIndex = 18
        Me.mainLabel.Text = "Enter New Password"
        Me.mainLabel.ThemeName = "Office2010Silver"
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.Color.White
        Me.txtNewPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass.Location = New System.Drawing.Point(21, 90)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Padding = New System.Windows.Forms.Padding(5)
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass.Size = New System.Drawing.Size(348, 32)
        Me.txtNewPass.TabIndex = 15
        Me.txtNewPass.ThemeName = "Office2010Silver"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.Color.White
        Me.txtConfirmPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(21, 175)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Padding = New System.Windows.Forms.Padding(5)
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtConfirmPass.Size = New System.Drawing.Size(348, 32)
        Me.txtConfirmPass.TabIndex = 16
        Me.txtConfirmPass.ThemeName = "Office2010Silver"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(391, 281)
        Me.Controls.Add(Me.lblResult2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.subLabel)
        Me.Controls.Add(Me.mainLabel)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChangePassword"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePassword"
        Me.ThemeName = "Office2010Silver"
        CType(Me.lblResult2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtConfirmPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResult2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnSubmit As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblResult As Telerik.WinControls.UI.RadLabel
    Friend WithEvents subLabel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents mainLabel As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtNewPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtConfirmPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
End Class

