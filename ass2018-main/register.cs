using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            /*iDTextBox.Text = null;
            nameTextBox.Text = null;
            surnameTextBox.Text = null;
            genderTextBox.Text = null;
            eMAILTextBox.Text = null;
            passwordTextBox.Text = null;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            Hide();
        }

        private void runBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.runBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void register_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.run". При необходимости она может быть перемещена или удалена.
           runTableAdapter.Fill(dataSet1.run);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataSet1.run.NewrunRow newRunRow;
            //newRunRow = dataSet1.run.NewrunRow;

            if (ppas.Text == passwordTextBox.Text)
            {
                try
                {
                    //this.dataSet1.run.AddrunRow(newUserRow);

                    //this.runTableAdapter.Update(this.dataSet1.run);
                    // runTableAdapter.Insert(dataSet1.run);

                    runTableAdapter.Insert(Int32.Parse(iDTextBox.Text), eMAILTextBox.Text, passwordTextBox.Text, nameTextBox.Text,
                        surnameTextBox.Text, dateDateTimePicker.Value, countryTextBox.Text, genderTextBox.Text);
                    MessageBox.Show("Регистрация прошла успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка регистрации: { ex.Message}");
                }
            }

            else if (ppas.Text != passwordTextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void openImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.png; *.jpeg; *.jpg)|*.png; *.jpeg; *.jpg|AllFiles(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                imageName.Text = ofd.SafeFileName;
            }
        }
    }
}
