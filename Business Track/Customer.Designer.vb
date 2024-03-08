<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtCustName = New TextBox()
        TxtCustAddress = New TextBox()
        TxtContactPerson = New TextBox()
        TxtPhoneNumber = New TextBox()
        Panel1 = New Panel()
        BtnExit = New Button()
        BtnDelete = New Button()
        BtnEdit = New Button()
        BtnFind = New Button()
        BtnAdd = New Button()
        BtnSave = New Button()
        Panel2 = New Panel()
        ShowReport = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Silver
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label1.Location = New Point(75, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 19)
        Label1.TabIndex = 0
        Label1.Text = "Customer Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label2.Location = New Point(75, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 19)
        Label2.TabIndex = 1
        Label2.Text = "Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Silver
        Label3.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label3.Location = New Point(75, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 19)
        Label3.TabIndex = 2
        Label3.Text = "Contact Person"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Silver
        Label4.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label4.Location = New Point(75, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 19)
        Label4.TabIndex = 3
        Label4.Text = "Phone Number"
        ' 
        ' TxtCustName
        ' 
        TxtCustName.Cursor = Cursors.IBeam
        TxtCustName.Location = New Point(75, 134)
        TxtCustName.Name = "TxtCustName"
        TxtCustName.Size = New Size(301, 23)
        TxtCustName.TabIndex = 4
        ' 
        ' TxtCustAddress
        ' 
        TxtCustAddress.Cursor = Cursors.IBeam
        TxtCustAddress.Location = New Point(75, 194)
        TxtCustAddress.Name = "TxtCustAddress"
        TxtCustAddress.Size = New Size(301, 23)
        TxtCustAddress.TabIndex = 5
        ' 
        ' TxtContactPerson
        ' 
        TxtContactPerson.Cursor = Cursors.IBeam
        TxtContactPerson.Location = New Point(75, 260)
        TxtContactPerson.Name = "TxtContactPerson"
        TxtContactPerson.Size = New Size(301, 23)
        TxtContactPerson.TabIndex = 7
        ' 
        ' TxtPhoneNumber
        ' 
        TxtPhoneNumber.Cursor = Cursors.IBeam
        TxtPhoneNumber.Location = New Point(75, 323)
        TxtPhoneNumber.Name = "TxtPhoneNumber"
        TxtPhoneNumber.Size = New Size(301, 23)
        TxtPhoneNumber.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(BtnExit)
        Panel1.Controls.Add(BtnDelete)
        Panel1.Controls.Add(BtnEdit)
        Panel1.Controls.Add(BtnFind)
        Panel1.Controls.Add(BtnAdd)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1386, 71)
        Panel1.TabIndex = 9
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.White
        BtnExit.FlatStyle = FlatStyle.Flat
        BtnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnExit.ForeColor = Color.Black
        BtnExit.Image = My.Resources.Resources.cross
        BtnExit.ImageAlign = ContentAlignment.TopCenter
        BtnExit.Location = New Point(351, 3)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(63, 63)
        BtnExit.TabIndex = 4
        BtnExit.TabStop = False
        BtnExit.Text = "Exit"
        BtnExit.TextAlign = ContentAlignment.BottomCenter
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.White
        BtnDelete.FlatStyle = FlatStyle.Flat
        BtnDelete.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnDelete.ForeColor = Color.Black
        BtnDelete.Image = My.Resources.Resources.bin
        BtnDelete.ImageAlign = ContentAlignment.TopCenter
        BtnDelete.Location = New Point(282, 3)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(63, 63)
        BtnDelete.TabIndex = 3
        BtnDelete.TabStop = False
        BtnDelete.Text = "Delete"
        BtnDelete.TextAlign = ContentAlignment.BottomCenter
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' BtnEdit
        ' 
        BtnEdit.BackColor = Color.White
        BtnEdit.FlatStyle = FlatStyle.Flat
        BtnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEdit.ForeColor = Color.Black
        BtnEdit.Image = My.Resources.Resources.pen
        BtnEdit.ImageAlign = ContentAlignment.TopCenter
        BtnEdit.Location = New Point(144, 3)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(63, 63)
        BtnEdit.TabIndex = 2
        BtnEdit.TabStop = False
        BtnEdit.Text = "Edit"
        BtnEdit.TextAlign = ContentAlignment.BottomCenter
        BtnEdit.UseVisualStyleBackColor = False
        ' 
        ' BtnFind
        ' 
        BtnFind.BackColor = Color.White
        BtnFind.FlatStyle = FlatStyle.Flat
        BtnFind.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnFind.ForeColor = Color.Black
        BtnFind.Image = My.Resources.Resources.find
        BtnFind.ImageAlign = ContentAlignment.TopCenter
        BtnFind.Location = New Point(213, 3)
        BtnFind.Name = "BtnFind"
        BtnFind.Size = New Size(63, 63)
        BtnFind.TabIndex = 1
        BtnFind.TabStop = False
        BtnFind.Text = "Find"
        BtnFind.TextAlign = ContentAlignment.BottomCenter
        BtnFind.UseVisualStyleBackColor = False
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.White
        BtnAdd.FlatStyle = FlatStyle.Flat
        BtnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAdd.ForeColor = Color.Black
        BtnAdd.Image = My.Resources.Resources.add_file__1_
        BtnAdd.ImageAlign = ContentAlignment.TopCenter
        BtnAdd.Location = New Point(75, 3)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(63, 63)
        BtnAdd.TabIndex = 0
        BtnAdd.TabStop = False
        BtnAdd.Text = "Add"
        BtnAdd.TextAlign = ContentAlignment.BottomCenter
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.White
        BtnSave.FlatStyle = FlatStyle.Flat
        BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSave.ForeColor = Color.Black
        BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), Image)
        BtnSave.ImageAlign = ContentAlignment.TopCenter
        BtnSave.Location = New Point(201, 367)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(63, 63)
        BtnSave.TabIndex = 10
        BtnSave.TabStop = False
        BtnSave.Text = "Save"
        BtnSave.TextAlign = ContentAlignment.BottomCenter
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(461, 134)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(504, 333)
        Panel2.TabIndex = 11
        ' 
        ' ShowReport
        ' 
        ShowReport.Location = New Point(411, 92)
        ShowReport.Name = "ShowReport"
        ShowReport.Size = New Size(1225, 584)
        ShowReport.TabIndex = 5
        ' 
        ' Customer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(1386, 710)
        ControlBox = False
        Controls.Add(ShowReport)
        Controls.Add(Panel2)
        Controls.Add(BtnSave)
        Controls.Add(Panel1)
        Controls.Add(TxtPhoneNumber)
        Controls.Add(TxtContactPerson)
        Controls.Add(TxtCustAddress)
        Controls.Add(TxtCustName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Customer"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCustName As TextBox
    Friend WithEvents TxtCustAddress As TextBox
    Friend WithEvents TxtContactPerson As TextBox
    Friend WithEvents TxtPhoneNumber As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnFind As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShowReport As Panel
End Class
