namespace DesafioProjetoHospedagem.Models
{
    public class Comum
    {
        public Comum() { }

        public Comum(string tipoComum, int capacidadeComum, decimal valorDiariaComum)
        {
            TipoSuite = tipoComum;
            CapacidadeComum = capacidadeComum;
            ValorDiariaComum = valorDiariaComum;
        }

        // Properties for the standard room
        public string TipoSuite { get; set; }
        public int CapacidadeComum  { get; set; }
        public decimal ValorDiariaComum { get; set; }
    }

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
