###Promices and asinchronic programming

####Callbacks
```js
(function(){
    function pause(delay) {
        setTimeout(function() {
            console.log('paused for ' + delay + 'ms');
        }, delay);
    }
    console.log('start');
    pause(2000);
    console.log('middle');
    pause(2000);
    console.log('end');
    // does not work because setTimeout is async!
}());
    // need to use Callbacks
(function(){
    console.log('start');
    var delay = 2000;
    setTimeout(() => {
        console.log('paused for ' + delay + 'ms');
        console.log('middle1');
        setTimeout(() => {
            console.log('paused for ' + delay + 'ms');
            console.log('middle2');
            setTimeout(() => {
                console.log('paused for ' + delay + 'ms');
                console.log('middle3');
            }, delay);
        }, delay);
    }, delay);
}());
```

####Promices
```js
promiseMeSomething()
    .then(function(value) {
        // handle success here
    }, function (reason) {
        // handle error here
    });
```
- automatic resolve (reject)
```js
var usersPromise = get('users.all');
var postsPromise = get('posts.everyone');

// wait until both are settled
Promise.all([usersPromise, postsPromise])
    .then((results) => {
        //results are array of responses
        myController.users = results[0];
        myController.posts = results[1];
    })
    .catch(() => {
        delete myController.users;
        delete myController.posts;
    })
```
- primise.race - vzima nai-byrziq promise

####function generators
```js
function *foo() { 
// OR function* foo() {}
    // yield something
    var x = 1 + (yield "foo");
    console.log(x);
 }

 var gen = foo();
 gen.next(); // 
```
- fibonacci sequence
```js
function* fibonacci() {
    var fn1 = 1, fn2 = 1, current, reset;
    while (true) {
        current = fn1;
        fn1 = fn2;
        fn2 = fn2 + current;
        reset = yield current;
        if (reset) {
            fn1 = 1;
            fn2 = 1;
        }
    }
}

var sequence = fibonacci();
sequence.next(true).value;
```

###HTTP and AJAX

- izvikvane na web prez konzolata
```
curl http://www.website.com
```
*GET*
```html
GET /hello.htm HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
Host: www.tutorialspoint.com
Accept-Language: en-us
Accept-Encoding: gzip, deflate
Connection: Keep-Alive
``` 
*PUT*
```html
POST /cgi-bin/process.cgi HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
Host: www.tutorialspoint.com
Content-Type: application/x-www-form-urlencoded
Content-Length: length
Accept-Language: en-us
Accept-Encoding: gzip, deflate
Connection: Keep-Alive

licenseID=string&content=string&/paramsXML=string
```
*Conditional HTTP GET headers*
```html
If-Modified-Since: date
```
*Response messages*
```html
HTTP/1.1 200 OK
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
Last-Modified: Wed, 22 Jul 2009 19:15:56 GMT
Content-Length: 88
Content-Type: text/html
Connection: Closed

<html>
<body>
<h1>Hello, World!</h1>
</body>
</html>
```
Status codes:

- 200, 300 - OK
- 400 - not found
- 500 - server error
- [Other](https://www.w3.org/Protocols/rfc2616/rfc2616-sec6.html)