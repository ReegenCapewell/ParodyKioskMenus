<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
    Inherits System.Windows.Forms.Form

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
        Me.lblGiftCardType = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGiftCardType
        '
        Me.lblGiftCardType.BackColor = System.Drawing.Color.DarkOrange
        Me.lblGiftCardType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGiftCardType.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblGiftCardType.Location = New System.Drawing.Point(29, 102)
        Me.lblGiftCardType.Name = "lblGiftCardType"
        Me.lblGiftCardType.Size = New System.Drawing.Size(209, 75)
        Me.lblGiftCardType.TabIndex = 10
        Me.lblGiftCardType.Text = "BACK"
        Me.lblGiftCardType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOne
        '
        Me.lblOne.BackColor = System.Drawing.Color.DarkOrange
        Me.lblOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOne.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblOne.Location = New System.Drawing.Point(-2, 102)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(35, 75)
        Me.lblOne.TabIndex = 9
        Me.lblOne.Text = "1"
        Me.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(11, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(487, 35)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MEDIA DESIGN CUSTOM GIFT CARDS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblInstructions.Location = New System.Drawing.Point(134, 238)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(252, 95)
        Me.lblInstructions.TabIndex = 11
        Me.lblInstructions.Text = "1. Select Gift Card      2. Select Gift Card Price 3. Pay and Print"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(240, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 27)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "HELP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(512, 440)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblGiftCardType)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximumSize = New System.Drawing.Size(528, 479)
        Me.MinimumSize = New System.Drawing.Size(528, 479)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGiftCardType As Label
    Friend WithEvents lblOne As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents Label1 As Label
End Class
