using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.ZargarovAA.Sprint7.V13.Lib;

namespace Tyuiu.ZargarovAA.Sprint7.V13
{
    public partial class FormMain_ZAA : Form
    {
        public FormMain_ZAA()
        {
            InitializeComponent();
        }



        

        private void iconButtonBrowse_ZAA_Click(object sender, EventArgs e)
        {
            dataGridViewBD_ZAA.DataSource = ReadCSVFile($@"{Directory.GetCurrentDirectory()}\DataBase.csv");
        }

        private void iconButtonSave_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_ZAA.FileName = "DataBase.csv";
                saveFileDialog_ZAA.InitialDirectory = @":C";
                if (saveFileDialog_ZAA.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_ZAA.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewBD_ZAA.RowCount;
                    int columns = dataGridViewBD_ZAA.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewBD_ZAA.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(",");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void iconButtonInfo_ZAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void iconButtonHelp_ZAA_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void iconButtonSearch_ZAA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewBD_ZAA.RowCount; i++)
            {
                dataGridViewBD_ZAA.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewBD_ZAA.ColumnCount; j++)
                    if (dataGridViewBD_ZAA.Rows[i].Cells[j].Value != null)
                        if (dataGridViewBD_ZAA.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_ZAA.Text))
                        {
                            dataGridViewBD_ZAA.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        private DataTable ReadCSVFile(string pathToCsvFile)
        {
            //создаём таблицу
            DataTable dt = new DataTable("countries");
            //создаём колонки
            DataColumn country;
            country = new DataColumn("Страна", typeof(String));
            DataColumn capital;
            capital = new DataColumn("Столица", typeof(String));
            DataColumn population;
            population = new DataColumn("Население(млн)", typeof(Int32));
            DataColumn square;
            square = new DataColumn("Площадь(км^2)", typeof(Int32));
            DataColumn currency;
            currency = new DataColumn("Валюта", typeof(String));
            DataColumn nationality;
            nationality = new DataColumn("Национальность");

            //добавляем колонки в таблицу
            dt.Columns.AddRange(new DataColumn[] { country, capital, population, square, currency, nationality });
            try
            {
                DataRow dr = null;
                string[] value = null;
                string[] countries = File.ReadAllLines(pathToCsvFile);
                for (int i = 0; i < countries.Length; i++)
                {
                    if (!String.IsNullOrEmpty(countries[i]))
                    {
                        value = countries[i].Split(',');
                        //создаём новую строку
                        dr = dt.NewRow();
                        dr["Страна"] = value[0];
                        dr["Столица"] = value[1];
                        dr["Население(млн)"] = Int32.Parse(value[2]);
                        dr["Площадь(км^2)"] = Int32.Parse(value[3]);
                        dr["Валюта"] = (value[4]);
                        dr["Национальность"] = (value[5]);
                        //добавляем строку в таблицу
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }




        private void groupBoxPanel_ZAA_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxBD_ZAA_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewBD_ZAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButtonClosse_ZAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_ZAA_Load(object sender, EventArgs e)
        {
            // Установка свойств для кнопки закрытия
            iconButtonClosse_ZAA.FlatStyle = FlatStyle.Flat;
            iconButtonClosse_ZAA.FlatAppearance.BorderSize = 0;
        }
        private void iconButtonAverage_ZAA_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < dataGridViewBD_ZAA.Rows.Count; i++)
            {
                c += Convert.ToInt32(dataGridViewBD_ZAA.Rows[i].Cells[2].Value);
            }
            int rows = dataGridViewBD_ZAA.Rows.Count - 1;
            double avg = c / rows;
            avg = Math.Round(avg, 2);
            textBoxAverage_ZAA.Text = avg.ToString();
        }

        private void iconButtonGraf_ZAA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBD_ZAA.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string xValue = row.Cells[0].Value.ToString();
                    double yValue = Convert.ToDouble(row.Cells[2].Value);


                }
            }
        }
    }

}