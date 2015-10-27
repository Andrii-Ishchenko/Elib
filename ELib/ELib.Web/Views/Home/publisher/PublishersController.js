﻿(function () {
    angular.module("elib")
           .controller("PublishersController", PublishersController);

    PublishersController.$inject = ["dataServiceFactory", '$routeParams', '$location'];

    function PublishersController(dataServiceFactory, $routeParams, $location) {
        var vm = this;

        vm.pageCount = ($routeParams.pageCount) ? $routeParams.pageCount : "5";
        vm.currPage = ($routeParams.pageNumb) ? $routeParams.pageNumb : 1;

        vm.ordering = {
            orderBy: 'Name',
            orderDirection: ($routeParams.orderDirection) ? $routeParams.orderDirection : 'DESC',
            defaultOrder: "Name",
            defaultDirection: "DESC",
            orderParameters: ["Name"]
        }
        
        var obj = dataServiceFactory.getService('publishers').get({
            pageCount: vm.pageCount, pageNumb: vm.currPage, query: $routeParams.query,
            orderBy: vm.ordering.orderBy, orderDirection: vm.ordering.orderDirection
        })
                                    .$promise.then(function (data) {
            vm.publishers = data.publishers;
            vm.totalCount = data.totalCount;
            vm.totalPages = Math.ceil(vm.totalCount / vm.pageCount);
            vm.pages = new Array(vm.totalPages);
        });

        vm.pageChanged = pageChanged;

        vm.OrderingChanged = function () {
            var obj = dataServiceFactory.getService('publishers').get({
                pageCount: vm.pageCount, pageNumb: vm.currPage, query: $routeParams.query,
                orderBy: vm.ordering.orderBy, orderDirection: vm.ordering.orderDirection
            }).$promise.then(function (data) {
                vm.publishers = data.publishers;
                vm.totalCount = data.totalCount;
                vm.totalPages = Math.ceil(vm.totalCount / vm.pageCount);
                vm.pages = new Array(vm.totalPages);
            });
        }



        function pageChanged() {
            $location.search("pageNumb", vm.currPage);
            $location.search("pageCount", vm.pageCount);
        }
    }
})();