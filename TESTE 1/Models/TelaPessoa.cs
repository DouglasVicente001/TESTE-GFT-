using static System.Console;
using TESTE_1.Models;
namespace TESTE_1.Models
{
    public class TelaPessoa
    {
        public void TelaInicial()
        {
                Pessoa pessoa = new Pessoa();
                pessoa.getNome();
                pessoa.getAltura();
                pessoa.getDataNascimento();
                pessoa.Calculo();
                WriteLine(pessoa.Mensagem());
        }
    }
}