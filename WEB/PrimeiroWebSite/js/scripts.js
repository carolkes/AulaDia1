$(document).ready(
    function () {
        AdicionaNomeAdicionaNome(); 
    });

/*Criamos nossa primeira fun��o*/
function AdicionaNomeAdicionaNome() {
    /*Agora adicionamos a fun��o dentro de nosso context
     do setInterval*/
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
}