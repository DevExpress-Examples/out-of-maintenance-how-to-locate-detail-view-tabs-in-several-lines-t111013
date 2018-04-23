Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MasterDetailProject.CustomGridControl
	Friend Class CustomGridViewInfo
		Inherits GridViewInfo

		Public Sub New(ByVal view As GridView)
			MyBase.New(view)
		End Sub

		Private _partital As Boolean

		Public Overrides Sub CalcRects(ByVal bounds As Rectangle, ByVal partital As Boolean)
			MyBase.CalcRects(bounds, partital)
			_partital = partital
		End Sub

		Protected Overrides Function CalcScrollRect() As Rectangle
			Dim scrollRect As Rectangle = MyBase.CalcScrollRect()

			If _partital AndAlso Me.TabControl.Handler.ViewInfo.PageBounds.Y > 0 Then
				scrollRect.Y = Me.TabControl.Handler.ViewInfo.PageBounds.Y + 1
				If Me.TabControl.Handler.ViewInfo.Bounds.Y > 0 Then
					scrollRect.Height -= Me.TabControl.Handler.ViewInfo.PageBounds.Y - Me.TabControl.Handler.ViewInfo.Bounds.Y - Me.ActualDataRowMinRowHeight
				End If
			End If

			Return scrollRect
		End Function

	End Class
End Namespace
