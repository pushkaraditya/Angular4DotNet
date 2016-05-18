registrationModule.controller("InstructorsController", function ($scope, instructorsRepository) {
  instructorsRepository.get().then(function (instructors) {
    $scope.instructors = instructors;
  });
});