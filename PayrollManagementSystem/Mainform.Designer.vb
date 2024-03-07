<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Mainform))
        Label1 = New Label()
        Panel1 = New Panel()
        Panel4 = New Panel()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button4 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(259, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(475, 86)
        Label1.TabIndex = 0
        Label1.Text = "Payroll System"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 450)
        Panel1.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(Button3)
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(Button2)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 112)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 338)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(12, 132)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 44)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 8
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(12, 44)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 44)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 88)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 44)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 44)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Top
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(214), CByte(229))
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(139), CByte(149), CByte(162))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Microsoft New Tai Lue", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(0, 132)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(3, 0, 0, 0)
        Button4.Size = New Size(200, 44)
        Button4.TabIndex = 4
        Button4.Text = "Log Out"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Top
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(214), CByte(229))
        Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(139), CByte(149), CByte(162))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Microsoft New Tai Lue", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(0, 88)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(5, 0, 0, 0)
        Button3.Size = New Size(200, 44)
        Button3.TabIndex = 3
        Button3.Text = "Bank details"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(214), CByte(229))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(139), CByte(149), CByte(162))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft New Tai Lue", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(0, 44)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(5, 0, 0, 0)
        Button1.Size = New Size(200, 44)
        Button1.TabIndex = 2
        Button1.Text = "Groups"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Top
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(214), CByte(229))
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(139), CByte(149), CByte(162))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft New Tai Lue", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(0, 0)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(5, 0, 0, 0)
        Button2.Size = New Size(200, 44)
        Button2.TabIndex = 1
        Button2.Text = "Staff"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 46)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 66)
        Panel3.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(34), CByte(47), CByte(62))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 46)
        Panel2.TabIndex = 0
        ' 
        ' Mainform
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Mainform"
        Text = "Mainform"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
