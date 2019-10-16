$('[name="botao_enviar"]').click(
    function () {
        var nome = $('[name="nome"]').val();
        alert(nome ? 'Seja bem vindo(a) ' + nome : 'Para Receber Mensagem, Digite Seu Nome!');
    }
);