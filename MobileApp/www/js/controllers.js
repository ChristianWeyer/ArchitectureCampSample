angular.module('starter.controllers', [])

    .controller('DashController', function ($scope) {
    })

    .controller('SessionsController', function ($scope, sessionsService) {
        sessionsService.all().then(function (result) {
            $scope.sessions = result.data;
        });
    })

    .controller('SessionDetailsController', function ($scope, $stateParams, sessionsService) {
        $scope.rating = { value: 0};

        $scope.rateIt = function () {
            sessionsService.rate($scope.rating.value, $scope.session.SessionBaseId, $scope.session.Speaker1Id);
        };

        sessionsService.get($stateParams.sessionId).then(function (result) {
            $scope.session = result.data;
        });
    })

    .controller('AccountController', function ($scope) {
    });
