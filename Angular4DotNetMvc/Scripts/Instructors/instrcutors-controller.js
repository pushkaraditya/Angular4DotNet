registrationModule.controller("InstructorController", function ($scope, bootstrappedInstructors) {
  $scope.instructors = bootstrappedInstructors.instructors;
});