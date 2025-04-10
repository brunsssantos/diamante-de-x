namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            //Solicitar número impar ao usuário
            do
            {
                Console.WriteLine("Digite um número inteiro ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)//Se digitar um número par

                {
                    Console.WriteLine("Número par. Por favor, digite um número ímpar.");
                    Console.ReadLine();
                }
            }

            while (numero % 2 == 0); //Repete até o usuário digitar um número ímpar

            //Gerar o diamante

            int meio = numero / 2; //Linha central do diamante
            for (int i = 0; i < numero; i++)
            {
                //Determinar número de X na linha
                int qtdXs;

                if (i <= meio)
                {
                    qtdXs = 1 + 2 * i;
                }
                else
                {
                    qtdXs = 1 + 2 * (numero - 1 - i);
                }

                int espacos = (numero - qtdXs) / 2;

                Console.Write(new string(' ', espacos));
                Console.WriteLine(new string('X', qtdXs));

                Console.ReadLine();
            }
        }
    }
}
