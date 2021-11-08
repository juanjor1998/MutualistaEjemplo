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
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        #region Patron Singleton
        private static frmEspecialidad unForm = null;
        public static frmEspecialidad Instancia()
        {
            if (unForm == null)
            {
                unForm = new frmEspecialidad();
            }
            return unForm;
        }
        #endregion

        #region Auxiliares
        private void Limpiar()
        {
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.lblMensaje.Text = "";
            this.txtId.Focus();
        }
        private Boolean faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtNombre.Text == "")
            {
                return true;
            }
            return false;
        }
        private void Cargar(short pId)
        {
            this.Limpiar();
            Dominio.Mutualista unaM = new Dominio.Mutualista();
            Dominio.Especialidad unaEs = unaM.buscarEspecialidad(pId);
            this.txtId.Text = unaEs.Id.ToString();
            this.txtNombre.Text = unaEs.Nombre;
        }
        #region Lista
        bool ordenABC=false;
        private void ListarXOrden()
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            this.lstLista.DataSource = null;
            this.lstLista.DataSource = unaMutualista.ListaE();
            this.lstLista.SelectedIndex = -1;
            ordenABC = false;
        }
        private void ListarXABC()
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            this.lstLista.DataSource = null;
            this.lstLista.DataSource = unaMutualista.ListaOrdenadaEspecialidad();
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
        #endregion
        
        #region Botones
        private void btnAlta_Click(object sender, EventArgs e)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                Dominio.Especialidad unaEspecialidad = new Dominio.Especialidad(id, nombre);
                if (unaMutualista.AltaEspecialidad(unaEspecialidad))
                {
                    this.Limpiar();
                    this.lblMensaje.Text = "Especialidad ingresada con exito";
                    this.Listar();
                }
                else
                {
                    this.txtId.Clear();
                    this.txtId.Focus();
                    this.lblMensaje.Text = "Ya existe una especialidad con ese ID";
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
            if(this.txtId.Text!="")
            {
                short id = short.Parse(this.txtId.Text);
                if (unaMutualista.BajaEspecialidad(id))
                {
                    this.Limpiar();
                    this.lblMensaje.Text = "Especialidad eliminada con exito";
                    this.Listar();
                }
                else
                {
                    this.txtId.Clear();
                    this.txtId.Focus();
                    this.lblMensaje.Text = "No existe una especialidad con ese ID";
                }
            }
            else
            {
                this.lblMensaje.Text = "Ingrese ID de la especialidad que desea eliminar";
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Dominio.Mutualista unaMutualista = new Dominio.Mutualista();
            if (!this.faltanDatos())
            {
                short id = short.Parse(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                if (unaMutualista.ModificarEspecialidad(id, nombre))
                {
                    this.Limpiar();
                    this.lblMensaje.Text ="Especialidad modificada con exito";
                    this.Listar();
                }
                else
                {
                    this.txtId.Clear();
                    this.txtId.Focus();
                    this.lblMensaje.Text = "No existe una especialidad con ese ID";
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
        private void rdbtnOrden_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarXOrden();
        }
        private void rdbtnABC_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarXABC();
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
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8 + (char)127;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void frmEspecialidad_Load(object sender, EventArgs e)
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
                short idEspecialidad = short.Parse(partes[0]);
                this.Cargar(idEspecialidad);
            }
        }
    }
}
