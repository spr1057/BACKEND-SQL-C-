namespace Unicorp.App.Dominio
{

    public class Personas

    {
        public int Id { get; set; }
        public string Nombre_completo { get; set; }
        public int Identificacion { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Rol { get; set; }
        public string Fecha_registro { get; set; }
    }
}