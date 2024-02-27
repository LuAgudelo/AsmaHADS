﻿using Entidades;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<Ciudad> ObtenerCiudades();
        List<TipoIdentificacion> ObtenerTipoIdentificacion();
        List<Genero> ObtenerGenero();
        List<NivelEscolaridad> ObtenerNivelEscolaridad();
        List<Ocupacion> ObtenerOcupacion();
        List<EPS> ObtenerEPS();
        List<EstadoCivil> ObtenerEstadoCivil();
    }
}