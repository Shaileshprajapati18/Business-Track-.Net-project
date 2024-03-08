<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        BtnCustomer = New Button()
        BtnPurchase = New Button()
        BtnSale = New Button()
        ShowReport = New Panel()
        SuspendLayout()
        ' 
        ' BtnCustomer
        ' 
        BtnCustomer.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BtnCustomer.Font = New Font("Calibri", 18F, FontStyle.Bold)
        BtnCustomer.ForeColor = Color.White
        BtnCustomer.Location = New Point(76, 54)
        BtnCustomer.Name = "BtnCustomer"
        BtnCustomer.Size = New Size(247, 50)
        BtnCustomer.TabIndex = 0
        BtnCustomer.Text = "CUSTOMER REPORT"
        BtnCustomer.UseVisualStyleBackColor = False
        ' 
        ' BtnPurchase
        ' 
        BtnPurchase.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BtnPurchase.Font = New Font("Calibri", 18F, FontStyle.Bold)
        BtnPurchase.ForeColor = Color.White
        BtnPurchase.Location = New Point(634, 54)
        BtnPurchase.Name = "BtnPurchase"
        BtnPurchase.Size = New Size(247, 50)
        BtnPurchase.TabIndex = 1
        BtnPurchase.Text = "PURCHASE REPORT"
        BtnPurchase.UseVisualStyleBackColor = False
        ' 
        ' BtnSale
        ' 
        BtnSale.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BtnSale.Font = New Font("Calibri", 18F, FontStyle.Bold)
        BtnSale.ForeColor = Color.White
        BtnSale.Location = New Point(360, 54)
        BtnSale.Name = "BtnSale"
        BtnSale.Size = New Size(247, 50)
        BtnSale.TabIndex = 3
        BtnSale.Text = "SALE REPORT"
        BtnSale.UseVisualStyleBackColor = False
        ' 
        ' ShowReport
        ' 
        ShowReport.Location = New Point(76, 130)
        ShowReport.Name = "ShowReport"
        ShowReport.Size = New Size(1225, 584)
        ShowReport.TabIndex = 6
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(1386, 710)
        ControlBox = False
        Controls.Add(ShowReport)
        Controls.Add(BtnSale)
        Controls.Add(BtnPurchase)
        Controls.Add(BtnCustomer)
        FormBorderStyle = FormBorderStyle.None
        Name = "Report"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub
    Friend WithEvents BtnCustomer As Button
    Friend WithEvents BtnPurchase As Button
    Friend WithEvents BtnSale As Button
    Friend WithEvents ShowReport As Panel
End Class
