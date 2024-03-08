<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerReport
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
        DataGridViewCusReport = New DataGridView()
        Label1 = New Label()
        TxtSearch = New TextBox()
        CType(DataGridViewCusReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewCusReport
        ' 
        DataGridViewCusReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCusReport.BackgroundColor = Color.Silver
        DataGridViewCusReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCusReport.GridColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCusReport.Location = New Point(29, 75)
        DataGridViewCusReport.Name = "DataGridViewCusReport"
        DataGridViewCusReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewCusReport.Size = New Size(627, 299)
        DataGridViewCusReport.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(107, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 19)
        Label1.TabIndex = 1
        Label1.Text = "Search"
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Location = New Point(191, 36)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.PlaceholderText = "Enter Customer Name"
        TxtSearch.Size = New Size(328, 23)
        TxtSearch.TabIndex = 2
        ' 
        ' CustomerReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(691, 416)
        Controls.Add(TxtSearch)
        Controls.Add(Label1)
        Controls.Add(DataGridViewCusReport)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "CustomerReport"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "CustomerReport"
        CType(DataGridViewCusReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridViewCusReport As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearch As TextBox
End Class
