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
    }
}