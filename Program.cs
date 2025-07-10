try
{
    Passageiro p = new Passageiro();

    Console.WriteLine("Digite o nome do passageiro:");
    p.nome = Console.ReadLine();
    Console.WriteLine("Digite o cpf:");
    p.cpf = Console.ReadLine();
    Console.WriteLine("Digite a Data de Nascimento:");
    p.dataNascimento = Console.ReadLine();
    Console.WriteLine("Digite o email:");
    p.email = Console.ReadLine();
    Console.WriteLine("Digite o telefone:");
    p.telefone = Console.ReadLine();



    Reserva r = new Reserva();

    Console.WriteLine("Informe o passageiro:");
    r._passageiro = Console.ReadLine();
    Console.WriteLine("Informe o número do assento:");
    r._numero_assento = Console.ReadLine();
    r._valorPassagem = 0;
    Console.WriteLine("Informe o status:");
    r._status = Console.ReadLine();
    Console.WriteLine("Informe a classe do voo:");
    r._classe = Console.ReadLine();


    Voo v = new Voo();

    Console.WriteLine("Informe número da passagem:");
    v._num = Console.ReadLine();
    Console.WriteLine("Informe a origem:");
    v._origem = Console.ReadLine();
    Console.WriteLine("Informe a destino:");
    v._destino = Console.ReadLine();
    Console.WriteLine("Informe o embarque:");
    v._Portao_embarque = Console.ReadLine();
    Console.WriteLine("Informe nome da aeronave:");
    v._nome_aeronave = Console.ReadLine();
}
catch
{
    new Exception("Inválido!");
}