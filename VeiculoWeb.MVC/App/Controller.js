app.controller("getClienteCtrl", function ($scope, clienteService) {
    getClientes();

    function getClienteById(id) {
        var getClienteDataById = clienteService.getClienteById(id);

        getClienteDataById.then(function (cliente) {
            $scope.detalhes = cliente.data;
            //GetDetails(cliente.data);
        }, function () {
            alert('Erro ao chamar detalhes do cliente.');
        });
    }


    function getClientes() {
        var getClienteData = clienteService.getClientes();
        getClienteData.then(function (cliente) {
            $scope.clientes = cliente.data;
        }, function () {
            alert('Erro ao chamar clientes.');
        });
    }

    $scope.openDetails = function (item) {
        $scope.divClientes = false;
        $scope.divDetail = true;

        getClienteById(item.Id);
    };

    $scope.closeDetails = function () {
        
        $scope.divClientes = true;
        $scope.divDetail = false;


    }

})

app.controller('formController', function ($scope, clienteService, $http) {

    $scope.getFileDetails = function (e) {
        $scope.files = [];
        $scope.$apply(function () {
            for (var i = 0; i < e.files.length; i++) {
                $scope.files.push(e.files[i])
            }
        });
    };

    $scope.AddCadastro = function () {

        var data = new FormData();
        for (var i in $scope.files) {
            data.append("uploadedFile", $scope.files[i]);
        }

        data.append("Nome", $scope.novocliente.Nome);
        data.append("CPF", $scope.novocliente.CPF);
        data.append("Placa", $scope.novocliente.Placa);
        data.append("Renavam", $scope.novocliente.Renavam);
        data.append("Bloqueado", $scope.novocliente.Bloqueado);

        var getClienteData = clienteService.AddCliente(data, $scope);

    }

});



