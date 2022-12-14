using System;
using System.Collections.Generic;
using System.Linq;
using Unicorp.App.Dominio;



namespace Unicorp.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        //Campo propio tipo AplicationContext de la clase RepositorioCliente
        private readonly AplicationContext _contexto;


        //Creamos el constructor de RepositorioCliente
        public RepositorioCliente(AplicationContext _context)
        {
            _contexto = _context;
        }

        //Metodos para realizar el CRUD
        //Metodo para actualizar un cliente

        Clientes IRepositorioCliente.UpdateCliente(Clientes cliente)
        {
            var clienteEncontrado = _contexto.Cliente.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.Nombre_completo = cliente.Nombre_completo;
                clienteEncontrado.Identificacion = cliente.Identificacion;
                clienteEncontrado.Password = cliente.Password;
                clienteEncontrado.Email = cliente.Email;
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Ciudad = cliente.Ciudad;
                clienteEncontrado.Direccion = cliente.Direccion;
                clienteEncontrado.Membresia = cliente.Membresia;
                clienteEncontrado.Tipo_cliente = cliente.Tipo_cliente;
                _contexto.SaveChanges();
            }
            return clienteEncontrado;
        }

        //Metodo para asignar un tecnico

        Tecnicos IRepositorioCliente.AsignarTecnico(int idCliente, int idTecnico)
        {
            var clienteEncontrado = _contexto.Cliente.FirstOrDefault(c => c.Id == idCliente);
            if(clienteEncontrado != null)
            {
                var tecnicoEncontrado = _contexto.Tecnico.FirstOrDefault(t => t.Id == idTecnico);
                if (tecnicoEncontrado != null)
                {
                    clienteEncontrado.Tecnicos = tecnicoEncontrado;
                }
                return tecnicoEncontrado;
            }
            return null;
        }

        //Metodo para obtener un registro historico
        Detalle_de_Servicios IRepositorioCliente.GetDetalle_de_Servicio(int idServicio)
        {
            return _contexto
                .Detalle_Servicio
                .FirstOrDefault(s => s.Id == idServicio);
        }


    }

}