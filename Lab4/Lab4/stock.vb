Public Class Stock
	' Implements the IComparable interface so stock instances can contain certain required methods
	Implements IComparable
	' Create properties that relate to each Stock object
	Public Property ticker As String
	Public Property price As Double
	Private Property earnings As Double
	Public ReadOnly Property PeRatio As Double
		Get
			' Round the PE Ratio by 2 decimal places
			Return Math.Round(price / earnings, 2)
		End Get
	End Property

	' Create constructor for Stock objects
	Public Sub New(ByVal sTicker As String, sPrice As Double, sEarnings As Double)

		ticker = sTicker
		price = sPrice
		earnings = sEarnings

	End Sub

	Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
		Dim S As Stock = CType(obj, Stock)
		Return Me.ticker.CompareTo(S.ticker)
	End Function

	' Override the default toString() function so that way may place a proper string into the list box when necessary
	Public Overrides Function ToString() As String
		Return ticker & ", price = " & price & ", P/E = " & PeRatio
	End Function

End Class
