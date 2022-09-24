using System;
using System.Collections.Generic;
using System.Linq;
using Unicorp.App.Dominio;

namespace Unicorp.App.Persistencia
{
    public interface IRepositorioCliente
    {
        Clientes UpdateCliente(Clientes cliente);
        Tecnicos AsignarTecnico(int idCliente, int idTecnico);
        Detalle_de_Servicios GetDetalle_de_Servicio(int idServicio);
    }
}
