using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio1.Dominio
{
    class Consulta
        // Clase de Relación: Consulta
        // Se crea relacionando Clase Socio y Clase Especialidad
    {
        private short _id;
        private DateTime _fecha;
        private Especialidad _especialidad;
        private Socio _socio;
        private string _hora;
        private string _minuto;

        #region Metodos de los atributos
        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public string Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        public string Minuto
        {
            get { return _minuto; }
            set { _minuto = value; }
        }
        public Especialidad Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }
        public Socio Socio
        {
            get { return _socio; }
            set { _socio = value; }
        }
        #endregion

        public override string ToString()
        {
            return this.Id + "; " + this.Especialidad.Nombre + "; " + this.Socio.Apellido + "; " + 
            this.Socio.Nombre + ";  " + this.Fecha.ToShortDateString() +"; "+ this.Hora + "; " + this.Minuto;
        }

        public Consulta(short pId, DateTime pFecha, string pHora, string pMinuto, 
                        Especialidad pEspecialidad, Socio pSocio)
        {
            this.Id             = pId;
            this.Fecha          = pFecha;
            this.Hora           = pHora;
            this.Minuto         = pMinuto;
            this.Especialidad   = pEspecialidad;
            this.Socio          = pSocio;
        }
    }
}
