angular.module('main').service("authenService", function ($http, constants) {
    this.initialize = function () {
        return $http.get(constants.BaseUrl + "Secure/Initialize");
    }
});