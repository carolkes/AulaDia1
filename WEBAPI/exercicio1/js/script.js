$(document).ready(
    function () {
        $('input[name="btnconsultar"]').click(
            function () {
                var url = `https://viacep.com.br/ws/${$('input[name="cep"]').val()}/json/`
                $.get(url, function (data, status) {

                    if (data.erro) {
                        alert("Cep Inválido!");
                        return false;
                    }

                    $('input[name="cep"]').val(data.cep);
                    $('input[name="localidade"]').val(data.localidade);
                    $('input[name="bairro"]').val(data.bairro);
                    $('input[name="localidade"]').val(data.localidade);
                    $('input[name="uf"]').val(data.uf);
                    $('input[name="unidade"]').val(data.unidade);
                    $('input[name="ibge"]').val(data.ibge);
                    $('input[name="gia"]').val(data.gia);
                });
            }
        );
    }
);
