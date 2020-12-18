using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CalcularIdade_Click(object sender, EventArgs e)
        {
            int idade = DateTime.Now.Year - dtpNascimento.Value.Year;
            if (DateTime.Now.DayOfYear < dtpNascimento.Value.DayOfYear) idade--;
            MessageBox.Show("Tem " + idade + " anos de idade"); 
        }
    }
}
