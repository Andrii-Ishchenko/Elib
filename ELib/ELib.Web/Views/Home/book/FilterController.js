﻿(function () {
    angular.module("elib")
           .controller("FilterController", FilterController);

    FilterController.$inject = ["$location", "$routeParams"];

    function FilterController($location, $routeParams) {
        vm = this;
        vm.pageCount = ($routeParams.pageCount) ? $routeParams.pageCount : 5;
        if ($routeParams.title)
        {
            vm.title = $routeParams.title;
        }

        if ($routeParams.author) {
            vm.author = $routeParams.author;
        }
        
        if ($routeParams.genre) {
            vm.genre = $routeParams.genre;
        }
        if ($routeParams.subgenre) {
            vm.subgenre = $routeParams.subgenre;
        }
        if ($routeParams.year) {
            vm.year = $routeParams.year;
        }

        vm.filterByTitle = function () {
            preparePath();
            $location.search('title', vm.title);
        }

        vm.filterByAuthor = function () {
            preparePath();
            $location.search('author', vm.author);
        }

        vm.filterByGenre = function () {
            preparePath();
            $location.search('genre', vm.genre);
        }

        vm.filterBySubgenre = function () {
            preparePath();
            $location.search('subgenre', vm.subgenre);
        }

        vm.filterByYear = function () {
            preparePath();
            $location.search('year', vm.year);
        }
        vm.changePageCount = function () {
            if ($location.path() === "/books"){
                $location.search({pageCount : vm.pageCount});
            }
            else {
                $location.search("pageCount", vm.pageCount);
            }

        }

        function preparePath() {
            if ($location.path() !== "/books/search") {
                $location.path("/books/search");
                $location.search({
                    title: undefined,
                    author: undefined,
                    genre: undefined,
                    subgenre: undefined,
                    year: undefined,
                    query: $routeParams.query,
                    pageCount: $routeParams.pageCount,
                    pageNumb: $routeParams.pageNumb
                });
            }
        }
    }
})();