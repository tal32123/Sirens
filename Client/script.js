// (function(){
//   var app = angular.module("sirens", []);
//
// var SirenController =
// function($scope) {
//   var siren = {
//   description: "",
//   type: 0,
//   start: "",
//   end: "",
//   id: "",
//   test: "TEST CONTROLLER"
// };
//
//     $scope.siren;
//     $scope.blah = "blahhhh"
// }
//
// app.controller("SirenController",  [$scope, SirenController]);
// }());

// var app = angular.module('sirens', []);
// app.controller('SirenController', function($scope) {
//     $scope.blah = "John";
//     $scope.greeting = "Doe";
//     $scope.test = "Doe";
// });

var app = angular.module('myapp', []);

app.controller('sirenController', ['$scope', function($scope) {
    $scope.issueName = 'very';
}]);
