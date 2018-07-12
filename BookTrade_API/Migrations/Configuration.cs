namespace BookTrade_API.Migrations {
    using BookTrade.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookTrade_API.Models.DbCtxt> {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(BookTrade_API.Models.DbCtxt context) {
            //********Seeds*********
            //utilizador
            var user = new List<Utilizador> {
                new Utilizador {Id=1,DataNasc=new DateTime(1996,10,02),Email="simaoliveira@ipt.pt",NomeCompleto="Simao Pedro De Oliveira Moleiro"},
                new Utilizador {Id=2,DataNasc=new DateTime(1996,05,03),Email="rafandreg@ipt.pt",NomeCompleto="Rafael Andre Campos Goncalves"},
                new Utilizador {Id=3,DataNasc=new DateTime(1995,10,02),Email="tixinha@ipt.pt",NomeCompleto="Patricia Sofia Magalhaes Faustino"},
                new Utilizador {Id=4,DataNasc=new DateTime(1995,07,02),Email="bokica@ipt.pt",NomeCompleto="Beatriz Bangura da Silva Okica de Sa"},
                new Utilizador {Id=5,DataNasc=new DateTime(1999,06,16),Email="cmartins@ipt.pt",NomeCompleto="Claudia Marisa Ferreira Martins"},
                new Utilizador {Id=6,DataNasc=new DateTime(1992,05,18),Email="sdias@ipt.pt",NomeCompleto="Ana Sofia Mendes Dias"},
            };
            user.ForEach(dd => context.Utilizador.AddOrUpdate(d => d.Id, dd));
            context.SaveChanges();


            //Autores
            var autor = new List<Autor> {
                new Autor {Id=1,Nome="Paulo Duarte", DataNasc=new DateTime(1979,03,14),Descricao="Paulo Duarte, sj. (1979 - Portim�o) - Jesu�ta, padre, coordenador da pastoral e professor no Col�gio das Caldinhas (Sto. Tirso). S�o muitas as pessoas que acompanha diariamente: em aulas, em conversas, em celebra��o de missa e reconcilia��o. �A presen�a nas redes sociais e ocasionalmente em programas televisivos permite uma comunica��o� ampla com a sociedade atual.",AutorFotografia="pauloduarte.jpg"},
                new Autor {Id=2,Nome="Raul Minh'alma", DataNasc=new DateTime(1992,05,14),Descricao="Nasceu em 1992, � natural do Marco de Canaveses, formado em Engenharia Mec�nica na Faculdade de Engenharia da Universidade do Porto. Come�ou a escrever poesia com dezassete anos e em 2011 lan�a o seu primeiro livro de poemas com o t�tulo",AutorFotografia="raulminhalma.jpg"},
                new Autor {Id=3,Nome="Heather Morris", DataNasc=new DateTime(1953,07,20),Descricao="Heather Morris nasceu na Nova Zel�ndia e reside atualmente na Austr�lia. Durante v�rios anos, enquanto trabalhava num hospital p�blico em Melbourne, estudou e escreveu argumentos para cinema. ",AutorFotografia="heathermorris.jpg"},
                new Autor {Id=4,Nome="Helena Sacadura Cabral", DataNasc=new DateTime(1950,10,03),Descricao="Al�m de colunista de diversos jornais e revistas, mant�m colabora��o regular em televis�o. Autora de duas dezenas de livros, concilia ainda a participa��o activa com a atualiza��o dos seus quatros blogues.",AutorFotografia="helenasacaduracabral.jpg"},
                new Autor {Id=5,Nome="Lars Kepler", DataNasc=new DateTime(1960,03,20),Descricao="Lars Kepler � o pseud�nimo de uma dupla de escritores de sucesso na Su�cia: Alexander Ahndoril e Alexandra Coelho Ahndoril. O Hipnotista, primeiro volume da saga, alcan�ou um enorme sucesso internacional e foi adaptado ao cinema pela m�o do realizador Lasse Hallstr�m",AutorFotografia="larskepler.jpg"},
                new Autor {Id=6,Nome="Herberto Helder", DataNasc=new DateTime(1980,04,30),Descricao="Herberto Helder nasceu em 1930 no Funchal, onde concluiu o 5.� ano. Em 1948 matriculou-se em Direito mas cedo abandonou esse curso para se inscrever em Filologia Rom�nica, que frequentou durante tr�s anos. Teve in�meros trabalhos e colaborou em v�rios peri�dicos como A Briosa",AutorFotografia="herbertohelder.jpg"},
                new Autor {Id=7,Nome="Maria Teresa Gonzales", DataNasc=new DateTime(1958,06,17),Descricao="Maria Teresa Maia Gonzalez, licenciada em L�nguas e Literaturas Modernas, co-autora da colec��o 'O Clube das Chaves', � autora de in�meras outras obras, incluindo v�rios t�tulos premiados. 'A Lua de Joana', o seu maior sucesso editorial. O seu livro, 'O Pai no Tecto', foi igualmente bem recebido pelos jovens leitores e professores. � uma das mais vendidas e prestigiadas autoras portuguesas de livros dedicados a crian�as e jovens adolescentes. Inicia com a publica��o deste livro na Principia, uma colabora��o na �rea dos livros para crian�as e jovens adolescentes, com livros cujo conte�do pretende transmitir uma mensagem espiritual e um sentido de religiosidade adaptado � idade do p�blico alvo.",AutorFotografia="MariaTeresaGoncalves.jpg"},
                new Autor {Id=8,Nome="Mark Manson", DataNasc=new DateTime(1984,03,09),Descricao="Mark Manson cresceu em Austin, no Texas, viveu em Boston e viajou por todo o mundo durante sete anos. � um autor bestseller do The New York Times e escreve sobre uma grande variedade de temas, no �mbito do desenvolvimento pessoal. Para al�m da sua atividade de bloguer e empreendedor, publica regularmente artigos com a BBC, CNN, Business Insider, Time, entre outros. Vive atualmente em Nova Iorque.",AutorFotografia="markmanson.jpg"},
                new Autor {Id=9,Nome="Afonso Noite-Luar", DataNasc=new DateTime(1992,06,17),Descricao="Eu sou o Afonso Noite-Luar. Basta-te saber isso.Afonso s� h� um, n�o invoques o meu nome em v�o.",AutorFotografia="afonsonoiteluar.jpg"},
                new Autor {Id=10,Nome="Jo�l Dicker", DataNasc=new DateTime(1985,06,16),Descricao="Jo�l Dicker nasceu em Gen�ve, Su��a, em 1985. A verdade sobre o caso Harry Quebert � o seu segundo romance, com o qual arrecadou v�rios pr�mios: Prix de la Vocation Bleustein-Blanchet, o Grande Pr�mio do Romance da Academia Francesa, o Pr�mio Goncourt des Lyc�ens e o pr�mio da revista Lire para Melhor Romance em l�ngua francesa. O seu primeiro romance, Les derniers jours de nos p�res, venceu o Pr�mio dos Escritores de Gen�ve.",AutorFotografia="joeldicker.jpg"},
            };
            autor.ForEach(dd => context.Autors.AddOrUpdate(d => d.Nome, dd));
            context.SaveChanges();

            //Categorias
            var categ = new List<Categorias> {
                new Categorias {Id=1,Nome="Infantis e Juvenis"},
                new Categorias {Id=2,Nome="Literatura"},
                new Categorias {Id=3,Nome="Politica"},
                new Categorias {Id=4,Nome="Crime"},
                new Categorias {Id=5,Nome="Hist�ria"},
                new Categorias {Id=6,Nome="Religi�o"},
                new Categorias {Id=7,Nome="Romance"},
                new Categorias {Id=8,Nome="Aventura"},
                new Categorias {Id=9,Nome="Auto Ajuda"},
                new Categorias {Id=10,Nome="Mem�rias e Testemunhos"},
           };
            categ.ForEach(dd => context.Categorias.AddOrUpdate(d => d.Nome, dd));
            context.SaveChanges();

            //Livros
            var livro = new List<Livro> {
                new Livro {Id=1,Titulo="O Ca�ador",Sinopse="A noite tinha acabado de cair, quando Sofia entra numa mans�o nos arredores de Estocolmo, onde o seu cliente - um homem muito abastado que nunca viu - a espera. Talvez seja por isso que Sofia avan�a furtivamente, como um animal selvagem.",AnoLanc=2018,Editora="Porto Editora",Idioma="Portugu�s",NumeroDePaginas=568,AutorId=5,Fotografia="ocacador.jpg"},
                new Livro {Id=2,Titulo="Uma Certa Forma de Vida",Sinopse="Neste livro, a autora come�a por abordar temas que marcam a vida moderna, mas que a podem transformar negativamente, se n�o estivermos atentos. ",AnoLanc=2018,Editora="Clube do Autor",Idioma="Portugues",NumeroDePaginas=184,AutorId=4,Fotografia="umacertaformadevida.jpg"},
                new Livro {Id=3,Titulo="O Tatuador de Auschwitz",Sinopse="Esta � a hist�ria assombrosa do tatuador de Auschwitz e da mulher que conquistou o seu cora��o - um dosepis�dios mais extraordin�rios e inesquec�veis do Holocausto.",AnoLanc=2018,Editora="Editorial Presen�a",Idioma="Portugues",NumeroDePaginas=232,AutorId=3,Fotografia="tatuador.jpg"},
                new Livro {Id=4,Titulo="Em min�sculas",Sinopse="Embora n�o esteja aqui coligida a totalidade das suas colabora��es, todos os textos deste livro foram publicados no Not�cia - Seman�rio Ilustrado, no per�odo em que Herberto Helder viveu em Luanda. ",AnoLanc=2018,Editora="Porto Editora",Idioma="Portugues",NumeroDePaginas=200,AutorId=6,Fotografia="emminusculas.jpg"},
                new Livro {Id=5,Titulo="D�-me um Dia para Mudar a Tua Vida",Sinopse=" Aqui encontras 500 mensagens inspiradoras para leres e refletires no teu dia a dia. Ser�o a tua b�ssola.",AnoLanc=2018,Editora="Manuscrito Editora",Idioma="Portugues",NumeroDePaginas=200,AutorId=2,Fotografia="dameumdia.jpg"},
                new Livro {Id=6,Titulo="Deus Como Tu",Sinopse="Deus Como Tu conduz-nos num regresso � f�, humana, vivida no quotidiano, e coloca-nos quest�es que nos fazem a pensar em temas como a morte, a culpa, a solid�o, mas tamb�m, o riso, a alegria e a liberdade.",AnoLanc=2018,Editora="Mat�ria Prima",Idioma="Portugues",NumeroDePaginas=168,AutorId=1,Fotografia="deuscomotu.jpg"},
                new Livro {Id=7,Titulo="A Lua de Joana",Sinopse="Ao lermos a Lua de Joana, n�o podemos deixar de pensar na forma como, muitas vezes, relegamos para segundo plano aquilo que realmente � importante na vida. Porque este livro alerta-nos para a import�ncia de estarmos atentos a n�s e ao outro, e de sermos capazes de, em conjunto, percorrer um caminho que conduza a uma vida plena�",AnoLanc=2010,Editora="PI",Idioma="Portugues",NumeroDePaginas=184,AutorId=7,Fotografia="aluadejoana.jpg"},
                new Livro {Id=8,Titulo="A Arte Subtil de Saber Dizer Que Se F*da",Sinopse="Durante d�cadas convenceram-nos de que o pensamento positivo era a chave para uma vida rica e feliz. Mas esses dias chegaram ao fim. Que se f*da o pensamento positivo! Mark Manson acredita que a sociedade est� contaminada por grandes doses de treta e de expectativas ilus�rias em rela��o a n�s pr�prios e ao mundo.",AnoLanc=2018,Editora="Desassossego",Idioma="Portugues",NumeroDePaginas=208,AutorId=8,Fotografia="aartesubtil.jpg"},
                new Livro {Id=9,Titulo="Ela Primeiro",Sinopse="�Vais apaixonar-te por mim dentro de um m�s�. In�s n�o precisou de tanto tempo para se perder no labirinto sedutor de Afonso e, aquilo que come�ou por ser um encontro casual no parque, rapidamente se tornou num complexo jogo de sedu��o e sexo.",AnoLanc=2018,Editora="Manuscrito Editora",Idioma="Portugues",NumeroDePaginas=312,AutorId=9,Fotografia="elaprimeiro.jpg"},
                new Livro {Id=10,Titulo="O Desaparecimento de Stephanie Mailer",Sinopse="Na noite de 30 de Julho de 1994, a pacata vila de Orphea, na costa leste dos Estados Unidos, assiste ao grande espect�culo de abertura do festival de teatro. Mas o presidente da C�mara est� atrasado para a cerim�nia� Ao mesmo tempo, Samuel Paladin percorre as ruas desertas da vila � procura da mulher, que saiu para correr e n�o voltou. S� para quando encontra o seu corpo em frente � casa do presidente da C�mara. Dentro da casa, toda a fam�lia do presidente est� morta.",AnoLanc=2018,Editora="Alfaguara Portugal",Idioma="Portugues",NumeroDePaginas=640,AutorId=10,Fotografia="odesaparecimento.jpg"},
            };
            livro.ForEach(dd => context.Livros.AddOrUpdate(d => d.Titulo, dd));
            context.SaveChanges();

            //Coment�rios
            var coment = new List<Comentarios> {
                new Comentarios {Id=1,Texto="Adoro! Muito Emocionante",Data=new DateTime(2016,10,03),LivroId=3,UtilizadorId=1},
                new Comentarios {Id=2,Texto="Muito Bom, recomendo!",Data=new DateTime(2017,03,10),LivroId=4,UtilizadorId=5},
                new Comentarios {Id=3,Texto="5 estrelas, Fantastico",Data=new DateTime(2018,01,26),LivroId=1,UtilizadorId=3},
                new Comentarios {Id=4,Texto="Ficou um pouco �quem das expectativas",Data=new DateTime(2017,12,06),LivroId=2,UtilizadorId=6},
                new Comentarios {Id=5,Texto="bom mas tedioso",Data=new DateTime(2016,05,15),LivroId=6,UtilizadorId=4},
                new Comentarios {Id=6,Texto="Teve um bom inicio mas um p�ssimo final",Data=new DateTime(2017,11,17),LivroId=5,UtilizadorId=2},
                new Comentarios {Id=7,Texto="Demasiado Tedioso",Data=new DateTime(2016,11,17),LivroId=5,UtilizadorId=3},
                new Comentarios {Id=8,Texto="Assunto Pouco Interessante",Data=new DateTime(2017,03,20),LivroId=3,UtilizadorId=4},
                new Comentarios {Id=9,Texto="�timo Livro, torna-nos muito pensativos",Data=new DateTime(2015,09,01),LivroId=7,UtilizadorId=6},
                new Comentarios {Id=10,Texto="Final fantastico!",Data=new DateTime(2016,07,27),LivroId=5,UtilizadorId=1},
            };
            coment.ForEach(dd => context.Comentarios.AddOrUpdate(d => d.Texto, dd));
            context.SaveChanges();
        }
    }
}
