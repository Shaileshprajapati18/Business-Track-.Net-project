<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Panel5 = New Panel()
        Label2 = New Label()
        Panel7 = New Panel()
        Label4 = New Label()
        TxtTotalHomeP = New TextBox()
        TxtTotalHomeS = New TextBox()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(TxtTotalHomeS)
        Panel5.Location = New Point(286, 220)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(227, 109)
        Panel5.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(50, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 33)
        Label2.TabIndex = 4
        Label2.Text = "Total Sale"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Red
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(TxtTotalHomeP)
        Panel7.Location = New Point(586, 222)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(227, 109)
        Panel7.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 20F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(18, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 33)
        Label4.TabIndex = 4
        Label4.Text = "Total Purchase"
        ' 
        ' TxtTotalHomeP
        ' 
        TxtTotalHomeP.BackColor = Color.White
        TxtTotalHomeP.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtTotalHomeP.ForeColor = Color.Black
        TxtTotalHomeP.Location = New Point(0, 59)
        TxtTotalHomeP.Multiline = True
        TxtTotalHomeP.Name = "TxtTotalHomeP"
        TxtTotalHomeP.ReadOnly = True
        TxtTotalHomeP.Size = New Size(227, 50)
        TxtTotalHomeP.TabIndex = 3
        TxtTotalHomeP.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtTotalHomeS
        ' 
        TxtTotalHomeS.BackColor = Color.White
        TxtTotalHomeS.BorderStyle = BorderStyle.FixedSingle
        TxtTotalHomeS.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtTotalHomeS.ForeColor = Color.Black
        TxtTotalHomeS.Location = New Point(-1, 59)
        TxtTotalHomeS.Multiline = True
        TxtTotalHomeS.Name = "TxtTotalHomeS"
        TxtTotalHomeS.ReadOnly = True
        TxtTotalHomeS.Size = New Size(227, 50)
        TxtTotalHomeS.TabIndex = 3
        TxtTotalHomeS.TextAlign = HorizontalAlignment.Center
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(854, 506)
        ControlBox = False
        Controls.Add(Panel7)
        Controls.Add(Panel5)
        FormBorderStyle = FormBorderStyle.None
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTotalHomeP As TextBox
    Friend WithEvents TxtTotalHomeS As TextBox

End Class
