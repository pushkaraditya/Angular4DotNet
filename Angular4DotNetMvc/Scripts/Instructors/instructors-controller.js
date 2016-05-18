registrationModule.controller("InstructorsController", function ($scope, instructorsRepository) {
  $scope.instructors = instructorsRepository.get();
});