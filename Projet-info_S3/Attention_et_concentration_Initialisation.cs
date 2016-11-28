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
    public partial class Attention_et_Concentration_Initialisation : Form
    {
        public Attention_et_Concentration_Initialisation()
        {
            InitializeComponent();
        }

        private void Retour_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Btn_Menu.Enabled = false;
        }
    }
}
