Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace FreeLayoutModeExample
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler tabbedView.QueryControl, AddressOf tabbedView_QueryControl
			SetDocumentsAppearance()
			exampleHelper = New ExampleHelper(tabbedView)
		End Sub

		Private ReadOnly exampleHelper As ExampleHelper

		Private Sub SetDocumentsAppearance()
			For Each doc As Document In tabbedView.Documents
				doc.Appearance.HeaderActive.BackColor = ExampleHelper.GetRandomColor()
			Next doc
		End Sub

		Private Sub tabbedView_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)
			e.Control = ExampleHelper.GetControl()
		End Sub

		Private Sub simpleButtonChange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonChange.Click
			Dim rowCount As Integer = Convert.ToInt32(textEditRow.EditValue)
			Dim colCount As Integer = Convert.ToInt32(textEditCol.EditValue)
			tabbedViewLayoutConverter1.ConvertLayout(rowCount, colCount)
		End Sub

		Private Sub simpleButtonAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonAdd.Click
			exampleHelper.AddNewDocument()
		End Sub

	End Class
End Namespace
