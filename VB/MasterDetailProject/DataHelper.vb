Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MasterDetailProject
	Friend NotInheritable Class DataHelper
		Private Sub New()
		End Sub
		Public Shared Function GetData() As BindingList(Of Customer)
			Dim customers As New BindingList(Of Customer)()
			customers.Add(GetCustomer(0,"Ivan"))
			customers.Add(GetCustomer(1,"Petr"))

			Return customers
		End Function

		Private Shared Function GetOrders() As BindingList(Of Order)
			Dim orders As New BindingList(Of Order)()
			orders.Add(New Order(0, "Car", New DateTime()))
			orders.Add(New Order(1, "Refregerator", New DateTime()))
			orders.Add(New Order(2, "Microwave", New DateTime()))
			Return orders
		End Function

		Private Shared Function GetAges() As BindingList(Of Integer)
			Dim ages As New BindingList(Of Integer)()
			ages.Add(40)
			Return ages
		End Function

		Private Shared Function GetLastNames(ByVal name As String) As BindingList(Of String)
			Dim names As New BindingList(Of String)()
			If name = "Ivan" Then
				names.Add("Sidorov")
			Else
				names.Add("Petrov")
			End If
			Return names
		End Function

		Private Shared Function GetCustomer(ByVal id As Integer, ByVal name As String) As Customer
			Dim customer As New Customer(id, name)
			customer.UserOrders = GetOrders()
			customer.NamesOfItems = GetLastNames(name)
			If name = "Ivan" Then
				customer.AgeOfUsers = GetAges()
			End If
			Return customer
		End Function

	End Class
End Namespace
