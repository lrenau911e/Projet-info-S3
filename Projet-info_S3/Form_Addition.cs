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
        public Form_Addition()
        {
            InitializeComponent();

            // Préparation du formulaire: création des opérandes
            Random rdm = new Random();
            rdm.Next(10, 99);
            int Nombre = Convert.ToInt32(rdm);
            label_Operande1.Text = Nombre.ToString();
            rdm.Next(10, 99);
            Nombre = Convert.ToInt32(rdm);
            label_Operande2.Text = Nombre.ToString();
        }

        private void textBox_Resultat_TextChanged(object sender, EventArgs e)
        {
            int saisie = Convert.ToInt32(textBox_Resultat.Text);
            // gestion du résultat
           string message = "";
           int result = Convert.ToInt32(label_Operande1.Text) + Convert.ToInt32(label_Operande2.Text);
            if (saisie == result)
            message = "Ok";
            else
                message = result.ToString();

            //Affichage du résultat
            MessageBox.Show(message, "");
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            int Score=0; // attention à ce que ça ne se remettre pas à 0 (sérialization?)
            bool ok = false;
            
           for (int i = 0; i < 10; i++)
           {
               if (ok == true)
                   Score++;            
               //Réitération du formulaire
           }
           Score = Score * 10;
           string message = "Voici votre résultat: \n" + Score + " %";
           MessageBox.Show(message, "Score");
        }

    }
}
