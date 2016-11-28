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
                button1.Enabled = true;
            else
                button1.Enabled = false;
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
                    message = "Ok";
                    Succes++;
                }
                else
                    message = result.ToString();
                //Affichage du résultat
                // TODO: mettre un timer de quelques secondes
                MessageBox.Show(message, "");
            }
        }

        private void AfficheNombre()
        {
            // Préparation du formulaire: création des opérandes
            Random rdm = new Random();
            int Nombre = rdm.Next(10, 99);
            label_Operande1.Text = Nombre.ToString();
            Nombre = rdm.Next(10, 99);
            label_Operande2.Text = Nombre.ToString();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Somme();
            AfficheNombre();
            NombreAddition++;
            button1.Text = "Addition Suivante : " + NombreAddition.ToString() + "/10";
            textBox_Resultat.Text = "";
            if (NombreAddition == 11)
            {
                button1.Text = "Résultat";
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

