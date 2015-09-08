﻿(function () {
    angular.module("elib")
           .controller("UploadBookController", UploadBookController);

    UploadBookController.$inject = ["authServiceFactory", "dataServiceFactory", "$location"];

    function UploadBookController(authServiceFactory, dataServiceFactory,  $location) {
        var vm = this;

        authServiceFactory.fillAuthData();
        
        if (!authServiceFactory.authentication.isAuth) {
            $location.path('/login');
        }

        var languages = dataServiceFactory.getService('languages').query();

        vm.originalLanguages = languages;
        vm.publishLanguages = languages;

    //    vm.publishers = dataServiceFactory.getService('publishers').query();

         vm.subgenres = dataServiceFactory.getService('subgenres').query();
        
    }
})();