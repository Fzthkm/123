using System;
using System.IO;
using System.Windows.Forms;

namespace testRcomr
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridFill();
        }

        public void GridFill()
        {
            string path = "E:\\test";
            string pathTo = "E:\\final";
            string[] directories = Directory.GetDirectories(path);
            DirectoryInfo dir = new DirectoryInfo(pathTo);
            if (dir.Exists)
                dir.Delete(true);
            foreach (string d in directories)
            {
                DirectoryInfo info = new DirectoryInfo(d);
                string Date = info.Name.Substring(0, 10).ToString();
                string str = info.Name.Substring(11).Trim();
                string Org = str.Substring(0, str.IndexOf('-')).Trim();
                string Name = str.Substring(str.IndexOf('-') + 1).Trim();
                //info.Name.Substring(0,10).ToString(),info.Name,info.Name

                Grid1.Rows.Add(false, Date, Org, Name, info.FullName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void filter_Click(object sender, EventArgs e)
        {
            Grid1.Rows.Clear();
            Grid1.Refresh();
            GridFill();
            if (!string.IsNullOrEmpty(from.Text))
            {
                try
                {
                    DateTime Datefrom = DateTime.ParseExact(from.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    for (int i = 0; i < Grid1.Rows.Count; i++)
                    {
                        DateTime gridDate = DateTime.ParseExact(Grid1.Rows[i].Cells[1].Value.ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                        if (gridDate < Datefrom)
                        {
                            Grid1.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при указании даты. Дата должна быть в формате YYYY-MM-DD");
                }
            }
            if (!string.IsNullOrEmpty(to.Text))
            {
                try
                {
                    DateTime Dateto = DateTime.ParseExact(from.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    for (int i = 0; i < Grid1.Rows.Count; i++)
                    {
                        DateTime gridDate = DateTime.ParseExact(Grid1.Rows[i].Cells[1].Value.ToString(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                        if (gridDate > Dateto)
                        {
                            Grid1.Rows.RemoveAt(i);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при указании даты. Дата должна быть в формате YYYY-MM-DD");
                }
            }
            if (!string.IsNullOrEmpty(Organisation.Text))
            {
                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    if (!Grid1.Rows[i].Cells[2].Value.ToString().ToLower().Contains(Organisation.Text.ToLower()))
                    {
                        Grid1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (!string.IsNullOrEmpty(StuffName.Text))
            {
                for (int i = 0; i < Grid1.Rows.Count; i++)
                {
                    if (!Grid1.Rows[i].Cells[3].Value.ToString().ToLower().Contains(StuffName.Text.ToLower()))
                    {
                        Grid1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Grid1.Rows.Count - 1; i++)
            {
                if (Grid1.Rows[i].Cells[0].Value.ToString() != "False")
                {
                    string[] files = Directory.GetFiles(Grid1.Rows[i].Cells[4].Value.ToString());
                    foreach (string path in files)
                    {
                        string pathTo = @"E:\final\";
                        FileInfo file = new FileInfo(path);
                        if (file.Exists)
                        {
                            pathTo = pathTo + file.Directory.Name.ToString();
                            DirectoryInfo dir = new DirectoryInfo(pathTo);
                            if (!dir.Exists)
                            {
                                dir.Create();
                            }
                            pathTo = pathTo + "\\" + file.Name.ToString();
                            file.CopyTo(pathTo, true);
                        }
                    }
                }
            }
            MessageBox.Show("Выбранные файлы успешно скопированы.");
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            Grid1.Rows.Clear();
            Grid1.Refresh();
            GridFill();
            for (int i = 0; i < Grid1.Rows.Count; i++)
                Grid1.Rows[i].Cells[0].Value = true;
        }
    }
}
