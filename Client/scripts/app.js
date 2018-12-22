(function(){

var app = angular.module("myapp", []);

app.controller("sirenController", ($scope) => {
    $scope.sirensArray = [];

  var siren = {
   description: "D",
   type: 1,
   start: "S Date",
   end: "E Date",
   id: "ID",
   test: "TEST CONTROLLER"
  };



  $scope.siren = siren;


  $scope.submit = function() {
      var issue = $scope.issueName;
    var identity = chance.guid();
    var submittedSiren = {
     description: issue,
      type: 1,
     start: "S Date",
      end: "E Date",
      id: identity,
      test: "TEST CONTROLLER"
    };
    console.log($scope.sirensArray);
    $scope.sirensArray.push(submittedSiren);
  }


});


}());
