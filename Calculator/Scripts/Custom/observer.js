var observer = {
    listeners: {},
    on: function (object, eventName, callback) {
        if (!this.listeners.hasOwnProperty(eventName)) {
            this.listeners[eventName] = object[callback];
        }
    },
    trigger: function (eventName, arg) {
        for (var ev in this.listeners) {
            if (ev == eventName) {
                this.listeners[ev](arg);
            }
        }
    }
}