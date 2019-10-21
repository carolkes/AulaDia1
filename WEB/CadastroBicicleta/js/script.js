/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var bicicleta = {
    marca: "Caloi",
    valor: 1500,
    peso: "11.3"

};

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="marca"]').val(bicicleta.marca);
        $('input[name="valor"]').val(bicicleta.valor);
        $('input[name="peso"]').val(bicicleta.peso);

        $('input[name="bntsalvar"]').click(function () {

            bicicleta = {

                marca: $('input[name="marca"]').val(),
                valor: $('input[name="valor"]').val(),
                peso: $('input[name="peso"]').val()

            }

            LimparTela();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert((bicicleta.marca) + " " + (bicicleta.valor) + " " + (bicicleta.peso));
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
