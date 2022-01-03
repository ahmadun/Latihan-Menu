<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PenghitungHuruf
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
        Me.Txt_box = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lb_count_huruf = New System.Windows.Forms.Label()
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
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Penghitung Huruf"
        '
        'Txt_box
        '
        Me.Txt_box.Location = New System.Drawing.Point(12, 55)
        Me.Txt_box.Multiline = True
        Me.Txt_box.Name = "Txt_box"
        Me.Txt_box.Size = New System.Drawing.Size(776, 58)
        Me.Txt_box.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jumlah Huruf :"
        '
        'Lb_count_huruf
        '
        Me.Lb_count_huruf.AutoSize = True
        Me.Lb_count_huruf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_count_huruf.Location = New System.Drawing.Point(87, 116)
        Me.Lb_count_huruf.Name = "Lb_count_huruf"
        Me.Lb_count_huruf.Size = New System.Drawing.Size(19, 13)
        Me.Lb_count_huruf.TabIndex = 4
        Me.Lb_count_huruf.Text = "..."
        '
        'PenghitungHuruf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 173)
        Me.Controls.Add(Me.Lb_count_huruf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_box)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PenghitungHuruf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PenghitungHuruf"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Lb_count_huruf As Label
End Class
