namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite, int capacidadeSuite, decimal valorDiariaSuite)
        {
            TipoSuite = tipoSuite;
            CapacidadeSuite = capacidadeSuite;
            ValorDiariaSuite = valorDiariaSuite;
        }

        public string TipoSuite { get; set; }
        public int CapacidadeSuite { get; set; }
        public decimal ValorDiariaSuite { get; set; }
    }
}