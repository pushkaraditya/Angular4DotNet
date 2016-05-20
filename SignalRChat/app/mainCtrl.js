angular.module("app").controller("mainCtrl", function ($scope, chat, toastr) {
  $scope.messages = [];
  $scope.inRoom = false;
  $scope.nameSet = false;

  $scope.joinRoom = function () {
    chat.server.joinRoom($scope.roomName, $scope.name)
      .then(function () {
        $scope.inRoom = true;
        $scope.$apply();
      });
  };

  $scope.leaveRoom = function () {
    chat.server.leaveRoom($scope.roomName, $scope.name)
      .then(function () {
        $scope.inRoom = false;
        $scope.$apply();
      });
  };

  $scope.setName = function () {
    $scope.nameSet = true;
  };


  $scope.sendMessage = function () {
    chat.server.sendMessage({ message: $scope.newMessage, roomName: $scope.roomName, name: $scope.name })
      .then(function () {
        var message = "Me: " + $scope.newMessage;
        $scope.newMessage = "";
        onNewMessage(message);
      });
  };

  chat.client.newMessage = onNewMessage;

  function onNewMessage(message) {
    $scope.messages.push({ message: message });
    $scope.$apply();
    console.log(message);
  };

  chat.client.newNotification = function onNotification(msg) {
    toastr.success(msg);
  };
});