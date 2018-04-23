Imports Microsoft.VisualBasic
Imports CustomGridControl
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Tab
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab.ViewInfo
Imports MasterDetailProject.CustomGridControl
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks

Namespace MasterDetailProject
	<System.ComponentModel.DesignerCategory("")> _
	Friend Class CustomGridView
		Inherits GridView
		Public Sub New()
		End Sub

		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
			Dim fields() As FieldInfo = (MyBase.TabControl).GetType().GetFields(BindingFlags.NonPublic Or BindingFlags.Instance)

			Dim fInfo As FieldInfo = fields.First(Function(item) item.Name = "viewInfo")

			fInfo.SetValue(Me.TabControl, New CustomBaseTabControlViewInfo(Me.TabControl))
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "CustomGridView"
			End Get
		End Property

	End Class

End Namespace
