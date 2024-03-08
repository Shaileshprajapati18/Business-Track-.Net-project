<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Panel1 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        Panel3 = New Panel()
        BtnReport = New Button()
        BtnPurchase = New Button()
        BtnSale = New Button()
        BtnCustomer = New Button()
        BtnHome = New Button()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 636)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1370, 35)
        Panel1.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = Color.Transparent
        DateTimePicker1.CalendarTitleBackColor = Color.Transparent
        DateTimePicker1.CalendarTrailingForeColor = Color.Gray
        DateTimePicker1.Location = New Point(1222, 1)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(141, 26)
        DateTimePicker1.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.CausesValidation = False
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(81, 7)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(115, 19)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Admin"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 18)
        Label1.TabIndex = 0
        Label1.Text = "Username : "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel2.Controls.Add(Label6)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1370, 36)
        Panel2.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 15F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(600, 5)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 24)
        Label6.TabIndex = 0
        Label6.Text = "Business Track"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel3.Controls.Add(BtnReport)
        Panel3.Controls.Add(BtnPurchase)
        Panel3.Controls.Add(BtnSale)
        Panel3.Controls.Add(BtnCustomer)
        Panel3.Controls.Add(BtnHome)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 36)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(208, 600)
        Panel3.TabIndex = 2
        ' 
        ' BtnReport
        ' 
        BtnReport.Cursor = Cursors.Hand
        BtnReport.Dock = DockStyle.Top
        BtnReport.FlatStyle = FlatStyle.Popup
        BtnReport.Font = New Font("Calibri", 12F, FontStyle.Bold)
        BtnReport.ForeColor = Color.White
        BtnReport.Image = My.Resources.Resources.file
        BtnReport.ImageAlign = ContentAlignment.MiddleLeft
        BtnReport.Location = New Point(0, 240)
        BtnReport.Margin = New Padding(3, 4, 3, 4)
        BtnReport.Name = "BtnReport"
        BtnReport.Padding = New Padding(11, 0, 0, 0)
        BtnReport.Size = New Size(208, 60)
        BtnReport.TabIndex = 7
        BtnReport.Text = " REPORT"
        BtnReport.TextAlign = ContentAlignment.MiddleLeft
        BtnReport.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnReport.UseVisualStyleBackColor = True
        ' 
        ' BtnPurchase
        ' 
        BtnPurchase.Cursor = Cursors.Hand
        BtnPurchase.Dock = DockStyle.Top
        BtnPurchase.FlatStyle = FlatStyle.Popup
        BtnPurchase.Font = New Font("Calibri", 12F, FontStyle.Bold)
        BtnPurchase.ForeColor = Color.White
        BtnPurchase.Image = My.Resources.Resources.cart
        BtnPurchase.ImageAlign = ContentAlignment.MiddleLeft
        BtnPurchase.Location = New Point(0, 180)
        BtnPurchase.Margin = New Padding(3, 4, 3, 4)
        BtnPurchase.Name = "BtnPurchase"
        BtnPurchase.Padding = New Padding(11, 0, 0, 0)
        BtnPurchase.Size = New Size(208, 60)
        BtnPurchase.TabIndex = 6
        BtnPurchase.Text = " PURCHASE"
        BtnPurchase.TextAlign = ContentAlignment.MiddleLeft
        BtnPurchase.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnPurchase.UseVisualStyleBackColor = True
        ' 
        ' BtnSale
        ' 
        BtnSale.Cursor = Cursors.Hand
        BtnSale.Dock = DockStyle.Top
        BtnSale.FlatStyle = FlatStyle.Popup
        BtnSale.Font = New Font("Calibri", 12F, FontStyle.Bold)
        BtnSale.ForeColor = Color.White
        BtnSale.Image = My.Resources.Resources.discount
        BtnSale.ImageAlign = ContentAlignment.MiddleLeft
        BtnSale.Location = New Point(0, 120)
        BtnSale.Margin = New Padding(3, 4, 3, 4)
        BtnSale.Name = "BtnSale"
        BtnSale.Padding = New Padding(11, 0, 0, 0)
        BtnSale.Size = New Size(208, 60)
        BtnSale.TabIndex = 5
        BtnSale.Text = " SALE"
        BtnSale.TextAlign = ContentAlignment.MiddleLeft
        BtnSale.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnSale.UseVisualStyleBackColor = True
        ' 
        ' BtnCustomer
        ' 
        BtnCustomer.Cursor = Cursors.Hand
        BtnCustomer.Dock = DockStyle.Top
        BtnCustomer.FlatStyle = FlatStyle.Popup
        BtnCustomer.Font = New Font("Calibri", 12F, FontStyle.Bold)
        BtnCustomer.ForeColor = Color.White
        BtnCustomer.Image = My.Resources.Resources.customer
        BtnCustomer.ImageAlign = ContentAlignment.MiddleLeft
        BtnCustomer.Location = New Point(0, 60)
        BtnCustomer.Margin = New Padding(3, 4, 3, 4)
        BtnCustomer.Name = "BtnCustomer"
        BtnCustomer.Padding = New Padding(11, 0, 0, 0)
        BtnCustomer.Size = New Size(208, 60)
        BtnCustomer.TabIndex = 3
        BtnCustomer.Text = "CUSTOMER"
        BtnCustomer.TextAlign = ContentAlignment.MiddleLeft
        BtnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCustomer.UseVisualStyleBackColor = True
        ' 
        ' BtnHome
        ' 
        BtnHome.Cursor = Cursors.Hand
        BtnHome.Dock = DockStyle.Top
        BtnHome.FlatStyle = FlatStyle.Popup
        BtnHome.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnHome.ForeColor = Color.White
        BtnHome.Image = My.Resources.Resources.home
        BtnHome.ImageAlign = ContentAlignment.MiddleLeft
        BtnHome.Location = New Point(0, 0)
        BtnHome.Margin = New Padding(3, 4, 3, 4)
        BtnHome.Name = "BtnHome"
        BtnHome.Padding = New Padding(11, 0, 0, 0)
        BtnHome.Size = New Size(208, 60)
        BtnHome.TabIndex = 2
        BtnHome.Text = " HOME"
        BtnHome.TextAlign = ContentAlignment.MiddleLeft
        BtnHome.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnHome.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Silver
        Panel4.Location = New Point(214, 52)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1225, 584)
        Panel4.TabIndex = 3
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(1370, 671)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "Main"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Business Track"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnReport As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnPurchase As Button
    Friend WithEvents BtnCustomer As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnSale As Button
End Class
