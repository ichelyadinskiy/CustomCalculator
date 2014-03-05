function ViewModel(options) {
    var self = this;
    this.model = new BaseModel();

    self.addNumber = function (data) {
        var currentValue = self.model.current();
        var newValue = parseInt(currentValue + "" + data.value)
        self.model.current(newValue);
    };
    self.runCommand = function (data) {
        switch (data.operator) {
            case "+": self.plus();
                break;
            case "-": self.minus();
                break;
            case "*": self.multiplication();
                break;
            case "/": self.division();
                break;
            case "MS": self.memorySave();
                break;
            case "MR": self.memoryTake();
                break;
            case "M+": self.increaseMemory();
                break;
            case "C": self.clear();
                break;
            case "CE": self.clearAll();
                break;
        }
    };
    self.ajaxRequest = function (type, url) {
        var data = {
            current: self.model.current(),
            result: self.model.result(),
            memory: self.model.memory()
        }
        $.ajax({
            type: type,
            url: url,
            data: data,
            dataType: 'json',
            success: function (returnedData) {
                self.model.current(returnedData.Current);
                self.model.result(returnedData.Result);
                self.model.memory(returnedData.Memory);
            }
        });
    }
    self.plus = function () {
        self.ajaxRequest('POST', "/api/Values/PostSum");
    };
    self.minus = function () {
        self.ajaxRequest('POST', '/api/Values/PostMinus');
    },
    self.multiplication = function() {
        self.ajaxRequest('POST', '/api/Values/PostMultiplication')
    },
    self.division = function() {
        self.ajaxRequest('POST', '/api/Values/PostDivision');
    },
    self.memorySave = function() {
        self.ajaxRequest('POST', '/api/Values/PostMemory');
    },
    self.memoryTake = function() {
        self.ajaxRequest('GET', '/api/Values/Getmemory');
    },
    self.increaseMemory = function() {
        self.ajaxRequest('PUT', '/api/Values/PutMemory');
    },
    self.clear = function() {
        self.ajaxRequest('GET', '/api/Values/GetClear');
    },
    self.clearAll = function () {
        self.ajaxRequest('GET', '/api/Values/GetClearAll');
    }
}

$(document).ready(function () {
    ko.applyBindings(new ViewModel());
})