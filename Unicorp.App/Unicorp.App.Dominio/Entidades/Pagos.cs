namespace Unicorp.App.Dominio
{

    public class Pagos
    
    {
        public int Id { get; set; }
        public int ID_persona { get; set; }
        public string Total_pagado { get; set; }
        public string Entidad_bancaria { get; set; }
        public string Soporte_pago { get; set; }
    }
}