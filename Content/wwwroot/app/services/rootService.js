angular.module('main').service("rootService", function ($http, constants) {
    this.initialize = function (test) {
        return $http.get(constants.BaseUrl + "Secure/Initialize?ID=" + encodeURIComponent(test));
    }
});