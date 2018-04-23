Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MasterDetailProject
	Friend Class Order
		Public Sub New(ByVal id As Integer, ByVal name As String, ByVal [date] As DateTime)
			Me.Id = id
			Me.Name = name
			Me.Date = [date]
		End Sub

		Private _age As Integer
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

		Private _date As DateTime
		Public Property [Date]() As DateTime
			Get
				Return _date
			End Get
			Set(ByVal value As DateTime)
				_date = value
			End Set
		End Property

	End Class
End Namespace
