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
    public partial class Form_Menu_principal : Form
    {
        public Form_Menu_principal()
        {
            InitializeComponent();
        }

        private void Btn1_PMA_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn1_PMA.Enabled = false;
            Form_Perception_et_memoire_associative Exo_Perception1 = new Form_Perception_et_memoire_associative(); Form_Addition Addition = new Form_Addition();
            Exo_Perception1.ShowDialog();
        }

        private void Btn2_PMA_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn2_PMA.Enabled = false;
            Form_Perception_et_memoire_associative Exo_Perception2 = new Form_Perception_et_memoire_associative();
            Exo_Perception2.ShowDialog();
        }

        private void Btn1_AC_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn1_AC.Enabled = false;
            Attention_et_Concentration_Initialisation Exo_Attention1 = new Attention_et_Concentration();
            Exo_Attention1.ShowDialog();
        }

        private void Btn2_AC_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn2_AC.Enabled = false;
            Attention_et_Concentration Exo_Attention2 = new Attention_et_Concentration();
            Exo_Attention2.ShowDialog();
        }

        private void Btn1_CM_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn1_CM.Enabled = false;
            Form_Calcul_mental Exo_Calcul1 = new Form_Calcul_mental();
            Exo_Calcul1.ShowDialog();
        }

        private void Btn2_CM_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn2_CM.Enabled = false;
            Form_Calcul_mental Exo_Calcul2 = new Form_Calcul_mental();
            Exo_Calcul2.ShowDialog();
        }

        private void Btn1_PM_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn1_PM.Enabled = false;
            Form_Problemes_mathematiques Exo_ProbMaths1 = new Form_Problemes_mathematiques();
            Exo_ProbMaths1.ShowDialog();
        }

        private void Btn2_PM_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn2_PM.Enabled = false;
            Form_Problemes_mathematiques Exo_ProbMaths2 = new Form_Problemes_mathematiques();
            Exo_ProbMaths2.ShowDialog();
        }

        private void Btn1_PP_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn1_PP.Enabled = false;
            Problemes_Physiques Exo_ProbPhys1 = new Problemes_Physiques();
            Exo_ProbPhys1.ShowDialog();
        }

        private void Btn2_PP_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Btn2_PP.Enabled = false;
            Problemes_Physiques Exo_ProbPhys2 = new Problemes_Physiques();
            Exo_ProbPhys2.ShowDialog();
        }
    }
}
