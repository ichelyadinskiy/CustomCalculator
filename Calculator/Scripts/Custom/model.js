var model = {
    digits: {
        current: 0,
        result: 0,
        memory: 0,
        sign: ''
    },
    digitClick: function(e){
        model.digits.current = parseInt(model.digits.current + "" + e);
        observer.trigger("modelChange");
    },
    processEvent: function(type, url, data){
        $.ajax({
            type: type,
            url: url,
            data: data,
            dataType: "json",
            success: function (answer) {
                model.digits.current = answer.Current;
                model.digits.memory = answer.Memory;
                model.digits.result = answer.Result;
                observer.trigger("modelChange");
            }
        });
    },
    plusClick: function () {
        this.processEvent('POST', '/api/Values/PostSum', model.digits);
    },
    minusClick: function() {
        this.processEvent('POST', '/api/Values/PostMinus', model.digits);
    },
    multiplicationClick: function() {
        this.processEvent('POST', '/api/Values/PostMultiplication', model.digits)
    },
    divisionClick: function() {
        this.processEvent('POST', '/api/Values/PostDivision', model.digits);
    },
    saveMemoryClick: function() {
        this.processEvent('POST', '/api/Values/PostMemory', model.digits);
    },
    getMemoryClick: function() {
        this.processEvent('GET', '/api/Values/Getmemory');
    },
    increaseMemoryClick: function() {
        this.processEvent('PUT', '/api/Values/PutMemory', model.digits);
    },
    clearClick: function() {
        this.processEvent('GET', '/api/Values/GetClear');
    },
    clearAllClick: function () {
        this.processEvent('GET', '/api/Values/GetClearAll');
    }
}