<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.btnTickerSort = New System.Windows.Forms.Button()
		Me.btnPriceSort = New System.Windows.Forms.Button()
		Me.btnPeSort = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lstStocks = New System.Windows.Forms.ListBox()
		Me.chkDesc = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'btnTickerSort
		'
		Me.btnTickerSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTickerSort.Location = New System.Drawing.Point(24, 56)
		Me.btnTickerSort.Name = "btnTickerSort"
		Me.btnTickerSort.Size = New System.Drawing.Size(132, 29)
		Me.btnTickerSort.TabIndex = 0
		Me.btnTickerSort.Text = "Sort by Ticker"
		Me.btnTickerSort.UseVisualStyleBackColor = True
		'
		'btnPriceSort
		'
		Me.btnPriceSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPriceSort.Location = New System.Drawing.Point(24, 111)
		Me.btnPriceSort.Name = "btnPriceSort"
		Me.btnPriceSort.Size = New System.Drawing.Size(132, 29)
		Me.btnPriceSort.TabIndex = 1
		Me.btnPriceSort.Text = "Sort by Price"
		Me.btnPriceSort.UseVisualStyleBackColor = True
		'
		'btnPeSort
		'
		Me.btnPeSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPeSort.Location = New System.Drawing.Point(24, 164)
		Me.btnPeSort.Name = "btnPeSort"
		Me.btnPeSort.Size = New System.Drawing.Size(132, 31)
		Me.btnPeSort.TabIndex = 2
		Me.btnPeSort.Text = "Sort by PE Ratio"
		Me.btnPeSort.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(114, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(318, 16)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "This application sorts a list of stocks in different ways"
		'
		'lstStocks
		'
		Me.lstStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstStocks.FormattingEnabled = True
		Me.lstStocks.ItemHeight = 16
		Me.lstStocks.Location = New System.Drawing.Point(178, 56)
		Me.lstStocks.Name = "lstStocks"
		Me.lstStocks.Size = New System.Drawing.Size(362, 132)
		Me.lstStocks.TabIndex = 4
		'
		'chkDesc
		'
		Me.chkDesc.AutoSize = True
		Me.chkDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDesc.Location = New System.Drawing.Point(295, 203)
		Me.chkDesc.Name = "chkDesc"
		Me.chkDesc.Size = New System.Drawing.Size(137, 20)
		Me.chkDesc.TabIndex = 5
		Me.chkDesc.Text = "Descending Order"
		Me.chkDesc.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(583, 239)
		Me.Controls.Add(Me.chkDesc)
		Me.Controls.Add(Me.lstStocks)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnPeSort)
		Me.Controls.Add(Me.btnPriceSort)
		Me.Controls.Add(Me.btnTickerSort)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnTickerSort As Button
	Friend WithEvents btnPriceSort As Button
	Friend WithEvents btnPeSort As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents lstStocks As ListBox
	Friend WithEvents chkDesc As CheckBox
End Class
