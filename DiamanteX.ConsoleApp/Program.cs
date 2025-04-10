namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = SolicitarNumeroImpar();
            ExibirDiamente(numero);
            Console.ReadLine();
        }
        //Função para solicitar número impar ao usuário

        static int SolicitarNumeroImpar()
        {
            int numero;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite um número inteiro ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)//Se digitar um número par

                {
                    Console.WriteLine("Número par. Por favor, digite um número ímpar.");
                    Console.ReadLine();
                }
            }

            while (numero % 2 == 0); //Repete até o usuário digitar um número ímpar

            return numero;
        }

        //Função para exibir o diamante

        static void ExibirDiamente(int numero)
        {
            int meio = numero / 2; //Linha central do diamante

            for (int i = 0; i < numero; i++)
            {

                int qtdXs = CalcularQuantidadeDeXs(i, meio, numero);
                int espacos = (numero - qtdXs) / 2;
                ExibirLinha(espacos, qtdXs);

            }
        }

        //Função para calcular a quantidade de 'X' em uma linha
        static int CalcularQuantidadeDeXs(int linhaAtual, int meio, int numero)
        {
            if (linhaAtual <= meio)
            {
                return 1 + 2 * linhaAtual;
            }
            else
            {
                return 1 + 2 * (numero - 1 - linhaAtual);
            }

        }

        //Função para exibir uma linha com espaços e 'X'

        static void ExibirLinha(int espacos, int qtdXs)
        {
            Console.Write(new string(' ', espacos));
            Console.WriteLine(new string('X', qtdXs));

        }

    }
}

