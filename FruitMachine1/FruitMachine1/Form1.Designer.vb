<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnHold1 = New System.Windows.Forms.Button()
        Me.btnHold2 = New System.Windows.Forms.Button()
        Me.btnHold3 = New System.Windows.Forms.Button()
        Me.credCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCred = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mBox = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timFlash = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.BackColor = System.Drawing.Color.LightGray
        Me.lb1.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.Location = New System.Drawing.Point(231, 17)
        Me.lb1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(44, 60)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = " "
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.BackColor = System.Drawing.Color.LightGray
        Me.lb2.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lb2.Location = New System.Drawing.Point(316, 17)
        Me.lb2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(44, 60)
        Me.lb2.TabIndex = 1
        Me.lb2.Text = " "
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.BackColor = System.Drawing.Color.LightGray
        Me.lb3.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold)
        Me.lb3.Location = New System.Drawing.Point(400, 17)
        Me.lb3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(44, 60)
        Me.lb3.TabIndex = 2
        Me.lb3.Text = " "
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(291, 117)
        Me.btnSpin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(100, 28)
        Me.btnSpin.TabIndex = 3
        Me.btnSpin.Text = "SPIN"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnHold1
        '
        Me.btnHold1.Location = New System.Drawing.Point(219, 81)
        Me.btnHold1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHold1.Name = "btnHold1"
        Me.btnHold1.Size = New System.Drawing.Size(76, 28)
        Me.btnHold1.TabIndex = 4
        Me.btnHold1.Text = "HOLD"
        Me.btnHold1.UseVisualStyleBackColor = True
        '
        'btnHold2
        '
        Me.btnHold2.Location = New System.Drawing.Point(303, 81)
        Me.btnHold2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHold2.Name = "btnHold2"
        Me.btnHold2.Size = New System.Drawing.Size(76, 28)
        Me.btnHold2.TabIndex = 5
        Me.btnHold2.Text = "HOLD"
        Me.btnHold2.UseVisualStyleBackColor = True
        '
        'btnHold3
        '
        Me.btnHold3.Location = New System.Drawing.Point(387, 81)
        Me.btnHold3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHold3.Name = "btnHold3"
        Me.btnHold3.Size = New System.Drawing.Size(76, 28)
        Me.btnHold3.TabIndex = 6
        Me.btnHold3.Text = "HOLD"
        Me.btnHold3.UseVisualStyleBackColor = True
        '
        'credCount
        '
        Me.credCount.AutoSize = True
        Me.credCount.Location = New System.Drawing.Point(84, 186)
        Me.credCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.credCount.Name = "credCount"
        Me.credCount.Size = New System.Drawing.Size(18, 17)
        Me.credCount.TabIndex = 7
        Me.credCount.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 186)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Credits: "
        '
        'btnCred
        '
        Me.btnCred.Location = New System.Drawing.Point(156, 175)
        Me.btnCred.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCred.Name = "btnCred"
        Me.btnCred.Size = New System.Drawing.Size(124, 38)
        Me.btnCred.TabIndex = 11
        Me.btnCred.Text = "Add Credits"
        Me.btnCred.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "1 Credit  = 10 pence "
        '
        'mBox
        '
        Me.mBox.BackColor = System.Drawing.SystemColors.Window
        Me.mBox.Location = New System.Drawing.Point(461, 146)
        Me.mBox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mBox.Name = "mBox"
        Me.mBox.Size = New System.Drawing.Size(199, 117)
        Me.mBox.TabIndex = 16
        Me.mBox.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fruity McFruitface"
        '
        'Timer1
        '
        '
        'timFlash
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 337)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCred)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.credCount)
        Me.Controls.Add(Me.btnHold3)
        Me.Controls.Add(Me.btnHold2)
        Me.Controls.Add(Me.btnHold1)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.lb3)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.lb1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(695, 388)
        Me.MinimumSize = New System.Drawing.Size(695, 388)
        Me.Name = "Form1"
        Me.Text = "Jasper's awsome fruit machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb1 As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents btnSpin As Button
    Friend WithEvents btnHold1 As Button
    Friend WithEvents btnHold2 As Button
    Friend WithEvents btnHold3 As Button
    Friend WithEvents credCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCred As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents mBox As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timFlash As Timer
End Class
