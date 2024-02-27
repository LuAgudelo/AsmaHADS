using Entidades;

namespace Negocio
{
    public interface INegocioMaestro
    {
        List<Ciudad> ObtenerCiudades();
        List<TipoIdentificacion> ObtenerTipoIdentificacion();
        List<EstadoCivil> ObtenerestadoCivil();
        List<Ocupacion> Obtenerocupacion();
        List<NivelEscolaridad> ObtenernivelEscolaridad();
        List<EPS> Obtenereps();

    }
}