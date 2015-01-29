<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditShortBoundary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditShortBoundary))
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.EditTxtShortAmount = New Telerik.WinControls.UI.RadTextBox()
        Me.EditTxtReasonShort = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lblRecordID = New Telerik.WinControls.UI.RadLabel()
        CType(Me.EditTxtShortAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditTxtReasonShort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRecordID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EditTxtShortAmount
        '
        Me.EditTxtShortAmount.Location = New System.Drawing.Point(31, 49)
        Me.EditTxtShortAmount.Name = "EditTxtShortAmount"
        Me.EditTxtShortAmount.Size = New System.Drawing.Size(247, 20)
        Me.EditTxtShortAmount.TabIndex = 18
        Me.EditTxtShortAmount.ThemeName = "Office2010Silver"
        '
        'EditTxtReasonShort
        '
        Me.EditTxtReasonShort.AutoSize = False
        Me.EditTxtReasonShort.Location = New System.Drawing.Point(31, 96)
        Me.EditTxtReasonShort.Multiline = True
        Me.EditTxtReasonShort.Name = "EditTxtReasonShort"
        Me.EditTxtReasonShort.Size = New System.Drawing.Size(247, 78)
        Me.EditTxtReasonShort.TabIndex = 17
        Me.EditTxtReasonShort.ThemeName = "Office2010Silver"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(158, 180)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(86, 24)
        Me.RadButton2.TabIndex = 15
        Me.RadButton2.Text = "Cancel"
        Me.RadButton2.ThemeName = "Office2010Silver"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(31, 75)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(42, 18)
        Me.RadLabel2.TabIndex = 16
        Me.RadLabel2.Text = "Reason"
        Me.RadLabel2.ThemeName = "Office2010Silver"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(66, 180)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(86, 24)
        Me.RadButton1.TabIndex = 14
        Me.RadButton1.Text = "Edit Record"
        Me.RadButton1.ThemeName = "Office2010Silver"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(31, 25)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel1.TabIndex = 13
        Me.RadLabel1.Text = "Amount"
        Me.RadLabel1.ThemeName = "Office2010Silver"
        '
        'lblRecordID
        '
        Me.lblRecordID.Location = New System.Drawing.Point(12, 1)
        Me.lblRecordID.Name = "lblRecordID"
        Me.lblRecordID.Size = New System.Drawing.Size(11, 18)
        Me.lblRecordID.TabIndex = 19
        Me.lblRecordID.Text = "-"
        '
        'EditShortBoundary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 229)
        Me.Controls.Add(Me.lblRecordID)
        Me.Controls.Add(Me.EditTxtShortAmount)
        Me.Controls.Add(Me.EditTxtReasonShort)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditShortBoundary"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Edit Record"
        Me.ThemeName = "Office2010Silver"
        CType(Me.EditTxtShortAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditTxtReasonShort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRecordID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents EditTxtShortAmount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents EditTxtReasonShort As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblRecordID As Telerik.WinControls.UI.RadLabel
End Class

