angular.module('main').controller('adminController', ['$scope', '$route', '$routeParams', '$location', '$cookies', '$controller', '$filter', 'adminService', 'constants',
    function ($scope, $route, $routeParams, $location, $cookies, $controller, $filter, adminService, constants) {
        $controller('baseController', { $scope: $scope });

        $scope.GetInput = function () {
            //$scope.register ตัวนี้ส่งไปให้ serv js ไง
            adminService.AD_Checker_Reg($scope.register).then(function (response) {
                $scope.chekerinfo = response;
            })
        }


    }
]);