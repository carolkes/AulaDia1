$(document).ready(function () {
    

    $('#btncalcular').click(function () {

        var nome = $('#form_principal').serialize();
        var url = `http://localhost:55426/api/CalculoIMC?${nome}`;

        $.get(url, function (data) {
            var teste = `
    <p>
 
  <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
    Botão com data-target
  $('input[name="nomeUsuario"]').val();
</p>
<div class="collapse" id="collapseExample">
  <div class="card card-body">
    ${data}
  </div>
</div>`
            $('#divContent').append(teste)
        });
    });

});

