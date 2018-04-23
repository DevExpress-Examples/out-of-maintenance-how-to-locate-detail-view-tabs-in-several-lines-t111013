Imports Microsoft.VisualBasic
Imports System
Namespace MasterDetailProject
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.customGridControlClass1 = New MasterDetailProject.CustomGridControlClass()
			Me.customGridView1 = New MasterDetailProject.CustomGridView()
			CType(Me.customGridControlClass1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customGridControlClass1
			' 
			Me.customGridControlClass1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.customGridControlClass1.Location = New System.Drawing.Point(0, 0)
			Me.customGridControlClass1.MainView = Me.customGridView1
			Me.customGridControlClass1.Name = "customGridControlClass1"
			Me.customGridControlClass1.Size = New System.Drawing.Size(313, 354)
			Me.customGridControlClass1.TabIndex = 0
			Me.customGridControlClass1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.customGridView1})
			' 
			' customGridView1
			' 
			Me.customGridView1.GridControl = Me.customGridControlClass1
			Me.customGridView1.Name = "customGridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(313, 354)
			Me.Controls.Add(Me.customGridControlClass1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.customGridControlClass1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customGridControlClass1 As CustomGridControlClass
		Private customGridView1 As CustomGridView


	End Class
End Namespace

