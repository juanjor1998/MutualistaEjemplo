using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Obligatorio1.Presentacion
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        #region Patron Singleton
        private static Estadisticas unForm = null;
        public static Estadisticas Instancia()
        {
            if(unForm==null)
            {
                unForm=new Estadisticas();
            }
            return unForm;
        }
        #endregion

        #region Auxiliares
        private void Listar()
        {
            Dominio.Mutualista unaMutualista=new Dominio.Mutualista();
            this.lstEspecialidades.DataSource = null;
            this.lstEspecialidades.DataSource = unaMutualista.ListaE();
            this.lstSocios2.DataSource = null;
            this.lstSocios2.DataSource = unaMutualista.ListaS();
            this.lstSocios1.DataSource = null;
            this.lstConsultas.DataSource = null;
        }
        #endregion

        #region Botones
        private void btnEspecialidadMax_Click(object sender, EventArgs e)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista(); //instancia la clase mutualista
            this.lstEspsMax.DataSource = null;
            List<Dominio.Especialidad> unaEspecialidad = unaMutualista.especialidadConMasConsultas();
            if (unaEspecialidad != null)
            {
                this.lstEspsMax.DataSource = unaEspecialidad;
            }
            else
            {
                this.lstEspsMax.Items.Remove("NO HAY ESPECIALIDADES");
                this.lstEspsMax.Items.Add("NO HAY ESPECIALIDADES");
            }
        }
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            this.Listar();
            this.lstEspsMax.DataSource = null;
        }
        private void btnSocio_Especialidad_Click(object sender, EventArgs e)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            if (this.lstEspecialidades.SelectedIndex > -1)
            {
                string especialidadSt = this.lstEspecialidades.SelectedItem.ToString();
                string[] especialidadArr = especialidadSt.Split(' ');
                short especialidadId = short.Parse(especialidadArr[0]);
                List<Dominio.Socio> listaSocios = unaMutualista.listaSociosDadaEspecialidad(especialidadId);
                this.lstSocios1.DataSource = null;
                this.lstSocios1.DataSource = listaSocios;
            }
        }
        private void btnConsulta_Socio_Click(object sender, EventArgs e)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            if (this.lstSocios2.SelectedIndex > -1)
            {
                string socioSt = this.lstSocios2.SelectedItem.ToString();
                string[] socioArr = socioSt.Split(' ');
                short socioId = short.Parse(socioArr[0]);
                List<Dominio.Consulta> listaConsultas = unaMutualista.listaConsultasDadoSocio(socioId);
                this.lstConsultas.DataSource = null;
                this.lstConsultas.DataSource = listaConsultas;
            }
        }
        #endregion

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.lstEspsMax.DataSource = null;
        }
    }
}
