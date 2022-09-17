namespace Unicorp.App.Dominio
{

    public class Pagos
    
    {
        public Clientes informacion_pago { get; set;}
        public int Id { get; set; }
        public int ID_Pago { get; set; }
        public int ID_Cliente { get; set; }
        public string Tarifa { get; set; }
        public string Soporte_pago { get; set; }
        public string Entidad_bancaria { get; set; }
    }
}