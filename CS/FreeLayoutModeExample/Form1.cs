using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeLayoutModeExample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            tabbedView.QueryControl += tabbedView_QueryControl;
            SetDocumentsAppearance();
            helper = new ExampleHelper(tabbedView);
        }
        readonly ExampleHelper helper;

        private void SetDocumentsAppearance()
        {
            foreach (Document doc in tabbedView.Documents)
                doc.Appearance.HeaderActive.BackColor = ExampleHelper.GetRandomColor();
        }

        void tabbedView_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            e.Control = ExampleHelper.GetControl();
        }

        private void simpleButtonChange_Click(object sender, EventArgs e)
        {
            int rowCount = Convert.ToInt32(textEditRow.EditValue);
            int colCount = Convert.ToInt32(textEditCol.EditValue);
            tabbedViewLayoutConverter1.ConvertLayout(rowCount, colCount);
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            helper.AddNewDocument();
        }

    }
}
