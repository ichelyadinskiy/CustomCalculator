var calcController = {
    _events: {
        "click.digit": "onDigitClick",
        "click.operator": "onOperatorClick"
    },
    run: function () {
        for (var ev in this._events) {
            var eventName = ev.split('.')[0];
            var selector = '.' + ev.split('.')[1];
            var handler = this[this._events[ev]];
            $('body').on(eventName, selector, handler.bind(this));
        }
        this.render();
    },
    onDigitClick: function (e) {
        var pushed = e.target.innerHTML;
        model.current = parseInt(model.current + '' + pushed);
        this.render();
    },
    onOperatorClick: function (e) {
        var operator = e.target.innerHTML;
        if (operator == "+") {
            model.memory = parseInt(model.memory) + parseInt(model.current);
        }
        model.current = 0;
        this.render();
    },
    render: function () {
        var container = $('#calculatorContainer');
        var html = $('#calculatorTemplate').html();
        var calculatorHtml = _.template(html, model);
        container.html(calculatorHtml);
    },
};