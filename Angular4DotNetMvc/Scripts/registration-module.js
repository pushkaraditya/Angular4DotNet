var registrationModule = angular.module("registrationModule", ['ngRoute'])
      .config(function ($routeProvider, $locationProvider) {
       $routeProvider.when('/Registration/Courses', {
           templateUrl: 'templates/courses.html',
           controller: 'CoursesController'
         })
         .when('/Registration/Instructors', {
           templateUrl: 'templates/instructors.html',
           controller: 'InstructorsController'
         })
         .when('/Registration/CreateAccount', {
          templateUrl: 'templates/create-account.html',
          controller: 'AccountController'
        });
       $locationProvider.html5Mode(true);
     });