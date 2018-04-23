Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MasterDetailProject
	<System.ComponentModel.DesignerCategory(""), ToolboxItem(True)> _
	Friend Class CustomGridControlClass
		Inherits GridControl

		Protected Overrides Function CreateDefaultView() As DevExpress.XtraGrid.Views.Base.BaseView
			Return (CreateView("CustomGridView"))
		End Function

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As DevExpress.XtraGrid.Registrator.InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New CustomGridViewRegistrator())
		End Sub

	End Class
End Namespace
