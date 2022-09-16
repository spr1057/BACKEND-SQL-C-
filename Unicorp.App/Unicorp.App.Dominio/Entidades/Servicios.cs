namespace Unicorp.App.Dominio
{

    public class Servicios

    {
        public int Id { get; set; }
        public string Tipo_servicio { get; set; }
        public int ID_persona { get; set; }
        public int ID_tecnico { get; set; }
        public string Tarifa_servicio { get; set; }
        public string Descripcion { get; set; }
    }
}