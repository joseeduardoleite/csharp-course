namespace Entities
{
    public class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
            : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            if (NumeroFuncionarios < 10)
                return RendaAnual * 0.16;
            else
                return RendaAnual * 0.14;
        }
    }
}