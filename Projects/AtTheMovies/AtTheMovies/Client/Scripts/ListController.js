(function (app) {
    var ListController = function ($scope, movieService) {
        movieService.getAll()
        .success(function (data) {
            $scope.movies = data;
        });
    };
    app.controller("ListController", ListController);

}(angular.module("atTheMovies")));