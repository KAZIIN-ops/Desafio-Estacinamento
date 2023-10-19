using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private List<string> veiculos2 = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
          
         Console.WriteLine("Digite a placa do veículo para estacionar:");
         string placa = Console.ReadLine();
         Console.WriteLine("Modelo");
         string modelo = Console.ReadLine();
         veiculos.Add(placa);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

           
            string placa =Console.ReadLine();


           
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

              
               
                string Horas =(Console.ReadLine());
               int Horas2=Convert.ToInt32(precoPorHora);

                
               decimal valorTotal= precoInicial +precoPorHora *Horas2;
                
                

               
                veiculos.Remove(placa);
                
               


                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
           
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
              
                int cont = 1;
                foreach(string item in veiculos){
                    Console.WriteLine($"veiculo N°{cont} placa e modelo: {item}");
                    cont++;
                } 
                
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
