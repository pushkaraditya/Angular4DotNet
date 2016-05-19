(function () {
  angular.module("app", []);

  $(function () {
    $.connection.hub.logging = true;
    $.connection.hub.start();
  });

  $.connection.hub.error(function (err) {
    console.log("An error has occured: " + err);
  });

  angular.module("app").value("chat", $.connection.chat);
})();