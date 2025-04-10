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

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Número par. Por favor, digite um número ímpar.");
                    Console.ReadLine();
                }
            }

            while (numero % 2 == 0); //Repete até o usuário digitar um número ímpar

        }
    }
}
