using System;
using System.Collections.Generic;
using System.Linq;
using Unicorp.App.Dominio;

namespace Unicorp.App.Persistencia
{
    public interface IRepositorioTecnico
    {
        Clientes GetCliente(int idCliente);
        Tecnicos UpdateTecnico(Tecnicos tecnico);
        Detalle_de_Servicios GetDetalle_de_Servicio(int idServicio);
        IEnumerable<Detalle_de_Servicios> GetAllDetalle_de_Servicio();
        Detalle_de_Servicios AddDetalle_de_Servicio(Detalle_de_Servicios detalle_de_servicio);
    }
}