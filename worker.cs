using System;

class Prestador {
    private string nome;
    private string contato;
    private string cidade;
    private string estado;
    private string profissao;

    public void Registrar(string nome, string cidade, string estado, string profissao){
        this.nome = nome;
        this.cidade = cidade;
        this.estado = estado;
        this.profissao = profissao;
    }

    public string getNome(){
        return nome;
    }

    public string getContato(){
        return contato;
    }

    public string getCidade(){
        return cidade;
    }

    public string getEstado(){
        return estado;
    }

    public string getProfissao(){
        return profissao;
    }

    public bool Confirmar(int x) {
        if (x == 1)
            return true;
        else
            return false;
    }
}