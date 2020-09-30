using System;

class Client {
    private string nome;
    private string contato;
    private string cidade;
    private string estado;
    public string areaProblema;
    public string descricaoProblema;
    
    
// Registra o solicitante
    public void Register(string nome, string contato, string cidade, string estado){
        this.nome = nome;
        this.contato = contato;
        this.cidade = cidade;
        this.estado = estado;
    }
// Registra o problema
    public void Problema(string areaProblema, string descricaoProblema){
        this.areaProblema = areaProblema;
        this.descricaoProblema = descricaoProblema;
    }

// Verifica se o prestador é compatível com as exigências do prestador
    public bool CompativelLocalidade(Prestador prestador) {
        if ((string.Equals(cidade, prestador.getCidade())) && (string.Equals(estado, prestador.getEstado()))) {
          return true;
        } else {
          return false;
        }
    }
    public bool CompativelProfissao(Prestador prestador) {
        if (string.Equals(areaProblema, prestador.getProfissao())) {
          return true;
        } else {
          return false;
        }
    }

    public bool Confirmar(int x) {
        if (x == 1)
            return true;
        else
            return false;
    }
}