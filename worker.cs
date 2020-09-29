using System;

class Worker {
    private string name;
    private char gender;
    private string city;
    private string state;
    private string type;

    // SET
    public void newWorker(string name, char gender, string city, string state, string type){
        this.name = name;
        this.gender = gender;
        this.city = city;
        this.state = state;
        this.type = type;
    }
    /*
    private void setName(){
        this.name = Console.ReadLine();
    }
    private void setGender(){
        this.gender = Console.ReadLine();
    }
    public void setCity(){
        this.name = Console.ReadLine();
    }
    public void setState(){
        this.name = Console.ReadLine();
    }
    public void setType(){
        this.name = Console.ReadLine();
    }
    */
}