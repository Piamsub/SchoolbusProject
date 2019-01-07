angular.module('main').controller('rootController', ['$scope', '$route', '$routeParams', '$location', '$cookies', '$controller', '$filter', 'rootService', 'constants',
    function ($scope, $route, $routeParams, $location, $cookies, $controller, $filter, rootService, constants) {
        $controller('baseController', { $scope: $scope });

        $scope.initialize = function () {
            $scope.Token = $cookies.get("TOKEN");

            if ($scope.Token) {
            }
        }

        $scope.authentication = function () {
            rootService.authen($scope.authen).then(function (response) {
                var result = response.data;

                if ($scope.authen.Is_Remember) {
                    $cookies.put(result.Object.Cookies_Name, result.Object.Cookies_Value);
                }
            })
        }
    }
]);