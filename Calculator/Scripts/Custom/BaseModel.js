﻿function BaseModel() {
    var self = this;
    self.current = ko.observable("0");
    self.memory = ko.observable("0");
    self.result = ko.observable("0");

    self.numbers = ko.observableArray([
        {
            value: "1"
        },
        {
            value: "2"
        },
        {
            value: "3"
        },
        {
            value: "4"
        },
        {
            value: "5"
        },
        {
            value: "6"
        },
        {
            value: "7"
        },
        {
            value: "8"
        },
        {
            value: "9"
        },
        {
            value: "0"
        }
    ]);
    self.operators = ko.observableArray([
        {
            operator: "MS"
        },
        {
            operator: "MR"
        },
        {
            operator: "M+"
        },
        {
            operator: "C"
        },
        {
            operator: "CE"
        },
        {
            operator: "+"
        },
        {
            operator: "-"
        },
        {
            operator: "*"
        },
        {
            operator: "/"
        }
    ])
}