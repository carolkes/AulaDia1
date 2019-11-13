/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var bicicleta = {
    nome: "Madu",
    idade: 6,
    raca: "Border Collie",
    cor: "preta e branca"
};

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nome"]').val(bicicleta.nome);
        $('input[name="idade"]').val(bicicleta.idade);
        $('input[name="raca"]').val(bicicleta.raca);
        $('input[name="cor"]').val(bicicleta.cor);

        $('input[name="bntsalvar"]').click(function () {
            
            bicicleta = {
                nome: $('input[name="nome"]').val(),
                idade: $('input[name="idade"]').val(),
                raca: $('input[name="raca"]').val(),
                cor: $('input[name="cor"]').val()
            }

            LimparTela();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert((bicicleta.nome) + " " + (bicicleta.idade) + " " + (bicicleta.raca) + " " + (bicicleta.cor));
        });

    }
);

function LimparTela() {
    debugger
    //obtemos todos os campos do tipo input
    var meusInputs = $('input[type="text"]');
    //loop para cada campo
    for (var i = 0; i < meusInputs.length; i++) {
        //limpamos o valor dos campos
        meusInputs.val("");
    }
}
