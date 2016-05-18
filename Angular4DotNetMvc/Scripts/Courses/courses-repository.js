registrationModule.factory("courseRepository", function ($http, $q) {
  var getCourses = function () {
    var deferred = $q.defer();
    $http.get("/Courses").success(deferred.resolve).error(deferred.reject);
    return deferred.promise;

    //return $http.get("/Courses")
    //            .then(function (response) {
    //              return response.data;
    //            });
  };

  return {
    get: getCourses
  };
});