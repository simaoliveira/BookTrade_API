//Capa do livro
function BookCover(result) {
    var div_holder_img = $("<div>");

    var img = $("<img>");
    div_holder_img.append(img);
    img.attr("src", "imagens/" + result.fotografia); //Adiciona  a Imagem do livro 
    img.css({ width: "300px", minHeight: "100%", height: "auto", objectFit: "contain" });

    return div_holder_img;
}

//Nome do livro 
function Books(result) {
    var h3_titulo = $("<h3>");

    h3_titulo.addClass("titulo");
    h3_titulo.css({ fontWeight: "bold", color: "firebrick", marginLeft: "50px" })
    h3_titulo.text(result.titulo);
    return h3_titulo;

}

//Nome do autor do livro
function BookAutors(result) {

    var div_autor = $("<div>");
    div_autor.css({ marginLeft: "50px" });

    var textDe = $("<a>");
    div_autor.append(textDe);
    textDe.text("de ");
    textDe.css({ color: "black" });


    var a_autor = $("<a>");
    div_autor.append(a_autor);
    a_autor.css({ textDecoration: "underline", color: "firebrick", cursor: "pointer", fontFamily: "Arial", fontWeight: "bold", fontSize: "18px" });
    a_autor.text(result.autoresNome);
    let idAutor = result.autores;
    a_autor.click(function () {
        loadAutor(idAutor);
    });

    return div_autor;

}

//Editora
function BookPublisher(result) {
    var div_publisher = $("<div>");
    div_publisher.css({ marginLeft: "50px" });

    var textDe = $("<a>");
    div_publisher.append(textDe);
    textDe.text("Editora: ");
    textDe.css({ color: "black" });


    var a_publisherText = $("<a>");
    div_publisher.append(a_publisherText);
    a_publisherText.css({ fontFamily: "Arial", color: "black" });
    a_publisherText.text(result.editora);

    return div_publisher;
}

//Idioma
function BookLanguage(result) {
    var div_language = $("<div>");

    div_language.css({ marginLeft: "50px" });


    var a_languageText = $("<a>");
    div_language.append(a_languageText);
    a_languageText.css({ fontFamily: "Arial", color: "black" });
    a_languageText.text(result.idioma);

    return div_language;
}

//Numero de Paginas
function PageNumbers(result) {
    var div_PagNum = $("<div>");

    div_PagNum.css({ marginLeft: "50px" });

    var textDe = $("<a>");
    div_PagNum.append(textDe);
    textDe.text("Número de Páginas: ");
    textDe.css({ color: "black", fontWeight: "bold" });


    var a_PageNumText = $("<a>");
    div_PagNum.append(a_PageNumText);
    a_PageNumText.css({ fontFamily: "Arial", color: "black" });
    a_PageNumText.text(result.numPag);

    return div_PagNum;

}

//Ano do Livro
function BookYear(result) {
    var div_ano = $("<div>");

    div_ano.css({ marginLeft: "50px" });

    var textDe = $("<a>");
    div_ano.append(textDe);
    textDe.text("Lançado em: ");
    textDe.css({ color: "black", fontWeight: "bold" });

    var a_anoTexto = $("<a>");
    div_ano.append(a_anoTexto);
    a_anoTexto.css({ fontFamily: "Arial", color: "black" });
    a_anoTexto.text(result.ano);

    return div_ano;
}

//categorias dos Livros 
function BookCategory(result) {
    var div_categorias = $("<div>");
    div_categorias.css({ marginLeft: "50px" });

    var p_categorias = $("<p>");
    div_categorias.append(p_categorias);
    p_categorias.css({ fontFamily: "Arial", fontWeight: "bold", color: "black", fontSize: "18px" });
    var tempStringBuild = "";
    for (var i = 0; i < result.categoria.length; i++) {
        tempStringBuild += result.categoria[i].Nome;
        if (i < result.categoria.length - 1) tempStringBuild += ", ";
    }
    p_categorias.text(tempStringBuild);

    return div_categorias;
}

//Sinopse do livro
function sinopse(result) {

    var div_sinopse = $("<div>");
    div_sinopse.addClass("sinopse");
    div_sinopse.css({ marginLeft: "50px" });

    var h5_Sinopse = $("<h5>");
    div_sinopse.append(h5_Sinopse);
    h5_Sinopse.css({ fontFamily: "Arial", fontWeight: "bold", color: "black" });
    h5_Sinopse.text("Sinopse");

    var span_sinopse = $("<span>");
    div_sinopse.append(span_sinopse);
    span_sinopse.text(result.sinopse);

    return div_sinopse;
}