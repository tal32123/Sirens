(function () {

    var app = angular.module("myapp", []);

    app.controller("sirenController", ($scope) =>
    {
        $scope.sirensArray = [];



        $scope.severityLevels = [1, 2, 3, 4, 5];

        $scope.submit = function () {

            // var sirenClass = {
            //     description: $scope.issueName,
            //     severity: $scope.severity,
            //     start: $scope.issueDate,
            //     end: $scope.issueEnd,
            //     id: chance.guid(),
            // };
            // $scope.siren = sirenClass;

            var identity = chance.guid();
            var submittedSiren = {
                description: $scope.issueName,
                severity: $scope.severity,
                start: $scope.issueDate,
                end: $scope.issueEnd,
                id: identity,
            };
            console.log("siren array = ");
            console.log( $scope.sirensArray)
            console.log("siren = ")

            console.log("submitted siren = ");
            console.log(submittedSiren)
            //$scope.sirensArray.push(siren);
            $scope.sirensArray.push(submittedSiren);

        }


    });


}());
