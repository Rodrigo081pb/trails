 
/* Estrutura de controle sequencial

var nome = "Hello world"; 

var user_input_name = window.prompt("Digite seu nome: ");
window.alert(user_input_name);

*/

let nome = window.prompt("Digite seu nome: ");

// Introdução a função/métodos/procedimentos

// essa função ela recebe o nome como parâmetro e exige uma mensagem de saudação
function informacao(nome) {
    window.alert("Olá " + nome + ", seja bem-vindo(a)!");
}

// FUNÇÃO QUE TROCA O NOME
function trocarNome() {
    let valor = window.document.getElementById("nome").value = "rodrigo";
    let nome = valor;
    informacao(nome);
}

trocarNome();


// criando uma classe
class rodrigo {
    // no construtor eu vou passar os atributos/parâmetros que eu quero que o objeto tenha
    constructor(nome, idade, sexo, profissao) {
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
        this.profissao = profissao;
    }
}

// criando um objeto
let rodrigo = new rodrigo("rodrigo", 30, "masculino", "desenvolvedor");
// acessando os atributos do objeto
console.log(rodrigo.nome);
console.log(rodrigo.idade);
console.log(rodrigo.sexo);
console.log(rodrigo.profissao);
