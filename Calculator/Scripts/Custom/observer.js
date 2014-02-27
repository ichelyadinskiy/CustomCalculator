var observer = {
    listners: {},
    addListner: function (object, evt, callback) {
        if (!this.hasOwnProperty(evt)) {
            this.listners[evt] = [];
        }
        this.listners[evt].push(object[callback]);
    },
    removeListener: function (object, evt, callback) {

        if (this.listeners.hasOwnProperty(evt)) {
            var i, length;

            for (i = 0, length = this.listeners[evt].length; i < length; i += 1) {

                if (this.listeners[evt][i] === object[callback]) {

                    this.listeners[evt].splice(i, 1);
                }
            }
        }
    },
    triggerEvent: function (evt, args) {
        if (this.listners.hasOwnProperty(evt)) {
            for (var i = 0; i < this.listners[evt].length; i++) {
                this.listners[evt][i](args);
            }
        }
    }
}