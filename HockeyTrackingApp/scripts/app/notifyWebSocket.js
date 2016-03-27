var hockeyTrackingApp = hockeyTrackingApp || {};

hockeyTrackingApp.notifyWebSocket = {
    uri: "ws://" + window.location.hostname + ':' + location.port + "/api/Notify",
    register: function (id) {
        var $el = $("#" + id);
        var webSocket = new WebSocket(this.uri);

        webSocket.onopen = function () {
            $el.append('<p>Connected...</p>');
        }

        webSocket.onerror = function (event) {
            $el.append('<p>Error Occurred!</p>');
        }

        webSocket.onmessage = function (event) {
            $el.append('<p>' + event.data + '</p>');
        }
    }
}