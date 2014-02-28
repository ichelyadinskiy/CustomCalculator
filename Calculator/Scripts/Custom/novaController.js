var novaController = {
    run: function () {
        for (var ev in this._events) {
            var eventName = ev.split('.')[0];
            var selector = '.' + ev.split('.')[1];
            var handler = this[this._events[ev]];
            $('body').on(eventName, selector, handler.bind(this));
        }
        this.render();
    }
}