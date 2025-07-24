function obterValores(){
    const valor1 = document.getElementById('valor1').value;
    const valor2 = document.getElementById('valor2').value;

    // Verificar se os campos estão preenchidos
    if (valor1 === '' || valor2 === '') {
        document.getElementById('resultado').innerHTML = 'Erro: Preencha todos os campos!';
        return null;
    }

    return [valor1, valor2];
}

function calcularSoma(valor1, valor2) {
    // ao executar o botão tenho que somar os valores
    const resultado = Number(valor1) + Number(valor2);
    // e exibir o resultado na tela dentro da tag <h1 id="resultado">
    document.getElementById('resultado').innerHTML = `Resultado: ${resultado}`;
}

function calcularSubtracao(valor1, valor2) {
    const resultado = Number(valor1) - Number(valor2);
    document.getElementById('resultado').innerHTML = `Resultado: ${resultado}`;
}

function calcularMultiplicacao(valor1, valor2) {
    const resultado = Number(valor1) * Number(valor2);
    document.getElementById('resultado').innerHTML = `Resultado: ${resultado}`;
}

function calcularDivisao(valor1, valor2) {
    if (Number(valor2) === 0) {
        document.getElementById('resultado').innerHTML = 'Erro: Divisão por zero não é permitida.';
        return;
    }
    const resultado = Number(valor1) / Number(valor2);
    document.getElementById('resultado').innerHTML = `Resultado: ${resultado}`;
}

function calculos(){

    document.getElementById('btnSomar').addEventListener('click', function() {
        const valores = obterValores();
        if (valores !== null) {
            const [valor1, valor2] = valores;
            calcularSoma(valor1, valor2);
        }
    });

    document.getElementById('btnSubtrair').addEventListener('click', function() {
        const valores = obterValores();
        if (valores !== null) {
            const [valor1, valor2] = valores;
            calcularSubtracao(valor1, valor2);
        }
    });

    document.getElementById('btnMultiplicar').addEventListener('click', function() {
        const valores = obterValores();
        if (valores !== null) {
            const [valor1, valor2] = valores;
            calcularMultiplicacao(valor1, valor2);
        }
    });

    document.getElementById('btnDividir').addEventListener('click', function() {
        const valores = obterValores();
        if (valores !== null) {
            const [valor1, valor2] = valores;
            calcularDivisao(valor1, valor2);
        }
    });
    
}

// Chamar a função para inicializar os event listeners
calculos();