<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase))
        Label4 = New Label()
        TxtInvoiceNo = New TextBox()
        BtnSave = New Button()
        Label5 = New Label()
        TxtDate = New TextBox()
        Panel2 = New Panel()
        Panel4 = New Panel()
        TxtGrandTotal = New TextBox()
        Label13 = New Label()
        Panel5 = New Panel()
        TxtTotal = New TextBox()
        TxtQuantity = New TextBox()
        Label15 = New Label()
        Panel6 = New Panel()
        TxtDiscount = New TextBox()
        Label14 = New Label()
        DataGridViewPurchase = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        BtnExit = New Button()
        BtnDelete = New Button()
        BtnEdit = New Button()
        BtnFind = New Button()
        BtnAdd = New Button()
        BtnPlus = New Button()
        Btnless = New Button()
        TxtSerialNo = New TextBox()
        TxtRate = New TextBox()
        TxtQty = New TextBox()
        TxtUnit = New TextBox()
        TxtDescription = New TextBox()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        CType(DataGridViewPurchase, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Silver
        Label4.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label4.Location = New Point(75, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 19)
        Label4.TabIndex = 3
        Label4.Text = "Invoice No."
        ' 
        ' TxtInvoiceNo
        ' 
        TxtInvoiceNo.Cursor = Cursors.IBeam
        TxtInvoiceNo.Location = New Point(75, 170)
        TxtInvoiceNo.Name = "TxtInvoiceNo"
        TxtInvoiceNo.Size = New Size(301, 23)
        TxtInvoiceNo.TabIndex = 7
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.White
        BtnSave.FlatStyle = FlatStyle.Flat
        BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSave.ForeColor = Color.Black
        BtnSave.Image = My.Resources.Resources.floppy_disk
        BtnSave.ImageAlign = ContentAlignment.TopCenter
        BtnSave.Location = New Point(185, 347)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(63, 63)
        BtnSave.TabIndex = 10
        BtnSave.TabStop = False
        BtnSave.Text = "Save"
        BtnSave.TextAlign = ContentAlignment.BottomCenter
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Silver
        Label5.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label5.Location = New Point(75, 229)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 19)
        Label5.TabIndex = 11
        Label5.Text = "Date"
        ' 
        ' TxtDate
        ' 
        TxtDate.Cursor = Cursors.IBeam
        TxtDate.Location = New Point(75, 251)
        TxtDate.Name = "TxtDate"
        TxtDate.Size = New Size(301, 23)
        TxtDate.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(DataGridViewPurchase)
        Panel2.Location = New Point(458, 142)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(565, 362)
        Panel2.TabIndex = 15
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel4.Controls.Add(TxtGrandTotal)
        Panel4.Controls.Add(Label13)
        Panel4.Location = New Point(0, 332)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(564, 25)
        Panel4.TabIndex = 5
        ' 
        ' TxtGrandTotal
        ' 
        TxtGrandTotal.BackColor = Color.White
        TxtGrandTotal.BorderStyle = BorderStyle.FixedSingle
        TxtGrandTotal.Location = New Point(470, -2)
        TxtGrandTotal.Multiline = True
        TxtGrandTotal.Name = "TxtGrandTotal"
        TxtGrandTotal.ReadOnly = True
        TxtGrandTotal.Size = New Size(94, 27)
        TxtGrandTotal.TabIndex = 4
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.FlatStyle = FlatStyle.Popup
        Label13.Font = New Font("Calibri", 14F, FontStyle.Bold)
        Label13.ForeColor = Color.White
        Label13.ImageAlign = ContentAlignment.TopLeft
        Label13.Location = New Point(364, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(100, 23)
        Label13.TabIndex = 2
        Label13.Text = "Grand Total"
        Label13.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel5.Controls.Add(TxtTotal)
        Panel5.Controls.Add(TxtQuantity)
        Panel5.Controls.Add(Label15)
        Panel5.Location = New Point(0, 242)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(564, 25)
        Panel5.TabIndex = 17
        ' 
        ' TxtTotal
        ' 
        TxtTotal.BackColor = Color.White
        TxtTotal.Location = New Point(470, -2)
        TxtTotal.Multiline = True
        TxtTotal.Name = "TxtTotal"
        TxtTotal.ReadOnly = True
        TxtTotal.Size = New Size(94, 27)
        TxtTotal.TabIndex = 4
        ' 
        ' TxtQuantity
        ' 
        TxtQuantity.BackColor = Color.White
        TxtQuantity.Location = New Point(384, -1)
        TxtQuantity.Multiline = True
        TxtQuantity.Name = "TxtQuantity"
        TxtQuantity.ReadOnly = True
        TxtQuantity.Size = New Size(52, 27)
        TxtQuantity.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.FlatStyle = FlatStyle.Popup
        Label15.Font = New Font("Calibri", 14F, FontStyle.Bold)
        Label15.ForeColor = Color.White
        Label15.ImageAlign = ContentAlignment.TopLeft
        Label15.Location = New Point(178, -1)
        Label15.Name = "Label15"
        Label15.Size = New Size(48, 23)
        Label15.TabIndex = 2
        Label15.Text = "Total"
        Label15.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel6.Controls.Add(TxtDiscount)
        Panel6.Controls.Add(Label14)
        Panel6.Location = New Point(0, 287)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(564, 25)
        Panel6.TabIndex = 17
        ' 
        ' TxtDiscount
        ' 
        TxtDiscount.BackColor = Color.White
        TxtDiscount.BorderStyle = BorderStyle.FixedSingle
        TxtDiscount.Location = New Point(470, -2)
        TxtDiscount.Multiline = True
        TxtDiscount.Name = "TxtDiscount"
        TxtDiscount.Size = New Size(94, 27)
        TxtDiscount.TabIndex = 4
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.FlatStyle = FlatStyle.Popup
        Label14.Font = New Font("Calibri", 14F, FontStyle.Bold)
        Label14.ForeColor = Color.White
        Label14.ImageAlign = ContentAlignment.TopLeft
        Label14.Location = New Point(384, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(80, 23)
        Label14.TabIndex = 2
        Label14.Text = "Discount"
        Label14.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' DataGridViewPurchase
        ' 
        DataGridViewPurchase.AllowUserToAddRows = False
        DataGridViewPurchase.AllowUserToDeleteRows = False
        DataGridViewPurchase.AllowUserToResizeColumns = False
        DataGridViewPurchase.AllowUserToResizeRows = False
        DataGridViewPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewPurchase.BackgroundColor = Color.White
        DataGridViewPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPurchase.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridViewPurchase.Location = New Point(0, 3)
        DataGridViewPurchase.Name = "DataGridViewPurchase"
        DataGridViewPurchase.ReadOnly = True
        DataGridViewPurchase.Size = New Size(562, 235)
        DataGridViewPurchase.TabIndex = 18
        ' 
        ' Column1
        ' 
        Column1.FillWeight = 60F
        Column1.HeaderText = "No"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Serial No"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.FillWeight = 250F
        Column3.HeaderText = "Description"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.FillWeight = 50F
        Column4.HeaderText = "Unit"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.FillWeight = 50F
        Column5.HeaderText = "Qty"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Rate"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Amount"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
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
        Panel1.Size = New Size(1060, 71)
        Panel1.TabIndex = 16
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
        ' BtnPlus
        ' 
        BtnPlus.Image = CType(resources.GetObject("BtnPlus.Image"), Image)
        BtnPlus.Location = New Point(946, 96)
        BtnPlus.Name = "BtnPlus"
        BtnPlus.Size = New Size(38, 40)
        BtnPlus.TabIndex = 18
        BtnPlus.UseVisualStyleBackColor = True
        ' 
        ' Btnless
        ' 
        Btnless.Image = CType(resources.GetObject("Btnless.Image"), Image)
        Btnless.Location = New Point(985, 96)
        Btnless.Name = "Btnless"
        Btnless.Size = New Size(38, 40)
        Btnless.TabIndex = 22
        Btnless.UseVisualStyleBackColor = True
        ' 
        ' TxtSerialNo
        ' 
        TxtSerialNo.Location = New Point(496, 113)
        TxtSerialNo.Name = "TxtSerialNo"
        TxtSerialNo.PlaceholderText = "Serial No"
        TxtSerialNo.Size = New Size(81, 23)
        TxtSerialNo.TabIndex = 23
        ' 
        ' TxtRate
        ' 
        TxtRate.Location = New Point(855, 113)
        TxtRate.Name = "TxtRate"
        TxtRate.PlaceholderText = "Rate"
        TxtRate.Size = New Size(85, 23)
        TxtRate.TabIndex = 25
        ' 
        ' TxtQty
        ' 
        TxtQty.Location = New Point(812, 113)
        TxtQty.Name = "TxtQty"
        TxtQty.PlaceholderText = "Qty"
        TxtQty.Size = New Size(37, 23)
        TxtQty.TabIndex = 26
        ' 
        ' TxtUnit
        ' 
        TxtUnit.Location = New Point(743, 113)
        TxtUnit.Name = "TxtUnit"
        TxtUnit.PlaceholderText = "Unit"
        TxtUnit.Size = New Size(65, 23)
        TxtUnit.TabIndex = 27
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Location = New Point(579, 113)
        TxtDescription.Name = "TxtDescription"
        TxtDescription.PlaceholderText = "Description"
        TxtDescription.Size = New Size(158, 23)
        TxtDescription.TabIndex = 28
        ' 
        ' Purchase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(1060, 516)
        ControlBox = False
        Controls.Add(TxtDescription)
        Controls.Add(TxtUnit)
        Controls.Add(TxtQty)
        Controls.Add(TxtRate)
        Controls.Add(TxtSerialNo)
        Controls.Add(Btnless)
        Controls.Add(BtnPlus)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(TxtDate)
        Controls.Add(Label5)
        Controls.Add(BtnSave)
        Controls.Add(TxtInvoiceNo)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Name = "Purchase"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(DataGridViewPurchase, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtInvoiceNo As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDate As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtGrandTotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnFind As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnPlus As Button
    Friend WithEvents Btnless As Button
    Friend WithEvents DataGridViewPurchase As DataGridView
    Friend WithEvents TxtSerialNo As TextBox
    Friend WithEvents TxtRate As TextBox
    Friend WithEvents TxtQty As TextBox
    Friend WithEvents TxtUnit As TextBox
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn

End Class
