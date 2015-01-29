<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.myimage = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.select_image = New System.Windows.Forms.Button()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.btnCapture = New System.Windows.Forms.Button()
        CType(Me.myimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myimage
        '
        Me.myimage.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.myimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myimage.Image = Global.TMS_Payongayong.My.Resources.Resources.payins
        Me.myimage.Location = New System.Drawing.Point(96, 27)
        Me.myimage.Name = "myimage"
        Me.myimage.Size = New System.Drawing.Size(164, 149)
        Me.myimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.myimage.TabIndex = 48
        Me.myimage.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(185, 222)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 23)
        Me.btnReset.TabIndex = 77
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseCompatibleTextRendering = True
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(95, 222)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(84, 23)
        Me.btnRegister.TabIndex = 75
        Me.btnRegister.Text = "Save"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister.UseCompatibleTextRendering = True
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'select_image
        '
        Me.select_image.BackColor = System.Drawing.Color.Silver
        Me.select_image.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.select_image.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_image.ForeColor = System.Drawing.Color.Black
        Me.select_image.Location = New System.Drawing.Point(95, 191)
        Me.select_image.Name = "select_image"
        Me.select_image.Size = New System.Drawing.Size(84, 25)
        Me.select_image.TabIndex = 73
        Me.select_image.Text = "Select"
        Me.select_image.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.select_image.UseCompatibleTextRendering = True
        Me.select_image.UseVisualStyleBackColor = False
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "OpenFileDialog1"
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCapture.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCapture.Location = New System.Drawing.Point(185, 191)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(82, 25)
        Me.btnCapture.TabIndex = 87
        Me.btnCapture.Text = "Camera"
        Me.btnCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCapture.UseCompatibleTextRendering = True
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(356, 339)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.myimage)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.select_image)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "Design"
        CType(Me.myimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents myimage As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents select_image As System.Windows.Forms.Button
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCapture As System.Windows.Forms.Button
End Class
