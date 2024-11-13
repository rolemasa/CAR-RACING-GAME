<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.car = New System.Windows.Forms.PictureBox()
        Me.race1 = New System.Windows.Forms.PictureBox()
        Me.race2 = New System.Windows.Forms.PictureBox()
        Me.race3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.RightSide = New System.Windows.Forms.Timer(Me.components)
        Me.LeftSide = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover1 = New System.Windows.Forms.Timer(Me.components)
        Me.RaceMover2 = New System.Windows.Forms.Timer(Me.components)
        Me.RaceMover3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.race1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.race2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.race3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SCORE 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(256, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SPEED 0"
        '
        'car
        '
        Me.car.Image = Global.CAR_RACING_GAME.My.Resources.Resources._4
        Me.car.Location = New System.Drawing.Point(149, 359)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(40, 65)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 13
        Me.car.TabStop = False
        '
        'race1
        '
        Me.race1.Image = Global.CAR_RACING_GAME.My.Resources.Resources._3
        Me.race1.Location = New System.Drawing.Point(261, 231)
        Me.race1.Name = "race1"
        Me.race1.Size = New System.Drawing.Size(40, 64)
        Me.race1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race1.TabIndex = 12
        Me.race1.TabStop = False
        '
        'race2
        '
        Me.race2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.race2.Image = Global.CAR_RACING_GAME.My.Resources.Resources._2
        Me.race2.Location = New System.Drawing.Point(149, 92)
        Me.race2.Name = "race2"
        Me.race2.Size = New System.Drawing.Size(40, 66)
        Me.race2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race2.TabIndex = 11
        Me.race2.TabStop = False
        '
        'race3
        '
        Me.race3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.race3.Image = Global.CAR_RACING_GAME.My.Resources.Resources._1
        Me.race3.Location = New System.Drawing.Point(20, 214)
        Me.race3.Name = "race3"
        Me.race3.Size = New System.Drawing.Size(40, 69)
        Me.race3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race3.TabIndex = 10
        Me.race3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox7.Location = New System.Drawing.Point(220, 423)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(13, 124)
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox8.Location = New System.Drawing.Point(99, 423)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(13, 124)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox6.Location = New System.Drawing.Point(99, 259)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(13, 124)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox5.Location = New System.Drawing.Point(220, 259)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(13, 124)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox4.Location = New System.Drawing.Point(220, 111)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(13, 124)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox3.Location = New System.Drawing.Point(99, 111)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(13, 124)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox2.Location = New System.Drawing.Point(220, -39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(13, 124)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.Location = New System.Drawing.Point(99, -39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 124)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'RightSide
        '
        Me.RightSide.Interval = 10
        '
        'LeftSide
        '
        Me.LeftSide.Interval = 10
        '
        'RacerMover1
        '
        Me.RacerMover1.Enabled = True
        Me.RacerMover1.Interval = 10
        '
        'RaceMover2
        '
        Me.RaceMover2.Enabled = True
        Me.RaceMover2.Interval = 10
        '
        'RaceMover3
        '
        Me.RaceMover3.Enabled = True
        Me.RaceMover3.Interval = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(68, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 59)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "GAMEOVER"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button1.Location = New System.Drawing.Point(99, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "REPLAY"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(334, 461)
        Me.Controls.Add(Me.race2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.race1)
        Me.Controls.Add(Me.race3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(350, 500)
        Me.MinimumSize = New System.Drawing.Size(350, 500)
        Me.Name = "Form1"
        Me.Text = "CAR RACING GAME"
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.race1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.race2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.race3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents race3 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents car As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RacerMover1 As Timer
    Friend WithEvents RaceMover2 As Timer
    Friend WithEvents RaceMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents race2 As PictureBox
End Class
