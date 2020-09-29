using System;

class Client {
    private string name;
    private char gender; //para preferenciar prestadores femininos para o sexo feminino
    private string contact;
    clientAdress adress = new Adress();
    
    // SETs
    public static void Register(string name, char gender, string contact){
        this.name = name;
        this.gender = gender;
        this.contact = contact;
        setAdress();
    }

    /*
    private void setName(){ //alter name
        Console.Write("Nome: ");
        this.name = Console.ReadLine();
    }
    private void setGender(){ //alter gender
        Console.Write("Gênero (M para masculino e F para feminino): ");
        this.gender = Console.ReadLine();
    }
    public void setcontact(){ //alter contact
        Console.Write("Telefone: ");
        this.contact = Console.ReadLine();
    }
    public void setAdress(){ //alter adress
        adress.setAdress();
    }
    */
}

private class clientAdress {
    private string street;
    private int number;
    private string complement;
    private string neighboor;
    private string city;
    private string state;

    public void setAdress(){
        Console.Write("Rua: ");
        street = Console.ReadLine();

        Console.Write("Número: ");
        number = IntParse(Console.ReadLine());

        Console.Write("Complemento: ");
        complement = Console.ReadLine();

        Console.Write("Bairro: ");
        neighboor = Console.ReadLine();

        Console.Write("Cidade: ");
        city = Console.ReadLine();

        Console.Write("Estado: ");
        State = Console.ReadLine();
    }

}