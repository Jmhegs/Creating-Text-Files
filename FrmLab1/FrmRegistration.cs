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


namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getInput2 = textBox1.Text;
            string getInput3 = textBox2.Text;
            string getInput4 = textBox3.Text;
            string getInput5 = dateTimePicker1.Text;
            string getInput6 = comboBox1.Text;
            string getInput7 = textBox4.Text;
            string getInput8 = textBox5.Text;
            string getInput9 = comboBox2.Text;
            string getInput10 = textBox6.Text;
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            getInput2 + ".txt")))
            {
                outputFile.WriteLine("Student No:" + getInput2);
                outputFile.WriteLine("Last Name:" + getInput3);
                outputFile.WriteLine("Age:" + getInput4);
                outputFile.WriteLine("Birthday:" + getInput5);
                outputFile.WriteLine("Program:" + getInput6);
                outputFile.WriteLine("First Name:" + getInput7);
                outputFile.WriteLine("MI:" + getInput8);
                outputFile.WriteLine("Gender:" + getInput9);
                outputFile.WriteLine("Contact No:" + getInput10);

            }

        }
    }
}
