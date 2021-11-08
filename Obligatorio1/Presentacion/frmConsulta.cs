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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        #region Patron Singleton
        private static frmConsulta unForm = null;
        public static frmConsulta Instancia()
        {
            if (unForm == null)
            {
                unForm = new frmConsulta();
            }
            return unForm;
        }
        #endregion

        #region Auxiliares
        private void Limpiar()
        {
            this.txtId.Clear();
            this.txtSocio.Clear();
            this.txtEspecialidad.Clear();
            this.lblMensaje.Text = "";
            this.dtpFecha.ResetText();
            this.txtHora.Text = "00";
            this.txtMinuto.Text = "00";
            this.txtId.Focus();
        }
        private Boolean faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtSocio.Text == "" || this.txtEspecialidad.Text == "" || this.txtHora.Text == "" || this.txtMinuto.Text == "")
            {
                return true;
            }
            return false;
        }
        private void Listar()
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            this.lstConsultas.DataSource = null;
            this.lstConsultas.DataSource = unaMutualista.ListaC();
            this.lstConsultas.SelectedIndex = -1;
            this.lstEspecialidades.DataSource = null;
            this.lstEspecialidades.DataSource = unaMutualista.ListaE();
            this.lstEspecialidades.SelectedIndex = -1;
            this.lstSocios.DataSource = null;
            this.lstSocios.DataSource = unaMutualista.ListaS();
            this.lstSocios.SelectedIndex = -1;
        }
        private void CargarSocio(short pId)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            Dominio.Socio unSocio = unaMutualista.buscarSocio(pId);
            this.txtSocio.Text = unSocio.ToString();
        }
        private void CargarEspecialidad(short pId)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            Dominio.Especialidad unaEspecialidad = unaMutualista.buscarEspecialidad(pId);
            this.txtEspecialidad.Text = unaEspecialidad.ToString();
        }
        private Dominio.Socio socioSeleccionado()
        {
            if (this.txtSocio.Text != "")
            {
                Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
                string socioSt = this.txtSocio.ToString();
                string[] socioArr = socioSt.Split(' ');
                short socioId = short.Parse(socioArr[2]);
                Dominio.Socio socioOb = unaMutualista.buscarSocio(socioId);
                if (socioOb!=null)
                {
                    return socioOb;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        private Dominio.Especialidad especialidadSeleccionada()
        {
            if (this.txtEspecialidad.Text != "")
            {
                Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
                string especialidadSt = this.txtEspecialidad.ToString();
                string[] especialidadArr = especialidadSt.Split(' ');
                short especialidadId = short.Parse(especialidadArr[2]);
                Dominio.Especialidad especialidadOb = unaMutualista.buscarEspecialidad(especialidadId);
                if (especialidadOb != null)
                {
                    return especialidadOb;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion
        private void frmConsulta_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Listar();
        }

        #region Botones

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            { 
                Dominio.Socio socio = this.socioSeleccionado();
                Dominio.Especialidad especialidad = this.especialidadSeleccionada();
                if (socio != null && especialidad != null)
                {
                    Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
                    short id = short.Parse(this.txtId.Text);
                    DateTime fecha = this.dtpFecha.Value;
                    string hora = this.txtHora.Text;
                    string minuto = this.txtMinuto.Text;
                    Dominio.Consulta unaConsulta = new Dominio.Consulta(id, fecha, hora, minuto, especialidad, socio);
                    if (unaMutualista.AltaConsulta(unaConsulta))
                    {
                        this.Listar();
                        this.Limpiar();
                        this.lblMensaje.Text = "Consulta ingresada con exito";
                    }
                    else
                    {
                        this.lblMensaje.Text = "Ya existe una Consulta con ese ID";
                        this.txtId.Focus();
                    }
                }
                else
                {
                    this.lblMensaje.Text = "Compruebe que el socio y la especialidad existan";
                }
            }
            else
            {
                this.lblMensaje.Text = "Ingrese todos los datos";
            }
            this.lstSocios.SelectedIndex = -1;
            this.lstEspecialidades.SelectedIndex = -1;
            this.lstConsultas.SelectedIndex = -1;
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                Dominio.Socio socio = this.socioSeleccionado();
                Dominio.Especialidad especialidad = this.especialidadSeleccionada();
                if (socio != null && especialidad != null)
                {
                    Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
                    short id = short.Parse(this.txtId.Text);
                    DateTime fecha = this.dtpFecha.Value;
                    string hora = this.txtHora.Text;
                    string minuto = this.txtMinuto.Text;
                    Dominio.Consulta unaConsulta = new Dominio.Consulta(id, fecha, hora, minuto, especialidad, socio);
                    if (unaMutualista.BajaConsulta(unaConsulta))
                    {
                        this.Listar();
                        this.Limpiar();
                        this.lblMensaje.Text = "Consulta eliminada con exito";
                    }
                    else
                    {
                        this.lblMensaje.Text = "No existe una Consulta con ese ID";
                        this.txtId.Focus();
                    }
                }
                else
                {
                    this.lblMensaje.Text = "Compruebe que el socio y la especialidad existan";
                }
            }
            else
            {
                this.lblMensaje.Text = "Ingrese todos los datos";
            }
            this.lstSocios.SelectedIndex = -1;
            this.lstEspecialidades.SelectedIndex = -1;
            this.lstConsultas.SelectedIndex = -1;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                Dominio.Socio socio = this.socioSeleccionado();
                Dominio.Especialidad especialidad = this.especialidadSeleccionada();
                if (socio != null && especialidad != null)
                {
                    Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
                    short id = short.Parse(this.txtId.Text);
                    DateTime fecha = this.dtpFecha.Value;
                    string hora = this.txtHora.Text;
                    string minuto = this.txtMinuto.Text;
                    if (unaMutualista.ModificarConsulta(id, fecha, especialidad, socio, hora, minuto))
                    {
                        this.Listar();
                        this.Limpiar();
                        this.lblMensaje.Text = "Consulta modificada con exito";
                    }
                    else
                    {
                        this.lblMensaje.Text = "No existe una consulta con ese ID";
                        this.txtId.Focus();
                    }
                }
                else
                {
                    this.lblMensaje.Text = "Compruebe que el socio y la especialidad existan";
                }
            }
            else
            {
                this.lblMensaje.Text = "Ingrese todos los datos";
            }
            this.lstSocios.SelectedIndex = -1;
            this.lstEspecialidades.SelectedIndex = -1;
            this.lstConsultas.SelectedIndex = -1;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        #endregion

        #region Captura de Datos en Lista
        private void lstSocios_Click(object sender, EventArgs e)
        {
            string linea = this.lstSocios.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short idSocio = short.Parse(partes[0]);
            this.CargarSocio(idSocio);
        }

        private void lstEspecialidades_Click(object sender, EventArgs e)
        {
            string linea = this.lstEspecialidades.SelectedItem.ToString();
            string[] partes = linea.Split(' ');
            short idEspecialidad = short.Parse(partes[0]);
            this.CargarEspecialidad(idEspecialidad);
        }

        private void lstConsultas_DoubleClick(object sender, EventArgs e)
        {
            string linea1 = this.lstConsultas.SelectedItem.ToString();
            string[] partes1 = linea1.Split(';');
            short idConsulta = short.Parse(partes1[0]);
            this.cargarConsulta(idConsulta);
        }

        private void cargarConsulta(short pIdConsulta) 
        {
            Dominio.Mutualista unaM = new Dominio.Mutualista();
            Dominio.Consulta unaConsulta = unaM.buscarConsulta(pIdConsulta);

            this.txtId.Text             = unaConsulta.Id.ToString();
            this.txtEspecialidad.Text   = unaConsulta.Especialidad.ToString();
            this.txtSocio.Text          = unaConsulta.Socio.ToString();
            this.dtpFecha.Value         = unaConsulta.Fecha;
            this.txtHora.Text           = unaConsulta.Hora;
            this.txtMinuto.Text         = unaConsulta.Minuto;
        }

        #endregion

        #region Testeo
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789" + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789" + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtMinuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789" + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}
