var controller = {
    run: function () {
        observer.on(model, "digitClicked", "digitClick");
        observer.on(model, "operatorClicked", "operatorClick");
        
        this.render();
    },
    render: function () {
        var container = $('#calculatorContainer');
        var html = $('#calculatorTemplate').html();
        var calculatorHtml = _.template(html, model.digits);
        container.html(calculatorHtml);
    },
};