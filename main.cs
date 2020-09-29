using System;

class MainClass {

    public static void Main(string[] args) {
        int answer;
        string name;
        char gender; //para preferenciar prestadores femininos para o sexo feminino
        string contact;
        clientAdress adress = new Adress();
        string city;
        string state;
        string type;

        Console.Write("Bem-vindo ao 'Resolva!', a plataforma que te ajuda a resolver seus problemas por si só com a ajuda de verdadeiros profissionais!!\n\nQuer solicitar suporte? [1] Sim ou [2] Não?\nResposta: ");
        answer = int.Parse(Console.ReadLine());
        if (answer == 1){
            Console.WriteLine("Dados pessoais");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Gênero (M para masculino e F para feminino): ");
            gender = Console.ReadLine();
            Console.Write("Telefone: ");
            contact = Console.ReadLine();
            Console.Write("Endereço: ");
            Client client = new Client();
            client.Register(name, gender, contact);
        } else if (answer == 2){
            Console.ReadLine("Cadastrar prestador? [1] Sim ou [2] Não?\nResposta: ");
            answer = int.Parse(Console.ReadeLine());
            if (answer == 1){
                Console.WriteLine("Dados pessoais");
                Console.Write("Nome: ");
                name = Console.ReadLine();
                Console.Write("Gênero (M para masculino e F para feminino): ");
                gender = Console.ReadLine();
                Console.Write("Cidade: ");
                city = Console.ReadLine();
                Console.Write("Estado: ");
                state = Console.ReadLine();
                Console.Write("Tipo: ");
                type = Console.ReadLine();
                Worker worker = new Worker(name, gender, city, state, type);
            }
        } else {
            Console.WriteLine("Obrigado por usar o App.");
            
        }
    }
}