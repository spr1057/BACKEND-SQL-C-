namespace Unicorp.App.Dominio
{

    public class Servicios

    {
        public Tecnicos presta_servicios { get; set; }
        public Clientes adquiere_servicios { get; set; }
        public Pagos informacion_pagos { get; set; }
        public int Id { get; set; }
        public string Tipo_servicio { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Tecnico { get; set; }
        public string Tarifa { get; set; }
    }
}