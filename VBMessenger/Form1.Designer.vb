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
        btnSend = New Button()
        Label1 = New Label()
        receiver = New TextBox()
        message = New TextBox()
        Label2 = New Label()
        status = New TextBox()
        Label3 = New Label()
        passwd = New TextBox()
        Label4 = New Label()
        phoneNo = New TextBox()
        Label5 = New Label()
        name = New TextBox()
        Label6 = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' btnSend
        ' 
        btnSend.Location = New Point(438, 286)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(75, 23)
        btnSend.TabIndex = 2
        btnSend.Text = "&Send"
        btnSend.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(87, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 22)
        Label1.TabIndex = 1
        Label1.Text = "To:"
        ' 
        ' receiver
        ' 
        receiver.Location = New Point(132, 106)
        receiver.Name = "receiver"
        receiver.Size = New Size(159, 23)
        receiver.TabIndex = 0
        ' 
        ' message
        ' 
        message.Location = New Point(132, 161)
        message.Multiline = True
        message.Name = "message"
        message.Size = New Size(381, 119)
        message.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(35, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 22)
        Label2.TabIndex = 3
        Label2.Text = "Message:"
        ' 
        ' status
        ' 
        status.Cursor = Cursors.IBeam
        status.Location = New Point(132, 315)
        status.Multiline = True
        status.Name = "status"
        status.ScrollBars = ScrollBars.Vertical
        status.Size = New Size(381, 119)
        status.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Cursor = Cursors.Help
        Label3.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(51, 315)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 22)
        Label3.TabIndex = 5
        Label3.Text = "Status:"
        ' 
        ' passwd
        ' 
        passwd.Location = New Point(132, 572)
        passwd.Name = "passwd"
        passwd.PasswordChar = "●"c
        passwd.Size = New Size(184, 23)
        passwd.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(20, 572)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 22)
        Label4.TabIndex = 7
        Label4.Text = "Password:"
        ' 
        ' phoneNo
        ' 
        phoneNo.Location = New Point(132, 516)
        phoneNo.Name = "phoneNo"
        phoneNo.Size = New Size(159, 23)
        phoneNo.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(37, 516)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 22)
        Label5.TabIndex = 9
        Label5.Text = "Number:"
        ' 
        ' name
        ' 
        name.Location = New Point(132, 462)
        name.Name = "name"
        name.Size = New Size(159, 23)
        name.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(57, 463)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 22)
        Label6.TabIndex = 11
        Label6.Text = "Name:"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(438, 622)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 12
        btnLogin.Text = "&Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(552, 657)
        Controls.Add(btnLogin)
        Controls.Add(name)
        Controls.Add(Label6)
        Controls.Add(phoneNo)
        Controls.Add(Label5)
        Controls.Add(passwd)
        Controls.Add(Label4)
        Controls.Add(status)
        Controls.Add(Label3)
        Controls.Add(message)
        Controls.Add(Label2)
        Controls.Add(receiver)
        Controls.Add(Label1)
        Controls.Add(btnSend)
        Name = "Form1"
        Text = "VBMessenger"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSend As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents receiver As TextBox
    Friend WithEvents message As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents status As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents passwd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents phoneNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogin As Button

End Class
