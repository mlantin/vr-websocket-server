var app = require('express')();
var http = require('http').Server(app);
var io = require('socket.io')(http);

var minimist = require('minimist')

var args = minimist(process.argv.slice(2), {
  string: 'host',
  alias: { h: 'help', v: 'version', p: 'port' },
  default: { host: '127.0.0.1', port: 4567 },
});

for (x in args) {
	switch (x) {
		case 'host':
		console.log("we have a host and it is " + args['host']);
		break;
	}
}

app.get('/', function(req,res) {
	res.send('<h1>Hello world. This is the gearvr websocket server</h1>');
});

io.on('connection', function(socket) {
	console.log('a new user connected: ');
	io.emit('new user');
	socket.on('gear-head',function(msg) {
		console.log('I received headset-data: ', msg);
		io.emit('gear-head', msg)
	});
	socket.on('leap-motion', function(msg) {
		console.log("got a leap message");
	});
	socket.on('disconnect', function() {
		console.log('a user disconnected')
		io.emit('user disconnected');
	})
});


// http.listen(4567, '192.168.11.34', function() {
// 	console.log('GearVR server listening on port 4567');
// });


