###Promices and asinchronic programming

####Callbacks
```JS
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
```JS
promiseMeSomething()
    .then(function(value) {
        // handle success here
    }, function (reason) {
        // handle error here
    });
```
