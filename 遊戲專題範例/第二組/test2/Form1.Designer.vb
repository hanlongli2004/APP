<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WalkTime = New System.Windows.Forms.Timer(Me.components)
        Me.toxic1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.toxic2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.fence = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.Blue = New System.Windows.Forms.PictureBox()
        Me.blueplat = New System.Windows.Forms.PictureBox()
        Me.Yellow = New System.Windows.Forms.PictureBox()
        Me.Yellow_plat = New System.Windows.Forms.PictureBox()
        Me.Purple = New System.Windows.Forms.PictureBox()
        Me.purpleplat = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.door = New System.Windows.Forms.PictureBox()
        Me.PictureBox27 = New System.Windows.Forms.PictureBox()
        Me.PictureBox28 = New System.Windows.Forms.PictureBox()
        Me.PictureBox29 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Player1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.fencetime = New System.Windows.Forms.Timer(Me.components)
        Me.Player2 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.toxic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toxic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blueplat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Yellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Yellow_plat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.purpleplat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'WalkTime
        '
        Me.WalkTime.Enabled = True
        Me.WalkTime.Interval = 300
        '
        'toxic1
        '
        Me.toxic1.BackColor = System.Drawing.Color.Transparent
        Me.toxic1.BackgroundImage = Global.test2.My.Resources.Resources.化學池
        Me.toxic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.toxic1.Image = Global.test2.My.Resources.Resources.化學池
        Me.toxic1.Location = New System.Drawing.Point(27, 409)
        Me.toxic1.Name = "toxic1"
        Me.toxic1.Size = New System.Drawing.Size(165, 34)
        Me.toxic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.toxic1.TabIndex = 0
        Me.toxic1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox2.Location = New System.Drawing.Point(190, 409)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(97, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox3.Location = New System.Drawing.Point(271, 544)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox4.Location = New System.Drawing.Point(368, 544)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.test2.My.Resources.Resources.雪地磚
        Me.PictureBox5.Location = New System.Drawing.Point(465, 543)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.test2.My.Resources.Resources.雪地磚
        Me.PictureBox6.Location = New System.Drawing.Point(563, 543)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox7.Location = New System.Drawing.Point(660, 543)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox8.Location = New System.Drawing.Point(782, 437)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(124, 30)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'toxic2
        '
        Me.toxic2.BackColor = System.Drawing.Color.Transparent
        Me.toxic2.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.toxic2.Location = New System.Drawing.Point(902, 437)
        Me.toxic2.Name = "toxic2"
        Me.toxic2.Size = New System.Drawing.Size(105, 30)
        Me.toxic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.toxic2.TabIndex = 8
        Me.toxic2.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox10.Location = New System.Drawing.Point(1007, 437)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(105, 30)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 9
        Me.PictureBox10.TabStop = False
        '
        'fence
        '
        Me.fence.BackColor = System.Drawing.Color.Transparent
        Me.fence.Image = Global.test2.My.Resources.Resources.柵欄
        Me.fence.Location = New System.Drawing.Point(787, 468)
        Me.fence.Name = "fence"
        Me.fence.Size = New System.Drawing.Size(119, 195)
        Me.fence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fence.TabIndex = 10
        Me.fence.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox12.Location = New System.Drawing.Point(396, 354)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(117, 30)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 11
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox13.Location = New System.Drawing.Point(510, 354)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(120, 30)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 12
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox14.Location = New System.Drawing.Point(627, 354)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(109, 30)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 13
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox15.Location = New System.Drawing.Point(174, 163)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 14
        Me.PictureBox15.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox16.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox16.Location = New System.Drawing.Point(271, 163)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 15
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox17.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox17.Location = New System.Drawing.Point(492, 187)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(90, 30)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 16
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox18.Image = Global.test2.My.Resources.Resources.磚__2_
        Me.PictureBox18.Location = New System.Drawing.Point(576, 187)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(90, 30)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 17
        Me.PictureBox18.TabStop = False
        '
        'Blue
        '
        Me.Blue.BackColor = System.Drawing.Color.Transparent
        Me.Blue.Image = Global.test2.My.Resources.Resources.按鈕_藍
        Me.Blue.Location = New System.Drawing.Point(992, 643)
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(60, 20)
        Me.Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Blue.TabIndex = 18
        Me.Blue.TabStop = False
        '
        'blueplat
        '
        Me.blueplat.BackColor = System.Drawing.Color.Transparent
        Me.blueplat.Image = Global.test2.My.Resources.Resources.移動平台_藍
        Me.blueplat.Location = New System.Drawing.Point(74, 163)
        Me.blueplat.Name = "blueplat"
        Me.blueplat.Size = New System.Drawing.Size(100, 30)
        Me.blueplat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.blueplat.TabIndex = 19
        Me.blueplat.TabStop = False
        '
        'Yellow
        '
        Me.Yellow.BackColor = System.Drawing.Color.Transparent
        Me.Yellow.Image = Global.test2.My.Resources.Resources.按鈕_黃
        Me.Yellow.Location = New System.Drawing.Point(661, 337)
        Me.Yellow.Name = "Yellow"
        Me.Yellow.Size = New System.Drawing.Size(60, 20)
        Me.Yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Yellow.TabIndex = 20
        Me.Yellow.TabStop = False
        '
        'Yellow_plat
        '
        Me.Yellow_plat.BackColor = System.Drawing.Color.Transparent
        Me.Yellow_plat.Image = Global.test2.My.Resources.Resources.移動平台_黃
        Me.Yellow_plat.Location = New System.Drawing.Point(754, 382)
        Me.Yellow_plat.Name = "Yellow_plat"
        Me.Yellow_plat.Size = New System.Drawing.Size(115, 30)
        Me.Yellow_plat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Yellow_plat.TabIndex = 21
        Me.Yellow_plat.TabStop = False
        '
        'Purple
        '
        Me.Purple.BackColor = System.Drawing.Color.Transparent
        Me.Purple.Image = Global.test2.My.Resources.Resources.按鈕_紫
        Me.Purple.Location = New System.Drawing.Point(245, 146)
        Me.Purple.Name = "Purple"
        Me.Purple.Size = New System.Drawing.Size(60, 20)
        Me.Purple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Purple.TabIndex = 22
        Me.Purple.TabStop = False
        '
        'purpleplat
        '
        Me.purpleplat.BackColor = System.Drawing.Color.Transparent
        Me.purpleplat.Image = Global.test2.My.Resources.Resources.移動平台_紫_直
        Me.purpleplat.Location = New System.Drawing.Point(660, 102)
        Me.purpleplat.Name = "purpleplat"
        Me.purpleplat.Size = New System.Drawing.Size(30, 115)
        Me.purpleplat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.purpleplat.TabIndex = 23
        Me.purpleplat.TabStop = False
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox25.Image = Global.test2.My.Resources.Resources.磚__直
        Me.PictureBox25.Location = New System.Drawing.Point(458, 34)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(35, 191)
        Me.PictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox25.TabIndex = 24
        Me.PictureBox25.TabStop = False
        '
        'door
        '
        Me.door.BackColor = System.Drawing.Color.Transparent
        Me.door.Image = Global.test2.My.Resources.Resources.門_關
        Me.door.Location = New System.Drawing.Point(549, 75)
        Me.door.Name = "door"
        Me.door.Size = New System.Drawing.Size(72, 119)
        Me.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.door.TabIndex = 25
        Me.door.TabStop = False
        '
        'PictureBox27
        '
        Me.PictureBox27.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox27.Image = Global.test2.My.Resources.Resources.通關星星
        Me.PictureBox27.Location = New System.Drawing.Point(968, 512)
        Me.PictureBox27.Name = "PictureBox27"
        Me.PictureBox27.Size = New System.Drawing.Size(53, 53)
        Me.PictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox27.TabIndex = 26
        Me.PictureBox27.TabStop = False
        '
        'PictureBox28
        '
        Me.PictureBox28.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox28.Image = Global.test2.My.Resources.Resources.通關星星
        Me.PictureBox28.Location = New System.Drawing.Point(298, 53)
        Me.PictureBox28.Name = "PictureBox28"
        Me.PictureBox28.Size = New System.Drawing.Size(53, 53)
        Me.PictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox28.TabIndex = 27
        Me.PictureBox28.TabStop = False
        '
        'PictureBox29
        '
        Me.PictureBox29.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox29.Image = Global.test2.My.Resources.Resources.通關星星
        Me.PictureBox29.Location = New System.Drawing.Point(1028, 364)
        Me.PictureBox29.Name = "PictureBox29"
        Me.PictureBox29.Size = New System.Drawing.Size(53, 53)
        Me.PictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox29.TabIndex = 28
        Me.PictureBox29.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.test2.My.Resources.Resources.招牌_removebg_preview
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1070, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 45)
        Me.Button1.TabIndex = 29
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Player1
        '
        Me.Player1.Enabled = True
        Me.Player1.Location = New System.Drawing.Point(12, 12)
        Me.Player1.Name = "Player1"
        Me.Player1.OcxState = CType(resources.GetObject("Player1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player1.Size = New System.Drawing.Size(75, 23)
        Me.Player1.TabIndex = 32
        Me.Player1.Visible = False
        '
        'fencetime
        '
        Me.fencetime.Enabled = True
        Me.fencetime.Interval = 2000
        '
        'Player2
        '
        Me.Player2.Enabled = True
        Me.Player2.Location = New System.Drawing.Point(968, 12)
        Me.Player2.Name = "Player2"
        Me.Player2.OcxState = CType(resources.GetObject("Player2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player2.Size = New System.Drawing.Size(75, 23)
        Me.Player2.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.test2.My.Resources.Resources.背景
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1132, 703)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox29)
        Me.Controls.Add(Me.PictureBox28)
        Me.Controls.Add(Me.PictureBox27)
        Me.Controls.Add(Me.door)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.purpleplat)
        Me.Controls.Add(Me.Purple)
        Me.Controls.Add(Me.Yellow_plat)
        Me.Controls.Add(Me.Yellow)
        Me.Controls.Add(Me.blueplat)
        Me.Controls.Add(Me.Blue)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.fence)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.toxic2)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.toxic1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.toxic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toxic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blueplat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Yellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Yellow_plat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.purpleplat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents WalkTime As Timer

    Friend WithEvents toxic1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents toxic2 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents fence As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents Blue As PictureBox
    Friend WithEvents blueplat As PictureBox
    Friend WithEvents Yellow As PictureBox
    Friend WithEvents Yellow_plat As PictureBox
    Friend WithEvents Purple As PictureBox
    Friend WithEvents purpleplat As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents door As PictureBox
    Friend WithEvents PictureBox27 As PictureBox
    Friend WithEvents PictureBox28 As PictureBox
    Friend WithEvents PictureBox29 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Player1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents fencetime As Timer
    Friend WithEvents Player2 As AxWMPLib.AxWindowsMediaPlayer
End Class
