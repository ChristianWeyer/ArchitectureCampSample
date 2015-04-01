angular.module('starter', ['ionic', 'ionic.rating', 'starter.controllers', 'starter.services'])

    .run(function ($ionicPlatform) {
        $ionicPlatform.ready(function () {
            if (window.cordova && window.cordova.plugins.Keyboard) {
                cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
            }
            if (window.StatusBar) {
                StatusBar.styleDefault();
            }
        });
    })

    .config(function ($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('tab', {
                url: "/tab",
                abstract: true,
                templateUrl: "templates/tabs.html"
            })
            .state('tab.dash', {
                url: '/dash',
                views: {
                    'tab-dash': {
                        templateUrl: 'templates/tab-dash.html',
                        controller: 'DashController'
                    }
                }
            })
            .state('tab.sessions', {
                url: '/sessions',
                views: {
                    'tab-sessions': {
                        templateUrl: 'templates/tab-sessions.html',
                        controller: 'SessionsController'
                    }
                }
            })
            .state('tab.session-detail', {
                url: '/session/:sessionId',
                views: {
                    'tab-sessions': {
                        templateUrl: 'templates/session-detail.html',
                        controller: 'SessionDetailsController'
                    }
                }
            })
            .state('tab.account', {
                url: '/account',
                views: {
                    'tab-account': {
                        templateUrl: 'templates/tab-account.html',
                        controller: 'AccountController'
                    }
                }
            })

        $urlRouterProvider.otherwise('/tab/dash');
    });

