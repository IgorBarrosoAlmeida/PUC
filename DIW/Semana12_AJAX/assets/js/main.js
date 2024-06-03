
// Função que define o onreadystatechange de uma requisição para capturar erros
function setRequisicaoState(req) {
    req.onreadystatechange = function () {
      if (req.readyState === 4) {
          if (req.status >= 200 && req.status < 300) {
              console.log("Requisição ocorreu corretamente")
          } else {
              console.error('Erro na requisição:', req.status, req.statusText);
          }
      }
    };
    return req;
}
  
// Recebe caminho da requisição e um valor no formato de objeto
async function putJSON(caminho, data) {
    try {
      let response = await fetch(caminho, {
        method: 'PUT',
        headers: {'Content-Type': 'application/json'},
        body: data
      })
  
      if(!response.ok)
        throw new Error(response.statusText);
    } catch(error){
      throw new Error('Erro ao fazer PUT: '+error);
    }
  
    return true;
}
  
// Recebe o caminho da requisição e retorna o json no formato de objeto
async function getJSON(caminho) {
    let response = await fetch(caminho);
    if (!response.ok) {
      throw new Error('Network response was not ok ' + response.statusText);
    }
    let data = await response.json();
    return data;
}

function carregaPagina(itens) {
    let div_cards = document.getElementById("cards");


    itens.forEach(element => {
        div_cards.innerHTML += `<div class="card col-3" style="width: 18rem;">`+
        `<img src="${element.linkImg}" class="card-img-top" alt="Imagem do filme ${element.nome}">`+
        `<div class="card-body">`+
        `  <h5 class="card-title">${element.nome}</h5>`+
        `  <p class="card-text">Genero: ${element.genero}</p>`+
        `  <p class="card-text">Sinopse: ${element.sinopse}</p>`+
        `  <p class="card-text">Data de Lançamento: ${element.dataDeLancamento}</p>`+
        `</div>`+
        `</div>`;
    });
}

async function main() {
    // Insira aqui o caminho do seu servidor
    const caminho_JSON = "https://730485d8-bc0f-48e0-a1a1-4e6d58910384-00-yml9m902y0qe.worf.replit.dev/filmes";

    try 
    {
        // Leitura dos dados do json
        let resposta_requisicao = await getJSON(caminho_JSON);

        carregaPagina(resposta_requisicao);
    }
    catch(e)
    {
        console.log("Problema ao efetuar requisição: " + e);
    }
}

main();