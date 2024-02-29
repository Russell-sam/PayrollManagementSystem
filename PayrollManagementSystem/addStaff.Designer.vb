<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStaff
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox8 = New TextBox()
        TextBox12 = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label13 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(154, 9)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(154, 38)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(154, 109)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(154, 151)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(154, 180)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(154, 226)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(154, 80)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 7
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(154, 263)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(100, 23)
        TextBox12.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 12
        Label1.Text = "staff_no"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 14
        Label3.Text = "email"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(35, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(49, 15)
        Label10.TabIndex = 21
        Label10.Text = "job_title"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(41, 37)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 15)
        Label11.TabIndex = 22
        Label11.Text = "Firstname"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(41, 79)
        Label13.Name = "Label13"
        Label13.Size = New Size(55, 15)
        Label13.TabIndex = 24
        Label13.Text = "lastname"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(35, 188)
        Label19.Name = "Label19"
        Label19.Size = New Size(38, 15)
        Label19.TabIndex = 30
        Label19.Text = "Salary"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(43, 266)
        Label20.Name = "Label20"
        Label20.Size = New Size(70, 15)
        Label20.TabIndex = 31
        Label20.Text = "Department"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(25, 218)
        Label21.Name = "Label21"
        Label21.Size = New Size(40, 15)
        Label21.TabIndex = 32
        Label21.Text = "Group"
        ' 
        ' addStaff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TextBox12)
        Controls.Add(TextBox8)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "addStaff"
        Text = "addStaff"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
End Class
