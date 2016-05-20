(function () {
  angular.module("app", []);

  $(function () {
    $.connection.hub.logging = true;
    $.connection.hub.start();
  });

  $.connection.hub.error(function (err) {
    console.log("An error has occured: " + err);
  });

  angular.module("app")
    .value("chat", $.connection.chat)
    .value("toastr", toastr)
  ;


  toastr.options = {
    "closeButton": false,
    "debug": false,
    "newestOnTop": false,
    "progressBar": false,
    "positionClass": "toast-top-right",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "5000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
  };
})();