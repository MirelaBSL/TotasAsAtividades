int Opcoes = 0;

//Construção do while com as opçoes do menu
while (Opcoes != 12)
{
    Opcoes = menuOpcoes();
    Console.Clear();

    // construção do switch com os "casos" do menu
    switch (Opcoes)
    {
        case 1:
            NomeIdadeAlturaPeso();
            break;

        case 2:
            Horario();
            break;

        case 3:
            CalcularArea();
            break;

        case 4:
            MediaAluno();
            break;

        case 5:
            MaiorNumero();
            break;

        case 6:
            Senha4Digitos();
            break;

        case 7:
            MostrarNumeroImpar();
            break;

        case 8:
            VetorNomes();
            break;

        case 9:
            VetorSoma();
            break;

        case 10:
            MatrizTabela();
            break;

        case 11:
            CaixaEletronico();
            break;

        case 12:
            Console.WriteLine("ENCERRANDO O PROGRAMA....");
            break;

    }
}
Console.ReadKey();
// construção do menu de opçoes
static int menuOpcoes()
{
    Console.WriteLine("SEJA BEM VINDO AOS PROJETOS DA NOSSA TURMA ^-^ \n================================================================== \n ABAIXO INSIRA O NÚMERO DA ATIVIDADE QUE DESEJA ACESSAR:");

    Console.WriteLine("");

    Console.WriteLine("[01] ATIVIDADE: PERGUNTAR AO USUARIO (nome, idade, altura e peso)");

    Console.WriteLine("[02] ATIVIDADE: RETORNO DE MENSAGEM DE ACORDO COM O HORARIO");

    Console.WriteLine("[03] ATIVIDADE: CALCULAR A ÁREA DO QUADRADO");

    Console.WriteLine("[04] ATIVIDADE: MEDIA DO ALUNO");

    Console.WriteLine("[05] ATIVIDADE: MOSTRAR O MAIOR NUMERO NA TELA");

    Console.WriteLine("[06] ATIVIDADE: SENHA CORRETA OU INCORRETA");

    Console.WriteLine("[07] ATIVIDADE: MOSTAR NO CONSOLE OS NUMEROS IMPARES");

    Console.WriteLine("[08] ATIVIDADE: VETOR QUE ARMAZENE E EXIBA OS NOMES");

    Console.WriteLine("[09] ATIVIDADE: VETOR QUE SOMA OS NUMEROS");

    Console.WriteLine("[10] ATIVIDADE: TABELA USANDO MATRIZ");

    Console.WriteLine("[11] ATIVIDADE: PROGRAMA ESTILO CAIXA ELETRONICO");

    Console.WriteLine("[12] SAIR");

    int opcoes = int.Parse(Console.ReadLine());
    return opcoes;
}
// Primeira atividade de perguntar ao usuario
static void NomeIdadeAlturaPeso()
{
    Console.WriteLine("Informe abaixo seu nome completo:");
    string nomeCompleto = Console.ReadLine();

    Console.WriteLine("Informe abaixo sua idade:");
    string idade = Console.ReadLine();

    Console.WriteLine("Informe abaixo sua altura:");
    string altura = Console.ReadLine();

    Console.WriteLine("Informe abaixo seu peso em KG:");
    string pesoKg = Console.ReadLine();

    Console.WriteLine("Seu nome completo é " + nomeCompleto + ", você tem " + idade + " anos, " + altura + " de altura e peso " + pesoKg + "Kg");
    Console.ReadLine();

    Console.Clear();
}
// Atividade para o console retornar a mensagem conforme o horário
static void Horario()
{

    Console.WriteLine("insira seu nome:");
    string nome = Console.ReadLine();

    Console.WriteLine("qual o horário");
    double horas = double.Parse(Console.ReadLine());

    if (horas < 12 && horas >= 5)
    {

        Console.WriteLine($"Bom Dia, {nome}");

    }
    else if (horas <= 18 && horas >= 12)
    {

        Console.WriteLine($"Boa tarde, {nome}");

    }
    else if (horas <= 24 && horas > 18)
    {

        Console.WriteLine($"Boa noite, {nome}");

    }
    else if(horas > 1 && horas < 5)
    {
        Console.WriteLine($"Boa madrugada, {nome}");
    }
    Console.ReadLine();
    Console.Clear();
}
// calcular a área do quadrado
static void CalcularArea()
{
    Console.WriteLine("Insira um numero INTEIRO para os lados do quadrado:");
    int numero = int.Parse(Console.ReadLine());
    //multiplicação para saber a area
    double area = numero * 4;
    Console.WriteLine($"A area do seu quadrado é {area}!");
    Console.ReadLine();
    Console.Clear();
}
// Calcular a media do aluno
static void MediaAluno()
{
    Console.WriteLine("Informe a nota da sua primeira prova:");
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota da segunda prova:");
    double nota2 = double.Parse(Console.ReadLine());

    double media = (nota1 + nota2) / 2.0;

    if (media >= 6)
    {

        Console.WriteLine("Aluno Aprovado! " + media);

    }
    else
    {

        Console.WriteLine("Aluno Reprovado! " + media);

    }
    Console.ReadLine();
    Console.Clear();
}
// Mostrar no console o maior número
static void MaiorNumero()
{
    int menor = 0, maior = 0, posicaoMenor = 0, posicaoMaior = 0;
    const int quantidadeNum = 3;
    int[] numeros = new int[quantidadeNum];
    Console.WriteLine("Informe 3 números inteiros:");

    for (int i = 0; i < quantidadeNum; i++)
    {

        Console.WriteLine((i + 1) + "º número:");
        numeros[i] = Convert.ToInt32(Console.ReadLine());

    }
    for (int i = 0; i < 3; i++)
    {

        if (numeros[i] < menor)
        {

            menor = numeros[i];
            posicaoMenor = i;

        }
        else if (numeros[i] > maior)
        {

            maior = numeros[i];
            posicaoMaior = i;

        }        
    }
    Console.WriteLine("O maior número é:" + maior);
    Console.ReadLine();
    Console.Clear();
}
// Atividade de criar uma senha
static void Senha4Digitos()
{
    bool numeroDigitado = false;
    Console.WriteLine("Crie uma senha de 4 numeros inteiros:");
    int senha = int.Parse(Console.ReadLine());
    Console.Clear();

    while (numeroDigitado == false)
    {

        Console.WriteLine("Digite a sua senha de 4 numeros inteiros:");
        int tentativa = int.Parse(Console.ReadLine());

        if (senha == tentativa)
        {

            Console.WriteLine("Senha Correta!!");
            numeroDigitado = true;

        }
        else
        {

            Console.WriteLine("Senha Incorreta!!");
            numeroDigitado = false;

        }
    }
    Console.ReadLine();
    Console.Clear();
}
// Atividade para mostrar o número ímpar
static void MostrarNumeroImpar()
{
    int n;
    int impar;

    Console.WriteLine("informe um numero inteiro para saber os impares;");
    n = int.Parse(Console.ReadLine());
    impar = 0;

    for (int i = 1; i <= n; i++)
    {

        if (i % 2 != 0)
        {

            Console.WriteLine(i);

        }
    }
    Console.ReadLine();
    Console.Clear();
}
// Atividade para pedir nomes e mostrar no console
static void VetorNomes()
{
    string[] nomes = new string[4];

    for (int i = 0; i < nomes.Length; i++)
    {

        Console.WriteLine($"Escreva o {i + 1}º nome");
        nomes[i] = Console.ReadLine();
        Console.Clear();

    }
    for (int i = 0; i < nomes.Length; i++)
    {

        Console.WriteLine(nomes[i].ToString());

    }
    Console.ReadLine();
    Console.Clear();
}
// Atividade para somar
static void VetorSoma()
{
    int[] numeros = new int[5];
    int soma = 0;

    for (int i = 0; i < numeros.Length; i++)
    {

        Console.WriteLine($"Digite abaixo o {i + 1}° número");
        numeros[i] = int.Parse(Console.ReadLine());
        soma = soma + numeros[i];

    }
    Console.WriteLine($"O total da sua soma é {soma}");
    Console.ReadLine();
    Console.Clear();
}
// Criação de tabela usando matriz
static void MatrizTabela()
{
    int[,] matriz = new int[4, 4];

    matriz[0, 0] = 1; matriz[0, 1] = 2; matriz[0, 2] = 3; matriz[0, 3] = 4;
    matriz[1, 0] = 10; matriz[1, 1] = 20; matriz[1, 2] = 30; matriz[1, 3] = 40;
    matriz[2, 0] = 12; matriz[2, 1] = 22; matriz[2, 2] = 32; matriz[2, 3] = 42;
    matriz[3, 0] = 15; matriz[3, 1] = 25; matriz[3, 2] = 35; matriz[3, 3] = 45;

    for (int linha = 0; linha < 4; linha++)
    {

        for (int coluna = 0; coluna < 4; coluna++)
        {

            if (linha == 0)
            {

                Console.Write($"  {matriz[linha, coluna]} ");

            }
            else
            {

                Console.Write($" {matriz[linha, coluna]} ");

            }
        }
        Console.WriteLine();
    }
    Console.ReadKey();
    Console.Clear();
}
// Atividade Caixa Eletronico
static void CaixaEletronico()
{
    double saldo = 0;
    int opcoes = 0;

    while (opcoes != 4)
    {

        opcoes = Menu();
        Console.Clear();
        // Criação do switch para a criação das opções
        switch (opcoes)
        {
            case 1:
                MostrarSaldo(saldo);
                break;

            case 2:
                saldo = FazerDeposito(saldo);
                break;

            case 3:
                saldo = Saque(saldo);
                break;

            case 4:
                Console.WriteLine("ENCERRANDO PROGRAMA....");
                break;

        }
    }
    Console.ReadKey();
    // criação do menu de opções 
    static int Menu()
    {

        Console.WriteLine("MENU DE OPÇÕES");
        Console.WriteLine("===============");
        Console.WriteLine("[1] Ver saldo");
        Console.WriteLine("[2] Depositar");
        Console.WriteLine("[3] Sacar");
        Console.WriteLine("[4] Encerrar");
        Console.Write("Escolha uma opção: ");

        int opcoes = int.Parse(Console.ReadLine());
        return opcoes;
    }
    // codigo de saldo
    static double MostrarSaldo(double saldo)
    {

        Console.WriteLine($"Seu saldo atual é R${saldo}");
        return saldo;

    }
    // codigo do deposito
    static double FazerDeposito(double saldo)
    {

        Console.Write("Digite o valor que deseja depositar, R$: ");
        double valor = double.Parse(Console.ReadLine());

        if (valor <= 0)
        {

            Console.WriteLine("Valor de depósito inválido. Tente novamente");

        }
        else
        {

            saldo += valor;
            Console.WriteLine($"Depósito de R${valor} realizado com sucesso. O saldo total é de R${saldo}");

        }
        return saldo;
    }
    // codigo do saque
    static double Saque(double saldo)
    {

        Console.Write("Qual o valor deseja sacar? R$: ");
        double valor = double.Parse(Console.ReadLine());

        if (valor <= 0)
        {

            Console.WriteLine("Valor de saque invalido!");

        }
        else if (valor > saldo)
        {

            Console.WriteLine("Saldo insuficiente para realizar essa operação!");

        }
        else
        {

            saldo -= valor;
            Console.WriteLine($"O saque de R${valor} realizado com sucesso. Seu novo saldo é R${saldo}");

        }
        return saldo;
    }
    Console.ReadLine();
    Console.Clear();
}