using System;

class Prestador {
    private string nome;
    //private char genero;
    private string cidade;
    private string estado;
    private string area;

    // SET
    public void Registrar(string nome,/* char genero,*/ string cidade, string estado, string area){
        this.nome = nome;
        //this.genero = genero;
        this.cidade = cidade;
        this.estado = estado;
        this.area = area;
    }
}