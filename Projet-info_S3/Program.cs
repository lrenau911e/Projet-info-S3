﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Projet_info_S3
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_Menu_principal LeMenu = new Form_Menu_principal();
            Application.Run(LeMenu);
            //Application.Run(new Form_Addition());

        }
    }
}
