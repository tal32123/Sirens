(function () {

    var app = angular.module("myapp", []);

    app.controller("sirenController", ($scope) => {
        $scope.sirensArray = [];

        var siren = {
            description: $scope.issueName,
            severity: $scope.severity,
            start: $scope.issueDate,
            end: $scope.issueEnd,
            id: chance.guid(),
        };

        $scope.severityLevels = [1, 2, 3, 4, 5];

        $scope.siren = siren;


        $scope.submit = function () {
            var identity = chance.guid();
            var submittedSiren = {
                description: $scope.issueName,
                severity: $scope.severity,
                start: $scope.issueDate,
                end: $scope.issueEnd,
                id: identity,
            };
            console.log($scope.sirensArray);
            $scope.sirensArray.push(submittedSiren);
        }


    });


}());
