﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoLista alumList = new AlumnoLista();
            alumList.ShowDialog();
            
        }
    }
}
