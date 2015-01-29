<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passcode
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnnew = New Telerik.WinControls.UI.RadButton()
        Me.txtpasscode = New Telerik.WinControls.UI.RadTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.btnnew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpasscode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Wrong Passcode! Please try again."
        Me.Label2.Visible = False
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(249, 28)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(52, 22)
        Me.btnnew.TabIndex = 117
        Me.btnnew.Text = "Go"
        Me.btnnew.ThemeName = "TelerikMetroBlue"
        '
        'txtpasscode
        '
        Me.txtpasscode.Location = New System.Drawing.Point(117, 28)
        Me.txtpasscode.Name = "txtpasscode"
        Me.txtpasscode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasscode.Size = New System.Drawing.Size(126, 20)
        Me.txtpasscode.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Enter a Passcode :"
        '
        'Passcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 95)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.txtpasscode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Passcode"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passcode"
        CType(Me.btnnew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpasscode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnnew As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtpasscode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

