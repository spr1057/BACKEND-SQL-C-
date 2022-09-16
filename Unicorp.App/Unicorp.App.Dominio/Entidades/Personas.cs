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
        public string Fecha_registro { get; set; }
        public string Rol { get; set; }
        public string Tipo_cliente { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public bool Disponibilidad_horario { get; set; }
        public string Tarjeta_profesional { get; set; }
        public string Formacion_profesional { get; set; }
        public bool Membresia { get; set; }
    }
}