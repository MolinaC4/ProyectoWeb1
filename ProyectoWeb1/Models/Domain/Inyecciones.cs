namespace ProyectoWeb1.Models.Domain
{
    public class Inyecciones
    {
        public Guid Id { get; set; }

        public string IDPaciente { get; set; }
        public string V_sarampion { get; set; }
        public string V_influenza { get; set; }
        public string V_covid { get; set; }
        public string Dosis { get; set; }
        public string Razon { get; set; }

    }
}
