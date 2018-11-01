<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PP
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
        Me.lblBkPP = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBkPP
        '
        Me.lblBkPP.BackColor = System.Drawing.Color.DarkOrange
        Me.lblBkPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBkPP.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblBkPP.Location = New System.Drawing.Point(30, 103)
        Me.lblBkPP.Name = "lblBkPP"
        Me.lblBkPP.Size = New System.Drawing.Size(209, 75)
        Me.lblBkPP.TabIndex = 10
        Me.lblBkPP.Text = "BACK"
        Me.lblBkPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOne
        '
        Me.lblOne.BackColor = System.Drawing.Color.DarkOrange
        Me.lblOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOne.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblOne.Location = New System.Drawing.Point(-1, 103)
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
        Me.lblTitle.Location = New System.Drawing.Point(12, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(487, 35)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MEDIA DESIGN CUSTOM GIFT CARDS"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(208, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Payment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Bisque
        Me.TextBox1.Location = New System.Drawing.Point(203, 288)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(122, 43)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(102, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(329, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Please insert your card and enter your PIN."
        '
        'PP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(512, 440)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBkPP)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(528, 479)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(528, 479)
        Me.Name = "PP"
        Me.Text = "PP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBkPP As Label
    Friend WithEvents lblOne As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
