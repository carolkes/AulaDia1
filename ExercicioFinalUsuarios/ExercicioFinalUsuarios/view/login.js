'strict';
(function () {

    window.addEventListener('load', function () {

        var button_login = document.getElementById("btn-entrar");
        var input_login = document.getElementById("login");
        var senha_login = document.getElementById("senha");

        button_login.addEventListener("click", function () {
            requisicao('/login', {
                method: 'POST',
                body: JSON.stringify({
                    login: input_login.value,
                    senha: senha_login.value
                })
            }).then(function (data) {
                alert('OK')
            });
        });
    });

})();