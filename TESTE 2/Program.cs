using static System.Console;
namespace TESTE2
{
      class program
      {
            public static void Main(string[]args)
            {     
                  while(true)
                  {
                  WriteLine("\nInforme o turno que você trabalha: "+
                  "\n se for manhã: Pressione [M]"+
                  "\n se for vespertino: Pressione [V]"+
                  "\n se for nortuno: Pressione [N]");

                  string Periodo = ReadLine();

                  if (Periodo.Equals("m",StringComparison.InvariantCultureIgnoreCase))
                  {
                        WriteLine("\nBom Dia Clecio ^^");
                  }
                  else if (Periodo.Equals("v",StringComparison.InvariantCultureIgnoreCase))
                  {
                        WriteLine("\nBom Tarde Clecio, hora do café. ^^");
                  }
                  else if (Periodo.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                  {
                        WriteLine("\nBom Noite Clecio, hora de uma pipoca com netflix . ^^");
                  }
                  else
                  {
                        WriteLine("\nValor inválido. Pressione uma opção válida.");
                  }
                  
                  WriteLine("\nDeseja continuar utilizando o app 'BOM DIA'? Pressione  [1]Sim/[0]Sair");
                  int Saida = int.Parse(ReadLine());
                        if (Saida == 0)
                        {
                              WriteLine("Saindo... Xau Clecio!");
                              break;
                        }
                  }
            }
      }
}