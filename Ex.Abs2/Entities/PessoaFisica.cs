namespace Entities
{
    public class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude)
            : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000.00)
                return (RendaAnual * 0.15) - (GastoSaude * 0.5);
            else
                return (RendaAnual * 0.25) - (GastoSaude * 0.5);
        }
    }
}