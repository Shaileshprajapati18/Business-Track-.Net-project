<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseReport))
        TxtSearch = New TextBox()
        Label1 = New Label()
        DataGridViewPurchaseReport = New DataGridView()
        TxtTotalPurchase = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TxtTotalQuantity = New TextBox()
        Btnless = New Button()
        CType(DataGridViewPurchaseReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Location = New Point(259, 32)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderText = "Enter invoise no"
        TxtSearch.Size = New Size(328, 23)
        TxtSearch.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(179, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 19)
        Label1.TabIndex = 4
        Label1.Text = "Search"
        ' 
        ' DataGridViewPurchaseReport
        ' 
        DataGridViewPurchaseReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewPurchaseReport.BackgroundColor = Color.Silver
        DataGridViewPurchaseReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPurchaseReport.GridColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewPurchaseReport.Location = New Point(78, 79)
        DataGridViewPurchaseReport.Name = "DataGridViewPurchaseReport"
        DataGridViewPurchaseReport.Size = New Size(655, 299)
        DataGridViewPurchaseReport.TabIndex = 3
        ' 
        ' TxtTotalPurchase
        ' 
        TxtTotalPurchase.Location = New Point(633, 403)
        TxtTotalPurchase.Name = "TxtTotalPurchase"
        TxtTotalPurchase.ReadOnly = True
        TxtTotalPurchase.Size = New Size(100, 23)
        TxtTotalPurchase.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label2.Location = New Point(496, 381)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 19)
        Label2.TabIndex = 7
        Label2.Text = "Total Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(624, 381)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 19)
        Label3.TabIndex = 8
        Label3.Text = "Total Purchase"
        ' 
        ' TxtTotalQuantity
        ' 
        TxtTotalQuantity.Location = New Point(503, 403)
        TxtTotalQuantity.Name = "TxtTotalQuantity"
        TxtTotalQuantity.ReadOnly = True
        TxtTotalQuantity.Size = New Size(100, 23)
        TxtTotalQuantity.TabIndex = 9
        ' 
        ' Btnless
        ' 
        Btnless.FlatStyle = FlatStyle.Flat
        Btnless.ForeColor = Color.Black
        Btnless.Image = CType(resources.GetObject("Btnless.Image"), Image)
        Btnless.Location = New Point(688, 32)
        Btnless.Name = "Btnless"
        Btnless.Size = New Size(45, 41)
        Btnless.TabIndex = 31
        Btnless.UseVisualStyleBackColor = True
        ' 
        ' PurchaseReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(772, 438)
        Controls.Add(Btnless)
        Controls.Add(TxtTotalQuantity)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtTotalPurchase)
        Controls.Add(TxtSearch)
        Controls.Add(Label1)
        Controls.Add(DataGridViewPurchaseReport)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PurchaseReport"
        ShowIcon = False
        Text = "PurchaseReport"
        CType(DataGridViewPurchaseReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewPurchaseReport As DataGridView
    Friend WithEvents TxtTotalPurchase As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotalQuantity As TextBox
    Friend WithEvents Btnless As Button
End Class
