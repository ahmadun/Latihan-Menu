<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RumusLuasPSG
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_leb = New System.Windows.Forms.TextBox()
        Me.Txt_pan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_hit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_luas = New System.Windows.Forms.TextBox()
        Me.Txt_kel = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 39)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hitung Luas dan Keliling Persegi Panjang"
        '
        'Txt_leb
        '
        Me.Txt_leb.Location = New System.Drawing.Point(68, 70)
        Me.Txt_leb.Name = "Txt_leb"
        Me.Txt_leb.Size = New System.Drawing.Size(187, 20)
        Me.Txt_leb.TabIndex = 6
        '
        'Txt_pan
        '
        Me.Txt_pan.Location = New System.Drawing.Point(68, 106)
        Me.Txt_pan.Name = "Txt_pan"
        Me.Txt_pan.Size = New System.Drawing.Size(187, 20)
        Me.Txt_pan.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Panjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lebar"
        '
        'Btn_hit
        '
        Me.Btn_hit.Location = New System.Drawing.Point(180, 132)
        Me.Btn_hit.Name = "Btn_hit"
        Me.Btn_hit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_hit.TabIndex = 10
        Me.Btn_hit.Text = "Btn_hitung"
        Me.Btn_hit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Luas nya adalah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kelilingnya adalah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(170, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = ":"
        '
        'Txt_luas
        '
        Me.Txt_luas.Location = New System.Drawing.Point(186, 162)
        Me.Txt_luas.Name = "Txt_luas"
        Me.Txt_luas.Size = New System.Drawing.Size(69, 20)
        Me.Txt_luas.TabIndex = 15
        '
        'Txt_kel
        '
        Me.Txt_kel.Location = New System.Drawing.Point(186, 186)
        Me.Txt_kel.Name = "Txt_kel"
        Me.Txt_kel.Size = New System.Drawing.Size(69, 20)
        Me.Txt_kel.TabIndex = 16
        '
        'RumusLuasPSG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 258)
        Me.Controls.Add(Me.Txt_kel)
        Me.Controls.Add(Me.Txt_luas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_hit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_pan)
        Me.Controls.Add(Me.Txt_leb)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RumusLuasPSG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RumusLuasPSG"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_leb As TextBox
    Friend WithEvents Txt_pan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_hit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_luas As TextBox
    Friend WithEvents Txt_kel As TextBox
End Class
