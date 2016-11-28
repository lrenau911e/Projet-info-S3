using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projet_info_S3
{
    public partial class Form_Calcul_mental : Form
    {
        public Form_Calcul_mental()
        {
            InitializeComponent();
        }

        private void button_Addition_Click(object sender, EventArgs e)
        {
            Form_Addition Addition = new Form_Addition();
            Addition.ShowDialog();
        }

        private void button_Soustraction_Click(object sender, EventArgs e)
        {
            Form_Soustraction Soustraction = new Form_Soustraction();
            Soustraction.ShowDialog();
        }

        private void button_Multiplication_Click(object sender, EventArgs e)
        {
            Form_Multiplication Multiplication = new Form_Multiplication();
            Multiplication.ShowDialog();
        }

        private void button_Division_Click(object sender, EventArgs e)
        {
            Form_Division Division = new Form_Division();
            Division.ShowDialog();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
