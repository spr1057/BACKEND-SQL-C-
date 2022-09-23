namespace Unicorp.App.Dominio
{

    public class Clientes : Personas
    
    {
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public bool Membresia { get; set; }
        public string Tipo_cliente { get; set; }
        public Tecnicos Tecnicos { get; set; }
        public Pagos genera_pago { get; set; }
        public Servicios solicita_servicio { get; set; }
    }
}