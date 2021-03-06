﻿using HolaWindowsForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaWindowsForms
{
    public partial class frmMdiPadre : Form
    {
        public frmMdiPadre()
        {
            InitializeComponent();
        }

        private void inicioDeSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin.Instancia.MdiParent = this;
            FormLogin.Instancia.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form formGrid = new FormGrid();
            formGrid.MdiParent = this;
            formGrid.Show();
        }

        private void frmMdiPadre_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Aplicación cargada correctamente.";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MaestroDetalleVentas.Instancia.MdiParent = this;
            MaestroDetalleVentas.Instancia.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var frmPrueba = new MyNumericInputBox().Show();
            MessageBox.Show(frmPrueba.ToString());
        }
    }
}
