<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoLooping
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
        Me.Btn_run = New System.Windows.Forms.Button()
        Me.Listboxs = New System.Windows.Forms.ListBox()
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
        Me.Panel1.Size = New System.Drawing.Size(326, 39)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Memilih Pizza"
        '
        'Btn_run
        '
        Me.Btn_run.Location = New System.Drawing.Point(15, 63)
        Me.Btn_run.Name = "Btn_run"
        Me.Btn_run.Size = New System.Drawing.Size(131, 23)
        Me.Btn_run.TabIndex = 4
        Me.Btn_run.Text = "RUN LOOP"
        Me.Btn_run.UseVisualStyleBackColor = True
        '
        'Listboxs
        '
        Me.Listboxs.FormattingEnabled = True
        Me.Listboxs.Location = New System.Drawing.Point(15, 92)
        Me.Listboxs.Name = "Listboxs"
        Me.Listboxs.Size = New System.Drawing.Size(252, 251)
        Me.Listboxs.TabIndex = 5
        '
        'DoLooping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 373)
        Me.Controls.Add(Me.Listboxs)
        Me.Controls.Add(Me.Btn_run)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DoLooping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoLooping"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_run As Button
    Friend WithEvents Listboxs As ListBox
End Class
