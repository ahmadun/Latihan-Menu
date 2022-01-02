<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimerApp
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Lb_time = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_start = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        '
        'Lb_time
        '
        Me.Lb_time.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lb_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_time.Location = New System.Drawing.Point(0, 0)
        Me.Lb_time.Name = "Lb_time"
        Me.Lb_time.Size = New System.Drawing.Size(568, 43)
        Me.Lb_time.TabIndex = 0
        Me.Lb_time.Text = "H:mm:ss"
        Me.Lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Lb_time)
        Me.Panel1.Location = New System.Drawing.Point(12, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 43)
        Me.Panel1.TabIndex = 1
        '
        'Btn_start
        '
        Me.Btn_start.Location = New System.Drawing.Point(254, 183)
        Me.Btn_start.Name = "Btn_start"
        Me.Btn_start.Size = New System.Drawing.Size(75, 23)
        Me.Btn_start.TabIndex = 2
        Me.Btn_start.Text = "START"
        Me.Btn_start.UseVisualStyleBackColor = True
        '
        'TimerApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 218)
        Me.Controls.Add(Me.Btn_start)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TimerApp"
        Me.Text = "TimerApp"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents Lb_time As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_start As Button
End Class
