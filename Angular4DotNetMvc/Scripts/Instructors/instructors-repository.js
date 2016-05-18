registrationModule.factory("instructorsRepository", function ($http, $q) {
  var get = function () {
    var deferred = $q.defer();
    $http.get("/api/Instructors").success(deferred.resolve).error(deferred.reject);
    return deferred.promise;
  };

  return {
    get: get
  };
});