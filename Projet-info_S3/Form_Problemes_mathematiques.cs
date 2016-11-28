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
    public partial class Form_Problemes_mathematiques : Form
    {
        int NombrePb = 1;
        int Succes = 0;

        public Form_Problemes_mathematiques()
        {
            InitializeComponent();
        }

        private void AfficheResultat()
        {
            Succes = Succes * 10;
            string score = "Voici votre résultat: \n" + Succes + " %";
            MessageBox.Show(score, "Score");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Instruction.Text = ""; //TODO: relier à la base de donnée
            buttonCommencer.Text = "Problème Suivant : " + NombrePb.ToString() + "/10";
            checkBox_Rep1.Visible = true;
            checkBox_Rep1.Text = "";//TODO: relier à la base de donnée
            checkBox_Rep2.Visible = true;
            checkBox_Rep2.Text = "";//TODO: relier à la base de donnée
            checkBox_Rep3.Visible = true;
            checkBox_Rep3.Text = "";//TODO: relier à la base de donnée
            checkBox_Rep4.Visible = true;
            checkBox_Rep4.Text = "";//TODO: relier à la base de donnée

            /*if (checkBox_Rep1.Checked == true)
            {
                checkBox_Rep2.Enabled = false;
                checkBox_Rep3.Enabled = false;
                checkBox_Rep4.Enabled = false;
            }

            if (checkBox_Rep2.Checked == true)
            {
                checkBox_Rep1.Enabled = false;
                checkBox_Rep3.Enabled = false;
                checkBox_Rep4.Enabled = false;
            }

            if (checkBox_Rep3.Checked == true)
            {
                checkBox_Rep1.Enabled = false;
                checkBox_Rep2.Enabled = false;
                checkBox_Rep4.Enabled = false;
            }

            if (checkBox_Rep4.Checked == true)
            {
                checkBox_Rep1.Enabled = false;
                checkBox_Rep2.Enabled = false;
                checkBox_Rep3.Enabled = false;
            }*/

            NombrePb++;
            if (NombrePb == 11)
            {
                buttonCommencer.Text = "Résultat";
                AfficheResultat();
                NombrePb++;
            }
            if (NombrePb == 12)
                this.Close();
        }
    }
}
