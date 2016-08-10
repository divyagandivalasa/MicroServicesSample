app.controller('customerController', function ($scope, $http) {
    var id = "ANATR";
    debugger;
    $http({
        method: 'Get',
        url: 'http://localhost:8733/api/GetId?id=ANATR',
        //params:
        //    {
        //        id: id
        //    }
    }).then(function successCallback(response) {
        debugger;
        $scope.customer = response.data;
    }, function errorCallback(response) {
        debugger;
        $scope.customer = [];
    });
});