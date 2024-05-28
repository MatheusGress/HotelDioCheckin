namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() 
        {
            TipoSuite = "Premium";
            CapacidadeSuite = 6;
            ValorDiariaSuite = 389;
        }

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
