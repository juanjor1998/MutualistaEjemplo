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
    public partial class frmSocio : Form
    {
        public frmSocio()
        {
            InitializeComponent();
        }

        #region Patron Singleton
        private static frmSocio unForm = null;
        public static frmSocio Instancia()
        {
            if (unForm == null)
            {
                unForm = new frmSocio();
            }
            return unForm;
        }
        #endregion

        #region Auxiliares
        private void Limpiar()
        {
            this.txtApellido.Clear();
            this.txtCedula.Clear();
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.dtpNacimiento.ResetText();
            this.dtpAsociado.ResetText();
            this.lblMensaje.Text = "";
            this.txtId.Focus();
        }
        private Boolean faltanDatos()
        {
            if (this.txtApellido.Text == "" || this.txtCedula.Text == "" || this.txtId.Text == "" || this.txtNombre.Text == "")
            {
                return true;
            }
            return false;
        }
        #region Lista
        bool ordenABC = false;
        private void ListarXOrden()
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            this.lstLista.DataSource = null;
            this.lstLista.DataSource = unaMutualista.ListaS();
            this.lstLista.SelectedIndex = -1;
            ordenABC = false;
        }
        private void ListarXABC()
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            this.lstLista.DataSource = null;
            this.lstLista.DataSource = unaMutualista.ListaOrdenadaSocio();
            this.lstLista.SelectedIndex = -1;
            ordenABC = true;
        }
        private void Listar()
        {
            if (ordenABC)
            {
                ListarXABC();
            }
            else
            {
                ListarXOrden();
            }
        }
        #endregion
        private void Cargar(short pId)
        {
            this.Limpiar();
            Dominio.Mutualista unaM = new Dominio.Mutualista();
            Dominio.Socio unSoc = unaM.buscarSocio(pId);
            this.txtId.Text = unSoc.Id.ToString();
            this.txtCedula.Text = unSoc.Cedula.ToString();
            this.txtNombre.Text = unSoc.Nombre;
            this.txtApellido.Text = unSoc.Apellido;
            this.dtpNacimiento.Value = unSoc.FechaNac;
            this.dtpAsociado.Text = unSoc.FechaAso.ToShortDateString();
        }
        #endregion
        
        #region Botones
        private void btnAlta_Click(object sender, EventArgs e)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                string cedula = this.txtCedula.Text;
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                DateTime fechaNac = this.dtpNacimiento.Value;
                DateTime fechaAso = this.dtpAsociado.Value;
                Dominio.Socio unSocio = new Dominio.Socio(id, cedula, nombre, apellido, fechaNac, fechaAso);
                if (unaMutualista.AltaSocio(unSocio))
                {
                    this.Limpiar();
                    this.lblMensaje.Text = "Socio ingresado con exito";
                    this.Listar();
                }
                else
                {
                    this.txtId.Clear();
                    this.txtId.Focus();
                    this.lblMensaje.Text = "Ya existe un socio con ese ID";
                }
            }
            else
            {
                this.lblMensaje.Text = "Ingrese todos los datos";
            }
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            if (this.txtId.Text != "")
            {
                short id = short.Parse(this.txtId.Text);
                if (unaMutualista.BajaSocio(id))
                {
                    this.Limpiar();
                    this.lblMensaje.Text = "Cliente eliminado con exito";
                    this.Listar();
                }
                else
                {
                    this.txtId.Clear();
                    this.txtId.Focus();
                    this.lblMensaje.Text = "No existe un socio con ese ID";
                }
            }
            else
            {
                this.lblMensaje.Text = "Ingrese el ID del socio que desea eliminar";
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                string cedula = this.txtCedula.Text;
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                DateTime fechaNac=this.dtpNacimiento.Value;
                DateTime fechaAso=this.dtpAsociado.Value;
                if (unaMutualista.ModificarSocio(id, cedula, nombre, apellido, fechaNac, fechaAso))
                {
                    this.Limpiar();
                    this.lblMensaje.Text = "Socio modificado con exito";
                    this.Listar();
                }
                else
                {
                    this.txtId.Clear();
                    this.txtId.Focus();
                    this.lblMensaje.Text = "No existe un socio con ese ID";
                }
            }
            else
            {
                this.lblMensaje.Text = "Ingrese todos los datos";
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Listar();
        }
        #endregion

        #region Listar
        private void rdbtnABC_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarXABC();
        }
        private void rdbtnOrden_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarXOrden();
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
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "0123456789.-" + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void frmSocio_Load(object sender, EventArgs e)
        {
            this.rdbtnOrden.Select();
            this.Limpiar();
            this.Listar();
        }
        private void lstLista_Click(object sender, EventArgs e)
        {
            if (this.lstLista.SelectedIndex > -1)
            {
                string linea = this.lstLista.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short idSocio = short.Parse(partes[0]);
                this.Cargar(idSocio);
            }
        }
    }
}
