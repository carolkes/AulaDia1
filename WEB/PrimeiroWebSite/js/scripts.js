$(document).ready(
    function () {
        AdicionaNomeAdicionaNome(); 
    });

/*Criamos nossa primeira função*/
function AdicionaNomeAdicionaNome() {
    /*Agora adicionamos a função dentro de nosso context
     do setInterval*/
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
}