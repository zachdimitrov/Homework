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
```
