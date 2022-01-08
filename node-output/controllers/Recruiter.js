'use strict';

var utils = require('../utils/writer.js');
var Recruiter = require('../service/RecruiterService');

module.exports.createRecruiter = function createRecruiter (req, res, next) {
  Recruiter.createRecruiter()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.createRecruitersWithArrayInput = function createRecruitersWithArrayInput (req, res, next) {
  Recruiter.createRecruitersWithArrayInput()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.createRecruitersWithListInput = function createRecruitersWithListInput (req, res, next) {
  Recruiter.createRecruitersWithListInput()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.getRecruiterByName = function getRecruiterByName (req, res, next, ) {
  Recruiter.getRecruiterByName()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.loginRecruiter = function loginRecruiter (req, res, next, , ) {
  Recruiter.loginRecruiter(, )
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.logoutRecruiter = function logoutRecruiter (req, res, next) {
  Recruiter.logoutRecruiter()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
