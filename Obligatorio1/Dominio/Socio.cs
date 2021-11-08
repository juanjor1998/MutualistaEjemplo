using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio1.Dominio
{
    class Socio
    {
        private short _id;
        private string _cedula;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;
        private DateTime _fechaAso;

        #region Metodos de los atributos
        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }
        public DateTime FechaAso
        {
            get { return _fechaAso; }
            set { _fechaAso = value; }
        }
        #endregion

        public override string ToString()
        {
            return this.Id + " " + this.Cedula + " " + this.Apellido + " " + this.Nombre + " " + 
                   this.FechaNac.ToShortDateString() + " " + this.FechaAso.ToShortDateString();
        }
        public Socio(short pId, string pCedula, string pNombre, string pApellido, 
                    DateTime pFechaNac, DateTime pFechaAso)
        {
            this.Id = pId;
            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.FechaNac = pFechaNac;
            this.FechaAso = pFechaAso;
        }
    }
}
