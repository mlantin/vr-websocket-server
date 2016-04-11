var WebSocketClient = require('websocket').client;
var leapclient = new WebSocketClient();
var wsvrClient = new WebSocketClient();

wsvrClient.connect('ws://toolip.homedns.org:4567/socket.io/?EIO=4&transport=websocket');

wsvrClient.on('connect', function(connection) {
	leapclient.connect('ws://localhost:6437/');
	// leapclient.on('connectFailed', function(error) {
	// 	console.log('Connect Error: ' + error.toString());
	// });
	leapclient.on('connect', function(leapconnection) {
	 	console.log('Connected to Leap Motion Socket');
	// 	leapconnection.on('error', function(error) {
	// 		console.log("Connection Error: " + error.toString());
	// 	});
	 	leapconnection.on('message', function(message) {
	 		console.log("got a message");
	// 		if (message.type === 'utf8') {
	// 			//console.log("Received: '" + message.utf8Data + "'");
				connection.send('leap-motion', message);	
	// 		}
		});
	 });
});



