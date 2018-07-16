//Pagina Inicial 
function generateBooksToList(item) {

    var holder = $("<div>"); // faz o mesmo que var holder = document.createElement("div");
    holder.addClass("cadalivro");

    var texto = $("<div>");
    texto.addClass("texto");

    var a = $("<a>");
    a.click(function () { loadBookDetails(idTemp); });
    a.text(item.titulo);
    a.attr("font-weight", "bold");
    a.css({ cursor: "pointer", fontWeight: "bold" });
    texto.append(a);
    holder.append(texto);

    var img = $("<img>");
    let idTemp = item.id;
    img.click(function () { loadBookDetails(idTemp); });
    img.attr("src", "imagens/" + item.fotografia); //Adiciona  a Imagem do livro
    img.css({ width: "80%", minHeight: "80%", height: "auto", marginTop: "-22px", objectFit: "contain" }); //css da capa do livro
    holder.append(img);
    return holder;

}
//Gera uma lista de Livros
function generateListBook(items) {
    var holder = $("<div>");
    holder.addClass("listalivros");
    var i;
    for (i = 0; i < items.length; i++) {
        holder.append(generateBooksToList(items[i]));
    }
    $("#pagina").html("").append(holder);
}

//obtem lista de Filmes
function getBookList() {
    return fetch("/api/livros", { headers: { Accept: "application/json" } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Um Erro ocorreu"));
            }
        });
}

//Gera uma Lista de detalhes dos livros
function getBookDetails(idLivro) {
    return fetch("/api/livros/" + idLivro, { headers: { Accept: "application/json" } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Um Erro ocorreu"));
            }
        });
}

//Gera uma Lista de detalhes dos autores 
function getAutorsDetails(idAutor) {
    return fetch("/api/autor/" + idAutor, { headers: { Accept: "application/json" } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Um Erro ocurreu"));
            }
        });
}
