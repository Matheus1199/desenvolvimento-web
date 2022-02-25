class Pessoa{
    constructor(nome) {
        this.nome = nome;
    }

    falar(frase) {
        console.log(this.nome + " disse: " + frase);
    }
}

class Aluno extends Pessoa{
    estudar(disciplina) {
        console.log(this.nome + " estuda: " + disciplina);
    }
}

class Professor extends Pessoa{
    ensina(disciplina) {
        console.log(this.nome + " ensina: " + disciplina);
    }
}

var p1 = new Aluno("Francisco");

p1.falar("Oi, tudo bem?");
p1.falar("Como vai?");
p1.estudar("Programação")