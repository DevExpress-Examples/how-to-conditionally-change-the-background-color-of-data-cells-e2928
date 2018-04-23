'
' * In this example the product names are painted in Red if Quantity equals 10.
' * 
' 


Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Media
Imports DevExpress.Xpf.Core.WPFCompatibility
Imports DevExpress.Xpf.Grid

Namespace ChangeRowAppearance
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = New ProductList()
		End Sub
	End Class

	Public Class ValToClrConverter
		Inherits MarkupExtension
		Implements IValueConverter

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function

		#Region "IValueConverter Members"

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			If CInt(Fix(value)) < 10 Then
				Return New SolidColorBrush(Colors.Red)
			End If
			If CInt(Fix(value)) > 100 Then
				Return New SolidColorBrush(Colors.Green)
			End If
			Return New SolidColorBrush(Colors.LightGray)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

		#End Region
	End Class
End Namespace
