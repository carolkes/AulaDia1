$(document).ready(function () {

    var url = `http://localhost:55426/api/CalculoIMC?nomeUsuario={nomeUsuario}&pesoUsuario={pesoUsuario}&alturaUsuario={alturaUsuario}`;
    $.get(url);

})

