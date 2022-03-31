using static System.Console;
namespace TESTE_1.Models
{
    public class Pessoa
    {   
        int Resultado;
        private string Nome;
        private int DataNascimento;
        private double Altura;
        private int AnoAtual;
        

        public void getNome()
        {
            WriteLine("Informe seu nome: ");
            Nome = ReadLine();
        }

        public void getDataNascimento()
        {
            WriteLine("Informe sua data de nascimento: ");
            DataNascimento = int.Parse(ReadLine());
            WriteLine("Informe o ano atual: ");
            AnoAtual = int.Parse(ReadLine());
        }
        public void getAltura()
        {
            WriteLine("Informe sua altura: ");
            Altura= double.Parse(ReadLine());
        }

        public void Calculo()
        {
        Resultado = AnoAtual - DataNascimento;
        }
        public string Mensagem()
        {
            return "===== APP CADASTRO ====="+$"\nNome: {Nome}"+$"\nIdade:  {Resultado}anos"+$"\nAltura: {Altura}"+$"\nData de Nascimento: {DataNascimento}";
        }

    }
}