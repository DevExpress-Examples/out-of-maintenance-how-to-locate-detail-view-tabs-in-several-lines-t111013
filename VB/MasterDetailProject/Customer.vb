Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MasterDetailProject
	Friend Class Customer

		Public Sub New(ByVal id As Integer, ByVal name As String)
			Me.Id = id
			Me.Name = name
		End Sub

		Private _id As Integer
		Public Property Id() As Integer
			Get
				Return _id
			End Get
			Set(ByVal value As Integer)
				_id = value
			End Set
		End Property

		Private _name As String
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set(ByVal value As String)
				_name = value
			End Set
		End Property

		Private _orders As BindingList(Of Order)
		Public Property UserOrders() As BindingList(Of Order)
			Get
				Return _orders
			End Get
			Set(ByVal value As BindingList(Of Order))
				_orders = value
			End Set
		End Property

		Private _names As BindingList(Of String)
		Public Property NamesOfItems() As BindingList(Of String)
			Get
				Return _names
			End Get
			Set(ByVal value As BindingList(Of String))
				_names = value
			End Set
		End Property


		Private _age As BindingList(Of Integer)
		Public Property AgeOfUsers() As BindingList(Of Integer)
			Get
				Return _age
			End Get
			Set(ByVal value As BindingList(Of Integer))
				_age = value
			End Set
		End Property


	End Class
End Namespace
