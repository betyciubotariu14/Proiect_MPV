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
        Me.btnIntarzieri = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRute = New System.Windows.Forms.Button()
        Me.btnDetalii = New System.Windows.Forms.Button()
        Me.btnChat = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnProgram = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIntarzieri
        '
        Me.btnIntarzieri.BackColor = System.Drawing.Color.Purple
        Me.btnIntarzieri.FlatAppearance.BorderSize = 0
        Me.btnIntarzieri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIntarzieri.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntarzieri.ForeColor = System.Drawing.Color.White
        Me.btnIntarzieri.Location = New System.Drawing.Point(0, 69)
        Me.btnIntarzieri.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIntarzieri.Name = "btnIntarzieri"
        Me.btnIntarzieri.Size = New System.Drawing.Size(121, 69)
        Me.btnIntarzieri.TabIndex = 2
        Me.btnIntarzieri.Text = "Intarzieri"
        Me.btnIntarzieri.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(167, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 405)
        Me.Panel1.TabIndex = 3
        '
        'btnRute
        '
        Me.btnRute.BackColor = System.Drawing.Color.Purple
        Me.btnRute.FlatAppearance.BorderSize = 0
        Me.btnRute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRute.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRute.ForeColor = System.Drawing.Color.White
        Me.btnRute.Location = New System.Drawing.Point(0, 135)
        Me.btnRute.Name = "btnRute"
        Me.btnRute.Size = New System.Drawing.Size(121, 69)
        Me.btnRute.TabIndex = 5
        Me.btnRute.Text = "Program autobuze"
        Me.btnRute.UseVisualStyleBackColor = False
        '
        'btnDetalii
        '
        Me.btnDetalii.BackColor = System.Drawing.Color.Purple
        Me.btnDetalii.FlatAppearance.BorderSize = 0
        Me.btnDetalii.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalii.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalii.ForeColor = System.Drawing.Color.White
        Me.btnDetalii.Location = New System.Drawing.Point(0, 198)
        Me.btnDetalii.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDetalii.Name = "btnDetalii"
        Me.btnDetalii.Size = New System.Drawing.Size(121, 69)
        Me.btnDetalii.TabIndex = 9
        Me.btnDetalii.Text = "Detalii autobuze"
        Me.btnDetalii.UseVisualStyleBackColor = False
        '
        'btnChat
        '
        Me.btnChat.BackColor = System.Drawing.Color.Purple
        Me.btnChat.FlatAppearance.BorderSize = 0
        Me.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChat.ForeColor = System.Drawing.Color.White
        Me.btnChat.Location = New System.Drawing.Point(0, 267)
        Me.btnChat.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(121, 69)
        Me.btnChat.TabIndex = 10
        Me.btnChat.Text = "Chat"
        Me.btnChat.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Purple
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(0, 336)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 69)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnProgram
        '
        Me.btnProgram.BackColor = System.Drawing.Color.Purple
        Me.btnProgram.FlatAppearance.BorderSize = 0
        Me.btnProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgram.ForeColor = System.Drawing.Color.White
        Me.btnProgram.Location = New System.Drawing.Point(0, 0)
        Me.btnProgram.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProgram.Name = "btnProgram"
        Me.btnProgram.Size = New System.Drawing.Size(121, 69)
        Me.btnProgram.TabIndex = 12
        Me.btnProgram.Text = "Rute"
        Me.btnProgram.UseVisualStyleBackColor = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 406)
        Me.Controls.Add(Me.btnProgram)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.btnDetalii)
        Me.Controls.Add(Me.btnRute)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnIntarzieri)
        Me.Name = "main"
        Me.Text = "Mersul autobuzelor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIntarzieri As System.Windows.Forms.Button
    Friend WithEvents btnRute As System.Windows.Forms.Button
    Friend WithEvents btnDetalii As System.Windows.Forms.Button
    Friend WithEvents btnChat As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnProgram As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
