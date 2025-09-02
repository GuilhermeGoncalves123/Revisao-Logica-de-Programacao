using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //variaveis
        //C# - Linguagem FORTEMENTE tipada
        //tipos de dados: string, int, float, double, bool
        //tiposDeDado nomeDaVariavel = valorAtribuido 
        string nome = "Laura"; //Criando e atribuindo a variavel

        int idade = 18; //criei e atribui a variavel 

        Console.WriteLine("O nome do usuario e:" + nome); //imprimi a variavel 
        Console.WriteLine(@$"A idade do usuario e: {idade}");//imprimi a variavel com a interpolacao


        var nomeDois = "allan";
        var idadeDois = 16;
        var verificacao = true;
        Console.WriteLine(nomeDois);
        Console.WriteLine(idadeDois);
        Console.WriteLine(verificacao);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("---------------OPERADORES ARITMETICOS------------");

        int anoAtual = 2025;
        int anoNascimento = 2008;

        int idade3 = anoAtual - anoNascimento;

        Console.WriteLine("A idade da dani e: " + idade3);

        float trocadoMae = 2.20f;
        float trocadoVo = 150.60f;

        float trocadoTotal = trocadoMae + trocadoVo;

        Console.Write("o trocado foi de: R$" + trocadoTotal);
        Console.WriteLine("--------------------------------");

        int numero01 = 6;
        int numero02 = 2;

        int multiplicacao = numero01 * numero02;
        int divisao = numero01 / numero02;
        int resto = numero01 % numero02;


        Console.WriteLine($" O resultado da multiplicacao e: {multiplicacao}");
        Console.WriteLine($" O resultado da divisao e: {divisao}");
        Console.WriteLine($" O resultado da resto e: {resto}");

        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("-----------------------------------------OPERADORES LOGICOS");
        // && - e 
        // || - ou 
        //! - nao 

        int idadeDabelly = 18;
        bool suco = true;
        bool roupaDeTime = true;

        if (idadeDabelly >= 18 && !suco || !roupaDeTime)
        {
            Console.WriteLine("VAMOS COMECAR, TUTS TUTS TUTS");
        }
        else
        {
            Console.WriteLine("Uma pena, e proibido a entrada de menores de idade!");
        }
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("------------------------OERADORES CONDICIONAIS-----------------------");
        // == - igual
        //!= - diferente
        //< - menor 
        // > - maior
        // <== - menor igual
        // >== - maior igual 

        int dindinDoryan = 2500;
        int dindinDoSillas = 10000;


        if (dindinDoryan > dindinDoSillas)
        {
            Console.WriteLine("O ryan paga a pizza hoje!");
        }
        else if (dindinDoryan > dindinDoSillas)
        {
            Console.WriteLine("O sillas paga a pkizza hoje!");
        }
        else
        {
            Console.WriteLine("vao ter que rachar a contaaaa!");
        }

        Console.WriteLine("--------------------------------------");


        //swith case 
        string diaDaSemana = "terca-feira";

        switch (diaDaSemana.ToLower())
        {
            case "domingo":
                Console.WriteLine("domingou, hora do fantastico");
                break;
            case "segunda-feira":
                Console.WriteLine("segundou, odeio tem aula de portugues");
                break;
            case "terca-feira":
                Console.WriteLine("tercou, dia de pizza em dobro");
                break;
            case "quarta-feira":
                Console.WriteLine("quartou, dia de feijuca");
                break;
            case "quinta-feira":
                Console.WriteLine("quintou, nao aguento mais");
                break;
            case "sexta-feira":
                Console.WriteLine("sextou, dia de maldade");
                break;
            case "sabado":
                Console.WriteLine("sabadou, trabalho dobrado");
                break;
        }

        //Laços

        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("------------------------LACOS DE REPETICAO-----------------------");

        //for(inicializador; condição; incrementa/decrementa)
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        //i-- == i - 1
        //i++ == i + 1
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        //while(condicao){}
        bool amarVoce = true;

        while (amarVoce)
        {
            Console.WriteLine($"TE AMO ❤🤍🌻");
            amarVoce = false;
        }
        //do while
        bool minerio = true;

        do
        {
            Console.WriteLine("Minerando...💎");
        } while (minerio);

        Console.WriteLine("-----------------------------------------------");



    }
}


