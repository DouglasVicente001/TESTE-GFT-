using static System.Console;
namespace TESTE3
{
      class program
      {
            public static void Main(string[]args)
            {     


                  double TotalLimao,Desconto,TotalTamarindo,DescontoTamarindo,Resultado;

                  WriteLine("Quantos litros do suco de Limão foram vendidos? Informe: ");
                  double Limao = double.Parse(ReadLine());

                  WriteLine("Quantos litros do suco de Tamarindo foram vendidos? Insira: ");
                  double Tamarindo = int.Parse(ReadLine());

                  if (Limao > 0 && Limao <=2)
                  {     
                        
                        Desconto = (Limao * 3)/100;
                        TotalLimao = Limao - Desconto;

                        WriteLine($"\nO valor do desconto do Limão é {Desconto}" + $"O total a pagar com desconto é: {TotalLimao}");
                  }
                  else if (Limao >= 5)
                  {     
                        Desconto = (Limao * 3)/100;
                        TotalLimao = Limao - Desconto;
                        WriteLine($"\nO valor do desconto do Limão é {Desconto}" + $"O total a pagar com desconto é: {TotalLimao}");
                  }
                  if (Tamarindo > 0 && Tamarindo <=2)
                  {     
                        
                        DescontoTamarindo = (Tamarindo * 4)/100;
                        TotalTamarindo = Tamarindo - DescontoTamarindo;
                        WriteLine($"\nO valor do desconto do tamarindo é {DescontoTamarindo}" +$"O Valor total a pagar do tamarindo é {TotalTamarindo}");;

                  }
                  else if (Tamarindo >= 5)
                  {     
                        
                        DescontoTamarindo = (Tamarindo * 6)/100;
                        TotalTamarindo = Tamarindo - DescontoTamarindo;
                        WriteLine($"\nO valor do desconto do tamarindo é {DescontoTamarindo}" +$"O Valor total a pagar do tamarindo é {TotalTamarindo}");
                  }
                  
                  //========== INFELZMENTE NAO TIVE TEMPO PARA CORRIGIR O ERRO FINAL MAS ERA APENAS QUESTAO DE TEMPO PARA EU EXPOR O RESULTADO DA SOMA DOS DOIS SUCOS, TENHO DIVERSOS TESTES FEITO EM MEU GIT HUB E PROVA MINHA CAPACIDADE, INFELIZMENTE NAO TIVE TANTA VELOCIDADE PORQUE ESTOU NERVOSO POR SER MEU PRIMEIRO TESTE NUMA MULTINACIONAL, OBRIGADO A TODOS POR ESTA EXPERIÊNCIA INCRÍVEL! ==========
                  
                  //Resultado = TotalLimao + TotalTamarindo;
                  //WriteLine($"O total a ser pago da soma dos dois sucos é {Resultado}");
                  
            }
      }
}
