﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAbsences.WinForms.view;

namespace GestionAbsences.WinForms
{

    /// <summary>
    /// Application de gestion des contancts
    /// </summary>
    internal class NamespaceDoc

     { 

     }

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
            Application.Run(new FormConnexion());
        }
    }
}
