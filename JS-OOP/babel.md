# [babel](https://babeljs.io/)
## babel - installation

##### local installation

```npm init``` - follow instructions on console to create **packages.json** file  
```npm install --save-dev babel-cli``` - this isntalls the **babel** runtime  
```npm install --save-dev babel-packages-es2015``` - install the needed package  

## babel - usage

add **"scripts"** to *packages.json* file
```
"scripts": {
    "build": "node_modules\\.bin\\babel src --source-maps -d compiled"
  },
```
here **src** is the folder we wirk in and **compiled** is the destination folder  
```--watch``` or ```-w``` is used for continious compiling while writing the file  
```--out-dir``` or ```-d``` is used for destination folder (add folder name after it)  
```--out-file``` or ```-o``` is used to output in a single file  
```--source-maps``` or ```-s``` cheates the source info in the compiled file  
```--source-maps inline```  - can also be used  
```--ignore [files]``` ignores the specified files 
```--help``` find help docs

create **.babelrs** file to config which packages to be used
```
{
  "presets": ["es2015"],
  "sourceMaps": true
}
```
run the configured babe on the console  
```npm run build```

