<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtlname = New Telerik.WinControls.UI.RadTextBox()
        Me.txtfname = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txtmname = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txtuname = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txtpass = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txtemail = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(25, 33)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(59, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Last Name"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(108, 33)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(190, 20)
        Me.txtlname.TabIndex = 1
        Me.txtlname.ThemeName = "Office2010Silver"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(108, 57)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(190, 20)
        Me.txtfname.TabIndex = 3
        Me.txtfname.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(25, 57)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(60, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "First Name"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(108, 81)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(190, 20)
        Me.txtmname.TabIndex = 5
        Me.txtmname.ThemeName = "Office2010Silver"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(25, 81)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(71, 18)
        Me.RadLabel3.TabIndex = 4
        Me.RadLabel3.Text = "Middle Initial"
        Me.RadLabel3.ThemeName = "Office2010Silver"
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(108, 105)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(190, 20)
        Me.txtuname.TabIndex = 7
        Me.txtuname.ThemeName = "Office2010Silver"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(25, 105)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel4.TabIndex = 6
        Me.RadLabel4.Text = "Username"
        Me.RadLabel4.ThemeName = "Office2010Silver"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(108, 131)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtpass.Size = New System.Drawing.Size(190, 20)
        Me.txtpass.TabIndex = 9
        Me.txtpass.ThemeName = "Office2010Silver"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(25, 131)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(53, 18)
        Me.RadLabel5.TabIndex = 8
        Me.RadLabel5.Text = "Password"
        Me.RadLabel5.ThemeName = "Office2010Silver"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(108, 155)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(190, 20)
        Me.txtemail.TabIndex = 11
        Me.txtemail.ThemeName = "Office2010Silver"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(25, 155)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(33, 18)
        Me.RadLabel6.TabIndex = 10
        Me.RadLabel6.Text = "Email"
        Me.RadLabel6.ThemeName = "Office2010Silver"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(25, 190)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(273, 38)
        Me.RadButton1.TabIndex = 14
        Me.RadButton1.Text = "Create"
        Me.RadButton1.ThemeName = "Office2010Silver"
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(330, 325)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "CreateAccount"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateAccount"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtlname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtfname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtmname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtuname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtpass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtemail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
End Class

