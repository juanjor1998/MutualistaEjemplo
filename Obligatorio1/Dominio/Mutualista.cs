using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obligatorio1.Dominio
{
    class Mutualista
    {
        private static List<Socio> _listaS = new List<Socio>();
        private static List<Especialidad> _listaE = new List<Especialidad>();
        private static List<Consulta> _listaC = new List<Consulta>();

        #region Socio
        public List<Socio> ListaS()
        {
            return _listaS;
        }
        public Socio buscarSocio(short pId)
        {
            if (_listaS.Count > 0)
            {
                foreach (Socio unSocio in _listaS)
                {
                    if (unSocio.Id == pId)
                        return unSocio;
                }
            }
            return null;
        }
        public Boolean AltaSocio(Socio pSocio)
        {
            Socio unSocio = this.buscarSocio(pSocio.Id);
            if (unSocio == null)
            {
                _listaS.Add(pSocio);
                return true;
            }
            return false;
        }
        public Boolean BajaSocio(short pId)
        {
            Socio unSocio = this.buscarSocio(pId);
            if (unSocio != null)
            {
                _listaS.Remove(unSocio);
                return true;
            }
            return false;
        }
        public Boolean ModificarSocio(short pId, string pCedula, string pNombre, string pApellido, DateTime pFechaNac, DateTime pFechaAso)
        {
            Socio unSocio = this.buscarSocio(pId);
            if (unSocio != null)
            {
                unSocio.Cedula = pCedula;
                unSocio.Nombre = pNombre;
                unSocio.Apellido = pApellido;
                unSocio.FechaNac = pFechaNac;
                unSocio.FechaAso = pFechaAso;
                return true;
            }
            return false;
        }
        public List<Socio> ListaOrdenadaSocio()
        {
            List<Socio> SociosOrdenados = new List<Socio>(_listaS);
            Socio auxSocio;
            for (int i = 0; i < SociosOrdenados.Count; i++)
            {
                for (int j = 0; j < SociosOrdenados.Count - 1; j++)
                {
                    if (SociosOrdenados[j].Apellido.ToUpper().CompareTo(SociosOrdenados[j + 1].Apellido.ToUpper()) > 0)
                    {
                        auxSocio = SociosOrdenados[j];
                        SociosOrdenados[j] = SociosOrdenados[j + 1];
                        SociosOrdenados[j + 1] = auxSocio;
                    }
                }
            }
            return SociosOrdenados;
        }
        #endregion

        #region Especialidad
        public List<Especialidad> ListaE()
        {
            return _listaE;
        }
        public Especialidad buscarEspecialidad(short pId)
        {
            if (_listaE.Count > 0)
            {
                foreach (Especialidad unaEspecialidad in _listaE)
                {
                    if (unaEspecialidad.Id == pId)
                        return unaEspecialidad;
                }
            }
            return null;
        }
        public Boolean AltaEspecialidad(Especialidad pEspecialidad)
        {
            Especialidad unaEspecialidad = this.buscarEspecialidad(pEspecialidad.Id);
            if (unaEspecialidad == null)
            {
                _listaE.Add(pEspecialidad);
                return true;
            }
            return false;
        }
        public Boolean BajaEspecialidad(short pId)
        {
            Especialidad unaEspecialidad = this.buscarEspecialidad(pId);
            if (unaEspecialidad != null)
            {
                _listaE.Remove(unaEspecialidad);
                return true;
            }
            return false;
        }
        public Boolean ModificarEspecialidad(short pId, string pNombre)
        {
            Especialidad unaEspecialidad = this.buscarEspecialidad(pId);
            if (unaEspecialidad != null)
            {
                unaEspecialidad.Nombre = pNombre;
                return true;
            }
            return false;
        }
        public List<Especialidad> ListaOrdenadaEspecialidad()
        {
            List<Especialidad> EspecialidadesOrdenadas = new List<Especialidad>(_listaE);
            Especialidad auxEspecialidad;
            for (int i = 0; i < EspecialidadesOrdenadas.Count; i++)
            {
                for (int j = 0; j < EspecialidadesOrdenadas.Count - 1; j++)
                {
                    if (EspecialidadesOrdenadas[j].Nombre.ToUpper().CompareTo(EspecialidadesOrdenadas[j + 1].Nombre.ToUpper()) > 0)
                    {
                        auxEspecialidad = EspecialidadesOrdenadas[j];
                        EspecialidadesOrdenadas[j] = EspecialidadesOrdenadas[j + 1];
                        EspecialidadesOrdenadas[j + 1] = auxEspecialidad;
                    }
                }
            }
            return EspecialidadesOrdenadas;
        }
        #endregion

        #region Consulta
        public List<Consulta> ListaC()
        {
            return _listaC;
        }
        public Consulta buscarConsulta(short pId)
        {
            if (_listaC.Count >0)
            {
                foreach (Consulta unaConsulta in _listaC)
                {
                    if (unaConsulta.Id == pId)
                        return unaConsulta;
                }
            }
            return null;
        }
        public Boolean AltaConsulta(Consulta pConsulta)
        {
            Consulta unaConsulta = this.buscarConsulta(pConsulta.Id);
            if (unaConsulta == null)
            {
                _listaC.Add(pConsulta);
                return true;
            }
            return false;

           
        }
        public Boolean BajaConsulta(Consulta pConsulta)
        {
            Consulta unaConsulta = this.buscarConsulta(pConsulta.Id);
            if (unaConsulta != null)
            {
                _listaC.Remove(unaConsulta);
                return true;
            }
            return false;
        }
        public Boolean ModificarConsulta(short pId, DateTime pFecha, Especialidad pEspecialidad, Socio pSocio, string pHora, string pMinuto)
        {
            Consulta unaConsulta = this.buscarConsulta(pId);
            if (unaConsulta != null)
            {
                unaConsulta.Id = pId;
                unaConsulta.Fecha = pFecha;
                unaConsulta.Especialidad = pEspecialidad;
                unaConsulta.Socio = pSocio;
                unaConsulta.Hora = pHora;
                unaConsulta.Minuto = pMinuto;
                return true;
            }
            return false;
        }
        #endregion

        #region Estadisticas
        public List<Socio> listaSociosDadaEspecialidad(short pId)
        {
            List<Socio> listaSocios = new List<Socio>();
            foreach (Consulta unaConsulta in _listaC)
            {
                if (unaConsulta.Especialidad.Id == pId)
                {
                    bool existe = false;
                    for (int i = 0; i < listaSocios.Count; i++)
                    {
                        if (listaSocios[i].Id == unaConsulta.Socio.Id)
                        {
                            existe = true;
                            break;
                        }
                    }
                    if(!existe)
                        listaSocios.Add(unaConsulta.Socio);
                }
            }
            return listaSocios;
        }
        public List<Consulta> listaConsultasDadoSocio(short pId)
        {
            List<Consulta> listaConsultas = new List<Consulta>();
            foreach (Consulta unaConsulta in _listaC)
            {
                if (unaConsulta.Socio.Id == pId)
                {
                    listaConsultas.Add(unaConsulta);
                }
            }
            return listaConsultas;
        }
        public List<Especialidad> especialidadConMasConsultas()
        {
            if (_listaE.Count == 0)
            {
                return null;
            }
            else
            {
                List<Especialidad> listaEsp = new List<Especialidad>(_listaE);
                if (_listaE.Count == 1)
                {
                    List<Especialidad> max = listaEsp;
                    return max;
                }
                else
                {
                    int[] cantidad = new int[listaEsp.Count];
                    for (int i = 0; i < cantidad.Length; i++)
                    {
                        cantidad[i] = 0;
                    }

                    for (int i = 0; i < _listaC.Count; i++)
                    {
                        for (int j = 0; j < listaEsp.Count; j++)
                        {
                            if (_listaC[i].Especialidad.Id == listaEsp[j].Id)
                            {
                                cantidad[j]++;
                                break;
                            }
                        }
                    }

                    for (int i = 0; i < listaEsp.Count - 1; i++)
                    {
                        if (cantidad[i] > cantidad[i + 1])
                        {
                            int auxI = cantidad[i];
                            Especialidad auxE = listaEsp[i];

                            cantidad[i] = cantidad[i + 1];
                            listaEsp[i] = listaEsp[i + 1];

                            cantidad[i + 1] = auxI;
                            listaEsp[i + 1] = auxE;
                        }
                    }

                    int maxC = cantidad[cantidad.Length - 1];
                    List<Especialidad> maxE = new List<Especialidad>();
                    for (int i = 0; i < cantidad.Length; i++)
                    {
                        if (cantidad[i] == maxC)
                        {
                            maxE.Add(listaEsp[i]);
                        }
                    }
                    return maxE;
                }
            }
        }
        #endregion
    }
}
