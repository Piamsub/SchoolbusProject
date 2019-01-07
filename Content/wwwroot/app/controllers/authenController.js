angular.module('main').controller('authenController', ['$scope', '$route', '$routeParams', '$location', '$cookies', '$controller', '$filter', 'rootService', 'constants',
    function ($scope, $route, $routeParams, $location, $cookies, $controller, $filter, rootService, constants) {
        $controller('baseController', { $scope: $scope });

    
    }
]);