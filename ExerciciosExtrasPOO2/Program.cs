using ExerciciosExtrasPOO2;

int opcao;

ContaBancaria conta = new ContaBancaria();
conta.setSaldo(1000);
conta.setTitular("Miguel");

do
{
    Console.WriteLine($"Bem vindo ao caixa eletrônico, {conta.getTitular()}, seu saldo é de {conta.getSaldo()} o que deseja fazer?");
    Console.WriteLine("Opção 1 - Depósito");
    Console.WriteLine("Opção 2 - Sacar");
    Console.WriteLine("Opção 3 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write($"Informe o valor do depósito: ");
            conta.Depositar(Convert.ToDecimal(Console.ReadLine()!));
            break;

        case 2:
            Console.Write($"Informe o valor do saque: ");
            conta.Sacar(Convert.ToDecimal(Console.ReadLine()!));
            break;
        case 3:
            Console.WriteLine($"Obrigado, volte sempre!");
            break;
        default:
            Console.WriteLine("Escolha uma opção válida! 1 - Depósito ou 2 - Saque ou 3 - Sair");
            break;
    }
} while (opcao != 3);

