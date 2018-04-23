Namespace FreeLayoutModeExample
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
			Me.components = New System.ComponentModel.Container()
			Dim dockingContainer1 As New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
			Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
			Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.simpleButtonAdd = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButtonChange = New DevExpress.XtraEditors.SimpleButton()
			Me.textEditCol = New DevExpress.XtraEditors.TextEdit()
			Me.textEditRow = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.tabbedViewLayoutConverter1 = New FreeLayoutModeExample.TabbedViewLayoutConverter()
			DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.textEditCol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.textEditRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentGroup1
			' 
			Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() { Me.document1, Me.document2, Me.document3})
			' 
			' document1
			' 
			Me.document1.Caption = "document1"
			Me.document1.ControlName = "document1"
			' 
			' document2
			' 
			Me.document2.Caption = "document2"
			Me.document2.ControlName = "document2"
			' 
			' document3
			' 
			Me.document3.Caption = "document3"
			Me.document3.ControlName = "document3"
			' 
			' tabbedView
			' 
			Me.tabbedView.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() { Me.documentGroup1})
			 Me.tabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2, Me.document3})
			Me.tabbedView.EnableFreeLayoutMode = DevExpress.Utils.DefaultBoolean.True
			Me.tabbedView.Orientation = System.Windows.Forms.Orientation.Vertical
			dockingContainer1.Element = Me.documentGroup1
			dockingContainer1.Parent = Me.tabbedView.RootContainer
			Me.tabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() { dockingContainer1})
			Me.tabbedView.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.simpleButtonAdd)
			Me.layoutControl1.Controls.Add(Me.simpleButtonChange)
			Me.layoutControl1.Controls.Add(Me.textEditCol)
			Me.layoutControl1.Controls.Add(Me.textEditRow)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(2, 2)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(679, 51)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' simpleButtonAdd
			' 
			Me.simpleButtonAdd.Location = New System.Drawing.Point(463, 12)
			Me.simpleButtonAdd.Name = "simpleButtonAdd"
			Me.simpleButtonAdd.Size = New System.Drawing.Size(204, 22)
			Me.simpleButtonAdd.StyleController = Me.layoutControl1
			Me.simpleButtonAdd.TabIndex = 4
			Me.simpleButtonAdd.Text = "Add new document"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
			' 
			' simpleButtonChange
			' 
			Me.simpleButtonChange.Location = New System.Drawing.Point(254, 12)
			Me.simpleButtonChange.Name = "simpleButtonChange"
			Me.simpleButtonChange.Size = New System.Drawing.Size(205, 22)
			Me.simpleButtonChange.StyleController = Me.layoutControl1
			Me.simpleButtonChange.TabIndex = 3
			Me.simpleButtonChange.Text = "Convert layout"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButtonChange.Click += new System.EventHandler(this.simpleButtonChange_Click);
			' 
			' textEditCol
			' 
			Me.textEditCol.EditValue = "1"
			Me.textEditCol.Location = New System.Drawing.Point(157, 12)
			Me.textEditCol.Name = "textEditCol"
			Me.textEditCol.Properties.Mask.EditMask = "[1-9]"
			Me.textEditCol.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.textEditCol.Size = New System.Drawing.Size(93, 20)
			Me.textEditCol.StyleController = Me.layoutControl1
			Me.textEditCol.TabIndex = 2
			' 
			' textEditRow
			' 
			Me.textEditRow.EditValue = "1"
			Me.textEditRow.Location = New System.Drawing.Point(36, 12)
			Me.textEditRow.Name = "textEditRow"
			Me.textEditRow.Properties.Mask.EditMask = "[1-9]"
			Me.textEditRow.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.textEditRow.Size = New System.Drawing.Size(93, 20)
			Me.textEditRow.StyleController = Me.layoutControl1
			Me.textEditRow.TabIndex = 0
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(679, 51)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.textEditRow
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(121, 31)
			Me.layoutControlItem1.Text = "Row"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(21, 13)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.textEditCol
			Me.layoutControlItem2.Location = New System.Drawing.Point(121, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(121, 31)
			Me.layoutControlItem2.Text = "Col"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(21, 13)
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.simpleButtonChange
			Me.layoutControlItem3.Location = New System.Drawing.Point(242, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(209, 31)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.simpleButtonAdd
			Me.layoutControlItem4.Location = New System.Drawing.Point(451, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(208, 31)
			Me.layoutControlItem4.Text = "Add Document"
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.layoutControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(683, 55)
			Me.panelControl1.TabIndex = 0
			' 
			' documentManager1
			' 
			Me.documentManager1.ContainerControl = Me
			Me.documentManager1.View = Me.tabbedView
			Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.tabbedView})
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
			' 
			' layoutConverterHelper1
			' 
			Me.tabbedViewLayoutConverter1.TabbedView = Me.tabbedView
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(683, 349)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.textEditCol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.textEditRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private WithEvents simpleButtonChange As DevExpress.XtraEditors.SimpleButton
		Private textEditCol As DevExpress.XtraEditors.TextEdit
		Private textEditRow As DevExpress.XtraEditors.TextEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents simpleButtonAdd As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
		Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
		Private document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private tabbedViewLayoutConverter1 As TabbedViewLayoutConverter
	End Class
End Namespace

