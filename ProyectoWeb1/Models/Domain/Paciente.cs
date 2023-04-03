namespace ProyectoWeb1.Models.Domain
{
    public class Paciente
    {
        public Guid Id { get; set; }

        public string NombrePaciente { get; set; }
        public string Ape1 { get; set; }
        public string Ape2 { get; set; }
        public string Ced { get; set; }
        public DateTime Fec_nac { get; set; }
        public string Genero { get; set; }
        public string Estado_Civil { get; set; }
        public string Tel_contacto { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public DateTime Fec_registro { get; set; }
        public string Ocupacion { get; set; }
    }
}
