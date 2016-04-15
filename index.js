var app = require('express')();
var http = require('http').Server(app);
var io = require('socket.io')(http);

var minimist = require('minimist')

var host = '127.0.0.1';
var port = 4567;

var args = minimist(process.argv.slice(2), {
  string: 'host',
  alias: { h: 'help', v: 'version', p: 'port' },
  default: { host: '127.0.0.1', port: 4567 },
});

for (x in args) {
	switch (x) {
		case 'host':
		host = args['host'];
		break;
		case 'port':
		port = args['port'];
		break;
		case 'version':
		console.log("vr-websocket version 1.0");
		break;
		case 'help':
		console.log("node index.js [--host <ip>] [-p | --port <port>] [-v] [-h]");
		console.log("The default host is 127.0.0.1. The default port is 4567.");
		break;
	}
}

app.get('/', function(req,res) {
	res.send('<h1>Hello world. This is the gearvr websocket server</h1>');
});

io.on('connection', function(socket) {
	console.log('a new user connected: ');
	socket.broadcast.emit('new user', {id: socket.id});
	socket.on('gear-head',function(msg) {
		console.log('I received headset-data: ', msg);
		socket.broadcast.emit('gear-head', {id: socket.id, data: msg})
	});
	socket.on('leap-motion', function(msg) {
		console.log("got a leap message");
	});
	socket.on('disconnect', function() {
		console.log('a user disconnected')
		socket.broadcast.emit('user disconnected', {id: socket.id});
	})
});


http.listen(port, host, function() {
	console.log('GearVR server listening on ' + host + ':' + port);
});


