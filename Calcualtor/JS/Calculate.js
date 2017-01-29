var calculatorApp = angular.module('calculatorApp', []);


calculatorApp.controller('calculateController',['$scope', '$http', function ($scope, $http) {


    //$scope.operators = ["*", "+", "-", "/"];
    $scope.getOperators = function() {
        $http({
            method: 'GET',
            url: 'api/Calculate/Operators'
        }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
            $scope.operators = response.data;
            
            },
            function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.

                console.log(response.data.message);
            });
    }
    $scope.getOperators();

    //$scope.resultTypes = [];
    $scope.getResultTypes = function () {
        $http({
            method: 'GET',
            url: 'api/Calculate/ResultTypes'
        }).then(function successCallback(response) {
            // this callback will be called asynchronously
            // when the response is available
            $scope.resultTypes = response.data;

        },
            function errorCallback(response) {
                // called asynchronously if an error occurs
                // or server returns response with an error status.

                console.log(response.data.message);
            });
    }
    $scope.getResultTypes();

    $scope.calculateResult = function () {

        console.log($scope.Action);
        $http({
            method: 'POST',
            url: 'api/Calculate/Calculate',
            data: $scope.Action
        }).then(function successCallback(response) {
            console.log(response);
            $scope.result = response.data;

            },
            function errorCallback(response) {
                console.log(response);
            });
    }
}])
    .directive('result', function () {
        return {
            restrict: 'E',
          
            link: function (scope) {
                scope.$watch('result',function(newValue, oldValue) {
                    if (!newValue)
                        return;
                    var templateUrl = '/JS/result_' + newValue.Type + '.html';
                    scope.resultTemplateUrl = templateUrl;
                });

               
            },
            template: "<div ng-include='resultTemplateUrl'></div>"
        };
    }); 
    
