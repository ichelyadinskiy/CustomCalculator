var model = {
    digits: {
        current: 0,
        result: 0,
        memory: 0
    },
    operatorClick: function (e) {
        var operator = e.innerHTML;
        switch (operator) {
            case "+" : {
                $.ajax({
                    type: 'POST',
                    url: "/api/Values/PostSum",
                    data: model.digits,
                    dataType: "json",
                    success: function (answer) {
                        model.digits.current = answer.Current;
                        model.digits.memory = answer.Memory;
                        model.digits.result = answer.Result;
                        observer.trigger("modelChange");
                    }
                });
                break;
            }
            case "MS": {
                $.ajax({
                    type: 'POST',
                    url: "/api/Values/PostMemory",
                    data: model.digits,
                    dataType: "json",
                    success: function (answer) {
                        model.digits.current = answer.Current;
                        model.digits.memory = answer.Memory;
                        model.digits.result = answer.Result;
                        observer.trigger("modelChange");
                    }
                });
                break;
            }
            case "MR": {
                $.ajax({
                    type: 'GET',
                    url: "/api/Values/GetMemory",
                    dataType: "json",
                    success: function (answer) {
                        model.digits.current = answer.Memory;
                        observer.trigger("modelChange");
                    }
                });
                break;
            }
            case "M+": {
                $.ajax({
                    type: 'PUT',
                    url: "/api/Values/PutMemory",
                    data: model.digits,
                    dataType: "json",
                    success: function (answer) {
                        model.digits.memory = answer.Memory;
                        model.digits.current = answer.Current;
                        observer.trigger("modelChange");
                    }
                });
                break;
            }
        }
    },
    digitClick: function (e) {
        var pushed = e.innerHTML;
        model.digits.current = parseInt(model.digits.current + "" + pushed);
        observer.trigger("modelChange");
    },
}