Public Class Form1
	' Create new list of Stocks
	Dim stockList As New List(Of Stock)

	Private Function ComparePrice(ByVal X As Stock, ByVal Y As Stock) As Integer
		Return X.price.CompareTo(Y.price)
	End Function

	Private Function CompareRatio(ByVal X As Stock, ByVal Y As Stock) As Integer
		Return X.PeRatio.CompareTo(Y.PeRatio)
	End Function

	Private Function DescPrice(ByVal X As Stock, ByVal Y As Stock) As Integer
		Return Y.price.CompareTo(X.price)
	End Function

	Private Function DescRatio(ByVal X As Stock, ByVal Y As Stock) As Integer
		Return Y.PeRatio.CompareTo(X.PeRatio)
	End Function

	Private Function DescTicker(ByVal X As Stock, ByVal Y As Stock) As Integer
		Return Y.ticker.CompareTo(X.ticker)
	End Function

	' When the form loads, add the following objects to the stockList list class
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		stockList.Add(New Stock("ABC", 80.12, 5.01))
		stockList.Add(New Stock("MSFT", 100.13, 1.95))
		stockList.Add(New Stock("GOOG", 360.22, 10.79))
		stockList.Add(New Stock("AMZN", 533.13, 12.58))
		stockList.Add(New Stock("POOP", 8008.11, 145.99))

		' Add each stockList item to the list box 
		For Each stock As Stock In stockList
			lstStocks.Items.Add(stock.ToString())
		Next

	End Sub

	' When clicked, sort the list by Ticker
	Private Sub btnTickerSort_Click(sender As Object, e As EventArgs) Handles btnTickerSort.Click

		lstStocks.Items.Clear()

		If chkDesc.Checked Then
			stockList.Sort(AddressOf DescTicker)
		Else
			stockList.Sort()
		End If

		For Each stock As Stock In stockList
			lstStocks.Items.Add(stock.ToString())
		Next

	End Sub

	' When clicked, sort the list by Price
	Private Sub btnPriceSort_Click(sender As Object, e As EventArgs) Handles btnPriceSort.Click

		lstStocks.Items.Clear()

		If chkDesc.Checked Then
			stockList.Sort(AddressOf DescPrice)
		Else
			stockList.Sort(AddressOf ComparePrice)
		End If

		For Each stock As Stock In stockList
			lstStocks.Items.Add(stock.ToString())
		Next

	End Sub

	' When clicked, sort the list by P/E Ratio
	Private Sub btnPeSort_Click(sender As Object, e As EventArgs) Handles btnPeSort.Click

		lstStocks.Items.Clear()

		If chkDesc.Checked Then
			stockList.Sort(AddressOf DescRatio)
		Else
			stockList.Sort(AddressOf CompareRatio)
		End If

		For Each stock As Stock In stockList
			lstStocks.Items.Add(stock.ToString())
		Next

	End Sub
End Class
