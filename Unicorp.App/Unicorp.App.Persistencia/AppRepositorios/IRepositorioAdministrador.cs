using System;
using System.Collections.Generic;
using System.Linq;
using Unicorp.App.Dominio;

namespace Unicorp.App.Persistencia
{
    public interface IRepositorioAdministrador
    {
        
        //Parte del cliente

        IEnumerable<Clientes> GetAllClientes();
        Clientes AddCliente(Clientes cliente);
        Clientes UpdateCliente(Clientes cliente);
        void DeleteCliente(int idCliente);
        Clientes GetCliente(int idCliente);
        Tecnicos AsignarTecnico(int idCliente, int idTecnico);

        //Parte del técnico
        IEnumerable<Tecnicos> GetAllTecnicos();
        Tecnicos AddTecnico(Tecnicos tecnico);
        Tecnicos UpdateTecnico(Tecnicos tecnico);
        void DeleteTecnico(int idTecnico);
        Tecnicos GetTecnico(int idTecnico);
        Tecnicos AsignarCliente(int idTecnico, int idCliente);
    }
}