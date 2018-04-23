Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Threading
Imports System.Windows.Forms

Namespace FreeLayoutModeExample
	Public Class ExampleHelper
		Public Sub New(ByVal _TabbedView As TabbedView)
			tabbedView = _TabbedView
		End Sub

		Private ReadOnly tabbedView As TabbedView

		Public Sub AddNewDocument()
			CreateNewDocument()
			ClearGroups()
			CreateDefaultLayout()
		End Sub

		Private Sub CreateNewDocument()
			Dim docName As String = String.Format("document{0}", tabbedView.Documents.Count + 1)
			Dim doc As Document = TryCast(tabbedView.AddDocument(GetControl()), Document)
			doc.Caption = docName
			doc.ControlName = docName
			doc.Appearance.HeaderActive.BackColor = ExampleHelper.GetRandomColor()
		End Sub

		Private Sub ClearGroups()
			tabbedView.DocumentGroups.Clear()
		End Sub

		Private Sub CreateDefaultLayout()
			Dim tempGroup As New DocumentGroup()
			tabbedView.DocumentGroups.Add(tempGroup)
			For Each doc As Document In tabbedView.Documents
				tabbedView.Controller.Dock(doc, tempGroup)
			Next doc
		End Sub

		Public Shared Function GetControl() As Control
			Return New Control With {.BackColor = ExampleHelper.GetRandomColor()}
		End Function

		Public Shared Function GetRandomColor() As Color
			Dim r As New Random()
			Thread.Sleep(15)
			Return Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255))
		End Function
	End Class
End Namespace
