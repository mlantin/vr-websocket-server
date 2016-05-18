var server = require('http').createServer()
  , url = require('url')
  , WebSocketServer = require('ws').Server
  , wss = new WebSocketServer({ server: server })
  , express = require('express')
  , app = express();

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

app.use(function (req, res) {
  res.send({ msg: "hello" });
});

function ack(error) {
   if (error)
   	console.log("error: " + error);
}

wss.broadcast = function broadcast(data, flags) {
  wss.clients.forEach(function each(client) {
  	if (client.readyState === 1)
    	client.send(data, flags, ack);
  });
};

wss.broadcastUsers = function broadcastUsers(data, flags) {
	wss.clients.forEach(function each(client) {
		if (client.isUser && client.readyState === 1) {
			client.send(data, flags, ack);
		}
	});
}

wss.broadcastOtherUsers = function broadcastOtherUsers(ws, data, flags) {
	wss.clients.forEach(function each(client) {
		if (client.isUser && client != ws && client.readyState === 1)
			client.send(data, flags, ack);
	});
}

wss.on('connection', function connection(ws) {
	console.log('a new connection');
	//console.log(ws);
	var location = url.parse(ws.upgradeReq.url, true);
  // you might use location.query.access_token to authenticate or share sessions
  // or ws.upgradeReq.headers.cookie (see http://stackoverflow.com/a/16395220/151312)

  	ws.on('message', function incoming(data, flags) {
  		if (flags.binary) {
	    	//console.log('received a protobuf msg');
	    	if (ws.isUser) {
	    		wss.broadcastOtherUsers(ws, data, flags)
	    	}
	    	else
		    	wss.broadcastUsers(data, flags)
  		}
	    else {
	    	//console.log('received a txt message: ' + data);
	    	var jmsg = JSON.parse(data);
	    	if (jmsg.hasOwnProperty('username')) {
	    		console.log("new user: " + jmsg.username);
	    		ws.isUser = true;
	    		ws.username = jmsg.username;
	    		//wss.broadcastOtherUsers(ws, data, flags);
	    	}
	    }

 	});

	// socket.broadcast.emit('newuser', {id: socket.id});

	// socket.on('mocap', function(msg) {
	// 	console.log("mocap msg : " + msg);
	// 	socket.broadcast.emit('mocap',msg);
	// });

	// socket.on('hydra', function(msg) {
	// 	socket.broadcast.emit('hydra', msg);
	// });

	// socket.on('set-username', function(msg) {
	// 	socket.username = msg["username"];
	// 	socket.broadcast.emit('newuser', {username: socket.username});
	// 	console.log("setting the username to "+socket.username);
	// });

	// socket.on('get-userlist', function(msg) {
	// 	var res = [];
	// 	var i = 0;
	// 	console.log("sending user list:")
	// 	for (var sid in io.sockets.sockets) {
	// 		if (io.sockets.sockets[sid].username) {
	// 			res[i++] = io.sockets.sockets[sid].username;
	// 			console.log(io.sockets.sockets[sid].username);
	// 		}
	// 	}

	// 	socket.emit("userList", {userList: res});
	// });
	
	// socket.on('gearhead',function(msg) {
	// 	//console.log('I received headset-data: ', msg);
	// 	socket.broadcast.volatile.emit('gearhead', {username: socket.username, data: msg})
	// });
	// socket.on('leap-motion', function(msg) {
	// 	console.log("got a leap message");
	// });
	ws.on('close', function() {
		console.log('a user disconnected')
//		socket.broadcast.emit('disconnect-user', {username: socket.username});
	});
});


server.on('request', app);
server.listen(port, host, function() {
	console.log('GearVR server listening on ' + host + ':' + port);
});


