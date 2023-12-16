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
            bool verificaPlaca = false;

            do
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                string placa = Console.ReadLine();


                if (String.IsNullOrEmpty(placa))
                {
                    Console.WriteLine("Preencha as informações do campo!");
                }
                else
                {
                    veiculos.Add(placa);
                    Console.WriteLine("Veiculo cadastrado com sucesso!");
                    verificaPlaca = true;
                    Console.WriteLine();

                }

            } while (!verificaPlaca);

        }

        public void RemoverVeiculo()
        {
            string placa;

            do
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                placa = Console.ReadLine();

                if (String.IsNullOrEmpty(placa))
                {
                    Console.WriteLine("Preencha as informações do campo!");
                }
            } while (String.IsNullOrEmpty(placa));

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string input = Console.ReadLine();

                int horas = int.Parse(input);
                decimal valorTotal = precoInicial + precoPorHora * horas;

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
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string vei in veiculos)
                {
                    Console.WriteLine(vei);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
