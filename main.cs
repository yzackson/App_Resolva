using System;

class MainClass {

    public static void Main(string[] args) {
        int resposta;
        string nome;
        string contato;
        string cidade;
        string estado;
        string profissao;
        string descricao;

        Prestador prestador = new Prestador();
        prestador.Registrar("Jão Couve", "Vitória", "ES", "Eletrica");

        Console.Write("Bem-vindo ao 'Resolva!'\n\nQuer solicitar suporte? [1] Sim ou [2] Não\nResposta: ");
        resposta = int.Parse(Console.ReadLine());
        if (resposta == 1){
            
            Console.Clear();

            Client client = new Client();

            Console.Write("Dados pessoais\nNome: ");
            nome = Console.ReadLine();
            Console.Write("Telefone: ");
            contato = Console.ReadLine();
            Console.Write("Cidade: ");
            cidade = Console.ReadLine();
            Console.Write("Estado: ");
            estado = Console.ReadLine();

            client.Register(nome, contato, cidade, estado);


            Console.Clear();
            Console.Write("Escreva a area de suporte? (eletrica, mecanica ou hidraulica)\nResposta: ");
            profissao = int.Parse(Console.ReadLine());
            Console.Write("Descrição do problema: ");
            descricao = Console.ReadLine();

            client.Problema(profissao, descricao);

            if (client.Compativel(prestador)){
                Console.Write("Encontramos o prestador [0]. Ele é de [1]-[2] e é da área [3].\n Deseja acioná-lo para suporte? [1] Sim ou [2] Não\nResposta: ", prestador.getNome, prestador.getCidade, prestador.getEstado, prestador.getProfissao);
                
                //client.Confirmar(int.Parse(Console.ReadLine()));
                
                if (client.Confirmar(int.Parse(Console.ReadLine()))) {
                    Console.WriteLine("Já passamos sua solicitação para o [0] e logo logo ele entrará em contato contigo. Obrigado por utilizar nosso App!");
                } else {
                    Console.WriteLine("Ah, tudo bem. Respeitamos seus motivos.");
                }
            }
            



        } else {
            Console.WriteLine("Obrigado por usar o App.");
        }
    }
}