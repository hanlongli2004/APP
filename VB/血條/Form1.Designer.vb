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
        meHealthBar = New ProgressBar()
        mePictureBox = New PictureBox()
        enemyPictureBox = New PictureBox()
        enemyHealthBar = New ProgressBar()
        Label1 = New Label()
        CType(mePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemyPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' meHealthBar
        ' 
        meHealthBar.BackColor = Color.Red
        meHealthBar.ForeColor = SystemColors.GrayText
        meHealthBar.Location = New Point(56, 38)
        meHealthBar.Name = "meHealthBar"
        meHealthBar.Size = New Size(684, 19)
        meHealthBar.Step = 0
        meHealthBar.TabIndex = 0
        ' 
        ' mePictureBox
        ' 
        mePictureBox.BackgroundImageLayout = ImageLayout.None
        mePictureBox.Image = My.Resources.Resources._me
        mePictureBox.Location = New Point(56, 130)
        mePictureBox.Name = "mePictureBox"
        mePictureBox.Size = New Size(193, 308)
        mePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        mePictureBox.TabIndex = 2
        mePictureBox.TabStop = False
        ' 
        ' enemyPictureBox
        ' 
        enemyPictureBox.BackgroundImageLayout = ImageLayout.Zoom
        enemyPictureBox.Image = My.Resources.Resources.enemy
        enemyPictureBox.Location = New Point(574, 161)
        enemyPictureBox.Name = "enemyPictureBox"
        enemyPictureBox.Size = New Size(131, 224)
        enemyPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        enemyPictureBox.TabIndex = 3
        enemyPictureBox.TabStop = False
        ' 
        ' enemyHealthBar
        ' 
        enemyHealthBar.BackColor = Color.Red
        enemyHealthBar.ForeColor = Color.Red
        enemyHealthBar.Location = New Point(574, 161)
        enemyHealthBar.Name = "enemyHealthBar"
        enemyHealthBar.Size = New Size(131, 19)
        enemyHealthBar.Step = 0
        enemyHealthBar.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 19)
        Label1.TabIndex = 5
        Label1.Text = "我方血量"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(enemyHealthBar)
        Controls.Add(enemyPictureBox)
        Controls.Add(mePictureBox)
        Controls.Add(meHealthBar)
        Name = "Form1"
        Text = "Form1"
        CType(mePictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(enemyPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents meHealthBar As ProgressBar
    Friend WithEvents enemyHealthBar As ProgressBar
    Public WithEvents mePictureBox As PictureBox
    Public WithEvents enemyPictureBox As PictureBox
    Friend WithEvents Label1 As Label
End Class
