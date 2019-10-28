var teste = `<p>
    <button class="btn btn-secondary" type="button" data-toggle="collapse" data-target="#collapse${id}" aria-expanded="false" aria-controls="collapseExample">
        Calcular IMC
    </button>
    </p>
    <div class="collapse" id="collapse_id">
        <div class="card card-body">
            ${data}
        </div>
    </div>`

$(document).ready(function () {

    $('#btncalcular').click(function () {
        var nome = $('#form_principal').serialize();
        var url = `http://localhost:55426/api/CalculoIMC?${nome}`;
        $.get(url, function (data) {



            $('#collapse_id').append(
                teste
            );  
        });
    });

});

