angular.module('main').service("adminService", function ($http, constants) {
    this.AD_Checker_Reg = function (register) { //<<register ตัวนี้
        return $http.post(constants.BaseUrl + "Admin/AD_Checker_Register", { checker: register });
        //return $http.post(constants.BaseUrl + "Admin/AD_Checker_Register");
        //{ checker_register << อันนี้ชื่อ parameter ใน controller :register อันนี้รับมาจาก ctrl js}
    }
});