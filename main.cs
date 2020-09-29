using System;

class MainClass {

    public static void Main(string[] args) {
        int resposta1, resposta2;
        string nome;
        char genero; //para preferenciar prestadores femininos para o sexo feminino
        string contato;
        clientAdress adress = new Adress();
        string area;

        Prestador joao = new Prestador();
        joao.Registrar("Jão Couve", "Vitória", "ES", "Eletrica");

        Console.Write("Bem-vindo ao 'Resolva!', a plataforma que te ajuda a resolver seus problemas por si só com a ajuda de verdadeiros profissionais!!\n\nQuer solicitar suporte? [1] Sim ou [2] Não?\nResposta: ");
        resposta1 = int.Parse(Console.ReadLine());
        if (resposta1 == 1){
            Console.Write("Presencial ou remoto? [1] Presencial ou [2] Remoto?\nResposta: ");
            resposta2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados pessoais");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            //Console.Write("Gênero (M para masculino e F para feminino): ");
            genero = Console.ReadLine();
            Console.Write("Telefone: ");
            contato = Console.ReadLine();
            Console.Write("Endereço: ");
            Client client = new Client();
            Console.Write("Qual a area de suporte?\n[1] Eletrica\n[2] Mecanica\n[3] Hidráulica?\nResposta: ");
            area = int.Parse(Console.ReadLine());
            client.Register(nome, genero, contato, reposta2);



        } else {
            Console.WriteLine("Obrigado por usar o App.");
        }
    }
}