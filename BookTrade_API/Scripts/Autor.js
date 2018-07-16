//Fotografia do Autor
function AutorPic(result) {
    var div_holder_img = $("<div>");

    var img = $("<img>");
    div_holder_img.append(img);
    img.attr("src", "imagens/" + result.imagem); //Adiciona  a Imagem do livro 
    img.css({ width: "400px", minHeight: "100%", height: "500px", objectFit: "contain" });

    return div_holder_img;
}

//Nome e data de nascimento do autor
function autor(result) {
    var div_holder_info = $("<div>");

    var h3_name = $("<h3>");
    div_holder_info.append(h3_name);
    h3_name.addClass("nome");
    h3_name.css({ fontWeight: "bold", color: "firebrick", marginLeft: "50px" })
    h3_name.text(result.nome);

    var a_birthDate = $("<div>");
    div_holder_info.append(a_birthDate);

    var textDe = $("<a>");
    a_birthDate.append(textDe);
    textDe.text("Nasceu em ");
    textDe.css({ color: "black", fontWeight: "bold", marginLeft: "50px" });

    var a_BirtDateText = $("<a>");
    a_birthDate.append(a_BirtDateText);
    a_BirtDateText.addClass("datanasc");
    a_BirtDateText.text(result.Aniv);

    return div_holder_info;
}

//Bibiografia do autor
function Bibliografia(result) {

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