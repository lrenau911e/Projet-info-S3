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
            this.Hide();
            Btn1_PMA.Enabled = false;
            Application.Run(new Form_Perception_et_memoire_associative());
        }

        private void Btn2_PMA_Click(object sender, EventArgs e)
        {
            Application.Run(new Form_Perception_et_memoire_associative());
        }

        private void Btn1_AC_Click(object sender, EventArgs e)
        {
            Application.Run(new Attention_et_Concentration());
        }

        private void Btn2_AC_Click(object sender, EventArgs e)
        {
            Application.Run(new Attention_et_Concentration());
        }

        private void Btn1_CM_Click(object sender, EventArgs e)
        {
            Application.Run(new Form_Calcul_mental());
        }

        private void Btn2_CM_Click(object sender, EventArgs e)
        {
            Application.Run(new Form_Calcul_mental());
        }

        private void Btn1_PM_Click(object sender, EventArgs e)
        {
            Application.Run(new Form_Problemes_mathematiques());
        }

        private void Btn2_PM_Click(object sender, EventArgs e)
        {
            Application.Run(new Form_Problemes_mathematiques());
        }

        private void Btn1_PP_Click(object sender, EventArgs e)
        {
            Application.Run(new Problemes_Physiques());
        }

        private void Btn2_PP_Click(object sender, EventArgs e)
        {
            Application.Run(new Problemes_Physiques());
        }
    }
}
