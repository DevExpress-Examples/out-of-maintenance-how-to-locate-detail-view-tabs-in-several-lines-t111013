Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports MasterDetailProject.CustomGridControl
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MasterDetailProject
	Friend Class CustomGridViewRegistrator
		Inherits GridInfoRegistrator

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomGridView"
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As DevExpress.XtraGrid.GridControl) As DevExpress.XtraGrid.Views.Base.BaseView
			Return New CustomGridView(TryCast(grid, GridControl))
		End Function

		Public Overrides Function CreateViewInfo(ByVal view As DevExpress.XtraGrid.Views.Base.BaseView) As DevExpress.XtraGrid.Views.Base.ViewInfo.BaseViewInfo
			Return New CustomGridViewInfo(CType(view, GridView))
		End Function

	End Class
End Namespace
