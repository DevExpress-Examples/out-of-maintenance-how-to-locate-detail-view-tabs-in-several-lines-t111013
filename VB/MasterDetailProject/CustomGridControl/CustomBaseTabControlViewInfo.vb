Imports Microsoft.VisualBasic
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.Registrator
Imports DevExpress.XtraTab.ViewInfo
Imports MasterDetailProject.CustomGridControl
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomGridControl
	Friend Class CustomBaseTabControlViewInfo
		Inherits SkinTabControlViewInfo

		Public Sub New(ByVal tab As IXtraTab)
			MyBase.New(tab)
		End Sub

		Public Overrides ReadOnly Property IsMultiLine() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Overrides ReadOnly Property IsAllowMultiLine() As Boolean
			Get
				Return True
			End Get
		End Property

	End Class
End Namespace
