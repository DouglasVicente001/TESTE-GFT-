using static System.Console;
namespace TESTE4
{
      class program
      {
            public static void Main(string[]args)
            {
      
                  WriteLine("Informe a idade do paciente: ");
                  int Idade = int.Parse(ReadLine());

                  if (Idade >= 18 && Idade <= 67)
                  {
                        WriteLine("A pessoa esta apta para doar sangue! ");
                  }
                  else if (Idade <18 || Idade > 67)
                  {
                        WriteLine("Infelizmente o paciente não pode doar sangue.");
                  }
            }
      }
}