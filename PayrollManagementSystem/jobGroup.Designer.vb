<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jobGroup
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 1
        Label2.Text = "Account number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 2
        Label3.Text = "Basic Salary"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(57, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 15)
        Label4.TabIndex = 3
        Label4.Text = "Total allowances"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(57, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 4
        Label5.Text = "Total Deductions"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(59, 196)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 15)
        Label6.TabIndex = 5
        Label6.Text = "Total Amount Paid"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(199, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(199, 94)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(198, 122)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(198, 154)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(198, 193)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(398, 92)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 12
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(398, 126)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 15
        Button4.Text = "Refresh"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(398, 162)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 29)
        Button2.TabIndex = 16
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' jobGroup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "jobGroup"
        Text = "jobGroup"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
End Class
