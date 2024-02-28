using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_01
{
    public partial class PhoneForm : Form
    {
        public static string getSurName
        {
            get; set;
        }
        public static string getAdress 
        {
            get; set;
        }
        public static string getPhone 
        { 
            get; set; 
        }
        public static string getSearch
        {
            get; set;
        }

        public PhoneForm()
        {
            InitializeComponent();
        }

        private void MenuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            InputPhone input = new InputPhone();
            input.ShowDialog();
            
            string surname = PhoneForm.getSurName;
            string address = PhoneForm.getAdress;
            string phone = PhoneForm.getPhone;

            int rowIndex = dataGridViewOrigin.Rows.Add();
            dataGridViewOrigin.Rows[rowIndex].Cells[0].Value = surname;
            dataGridViewOrigin.Rows[rowIndex].Cells[1].Value = address;
            dataGridViewOrigin.Rows[rowIndex].Cells[2].Value = phone;
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOrigin.SelectedRows)
            {
                dataGridViewOrigin.Rows.RemoveAt(row.Index);
            }
        }

        private void MenuItemSort_Click(object sender, EventArgs e)
        {
            dataGridViewOrigin.Sort(dataGridViewOrigin.Columns["ColmSurName"], ListSortDirection.Ascending);
        }

        private void MenuItemSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();

            string surName = PhoneForm.getSearch;
            foreach (DataGridViewRow r in dataGridViewOrigin.Rows)
            {
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.FormattedValue.ToString().Contains(surName))
                    {
                        dataGridViewOrigin.Rows[r.Index].Cells[c.ColumnIndex].Selected = true;
                    }

                }
            }
        }

        private void MenuItemLoading_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "source.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                dataGridViewOrigin.Rows.Clear();
                string filePath = openFileDialog1.FileName;
                StreamReader reader = new StreamReader(filePath);
                while (!reader.EndOfStream)
                {
                    // Читаем строки из файла
                    string lastName = reader.ReadLine();
                    string address = reader.ReadLine();
                    string phone = reader.ReadLine();

                    // Добавляем значения в DataGridView
                    int rowIndex = dataGridViewOrigin.Rows.Add();
                    dataGridViewOrigin.Rows[rowIndex].Cells[0].Value = lastName;
                    dataGridViewOrigin.Rows[rowIndex].Cells[1].Value = address;
                    dataGridViewOrigin.Rows[rowIndex].Cells[2].Value = phone;
                }

                // Закрываем файл
                reader.Close();
                MessageBox.Show("Данные из файла загруженны");
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "source.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string filePath = saveFileDialog1.FileName;
                StreamWriter writer = new StreamWriter(filePath);
                for (int i = 0; i < dataGridViewOrigin.Rows.Count - 1; i++) {
                    for (int index = 0; index < dataGridViewOrigin.Rows[i].Cells.Count; index++) {
                        writer.WriteLine(dataGridViewOrigin.Rows[i].Cells[index].Value);
                    } 
                }
                writer.Close();
                MessageBox.Show("Файл Сохранён");
            }
        }
    }
}
