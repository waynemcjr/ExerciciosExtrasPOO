using ExerciciosExtrasPOO1;

int opcao;

Console.Write("Escolha o método de pagamento (1 - Pagamento Boleto ou 2 - Pagamento Cartão de Crédito): ");
opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1) {
    Pagamento pagamento = new PagamentoBoleto();

    Console.Write("Informe o valor do pagamento: ");
    pagamento.setValor(Convert.ToDouble(Console.ReadLine()));

    Console.Write("Informe a data de pagamento: ");
    pagamento.setDataPagamento(Console.ReadLine()!);

    Console.WriteLine($"\nValor total pago: {pagamento.ProcessarPagamento()}");
}
else if (opcao == 2){
    Pagamento pagamento = new PagamentoCartaoCredito();

    Console.Write("Informe o valor do pagamento: ");
    pagamento.setValor(Convert.ToDouble(Console.ReadLine()));

    Console.Write("Informe a data de pagamento: ");
    pagamento.setDataPagamento(Console.ReadLine()!);

    Console.WriteLine($"\nValor total pago: {pagamento.ProcessarPagamento()}");
}
else
{
    Console.WriteLine("Escolha uma opção válida! 1 - Pagamento Boleto ou 2 - Pagamento Cartão de Crédito");
}