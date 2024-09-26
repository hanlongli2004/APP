Public Class Form1
    Dim initialMeHealth As Double = 100 ' 玩家初始血量
    Dim initialEnemyHealth As Double = 100 ' 敌人初始血量

    Dim meHealth As Double = 100 ' 玩家当前血量
    Dim enemyHealth As Double = 100 ' 敌人当前血量

    Dim enemyStartPos As Integer
    Dim enemySpeed As Integer = 10 ' 敌人移动速度
    Dim attackDistance As Integer = 20 ' 攻击后退距离

    Dim attacking As Boolean = False ' 攻击状态

    Private WithEvents EnemyMovementTimer As New Timer ' 声明为 WithEvents

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enemyStartPos = Me.Width - enemyPictureBox.Width
        enemyPictureBox.Left = enemyStartPos

        EnemyMovementTimer.Interval = 50 ' 调整计时器的间隔时间以控制移动速度
        EnemyMovementTimer.Start()

        ' 设置血条初始值为满血状态
        enemyHealthBar.Value = CInt(initialEnemyHealth)
        meHealthBar.Value = CInt(initialMeHealth)
    End Sub

    Private Sub EnemyMovementTimer_Tick(sender As Object, e As EventArgs) Handles EnemyMovementTimer.Tick
        If Not attacking Then
            enemyPictureBox.Left -= enemySpeed ' 调整移动速度

            ' 判定敌人是否到达我方角色的位置
            If enemyPictureBox.Left <= mePictureBox.Left + mePictureBox.Width Then
                EnemyMovementTimer.Stop() ' 攻击前停止移动
                Attack()
            End If

            ' 更新敵人血条位置
            enemyHealthBar.Left = enemyPictureBox.Left ' 將血条左侧与敌人角色的左侧对齐
        End If
    End Sub


    Private Sub CheckGameStatus()
        If enemyHealth <= 0 Or meHealth <= 0 Then
            Dim result As DialogResult = MessageBox.Show("是否重新开始游戏？", "游戏结束", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' 重新开始游戏
                RestartGame()
            Else
                ' 关闭窗口
                Me.Close()
            End If
        End If
    End Sub

    Private Sub RestartGame()
        ' 重新设置初始血量和当前血量
        meHealth = initialMeHealth
        enemyHealth = initialEnemyHealth

        ' 更新血条显示
        UpdateHealthBars()

        ' 重新启动敌人移动和攻击
        attacking = False
        EnemyMovementTimer.Start()
    End Sub

    Private Sub Attack()
        attacking = True ' 进入攻击状态

        ' 每次攻击扣除 10% 的血量
        enemyHealth -= initialEnemyHealth * 0.1
        meHealth -= initialMeHealth * 0.05 ' 假设敌人攻击也会造成我方角色的伤害

        ' 更新血条显示
        UpdateHealthBars()

        ' 敌人攻击后稍微后退一点再前进
        enemyPictureBox.Left += attackDistance

        ' 增加攻击之间的延迟
        System.Threading.Thread.Sleep(500) ' 延迟500毫秒

        ' 判定是否还有血量，若有则继续攻击
        If enemyHealth > 0 And meHealth > 0 Then
            attacking = False ' 退出攻击状态
            EnemyMovementTimer.Start() ' 重新启动敌人移动
        Else
            CheckGameStatus() ' 检查游戏状态
        End If
    End Sub

    Private Sub UpdateHealthBars()
        ' 更新血条显示的代码
        enemyHealthBar.Value = CInt(enemyHealth)
        meHealthBar.Value = CInt(meHealth)
    End Sub

End Class
