using System;
using System.Collections.Generic;
using System.Linq;
using Unicorp.App.Dominio;



namespace Unicorp.App.Persistencia
{
    public class RepositorioAdministrador : IRepositorioAdministrador
    {
        //Campo propio tipo AplicationContext de la clase RepositorioAdministrador
        private readonly AplicationContext _contexto;


        //Creamos el constructor de RepositorioAdministrador
        public RepositorioAdministrador(AplicationContext _context)
        {
            _contexto = _context;
        }

        //Metodos para realizar el CRUD
        //Esto que aparece es lo mismo decir: public Administrador AddCliente(Clientes cliente){Aqui iría el código... }

        //Metodo para añadir un cliente
        Clientes IRepositorioAdministrador.AddCliente(Clientes cliente)
        {
            var clienteAdicionado = _contexto.Cliente.Add(cliente);
            _contexto.SaveChanges();
            return clienteAdicionado.Entity;
        }

        //Metodo para eliminar un cliente
        //esto es lo mismo decir public void Administrador (int idCliente){ Codigo aqui... }
        void IRepositorioAdministrador.DeleteCliente(int idCliente)
        {
            var clienteEncontrado = _contexto.Cliente.FirstOrDefault(c => c.Id == idCliente);
            if (clienteEncontrado == null) return;
            _contexto.Cliente.Remove (clienteEncontrado);
            _contexto.SaveChanges();
        }

        //Metodo para obtener todos los clientes

        IEnumerable<Clientes> IRepositorioAdministrador.GetAllClientes()
        {
            return _contexto.Cliente;
        }

        //Metodo para obtener un solo cliente

        Clientes IRepositorioAdministrador.GetCliente(int idCliente)
        {
            return _contexto
                .Cliente
                .FirstOrDefault(c => c.Id == idCliente);
        }

        //Metodo para actualizar un cliente

        Clientes IRepositorioAdministrador.UpdateCliente(Clientes cliente)
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

        Tecnicos IRepositorioAdministrador.AsignarTecnico(int idCliente, int idTecnico)
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
        //Metodo para añadir un técnico
        Tecnicos IRepositorioAdministrador.AddTecnico(Tecnicos tecnico)
        {
            var tecnicoAdicionado = _contexto.Tecnico.Add(tecnico);
            _contexto.SaveChanges();
            return tecnicoAdicionado.Entity;
        }
         //Metodo para actualizar un tecnico

        Tecnicos IRepositorioAdministrador.UpdateTecnico(Tecnicos tecnico)
        {
            var tecnicoEncontrado = _contexto.Tecnico.FirstOrDefault(t => t.Id == tecnico.Id);
            if (tecnicoEncontrado != null)
            {
                tecnicoEncontrado.Nombre_completo = tecnico.Nombre_completo;
                tecnicoEncontrado.Identificacion = tecnico.Identificacion;
                tecnicoEncontrado.Password = tecnico.Password;
                tecnicoEncontrado.Email = tecnico.Email;
                tecnicoEncontrado.Telefono = tecnico.Telefono;            
                tecnicoEncontrado.Disponibilidad = tecnico.Disponibilidad;
                tecnicoEncontrado.Tarjeta_Profesional = tecnico.Tarjeta_Profesional;
                tecnicoEncontrado.Formacion_Academica = tecnico.Formacion_Academica;               
                _contexto.SaveChanges();
            }
            return tecnicoEncontrado;
        }
                //Metodo para eliminar un tecnico
     
        void IRepositorioAdministrador.DeleteTecnico(int idTecnico)
        {
            var tecnicoEncontrado = _contexto.Tecnico.FirstOrDefault(c => c.Id == idTecnico);
            if (tecnicoEncontrado == null) return;
            _contexto.Tecnico.Remove (tecnicoEncontrado);
            _contexto.SaveChanges();
        }

        //Metodo para obtener todos los Tecnicos

        IEnumerable<Tecnicos> IRepositorioAdministrador.GetAllTecnicos()
        {
            return _contexto.Tecnico;
        }

        //Metodo para obtener un solo tecnico

        Tecnicos IRepositorioAdministrador.GetTecnico(int idTecnico)
        {
            return _contexto
                .Tecnico
                .FirstOrDefault(t => t.Id == idTecnico);
        }

        //Metodo para obtener un solo registro histórico

        Detalle_de_Servicios IRepositorioAdministrador.GetDetalle_de_Servicio(int idServicio)
        {
            return _contexto
                .Detalle_Servicio
                .FirstOrDefault(s => s.Id == idServicio);
        }

        //Metodo para obtener todo el registro histórico

        IEnumerable<Detalle_de_Servicios> IRepositorioAdministrador.GetAllDetalle_de_Servicio()
        {
            return _contexto.Detalle_Servicio;
        }
        
    }   

}