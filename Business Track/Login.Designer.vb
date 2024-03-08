<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label3 = New Label()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        BtnLogin = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        BtnExit = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label1.Location = New Point(30, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 19)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label3.Location = New Point(30, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 19)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(33, 74)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(378, 23)
        TxtUsername.TabIndex = 3
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(33, 134)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(378, 23)
        TxtPassword.TabIndex = 4
        TxtPassword.UseSystemPasswordChar = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.Blue
        BtnLogin.Font = New Font("Calibri", 12F, FontStyle.Bold)
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(255, 179)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 32)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(BtnExit)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(BtnLogin)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TxtPassword)
        Panel1.Controls.Add(TxtUsername)
        Panel1.Location = New Point(464, 240)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(434, 219)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(434, 31)
        Panel2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Calibri", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(185, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 23)
        Label2.TabIndex = 0
        Label2.Text = "Login"
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        BtnExit.Font = New Font("Calibri", 12F, FontStyle.Bold)
        BtnExit.ForeColor = Color.White
        BtnExit.Location = New Point(336, 179)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(75, 32)
        BtnExit.TabIndex = 6
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.loginback1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1084, 561)
        Controls.Add(Panel1)
        Name = "Login"
        Text = "Login"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label

End Class
