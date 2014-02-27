var controller = {
    run: function () {
        observer.addListner(model, "digitClicked", "digitClick");
        observer.addListner(model, "operatorClicked", "operatorClick");
        
        this.render();
    },
    render: function () {
        var container = $('#calculatorContainer');
        var html = $('#calculatorTemplate').html();
        var calculatorHtml = _.template(html, model);
        container.html(calculatorHtml);
    },
};