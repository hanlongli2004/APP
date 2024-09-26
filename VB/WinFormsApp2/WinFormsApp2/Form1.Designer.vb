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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(366, 45)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 63)
        Button1.TabIndex = 0
        Button1.Text = "確定"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(366, 234)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 63)
        Button2.TabIndex = 1
        Button2.Text = "離開"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(366, 141)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 63)
        Button3.TabIndex = 2
        Button3.Text = "重填"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(78, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 25)
        Label1.TabIndex = 3
        Label1.Text = "請選擇一位使用者"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("微軟正黑體", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(78, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 25)
        Label2.TabIndex = 4
        Label2.Text = "使用者密碼"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Alice", "John", "Ray"})
        ComboBox1.Location = New Point(78, 120)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 27)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(78, 234)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(554, 344)
        ControlBox = False
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "請登入"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
