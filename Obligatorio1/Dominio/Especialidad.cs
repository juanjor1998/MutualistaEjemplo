using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio1.Dominio
{
    class Especialidad
    {
        private short _id;
        private string _nombre;

        #region Metodos de los atributos
        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion

        public override string ToString()
        {
            return this.Id + " " + this.Nombre;
        }

        public Especialidad(short pId, string pNombre)
        {
            this.Id = pId;
            this.Nombre = pNombre;
        }
    }
}
