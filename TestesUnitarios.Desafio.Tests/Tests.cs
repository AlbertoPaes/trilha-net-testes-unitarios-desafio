using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class Tests
    {
        protected ValidacoesLista _validacoesLista;
        protected ValidacoesString _validacoesString;

        public Tests() {
            _validacoesLista = new ValidacoesLista();
            _validacoesString = new ValidacoesString();
        }
    }
}