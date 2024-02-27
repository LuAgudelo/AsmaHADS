using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMaestro : INegocioMaestro
    {
        IRepositorioMaestro repositorioMaestro = new RepositorioMaestroEF();

        public NegocioMaestro()
        {
        }

        public NegocioMaestro(IRepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }

        public List<Ciudad> ObtenerCiudades()
        => repositorioMaestro.ObtenerCiudades();

        public List<EPS> Obtenereps()
        {
            throw new NotImplementedException();
        }

        public List<EstadoCivil> ObtenerestadoCivil()
        {
            throw new NotImplementedException();
        }

        public List<NivelEscolaridad> ObtenernivelEscolaridad()
        {
            throw new NotImplementedException();
        }

        public List<Ocupacion> Obtenerocupacion()
        {
            throw new NotImplementedException();
        }

        public List<TipoIdentificacion> ObtenerTipoIdentificacion()
        => repositorioMaestro.ObtenerTipoIdentificacion();

    }
}
