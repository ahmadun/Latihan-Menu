<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MengenalMethode
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
        Me.Txt_bil1 = New System.Windows.Forms.TextBox()
        Me.Txt_bil2 = New System.Windows.Forms.TextBox()
        Me.Btn_check = New System.Windows.Forms.Button()
        Me.Lb_hasil = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_bil1
        '
        Me.Txt_bil1.Location = New System.Drawing.Point(63, 60)
        Me.Txt_bil1.Name = "Txt_bil1"
        Me.Txt_bil1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_bil1.TabIndex = 0
        '
        'Txt_bil2
        '
        Me.Txt_bil2.Location = New System.Drawing.Point(63, 86)
        Me.Txt_bil2.Name = "Txt_bil2"
        Me.Txt_bil2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_bil2.TabIndex = 1
        '
        'Btn_check
        '
        Me.Btn_check.Location = New System.Drawing.Point(63, 112)
        Me.Btn_check.Name = "Btn_check"
        Me.Btn_check.Size = New System.Drawing.Size(100, 23)
        Me.Btn_check.TabIndex = 2
        Me.Btn_check.Text = "CHECK MAX"
        Me.Btn_check.UseVisualStyleBackColor = True
        '
        'Lb_hasil
        '
        Me.Lb_hasil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_hasil.Location = New System.Drawing.Point(3, 153)
        Me.Lb_hasil.Name = "Lb_hasil"
        Me.Lb_hasil.Size = New System.Drawing.Size(222, 23)
        Me.Lb_hasil.TabIndex = 3
        Me.Lb_hasil.Text = "..."
        Me.Lb_hasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 39)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mengenal Methode"
        '
        'MengenalMethode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lb_hasil)
        Me.Controls.Add(Me.Btn_check)
        Me.Controls.Add(Me.Txt_bil2)
        Me.Controls.Add(Me.Txt_bil1)
        Me.Name = "MengenalMethode"
        Me.Text = "MengenalMethode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_bil1 As TextBox
    Friend WithEvents Txt_bil2 As TextBox
    Friend WithEvents Btn_check As Button
    Friend WithEvents Lb_hasil As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
