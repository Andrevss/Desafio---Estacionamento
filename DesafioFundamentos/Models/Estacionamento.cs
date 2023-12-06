namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Por favor, digite a placa do carro que deseja estacionar:");
            string Placa = Console.ReadLine();
            veiculos.Add(Placa.ToUpper());
            Console.WriteLine($"Carro com a placa {Placa} adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Por favor, digite a placa do carro que deseja remover:");
            string Placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == Placa.ToUpper()))
            {

                Console.WriteLine("Por favor, digite a quantidade de horas que o veículo permaneceu estacionado:");
                int qtdHoras;

                if(int.TryParse(Console.ReadLine(), out qtdHoras))
                {
                    if(qtdHoras < 0)
                    {
                        Console.WriteLine("Por favor, digite uma quantidade de horas válida!");
                    }else
                    {
                        decimal Total = precoInicial + (precoPorHora * qtdHoras);
                        veiculos.Remove(Placa); 
                        Console.WriteLine($"Veiculo de placa {Placa} removido com sucesso. O preço total a pagar é de R${Total}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
