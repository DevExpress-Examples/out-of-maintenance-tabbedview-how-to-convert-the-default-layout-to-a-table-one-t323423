using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FreeLayoutModeExample
{
    public class ExampleHelper
    {
        public ExampleHelper(TabbedView _TabbedView)
        {
            tabbedView = _TabbedView;
        }

        readonly TabbedView tabbedView;

        public void AddNewDocument()
        {
            CreateNewDocument();
            ClearGroups();
            CreateDefaultLayout();
        }

        private void CreateNewDocument()
        {
            string docName = string.Format("document{0}", tabbedView.Documents.Count + 1);
            Document doc = tabbedView.AddDocument(GetControl()) as Document;
            doc.Caption = docName;
            doc.ControlName = docName;
            doc.Appearance.HeaderActive.BackColor = ExampleHelper.GetRandomColor();
        }

        private void ClearGroups()
        {
            tabbedView.DocumentGroups.Clear();
        }

        private void CreateDefaultLayout()
        {
            DocumentGroup tempGroup = new DocumentGroup();
            tabbedView.DocumentGroups.Add(tempGroup);
            foreach (Document doc in tabbedView.Documents)
                tabbedView.Controller.Dock(doc, tempGroup);
        }

        public static Control GetControl()
        {
            return new Control { BackColor = ExampleHelper.GetRandomColor() };
        }

        public static Color GetRandomColor()
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
        }
    }
}
