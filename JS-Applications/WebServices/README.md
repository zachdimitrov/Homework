## HTTP Requests

### Requests Examples

- **GET** has only headers, no body

```js
GET /academy/winter-2009-2010.aspx HTTP/1.1
Host: www.telerik.com
Accept: * / *
Accept-Language: bg
Accept-Encoding: gzip, deflate
User-Agent: Mozilla/4.0(compatible;MSIE 6.0; Windows NT 5.0)
Connection: Keep-Alive
Cashe-Control: no-cashe 
```
-**PUT** the same but with body after empty line

```js
POST /webmai.login.html HTTP/1.1
Host: www.abv.bg
Accept: */ *
Accept-Language: bg
Accept-Encoding: gzip, deflate
User-Agent: Mozilla/4.0(compatible;MSIE 6.0; Windows NT 5.0)
Connection: Keep-Alive
Content-Length: 59 

LOGIN_USER=Pesho // not correct way to send user data
DOMAIN_NAME=abv.bg
LOGIN_PASS=top*secret!
``` 

-**Conditional** - only if resource has changed

```js
GET /academy/join.aspx HTTP/1.1
Host: www.telerik.com
User-Agent: Gecko/20100115 Firefox/3.6
If-Modified-Since: Tue, 9 Mar 2010 11:12:23 GMT
```

### Response Messages

```js
HTTP/<version> <status code> <status text>
<headers>
<CRLF>
<responce_body>
```
```js
HTTP/1.1 200 OK
Date: Fri, 17 Jul 2010 16:09:18 GMT+2
Server: Apache/2.2.14 (Linux)
Connection: close
Content-Type: hext/html
<CRLF>
<html><head><title>404 Not Found!<title/><head/></html>;
```