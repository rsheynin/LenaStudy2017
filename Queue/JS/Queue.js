var queueApp = angular.module('queueApp', []);

queueApp.controller('QueueCtrl',
[
    '$scope', '$http', function ($scope, $http)
    {

        $scope.createClient = function () {
            $http({
                method: 'GET',
                url: 'api/Client/Add/'+$scope.NewClientName
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
                    if (response) {
                        $scope.getAllNotServed();
                    } else {
                        alert("An error occured");
                    }
                },
                function errorCallback(response) {
                    // called asynchronously if an error occurs
                    // or server returns response with an error status.

                    console.log(response.data.message);
                    alert("An error occured");
                });
        }
       
        $scope.getCurrentClientInServe = function () {
            $http({
                method: 'GET',
                url: 'api/Client/InServe'
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
                $scope.currentClient = response.data;

            },
                function errorCallback(response) {
                    // called asynchronously if an error occurs
                    // or server returns response with an error status.

                    console.log(response.data.message);
                    alert("An error occured");
                });
        }

        $scope.serveNextClient = function() {
            $http({
                method: 'GET',
                url: 'api/Client/NextClient'
            }).then(function successCallback(response) {
                    // this callback will be called asynchronously
                    // when the response is available
                    if (response.data) {
                        $scope.reloadPageData();
                    } else {
                        alert("An error occured");
                    }

                },
                function errorCallback(response) {
                    // called asynchronously if an error occurs
                    // or server returns response with an error status.

                    console.log(response.data.message);
                    alert("An error occured");
                });
        };

        $scope.reloadPageData = function() {
            $scope.getAllNotServed();
            $scope.getCurrentClientInServe();
        };

        $scope.getAllNotServed = function () {
            $http({
                method: 'GET',
                url: 'api/Client/NotServed'
            }).then(function successCallback(response) {
                // this callback will be called asynchronously
                // when the response is available
                $scope.clientList = response.data;

            },
                function errorCallback(response) {
                    // called asynchronously if an error occurs
                    // or server returns response with an error status.

                    console.log(response.data.message);
                    alert("An error occured");
                });
        }

        $scope.reloadPageData();
    }
]);