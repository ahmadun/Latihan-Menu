<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpanTeks
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
        Me.Txt_teksin = New System.Windows.Forms.TextBox()
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.Txt_boxout = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(800, 39)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Simpan Teks"
        '
        'Txt_teksin
        '
        Me.Txt_teksin.Location = New System.Drawing.Point(15, 60)
        Me.Txt_teksin.Multiline = True
        Me.Txt_teksin.Name = "Txt_teksin"
        Me.Txt_teksin.Size = New System.Drawing.Size(764, 58)
        Me.Txt_teksin.TabIndex = 6
        '
        'Btn_save
        '
        Me.Btn_save.Location = New System.Drawing.Point(15, 124)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(75, 23)
        Me.Btn_save.TabIndex = 7
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'Txt_boxout
        '
        Me.Txt_boxout.Location = New System.Drawing.Point(15, 153)
        Me.Txt_boxout.Multiline = True
        Me.Txt_boxout.Name = "Txt_boxout"
        Me.Txt_boxout.Size = New System.Drawing.Size(764, 148)
        Me.Txt_boxout.TabIndex = 8
        '
        'SimpanTeks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 313)
        Me.Controls.Add(Me.Txt_boxout)
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.Txt_teksin)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SimpanTeks"
        Me.Text = "SimpanTeks"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_teksin As TextBox
    Friend WithEvents Btn_save As Button
    Friend WithEvents Txt_boxout As TextBox
End Class
