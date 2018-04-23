Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports System.ComponentModel

Namespace FreeLayoutModeExample
	Public Class TabbedViewLayoutConverter
		Inherits Component

		Public Sub New()
			TabbedView = Nothing
		End Sub

		Public Property TabbedView() As TabbedView


		Public Sub ConvertLayout(ByVal rowCount As Integer, ByVal colCount As Integer)
			If Not CanCreateTableLayout(rowCount, colCount) Then
				Return
			End If

			TabbedView.BeginUpdate()
			ClearGroups()
			WrapDocuments()
			CreateTableLayout(rowCount, colCount)
			TabbedView.EndUpdate()
		End Sub

		Private Function CanCreateTableLayout(ByVal rowCount As Integer, ByVal colCount As Integer) As Boolean
			Return rowCount * colCount >= TabbedView.Documents.Count
		End Function

		Private Sub ClearGroups()
			TabbedView.DocumentGroups.Clear()
		End Sub

		Private Sub WrapDocuments()
			Dim tempGroup As DocumentGroup = Nothing
			For Each doc As Document In TabbedView.Documents
				tempGroup = New DocumentGroup()
				TabbedView.DocumentGroups.Add(tempGroup)
				TabbedView.Controller.Dock(doc, tempGroup)
			Next doc
		End Sub

		Private Sub CreateTableLayout(ByVal rowCount As Integer, ByVal colCount As Integer)
			Dim groupCount As Integer
			Dim [exit] As Boolean = False
			Dim rowOrientation As Orientation = Orientation.Horizontal

			For i As Integer = 0 To rowCount - 1
				For j As Integer = 1 To colCount - 1
					groupCount = i * colCount + j
					If groupCount >= TabbedView.DocumentGroups.Count Then
						[exit] = True
						Exit For
					End If
					TabbedView.DocumentGroups(groupCount).DockTo(TabbedView.DocumentGroups(groupCount - 1), rowOrientation)
				Next j
				If [exit] Then
					Exit For
				End If
			Next i
		End Sub
	End Class
End Namespace
