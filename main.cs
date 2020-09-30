using System;

class MainClass {

    public static void Main(string[] args) {

        Console.Clear();

        int resposta;
        string nome;
        string contato;
        string cidade;
        string estado;
        string profissao;
        string descricao;

        Prestador prestador = new Prestador();
        prestador.Registrar("Jão Couve", "Vitória", "ES", "eletrica");

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
            profissao = Console.ReadLine();
            Console.Write("Descrição do problema: ");
            descricao = Console.ReadLine();

            client.Problema(profissao, descricao);

            if (client.CompativelProfissao(prestador)){
                Console.Clear();
                if (client.CompativelLocalidade(prestador)) {
                    Console.Write("Encontramos o prestador {0} perto da sua localidade.\n Acionar suporte? [1] Sim ou [2] Não\nResposta: ", prestador.getNome());
                    
                    //client.Confirmar(int.Parse(Console.ReadLine()));
                    
                    if (client.Confirmar(int.Parse(Console.ReadLine()))) {
                        Console.WriteLine("Já passamos sua solicitação para o {0} e logo logo ele entrará em contato contigo. Obrigado por utilizar nosso App!", prestador.getNome());
                    } else {
                        Console.WriteLine("Obrigado por utilizar o App.");
                    }
                } else {
                    Console.Write("Encontramos o prestador {0}, mas ele não é da sua localidade. Ele é de {1}-{2} e só poderá te atender remotamente.\n Acionar suporte? [1] Sim ou [2] Não\nResposta: ", prestador.getNome(), prestador.getCidade(), prestador.getEstado());
                    if (client.Confirmar(int.Parse(Console.ReadLine()))) {
                        Console.WriteLine("Já passamos sua solicitação para o {0} e logo logo ele entrará em contato contigo. Obrigado por utilizar nosso App!", prestador.getNome());
                    } else {
                        Console.WriteLine("Obrigado por utilizar o App.");
                    }
                }
            } else {
                Console.Write("Nenhum prestador encontrado.");
            }
        } else {
            Console.WriteLine("Obrigado por utilizar o App.");
        }
    }
}