const moedas = {
    real: 1,
    dolar_americano: 5.08,
    euro: 5.47,
    iene: 0.033,
    dolar_canadense: 3.71,
}

const form = document.getElementById("form");

form.addEventListener("submit", function(event) {
    // Evita que o formulário seja enviado
    event.preventDefault();

    // Pega os valores necessários para a conversão
    let input_valor = document.getElementById("input_valor").value;
    let origem = document.getElementById("moeda_origem").value;
    let destino = document.getElementById("moeda_destino").value;

    // Converte
    let valor_convertido = input_valor / moedas[origem];
    valor_convertido *= moedas[destino];

    // Caso já tenha um valor remove
    let div_convertido = document.getElementById("convertido");
    if(div_convertido.childElementCount > 0) {
        div_convertido.innerHTML = "";
    }

    // Adiciona o valor convertido na pagina
    var novo_texto;
    if(valor_convertido == 0) {
        novo_texto = "Valor invalido, preencha qual é o valor a ser convertido"
    } else {
        novo_texto = `${input_valor} ${origem.replace("_", " ")} é igual a: ${valor_convertido.toFixed(2)} ${destino.replace("_", " ")}`;
    }
    let texto_conversao = document.createElement("p");
    texto_conversao.appendChild(document.createTextNode(novo_texto));
    texto_conversao.classList.add("texto_conversao");

    div_convertido.appendChild(texto_conversao);
})