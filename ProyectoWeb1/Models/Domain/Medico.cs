namespace ProyectoWeb1.Models.Domain
{
    public class Medico
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }
        public string Ced { get; set; }

        public string Correo { get; set; }

        public string Pais { get; set; }

        public string Provincia { get; set; }
    }
}
