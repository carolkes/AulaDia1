/*Ap carregar nosso site por completo, executa o conteudo do $(document).ready()*/
$(document).ready(
    function () {
        /*Informamos que ao clicar no botão enviar ele irá chamar nosso alerta*/
        $('button [name="btnboasvindas"]').click(function () {
            /*Aqui obtemos o valor digitado pelo usuario*/
            var nome_usuario = $('input[name="nome_usuario"]').val();
            /*Apresentamos nosso alerta de boas vindas*/
            $('span[name="usuariotext"]').text(nome_usuario);
            
        });  
    }
);

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="btnboasvindas"]').click();
    }
});
