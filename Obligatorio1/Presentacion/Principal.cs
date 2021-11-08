using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Obligatorio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void aBMDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSocio = Presentacion.frmSocio.Instancia();
            frmSocio.MdiParent = this;
            frmSocio.Show();
            frmSocio.Activate();
        }

        private void aBMDeEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmEspecialidad = Presentacion.frmEspecialidad.Instancia();
            frmEspecialidad.MdiParent = this;
            frmEspecialidad.Show();
            frmEspecialidad.Activate();
        }

        private void nuevaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmConsulta = Presentacion.frmConsulta.Instancia();
            frmConsulta.MdiParent = this;
            frmConsulta.Show();
            frmConsulta.Activate();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Estadisticas = Presentacion.Estadisticas.Instancia();
            Estadisticas.MdiParent = this;
            Estadisticas.Show();
            Estadisticas.Activate();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
