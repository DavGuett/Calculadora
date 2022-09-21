// See https://aka.ms/new-console-template for more information

bool executar = true;
while (executar)
{
    Console.WriteLine("Olá! Por favor escolha a operação");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Divisão");
    Console.WriteLine("3 - Subtração");
    Console.WriteLine("4 - Sair");

    int operacao = int.Parse(Console.ReadLine());
    int resultado;

    switch (operacao)
    {
        case 1:
            Console.WriteLine("Digite os números que deseja somar (máximo 2)");
            Console.Write("Número 1: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            int numero2 = int.Parse(Console.ReadLine());
            resultado = Adicionar(numero1, numero2);
            Console.WriteLine("A soma dos dois números é: " + resultado);
            break;

        case 4:
            executar = false;
            break;
    }





    

}

static int Adicionar(int numero1, int numero2)
{
    int resultado = numero1 + numero2;
    return resultado;
}


