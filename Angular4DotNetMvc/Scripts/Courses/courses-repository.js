﻿registrationModule.factory("courseRepository", function ($resource) {
  return {
    get: function () {
      return $resource("/api/Courses").query();
    }
  };
});