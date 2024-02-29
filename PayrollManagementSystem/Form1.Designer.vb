<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        txt_username = New TextBox()
        txt_password = New TextBox()
        btn_login = New Button()
        btn_close = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(153, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 21)
        Label1.TabIndex = 0
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(153, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 21)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD"
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(291, 69)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(221, 23)
        txt_username.TabIndex = 2
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(291, 142)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(221, 23)
        txt_password.TabIndex = 3
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(249, 215)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(75, 23)
        btn_login.TabIndex = 4
        btn_login.Text = "LOGIN"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_close
        ' 
        btn_close.Location = New Point(420, 215)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 23)
        btn_close.TabIndex = 5
        btn_close.Text = "CLOSE"
        btn_close.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_close)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_close As Button
End Class
