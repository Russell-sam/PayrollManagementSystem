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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        txt_username = New TextBox()
        txt_password = New TextBox()
        btn_login = New Button()
        btn_close = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(169, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 21)
        Label1.TabIndex = 0
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(167, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 21)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD"
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(291, 118)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(221, 23)
        txt_username.TabIndex = 2
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(291, 185)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(221, 23)
        txt_password.TabIndex = 3
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = SystemColors.ButtonHighlight
        btn_login.Location = New Point(291, 237)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(75, 23)
        btn_login.TabIndex = 4
        btn_login.Text = "LOGIN"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = SystemColors.ButtonHighlight
        btn_close.Location = New Point(437, 237)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(75, 23)
        btn_close.TabIndex = 5
        btn_close.Text = "CLOSE"
        btn_close.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(339, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 79)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btn_close)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
