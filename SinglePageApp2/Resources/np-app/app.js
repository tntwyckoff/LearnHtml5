
/*

Global variables on our global "app" module:
    "library":          js representation of the entire library model

 */

// spa app global object:
var app = angular.module('iNotate', []);

(function () {

    var httpFx = function ($http) {
        this.httpService = $http;
        this.library = {};
        this.libraryLoaded = false;
        this.serviceResponded = false;
        this.loadError = false;
        this.errorMessage = "";

        var con = this;

        con.httpService.get('./Resources/Data/iNotateDataStore.json')
            .success(function (data) {
                con.serviceResponded = true;
                con.library = data[0];
                con.libraryLoaded = null != con.library;
                app.value("library", con.library);
            })
            .error(function () {
                con.loadError = true;
                con.errorMessage = "An unknown error occurred accessing the library contents.";
            });
    }

    app.controller('DataStoreController', ['$http', httpFx]);

})();



        //this.getData = function () {
        //    return {
        //        "Id":1,
        //        "Items":
        //        [
        //            {
        //                "Id":540346,
        //                "Type":'Book',
        //                "Name":'Hitch 22',
        //                "Description":'Christopher Hitchens\' autobiography',
        //                "Notes":[]
        //            },

        //            {
        //                "Id": 249771,
        //                "Type": 'Book',
        //                "Name": 'ASP.NET MVC 4 and the Web API',
        //                "Description": 'Buyilding a REST service from Start to Finish',
        //                "Notes": []
        //            }
        //        ]
        //    }
        //};