<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleReport))
        TxtTotalQuantity = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TxtTotalSale = New TextBox()
        TxtSearch = New TextBox()
        Label1 = New Label()
        DataGridViewSaleReport = New DataGridView()
        Btnless = New Button()
        CType(DataGridViewSaleReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtTotalQuantity
        ' 
        TxtTotalQuantity.Location = New Point(625, 393)
        TxtTotalQuantity.Name = "TxtTotalQuantity"
        TxtTotalQuantity.ReadOnly = True
        TxtTotalQuantity.Size = New Size(100, 23)
        TxtTotalQuantity.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(787, 371)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 19)
        Label3.TabIndex = 15
        Label3.Text = "Total Sale"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 12F, FontStyle.Bold)
        Label2.Location = New Point(618, 371)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 19)
        Label2.TabIndex = 14
        Label2.Text = "Total Quantity"
        ' 
        ' TxtTotalSale
        ' 
        TxtTotalSale.Location = New Point(762, 393)
        TxtTotalSale.Name = "TxtTotalSale"
        TxtTotalSale.ReadOnly = True
        TxtTotalSale.Size = New Size(100, 23)
        TxtTotalSale.TabIndex = 13
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Location = New Point(213, 22)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderText = "Enter invoise no"
        TxtSearch.Size = New Size(328, 23)
        TxtSearch.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(152, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 19)
        Label1.TabIndex = 11
        Label1.Text = "Search"
        ' 
        ' DataGridViewSaleReport
        ' 
        DataGridViewSaleReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewSaleReport.BackgroundColor = Color.Silver
        DataGridViewSaleReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewSaleReport.GridColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewSaleReport.Location = New Point(17, 69)
        DataGridViewSaleReport.Name = "DataGridViewSaleReport"
        DataGridViewSaleReport.Size = New Size(845, 299)
        DataGridViewSaleReport.TabIndex = 17
        ' 
        ' Btnless
        ' 
        Btnless.FlatStyle = FlatStyle.Flat
        Btnless.ForeColor = Color.Black
        Btnless.Image = CType(resources.GetObject("Btnless.Image"), Image)
        Btnless.Location = New Point(817, 26)
        Btnless.Name = "Btnless"
        Btnless.Size = New Size(45, 41)
        Btnless.TabIndex = 32
        Btnless.UseVisualStyleBackColor = True
        ' 
        ' SaleReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(885, 438)
        Controls.Add(Btnless)
        Controls.Add(DataGridViewSaleReport)
        Controls.Add(TxtTotalQuantity)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtTotalSale)
        Controls.Add(TxtSearch)
        Controls.Add(Label1)
        ForeColor = Color.Black
        MaximizeBox = False
        MinimizeBox = False
        Name = "SaleReport"
        ShowIcon = False
        Text = "SaleReport"
        CType(DataGridViewSaleReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtTotalQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTotalSale As TextBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewSaleReport As DataGridView
    Friend WithEvents Btnless As Button
End Class
