namespace ProyectoWeb1.Models.Domain
{
    public class Clinica
    {
        public Guid Id { get; set; }

        public string NombreClinica { get; set; }
        public string CedClinica { get; set; }

        public string CorreoClinica { get; set; }

        public string PaisClinica { get; set; }

        public string ProvinciaClinica { get; set; }
    }
}
