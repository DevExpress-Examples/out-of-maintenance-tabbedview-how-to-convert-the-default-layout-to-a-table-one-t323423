Imports DevExpress.Skins
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace FreeLayoutModeExample
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			DevExpress.Skins.SkinManager.EnableFormSkins()
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace
