using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class InputPhone : Form
    {
        public InputPhone()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TbxAddress.Text != "" && TbxSurname.Text != "" && MtbxPhone.Text != "") 
            {
                PhoneForm.getAdress = TbxAddress.Text;
                PhoneForm.getPhone = MtbxPhone.Text;
                PhoneForm.getSurName = TbxSurname.Text;
                Close();
            }
            else 
            {
                MessageBox.Show("Заполните поля для ввода!");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
