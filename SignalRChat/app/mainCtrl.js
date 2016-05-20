angular.module("app").controller("mainCtrl", function ($scope, chat) {
  $scope.messages = [];
  $scope.inRoom = false;
  $scope.nameSet = false;
  $scope.step = 1;

  $scope.joinRoom = function () {
    chat.server.joinRoom($scope.roomName)
      .then(function () {
        $scope.inRoom = true;
        if ($scope.nameSet)
          $scope.step = 3;
        else
          $scope.step = 2;
        $scope.$broadcast('step');
        $scope.$apply();
      });
  };

  $scope.leaveRoom = function () {
    chat.server.leaveRoom($scope.roomName)
      .then(function () {
        $scope.inRoom = false;
        $scope.step = 1;
        $scope.$broadcast('step');
        $scope.$apply();
      });
  };

  $scope.setName = function () {
    $scope.nameSet = true;
    $scope.$broadcast('step');
    $scope.step = 3;
  };


  $scope.sendMessage = function () {
    chat.server.sendMessage({ message: $scope.newMessage, roomName: $scope.roomName, name: $scope.name });
    $scope.newMessage = "";
  };

  chat.client.newMessage = function onNewMessage(message) {
    displayMessage(message);
    $scope.$apply();
    console.log(message);
  };

  displayMessage = function (message) {
    $scope.messages.push({ message: message });
  };
});