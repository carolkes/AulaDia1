<<<<<<< HEAD
var endpoint =
  "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";

function mostrar_historio(list_cotacao) {
  $("#lista-historico").empty();
  list_cotacao.forEach(function(item) {
    $("#lista-historico").append(`<li class="list-group-item">${item}</li>`);
  });
}

$(document).ready(function() {
  var list_cotacao = JSON.parse(localStorage.getItem("cotacoes") || `[]`);
  mostrar_historio(list_cotacao);

  var cotacao_compra = 0;
  var cotacao_venda = 0;

  fetch(endpoint).then(function(response) {
    response.json().then(function(data) {
      cotacao_compra = data.value[0].cotacaoCompra;
      cotacao_venda = data.value[0].cotacaoVenda;
    });
  });

  $("#btn-converter").click(function() {
    var money = $("#input-valor").val();
    var valorFinalCompra = money ? parseFloat(money) * cotacao_compra : 0;
    var valorFinalVenda = money ? parseFloat(money) * cotacao_venda : 0;

    $("#input-resultado").text(`R$ ${valorFinalCompra.toFixed(2)}`);
    list_cotacao.push(`valor:${money} - conversão:${valorFinalCompra}`);
    localStorage.setItem("cotacoes", JSON.stringify(list_cotacao));
    mostrar_historio(list_cotacao);
  });

  $("#btn-limpar").click(function() {
    if (confirm("Deseja apagar os valores?")) {
      localStorage.clear();
      list_cotacao = [];
      mostrar_historio(list_cotacao);
    }
  });
});
=======
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



>>>>>>> 11364dcfd37844a509e11b311e263b03e964ae1a
