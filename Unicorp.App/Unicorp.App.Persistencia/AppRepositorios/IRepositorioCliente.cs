using System;
using System.Collections.Generic;
using System.Linq;
using Unicorp.App.Dominio;

namespace Unicorp.App.Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Clientes> GetAllClientes();
        Clientes AddCliente(Clientes cliente);
        Clientes UpdateCliente(Clientes cliente);
        void DeleteCliente(int idCliente);
        Clientes GetCliente(int idCliente);
        Tecnicos AsignarTecnico(int idCliente, int idTecnico);
    }
}
