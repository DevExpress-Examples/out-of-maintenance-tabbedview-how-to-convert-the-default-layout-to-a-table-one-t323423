using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FreeLayoutModeExample
{
    public class TabbedViewLayoutConverter : Component
    {
        public TabbedViewLayoutConverter() { TabbedView = null; }

        public TabbedView TabbedView { get; set; }


        public void ConvertLayout(int rowCount, int colCount)
        {
            if (!CanCreateTableLayout(rowCount, colCount))
                return;

            TabbedView.BeginUpdate();
            ClearGroups();
            WrapDocuments();
            CreateTableLayout(rowCount, colCount);
            TabbedView.EndUpdate();
        }

        private bool CanCreateTableLayout(int rowCount, int colCount)
        {
            return rowCount * colCount >= TabbedView.Documents.Count;
        }

        private void ClearGroups()
        {
            TabbedView.DocumentGroups.Clear();
        }

        private void WrapDocuments()
        {
            DocumentGroup tempGroup = null;
            foreach (Document doc in TabbedView.Documents)
            {
                tempGroup = new DocumentGroup();
                TabbedView.DocumentGroups.Add(tempGroup);
                TabbedView.Controller.Dock(doc, tempGroup);
            }
        }

        private void CreateTableLayout(int rowCount, int colCount)
        {
            int groupCount;
            bool exit = false;
            Orientation rowOrientation = Orientation.Horizontal;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 1; j < colCount; j++)
                {
                    groupCount = i * colCount + j;
                    if (groupCount >= TabbedView.DocumentGroups.Count) { exit = true; break; }
                    TabbedView.DocumentGroups[groupCount].DockTo(TabbedView.DocumentGroups[groupCount - 1], rowOrientation);
                }
                if (exit) break;
            }
        }
    }
}
