namespace DesafioProjetoHospedagem.Models
{
    public class Comum
    {
        public Comum() { }

        public Comum(string tipoComum, int capacidadeComum, decimal valorDiariaComum)
        {
            TipoComum = tipoComum;
            CapacidadeComum = capacidadeComum;
            ValorDiariaComum = valorDiariaComum;
        }

        public string TipoComum { get; set; }
        public int CapacidadeComum { get; set; }
        public decimal ValorDiariaComum { get; set; }
    }

}
