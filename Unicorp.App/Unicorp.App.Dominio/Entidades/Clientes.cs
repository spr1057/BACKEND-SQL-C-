namespace Unicorp.App.Dominio
{

    public class Clientes : Personas
    
    {
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public bool Membresia { get; set; }
        public string Tipo_cliente { get; set; }
    }
}