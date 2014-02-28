var controller = _.extend(novaController, {
    _events: {
        "click.digit": "onDigitClick",
        "click.operator": "onOperatorClick"
    },
    init: function() {
        this.render();
        observer.on(controller, "modelChange", "render");
    },
    render: function () {
        var container = $('#calculatorContainer');
        var html = $('#calculatorTemplate').html();
        var calculatorHtml = _.template(html, model.digits);
        container.html(calculatorHtml);
    },
    onDigitClick: function (e) {
        var pushed = e.target.innerHTML;
        model.digitClick(pushed);
    },
    onOperatorClick: function (e) {
        var operator = e.target.innerHTML;
        switch (operator) {
            case "+": model.plusClick();
                break;
            case "-": model.minusClick();
                break;
            case "*": model.multiplicationClick();
                break;
            case "/": model.divisionClick();
                break;
            case "MS": model.saveMemoryClick();
                break;
            case "MR": model.getMemoryClick();
                break;
            case "M+": model.increaseMemoryClick();
                break;
            case "C": model.clearClick();
                break;
            case "CE": model.clearAllClick();
                break;
        }
    }
});