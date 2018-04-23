Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Public Class Product
	Implements INotifyPropertyChanged
	Private fProductName As String
	Public Property ProductName() As String
		Get
			Return fProductName
		End Get
		Set(ByVal value As String)
			fProductName = value
			OnChanged("ProductName")
		End Set
	End Property

	Private fUnitPrice As Double
	Public Property UnitPrice() As Double
		Get
			Return fUnitPrice
		End Get
		Set(ByVal value As Double)
			fUnitPrice = value
			OnChanged("UnitPrice")
		End Set
	End Property

	Private fQuantity As Integer
	Public Property Quantity() As Integer
		Get
			Return fQuantity
		End Get
		Set(ByVal value As Integer)
			fQuantity = value
			OnChanged("Quantity")
		End Set
	End Property

	Private Sub OnChanged(ByVal p As String)
		RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(p))
	End Sub

	#Region "INotifyPropertyChanged Members"

	Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

	#End Region
End Class

Public Class ProductList
	Inherits ObservableCollection(Of Product)
	Public Sub New()
		MyBase.New()
		Add(New Product() With {.ProductName = "Chang", .UnitPrice = 19, .Quantity = 5})
		Add(New Product() With {.ProductName = "Gravad lax", .UnitPrice = 12.5, .Quantity = 16})
		Add(New Product() With {.ProductName = "Ravioli Angelo", .UnitPrice = 19, .Quantity = 12})
		Add(New Product() With {.ProductName = "Tarte au sucre", .UnitPrice = 22, .Quantity = 150})
		Add(New Product() With {.ProductName = "Steeleye Stout", .UnitPrice = 18, .Quantity = 20})
		Add(New Product() With {.ProductName = "Pavlova", .UnitPrice = 21, .Quantity = 52})
		Add(New Product() With {.ProductName = "Longlife Tofu", .UnitPrice = 7.75, .Quantity = 120})
		Add(New Product() With {.ProductName = "Alice Mutton", .UnitPrice = 21, .Quantity = 4})
		Add(New Product() With {.ProductName = "Alice Mutton", .UnitPrice = 44, .Quantity = 16})
	End Sub
End Class
