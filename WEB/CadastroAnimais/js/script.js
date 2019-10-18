var animais = []

var animal = {
    nome: "Madu",
    idade: 6,
    raca: "Border Collie",
    cor: "preta e branca"
}

$(document).click(
    () => {
        animal = {
            nome: $('input[name="nome_animal"]').val(),
            idade: $('input[name="idade_animal"]').val(),
            raca: $('input[name="raca_animal"]').val(),
            cor: $('input[name="cor_animal"]').val()
        }
        animais.push(animal)
        console.log(animais)
    }
)

$(document).ready(
    function () {
        console.log(animal)
        $('input[name="nome_animal"]').val(animal.nome);
        $('input[name="idade_animal"]').val(animal.idade);
        $('input[name="raca_animal"]').val(animal.raca);
        $('input[name="cor_animal"]').val(animal.cor);



    }
    
)