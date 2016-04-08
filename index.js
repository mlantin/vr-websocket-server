var app = require('express')();
var http = require('http').Server(app);
var io = require('socket.io')(http);

var WebSocketClient = require('websocket').client;

var client = new WebSocketClient();

client.on('connectFailed', function(error) {
	console.log('Connect Error: ' + error.toString());
});

client.on('connect', function(connection) {
	console.log('Connected to Leap Motion Socket');
	connection.on('error', function(error) {
		console.log("Connection Error: " + error.toString());
	});
	connection.on('message', function(message) {
		if (message.type === 'utf8') {
			//console.log("Received: '" + message.utf8Data + "'");
			io.emit('leap-motion', message);
		}
	});
});

app.get('/', function(req,res) {
	res.send('<h1>Hello world. This is the gearvr websocket server</h1>');
});

io.on('connection', function(socket) {
	console.log('a new user connected');
	io.emit('a new user connected');
	socket.on('gear-head',function(msg) {
		console.log('I received headset-data: ', msg);
	});
	socket.on('disconnect', function() {
		console.log('a user disconnected')
		io.emit('a user disconnected');
	})
});


http.listen(4567, '192.168.11.34', function() {
	console.log('GearVR server listening on port 4567');
});

client.connect('ws://localhost:6437/');
