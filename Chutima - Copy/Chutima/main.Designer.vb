<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.bt_cutgrade = New System.Windows.Forms.Button()
        Me.bt_sum = New System.Windows.Forms.Button()
        Me.bt_end = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_cutgrade
        '
        Me.bt_cutgrade.Location = New System.Drawing.Point(81, 72)
        Me.bt_cutgrade.Name = "bt_cutgrade"
        Me.bt_cutgrade.Size = New System.Drawing.Size(119, 23)
        Me.bt_cutgrade.TabIndex = 0
        Me.bt_cutgrade.Text = "โปรแกรมตัดเกรด"
        Me.bt_cutgrade.UseVisualStyleBackColor = True
        '
        'bt_sum
        '
        Me.bt_sum.Location = New System.Drawing.Point(81, 43)
        Me.bt_sum.Name = "bt_sum"
        Me.bt_sum.Size = New System.Drawing.Size(119, 23)
        Me.bt_sum.TabIndex = 1
        Me.bt_sum.Text = "โปรแกรมคิดเลข"
        Me.bt_sum.UseVisualStyleBackColor = True
        '
        'bt_end
        '
        Me.bt_end.Location = New System.Drawing.Point(138, 206)
        Me.bt_end.Name = "bt_end"
        Me.bt_end.Size = New System.Drawing.Size(100, 23)
        Me.bt_end.TabIndex = 2
        Me.bt_end.Text = "จบการทำงาน"
        Me.bt_end.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.bt_end)
        Me.Controls.Add(Me.bt_sum)
        Me.Controls.Add(Me.bt_cutgrade)
        Me.Name = "main"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "หน้าหลัก"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_cutgrade As System.Windows.Forms.Button
    Friend WithEvents bt_sum As System.Windows.Forms.Button
    Friend WithEvents bt_end As System.Windows.Forms.Button

End Class
