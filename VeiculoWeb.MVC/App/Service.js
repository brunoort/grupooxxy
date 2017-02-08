

app.service("clienteService", function ($http) {

    this.getClientes = function () {
        return $http.get("Cliente/GetAll");
    };

    this.getClienteById = function (id) {
         var response = $http({
            method: "post",
            url: "Cliente/GetById",
            params: {
                id: JSON.stringify(id)
            }
        });
        return response;
    }

    this.AddCliente = function (cliente, $scope) {
        
        var objXhr = new XMLHttpRequest();
        objXhr.responseType = "arraybuffer";
        objXhr.onload = function onload(result) {
            alert("Cadastro efetuado com sucesso!");           
        };        
        objXhr.onerror = function onerror(result) {
            alert("Erro ao efetuar cadastro.");
        };

        objXhr.open("POST", "/Cliente/Create/");
        objXhr.send(cliente);
    }

});