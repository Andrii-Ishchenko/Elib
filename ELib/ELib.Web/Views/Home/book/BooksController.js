﻿(function () {
    angular.module("elib")
           .controller("BooksController", BooksController);

    BooksController.$inject = ["dataServiceFactory", '$routeParams'];

    function BooksController(dataServiceFactory, $routeParams) {
        var vm = this;
        vm.pageCount = ($routeParams.pageCount) ? $routeParams.pageCount : 5;
        vm.currPage = ($routeParams.pageNumb) ? $routeParams.pageNumb : 1;
        var parameters = {
            pageCount : vm.pageCount,
            pageNumb  : vm.currPage,
            query     : $routeParams.query,
            title     : $routeParams.title,
            authorName: $routeParams.author,
            genre     : $routeParams.genre,
            subgenre  : $routeParams.subgenre,
            year      : $routeParams.year
    }

        var obj = dataServiceFactory.getService('books').get(parameters);
        obj.$promise.then(function (data) {
            vm.books = data.books;
            vm.totalCount = data.totalCount;
            vm.totalPages = Math.ceil(vm.totalCount / vm.pageCount);
            vm.pages = new Array(vm.totalPages);
        })
      

        //activate();

        //function activate() {
        //    return getBooks().then(function () {
        //        console.log('Activated Books View');
        //    });
        //}

        //function getBooks() {
        //    return DataService.getAll('book')
        //    .then(function (data) {
        //        vm.books = data;
        //        console.log(vm.books);
        //        return vm.books;
        //    });
        //}
    }
})();