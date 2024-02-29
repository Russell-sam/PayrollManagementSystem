<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bank_details
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
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        TextBox8 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 15)
        Label1.TabIndex = 0
        Label1.Text = "id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 15)
        Label2.TabIndex = 1
        Label2.Text = "Bank"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 2
        Label3.Text = "staff_no"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 3
        Label4.Text = "account_no"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(28, 177)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 15)
        Label6.TabIndex = 5
        Label6.Text = "account_name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(124, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(124, 140)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(124, 102)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(124, 174)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(124, 68)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(114, 227)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 14
        Button1.Text = "submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' bank_details
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox8)
        Controls.Add(TextBox5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "bank_details"
        Text = "bank_details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
End Class
