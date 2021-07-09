using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentSearch
{
    public partial class MainForm : Form
    {

        public string base_path;
        public string excel_path;
        public Search search;
        private Helpers helpers;
        public ArrayList listOfCheckBox = new ArrayList();
        public string dDir;
        public string[] dTopDir;
        public AutoCompleteStringCollection listOfStoreNumber = new AutoCompleteStringCollection();

        public MainForm()
        {
            InitializeComponent();

            string a = "0000000000";
            Console.WriteLine(Int32.Parse(a));
            search = new Search(this);
            helpers = new Helpers(this);
            //search.dTopDir = Directory.GetDirectories(search.dDir, "*", SearchOption.TopDirectoryOnly);

        }



        private void search_button_Click(object sender, EventArgs e)
        {
            string storeNumber = String.IsNullOrEmpty(storeNum_textBox.Text) ? "" : storeNum_textBox.Text;
            string employeeNumber = String.IsNullOrEmpty(empNum_textBox.Text) ? "" : empNum_textBox.Text;
            string insuredNumber = String.IsNullOrEmpty(insuredNum_textBox.Text) ? "" : insuredNum_textBox.Text;
            string fullName = String.IsNullOrEmpty(fullName_textBox.Text) ? "" : fullName_textBox.Text;

            helpers.PopulateTable(search.SearchDocs(storeNumber, employeeNumber, insuredNumber, fullName));
        }

        private void numberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void form_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            helpers.formNames_checkBox_CheckedChanged(sender, e);
        }

        private void employee_dgv_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                int res = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.SortResult = res;
                e.Handled = true;//pass by the default sorting
            }
            else if (e.Column.Index == 1)
            {

                if (e.CellValue1.ToString().Length > 4)
                {
                    e.SortResult = -1;
                }
                else if (e.CellValue2.ToString().Length > 4)
                {
                    e.SortResult = 1;
                }
                else
                {
                    e.SortResult = e.CellValue1.ToString().CompareTo(e.CellValue2.ToString());
                }

                e.Handled = true;//pass by the default sorting
            }
        }

        private void reset_label_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void reset_label_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void reset_label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Panel panel = (Panel)label.Parent;

            foreach (Control control in panel.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox chk = (CheckBox)control;
                    chk.Checked = false;
                }

                if (control is TextBox)
                {
                    TextBox txtB = (TextBox)control;
                    txtB.Text = "";
                }
            }
            search.FormSelected.Clear();
            search.YearSelected.Clear();
        }

        private void employee_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
                helpers.OpenPDF(employee_dgv.CurrentRow.Cells[7].Value.ToString());
        }

        private void employee_dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                Cursor = Cursors.Hand;
            else
                Cursor = Cursors.Arrow;
        }
    }
}
