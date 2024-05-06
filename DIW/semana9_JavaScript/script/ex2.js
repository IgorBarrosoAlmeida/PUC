do {
    var operacao = prompt("Digite a operação ('+', '-', '*' ou '/'):")[0];
    var num1 = parseFloat(prompt("Digite o primeiro número:"));
    var num2 = parseFloat(prompt("Digite o segundo número:"));
    var invalido;


    if(isNaN(num1) || isNaN(num2)) {
        alert("Número invalido.");
        invalido = true;
    } else {
        switch(operacao) {
            case '+':
                alert(num1 + operacao + num2 + " = " + (num1 + num2));
                invalido = false;
                break;
            case '-':
                alert(num1 + operacao + num2 + " = " + (num1 - num2));
                invalido = false;
                break;
            case '*':
                alert(num1 + operacao + num2 + " = " + (num1 * num2));
                invalido = false;
                break;
            case '/':
                alert(num1 + operacao + num2 + " = " + (num1 / num2));
                invalido = false;
                break;
            default:
                alert("Operação invalida.");
                invalido = true;
                break;
        }
    }
} while(invalido);
