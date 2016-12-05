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
    public partial class Form_Perception_et_memoire_associative : Form
    {
        int NombreTest = 1;
        int Succes = 0;

        public Form_Perception_et_memoire_associative()
        {
            InitializeComponent();
        }

        private void AfficheResultat()
        {
            Succes = Succes * 10;
            string score = "Voici votre résultat: \n" + Succes + " %";
            MessageBox.Show(score, "Score");
        }

        public void RemiseAZero()
        {
            label_Rep1.Visible = true;
            label_Rep1.Text = "";//TODO: relier à la base de donnée
            label_ope1.Visible = true;
            textBox_Rep1.Visible = true;
            textBox_Rep1.Text = "";

            label_Rep2.Visible = false;
            label_Rep2.Text = "";//TODO: relier à la base de donnée
            label_ope2.Visible = false;
            textBox_Rep2.Visible = false;
            textBox_Rep2.Text = "";

            label_Rep3.Visible = false;
            label_Rep3.Text = "";//TODO: relier à la base de donnée
            label_ope3.Visible = false;
            textBox_Rep3.Visible = false;
            textBox_Rep3.Text = "";
            buttonCommencer.Enabled = false;
        }

        private void buttonCommencer_Click(object sender, EventArgs e)
        {
            //Ouverture d'une page avec les images avec affichage de la consigne
            RemiseAZero();
            textBox_Instruction.Text = ""; //TODO: relier à la base de donnée
            buttonCommencer.Text = "Problème Suivant : " + NombreTest.ToString() + "/10";

            NombreTest++;
            if (NombreTest == 11)
            {
                buttonCommencer.Text = "Résultat";
                AfficheResultat();
                NombreTest++;
            }
            if (NombreTest == 12)
                this.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Rep1.Text == "")
                Succes++;
            label_Rep2.Visible = true;
            label_Rep2.Text = "";//TODO: relier à la base de donnée
            label_ope2.Visible = true;
            textBox_Rep2.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Rep2.Text == "")
                Succes++;
            label_Rep3.Visible = true;
            label_Rep3.Text = "";//TODO: relier à la base de donnée
            label_ope3.Visible = true;
            textBox_Rep3.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Rep3.Text == "")
                Succes++;
            buttonCommencer.Enabled = true;
        }


    }
}
