using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentSearch
{
    class Helpers
    {

        
        private MainForm MF;
        private DataGridView employee_dgv;

        public Helpers(MainForm MainForm)
        {
            MF = MainForm;
            employee_dgv = MF.employee_dgv;
            LoadFiles();
            formatDGV();
            MF.dTopDir = Directory.GetDirectories(MF.base_path, "*", SearchOption.TopDirectoryOnly);
            GenerateCheckBoxes();
            GenerateStoreNumber();
        }

        public void GenerateCheckBoxes()
        {
            MF.listOfCheckBox = ProcessFiles();
            List<string> typeOfOutput = new List<string>();
            int index = 115;

            foreach (var checkBoxList in MF.listOfCheckBox)
            {
                int testNumber;
                bool success = Int32.TryParse(Convert.ToString(checkBoxList), out testNumber);
                CheckBox cb = new CheckBox();
                MF.search.YearChoices.Add(checkBoxList.ToString());
                if (!success)
                {
                    cb.Text = "2020下";
                }
                else
                {
                    cb.Text = checkBoxList.ToString();
                }
                cb.Font = new Font("Yu Gothic", 10);
                cb.AutoSize = true;
                cb.CheckedChanged += new EventHandler(ck_CheckedChanged);
                cb.Location = new Point(index, 15);
                MF.search_panel.Controls.Add(cb);
                index += 115;
            }
        }

        public void formatDGV()
        {
            MF.employee_dgv.ColumnCount = 8;

            employee_dgv.Columns[0].Name = "No."; // number
            employee_dgv.Columns[1].Name = "作成年"; //year
            employee_dgv.Columns[2].Name = "店舗番号"; //store number
            employee_dgv.Columns[3].Name = "帳票名"; // form name
            employee_dgv.Columns[4].Name = "社員番号"; //employee number
            employee_dgv.Columns[5].Name = "被保険者番号"; //insured number
            employee_dgv.Columns[6].Name = "氏名"; // full name
            employee_dgv.Columns[7].Name = "path"; // full name

            // auto resize columns
            employee_dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            employee_dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employee_dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employee_dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employee_dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employee_dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employee_dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // dis able edit
            employee_dgv.Columns[0].ReadOnly = true;
            employee_dgv.Columns[1].ReadOnly = true;
            employee_dgv.Columns[2].ReadOnly = true;
            employee_dgv.Columns[3].ReadOnly = true;
            employee_dgv.Columns[4].ReadOnly = true;
            employee_dgv.Columns[5].ReadOnly = true;
            employee_dgv.Columns[6].ReadOnly = true;

            //center content
            employee_dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employee_dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employee_dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employee_dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employee_dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employee_dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employee_dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // fonts
            employee_dgv.Columns[0].DefaultCellStyle.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[1].DefaultCellStyle.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[2].DefaultCellStyle.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[3].DefaultCellStyle.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[4].DefaultCellStyle.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[5].DefaultCellStyle.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[6].DefaultCellStyle.Font = new Font("Yu Gothic", 10);

            employee_dgv.Columns[0].HeaderCell.Style.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[1].HeaderCell.Style.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[2].HeaderCell.Style.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[3].HeaderCell.Style.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[4].HeaderCell.Style.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[5].HeaderCell.Style.Font = new Font("Yu Gothic", 10);
            employee_dgv.Columns[6].HeaderCell.Style.Font = new Font("Yu Gothic", 10);

            employee_dgv.AllowUserToAddRows = false;
            employee_dgv.Columns[7].Visible = false;
            //employee_dgv.Columns[7].DefaultCellStyle.ForeColor = Color.DodgerBlue;

            int firstcolW = employee_dgv.Columns[0].Width;
            Point dgvloc = employee_dgv.Location;

            //sAll_checkBox.Location = new Point(employee_dgv.Location.X + (firstcolW / 2) + 35, employee_dgv.Location.Y + 5); ;
            //employee_dgv.Controls.SetChildIndex(checkBox1, 1);(firstcol / 2)employee_dgv.Location.X + (firstcol / 2)被保険者番号
        }

        public void LoadFiles()
        {
            DotNetEnv.Env.Load();
            MF.base_path = DotNetEnv.Env.GetString("BASE_PATH");
            MF.excel_path = Path.Combine(Directory.GetCurrentDirectory(), "Data\\事業所コードリスト.csv");


            if (!Directory.Exists(MF.base_path))
            {
                MessageBox.Show("登録されたパスが見つかりませんでした。envファイルのBASE_PATHを変更してください。");
                Application.ExitThread();
                Environment.Exit(Environment.ExitCode);
            }
        }

        public void ck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox year_chk = (CheckBox)sender;
            if (year_chk.Checked)
            {
                if (!MF.search.YearSelected.Contains(year_chk.Text.Replace("下", "S")))
                    MF.search.YearSelected.Add(year_chk.Text.Replace("下", "S"));
            }
            else
            {
                MF.search.YearSelected.Remove(year_chk.Text.Replace("下", "S"));
            }
        }

        public void PopulateTable(IEnumerable<string> filteredData)
        {
            //transform each string to array
            // the column data for each record is in the file path

            employee_dgv.Rows.Clear();
            employee_dgv.Refresh();

            for (int i = 0; i < filteredData.Count(); i++)
            {
                IDictionary<string, string> employeeData = FilePathToArray(filteredData.ElementAt(i));

                string[] row = {
                    (i + 1).ToString(),
                    employeeData["year"],
                    employeeData["store"],
                    employeeData["form"],
                    employeeData["employee_number"],
                    employeeData["insured_number"],
                    employeeData["name"],
                    employeeData["filepath"]
                };
                employee_dgv.Rows.Add(row);
                MF.noData_panel.Visible = false;
            }

            if (filteredData.Count() <= 0)
            {
                MF.noData_panel.Visible = true;
            }

            //    employee_dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
            //employee_dgv.Columns[1].State = DataGridViewElementStates.Frozen;
        }

        public IDictionary<string, string> FilePathToArray(string filepath)
        {
            string[] employeeData;
            string form_letter = "";
            int offset = 0;
            IDictionary<string, string> finalData = new Dictionary<string, string>();

            string basePath = DotNetEnv.Env.GetString("BASE_PATH");

            finalData["filepath"] = filepath;
            filepath = filepath.Replace(basePath + @"\", "");
            employeeData = filepath.Split('\\');
            form_letter = employeeData[1];
            finalData["year"] = employeeData[0].Replace("S", "下");
            finalData["form"] = GetFormName(employeeData[1].ToCharArray()[0]);

            finalData["store"] = employeeData[2];
            finalData["filename"] = employeeData[3 - offset];
            // re use variable
            employeeData = employeeData[3 - offset].Split(new char[] { '_' });

            finalData["employee_number"] = employeeData[0];
            finalData["name"] = employeeData[employeeData.Length -1].Split('.')[0];
            
            if (employeeData.Length == 3)
            {
                int con = 0;
                if(int.TryParse(employeeData[1], out con) && con != 0)
                    finalData["insured_number"] = employeeData[1];
                else
                    finalData["insured_number"] = "---"; ;
            }
            else
                finalData["insured_number"] = "---"; ;

            return finalData;
        }

        public string GetFormName(char type)
        {
            switch (type)
            {
                case 'A':
                    return "[A] 畷生会(てっせいかい)";
                case 'B':
                    return "[B] メディカル";
                case 'C':
                    return "[C] 医療情報健康財団";
                case 'D':
                    return "[D] 医療情報健康財団【那須クリニック】";
                case 'E':
                    return "[E] 人間ドック";
                case 'F':
                    return "[F] その他の病院・個別受診";
                case 'G':
                    return "[G] 畷生会(てっせいかい)";
                default:
                    return "-";
            }
        }

        public void formNames_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Name == "tessikai_checkBox")
            {
                if (chk.Checked)
                    MF.search.FormSelected.Add("A");
                else
                    MF.search.FormSelected.Remove("A");
            }
            else if (chk.Name == "medical_checkBox")
            {
                if (chk.Checked)
                    MF.search.FormSelected.Add("B");
                else
                    MF.search.FormSelected.Remove("B");
            }
            else if (chk.Name == "informant_checkBox")
            {
                if (chk.Checked)
                    MF.search.FormSelected.Add("C");
                else
                    MF.search.FormSelected.Remove("C");
            }
            else if (chk.Name == "medicalInformation_checkBox")
            {
                if (chk.Checked)
                    MF.search.FormSelected.Add("D");
                else
                    MF.search.FormSelected.Remove("D");
            }
            else if (chk.Name == "humanDog_checkBox")
            {
                if (chk.Checked)
                    MF.search.FormSelected.Add("E");
                else
                    MF.search.FormSelected.Remove("E");
            }
            else if (chk.Name == "other_checkBox")
            {
                if (chk.Checked)
                    MF.search.FormSelected.Add("F");
                else
                    MF.search.FormSelected.Remove("F");
            }
            else if (chk.Name == "disqualifyOld_checkBox")
            {
                if (chk.Checked)
                    MF.search.FormSelected.Add("G");
                else
                    MF.search.FormSelected.Remove("G");
            }
        }

        public ArrayList ProcessFiles()
        {
            int index = 0;
            foreach (string dir in MF.dTopDir)
            {
                string tempDir = dir.Replace(MF.base_path + @"\", "");
                MF.search.listOfCheckBox.Add(tempDir);
            }

            var listOfItems = OrderList(MF.search.listOfCheckBox);

            foreach (string items in listOfItems.Item1)
            {
                MF.search.sortedListOfCheckBox.Insert(index, items);
                index++;
            }

            foreach (string items in listOfItems.Item2)
            {
                MF.search.sortedListOfCheckBox.Insert(index, items);
                index++;
            }

            index = 0;
            return MF.search.sortedListOfCheckBox;
        }

        private Tuple<ArrayList, ArrayList> OrderList(ArrayList unSortedList)
        {

            int number;

            foreach (string tempList in unSortedList)
            {
                bool success = Int32.TryParse(tempList, out number);
                if (success)
                {
                    MF.search.numberList.Add(tempList);
                }
                else
                {
                    MF.search.stringList.Add(tempList);
                }
            }

            var listOfItems = new Tuple<ArrayList, ArrayList>(MF.search.stringList,  MF.search.numberList);
            return listOfItems;
        }

        public void GenerateStoreNumber()
        {
            //string path = @"\\10.20.0.32\SD_Files\00_ProjectFiles\2021\KONAN\Project Files\02_事業所コードリスト.xlsx";

            var reader = new StreamReader(MF.excel_path);

            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            int counter = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (counter > 0)
                {
                    //listA.Add(values[0]);
                    MF.listOfStoreNumber.Add(values[0]);
                }
                else
                {
                    counter++;
                }

            }
            counter = 0;

            MF.storeNum_textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            MF.storeNum_textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            MF.storeNum_textBox.AutoCompleteCustomSource = MF.listOfStoreNumber;
        }

        public void OpenPDF(string filepath)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "AcroRd32";
            info.UseShellExecute = true;
            //btn.Tag Contains the full file path 
            info.Arguments = filepath;
            Process.Start(info);
        }
    }
}
