var model = {
    current: 0,
    result: 0,
    memory: 0,
    operatorClick: function (e) {
        var operator = e.innerHTML;
        if (operator == "+") {
            $$.ajax({
                type: 'POST',
                url: "/api/Values/PostSum",
                data: model,
                dataType: "json",
                success: function (answer) {
                    model.current = answer.Current;
                    model.memory = answer.Memory;
                    model.result = answer.Result;
                    observer.triggerEvent("modelChange");
                }
            });
        }
    },
    digitClick: function (e) {
        $(document).ready(function () {
            var pushed = e.innerHTML;
            console.log(parseInt(model.current + '' + pushed));
            model.current = parseInt(model.current + "" + pushed);
            observer.triggerEvent("modelChange");
        });
    },
}