using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DocumentSearch
{

    public class Search
    {
        private MainForm MF;
        public ArrayList listOfCheckBox = new ArrayList();
        public ArrayList sortedListOfCheckBox = new ArrayList();
        public ArrayList numberList = new ArrayList();
        public ArrayList stringList = new ArrayList();

        public List<string> YearSelected = new List<string>();
        public List<string> YearChoices = new List<string>();
        public List<string> FormSelected = new List<string>();

        

        public Search(MainForm MainForm)
        {
            MF = MainForm;
        }

        public IEnumerable<string> SearchDocs(string store_number = "", string employee_number = "", string insured_number = "", string full_name = "")
        {
            IEnumerable<string> filepaths = Directory.GetFiles(MF.base_path, "*.pdf", SearchOption.AllDirectories);
            IEnumerable<string> pdf_paths, form_paths, store_paths, filtered_files;
            List<string> temp_paths = new List<string>();
            string reg = "";
            bool noYearSelected = false;
            if (YearSelected.Count <= 0)
            {
                YearSelected = YearChoices.Select(y => (string)y.Clone()).ToList();
                noYearSelected = true;
            }

            // iterate tru years
            foreach (string year in YearSelected)
            {
                if (FormSelected.Count > 0)
                {
                    foreach (string form in FormSelected)
                    {
                        reg += $"{form}$|";
                    }
                    reg = reg.Remove(reg.Length - 1);
                }
                var regex = new Regex(reg, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                reg = "";
                form_paths = Directory.EnumerateDirectories(MF.base_path + @"\" + year, "*", SearchOption.TopDirectoryOnly).Where(dir => regex.IsMatch(dir)).ToArray();
                // iterate tru forms
                foreach (string form in form_paths)
                {
                    reg = (string.IsNullOrEmpty(store_number) ? "" : $"{store_number}$");
                    regex = new Regex(reg, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    reg = "";
                    store_paths = Directory.EnumerateDirectories(form, "*", SearchOption.TopDirectoryOnly).Where(dir => regex.IsMatch(dir)).ToArray();

                    string form_letter = form.Replace(MF.base_path + @"\" + year + @"\", "");
                    if (!string.IsNullOrEmpty(employee_number))
                    {
                        reg += employee_number + "|";
                    }
                    else if (!string.IsNullOrEmpty(insured_number) )
                    {
                        reg += insured_number + "|";
                    }

                    if (!string.IsNullOrEmpty(full_name))
                    {
                        reg += full_name + "|";
                    }

                    if (!string.IsNullOrEmpty(reg))
                        reg = reg.Remove(reg.Length - 1);

                    regex = new Regex(reg, RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    reg = "";

                    // iterate tru stores
                    foreach (string store in store_paths)
                    {
                        pdf_paths = Directory.GetFiles(store, "*.pdf", SearchOption.TopDirectoryOnly).Where(dir =>
                        {
                            dir = dir.Replace(store, "");
                            return regex.IsMatch(dir);
                        }).ToArray();
                        foreach (string pdf in pdf_paths)
                        {
                            string[] temp_path = pdf.Replace($"{store}\\", "").Split('_');
                            if (temp_path[temp_path.Length - 1].Replace(".pdf", "").Contains(full_name))
                            {
                                if (
                                    ((string.IsNullOrEmpty(employee_number) && string.IsNullOrEmpty(insured_number)))
                                )
                                {
                                    temp_paths.Add(pdf);
                                }
                                else if((temp_path.Length == 3 ) && (temp_path[0].Contains(employee_number) && temp_path[1].Contains(insured_number)))
                                {
                                    temp_paths.Add(pdf);
                                }
                                else if (temp_path.Length == 2 && string.IsNullOrEmpty(insured_number) && temp_path[0].Contains(employee_number))
                                {
                                    temp_paths.Add(pdf);
                                }
                            }
                        }
                    }
                }

            }

            if (noYearSelected)
                YearSelected.Clear();

            filtered_files = temp_paths;

            return filtered_files;
        }
    }
}
