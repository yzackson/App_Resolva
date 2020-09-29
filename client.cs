using System;

class Client {
    private string nome;
    private char genero; //para preferenciar prestadores femininos para o sexo feminino
    private string contato;
    clientAdress endereco = new Adress();
    
    public static void Register(string nome, /*char genero, */string contato, int tipoSuporte){
        this.nome = nome;
        this.genero = genero;
        this.contato = contato;
        if (tipoSuporte == 1)
            setAdress();
        else
            SuporteRemoto();
    }

    public void VerificaCompatibilidade(Client cliente, Prestador prestador) {
        
    }

private class clientAdress {
    private string rua;
    private int numero;
    private string complemento;
    private string bairro;
    private string cidade;
    private string estado;

    public void setAdress(){
        Console.Write("Rua: ");
        rua = Console.ReadLine();

        Console.Write("Número: ");
        numero = IntParse(Console.ReadLine());

        Console.Write("Complemento: ");
        complemento = Console.ReadLine();

        Console.Write("Bairro: ");
        bairro = Console.ReadLine();

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Estado: ");
        estado = Console.ReadLine();
    }

}