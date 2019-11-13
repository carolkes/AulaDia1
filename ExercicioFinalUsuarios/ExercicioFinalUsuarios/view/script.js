function requisicao(endpoint, config) {
    return fetch('http://localhost:53000' + endpoint, config).then(function (response) {
        return response.json()
    });
}