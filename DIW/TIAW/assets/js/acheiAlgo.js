/* Arquivo de Javascript da página de cadastro de um item */

/* ----------- Funções ----------- */
function preenche_select(req) {
    let select = document.getElementById("select_instituicao");

    // Passa por cada elemento de instituições para adicionar no select
    req.instituicoes.forEach(element => {
        let text = `<option value="${element.id}">${element.nome}</option>`;
        select.innerHTML += text;
    });
}

// declara variaveis
var form_cadastro = document.getElementById("cadastro_item");
var lista_input = document.getElementsByClassName("item_input");
var caminho_JSON = "./assets/json/instituicao.json"
var requisicao = new XMLHttpRequest();

// Leitura dos dados do json
requisicao.open("GET", caminho_JSON);
requisicao.responseType = "json";
requisicao.send();

requisicao.onload = function () {
    var resposta_requisicao = requisicao.response;
    preenche_select(resposta_requisicao);
  
};


form_cadastro.addEventListener("submit", (event) => {
    event.preventDefault();
});