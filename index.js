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
	res.send('<h1>Hello world. This is the vr websocket server</h1>');
});

io.on('connection', function(socket) {
	console.log('a new connection');

	// socket.broadcast.emit('newuser', {id: socket.id});

	socket.on('mocap', function(msg) {
		console.log("mocap msg : " + msg);
		socket.broadcast.emit('mocap',msg);
	});

	socket.on('hydra', function(msg) {
		socket.broadcast.emit('hydra', msg);
	});

	socket.on('set-username', function(msg) {
		socket.username = msg["username"];
		socket.broadcast.emit('newuser', {username: socket.username});
		console.log("setting the username to "+socket.username);
	});

	socket.on('get-userlist', function(msg) {
		var res = [];
		var i = 0;
		console.log("sending user list:")
		for (var sid in io.sockets.sockets) {
			if (io.sockets.sockets[sid].username) {
				res[i++] = io.sockets.sockets[sid].username;
				console.log(io.sockets.sockets[sid].username);
			}
		}

		socket.emit("userList", {userList: res});
	});
	
	socket.on('gearhead',function(msg) {
		//console.log('I received headset-data: ', msg);
		socket.broadcast.volatile.emit('gearhead', {username: socket.username, data: msg})
	});
	socket.on('leap-motion', function(msg) {
		console.log("got a leap message");
	});
	socket.on('disconnect', function() {
		console.log('a user disconnected')
		socket.broadcast.emit('disconnect-user', {username: socket.username});
	})
});


http.listen(port, host, function() {
	console.log('GearVR server listening on ' + host + ':' + port);
});


