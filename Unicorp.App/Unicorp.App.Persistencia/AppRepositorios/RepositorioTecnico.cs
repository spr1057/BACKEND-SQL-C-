using System;
using System.Collections.Generic;
using System.Linq;
using Unicorp.App.Dominio;



namespace Unicorp.App.Persistencia
{
    public class RepositorioTecnico : IRepositorioTecnico
    {
        //Campo propio tipo AplicationContext de la clase RepositorioCliente
        private readonly AplicationContext _contexto;


        //Creamos el constructor de RepositorioTecnico
        public RepositorioTecnico(AplicationContext _context)
        {
            _contexto = _context;
        }

        //Metodo para obtener un solo cliente

        Clientes IRepositorioTecnico.GetCliente(int idCliente)
        {
            return _contexto
                .Cliente
                .FirstOrDefault(c => c.Id == idCliente);
        }

        //Metodo para actualizar un tecnico

        Tecnicos IRepositorioTecnico.UpdateTecnico(Tecnicos tecnico)
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

        //Metodo para obtener un solo registro histórico

        Detalle_de_Servicios IRepositorioTecnico.GetDetalle_de_Servicio(int idServicio)
        {
            return _contexto
                .Detalle_Servicio
                .FirstOrDefault(s => s.Id == idServicio);
        }

        //Metodo para obtener todo el registro histórico

        IEnumerable<Detalle_de_Servicios> IRepositorioTecnico.GetAllDetalle_de_Servicio()
        {
            return _contexto.Detalle_Servicio;
        }
        
        //Metodo para adicionar un registro histórico

        Detalle_de_Servicios IRepositorioTecnico.AddDetalle_de_Servicio(Detalle_de_Servicios detalle_de_servicio)
        {
            var detalle_de_servicioAdicionado = _contexto.Detalle_Servicio.Add(detalle_de_servicio);
            _contexto.SaveChanges();
            return detalle_de_servicioAdicionado.Entity;
        }

        

    }

}