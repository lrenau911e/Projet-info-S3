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
    public partial class Form_Addition : Form
    {
        public int NombreAddition = 0;
        public int Succes = 0;

        public Form_Addition()
        {
            InitializeComponent();
        }

        private void textBox_Resultat_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Resultat.Text != "")
            {
                buttonCommencer.Enabled = true;
            }
            else
            {
                buttonCommencer.Enabled = false;
            }

        }

        private void Somme()
        {
            if (textBox_Resultat.Text != "")
            // Faire une méthode
            { 
                int saisie = Convert.ToInt32(textBox_Resultat.Text);
                // gestion du résultat
                string message = "";
                int result = Convert.ToInt32(label_Operande1.Text) + Convert.ToInt32(label_Operande2.Text);
                if (saisie == result)
                {
                    message = "Ok vous avez entré le bon résultat";
                    Succes++;
                }
                else
                    message = "Faux, le résultat est : "+result.ToString();
                //Affichage du résultat
                // TODO: mettre un timer de quelques secondes
                MessageBox.Show(message, "Solution");
            }
        }

        private void AfficheNombre()
        {
            // Préparation du formulaire: création des opérandes
            Random rdm = new Random();
            int Nombre = rdm.Next(100, 999);
            label_Operande1.Text = Nombre.ToString();
            Nombre = rdm.Next(100, 999);
            label_Operande2.Text = Nombre.ToString();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            buttonCommencer.Enabled = false;
            textBox_Resultat.Enabled = true;
            Somme();
            AfficheNombre();
            NombreAddition++;
            buttonCommencer.Text = "Addition Suivante : " + NombreAddition.ToString() + "/10";
            textBox_Resultat.Text = "";
            if (NombreAddition == 11)
            {
                buttonCommencer.Text = "Résultat";
                AfficheResultat();
                NombreAddition++;
            }
            if (NombreAddition == 12)
                this.Close();

        }

        private void AfficheResultat()
        {
            Succes = Succes * 10;
            string score = "Voici votre résultat: \n" + Succes + " %";
            MessageBox.Show(score, "Score");
        }

    }
    }

