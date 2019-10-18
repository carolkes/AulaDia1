$(document).ready(
    function () {
        $('input[name="btnconverter"]').click(function () {
            var valor_dolar = 4.16;
            var valor_real = $('input[name="valor_real"]').val();

            var convercao = valor_real / valor_dolar;

            $('input[name="valor_dolar"]').val(convercao);
        });
    }
);



