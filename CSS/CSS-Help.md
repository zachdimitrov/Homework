# Presentation

### Text Related Properties
All properties have **initial** and **inherit** values.

##### Font Related
 - ```color``` - #123ABC, (123, 112, 32, 55)
 - ```font-size``` - 10px, set to **body** and then use 1.7em, or 2.3rem
  - **em** - multiply to previous element size
  - **rem** - multiply to initial size
 - ```font-family``` - Verdana, Arial, Sans-serif
 - ```font-variant``` - normal, small-caps
 - ```font-weight``` - normal, bold, bolder, 100 ... 900
 - ```font-style``` - normal, italic, oblique
 
##### Text Related
 - ```text-decoration``` - none, underline, strike-through, overline, (blink)
 - ```text-align``` - left, right, center, justify
 - ```text-shadow``` -  2px 2px 5px #ff0000; (x, y, blur, color)
 - ```text-overflow```
  - **clip** - reje texta
  - **ellipsis** - slaga mnogotochie
 - ```text-transform``` - uppercase, lowercase, capitalize;
 - ```line-height``` - 10px, 150%, 1.5em (related to the size of text)
 - ```white-space``` - normal, nowrap, pre, pre-line, pre-wrap
 - ```word-wrap``` - normal, break-word
 - ```word-spacing``` - 10px
 
##### Short Way to set tet rules (not used)
```CSS
#selector { font: italic normal bold 12px/16px verdana; }
```
is equal to
```css
#selector {
   font-style: italic;
   font-variant: normal;
   font-weight: bold;
   font-size: 12px;
   line-height: 16px;
   font-family: verdana;
}
```

##### Declare font face
```css
@font-face {
   font-family: 'Roboto', sans-serif;
   src: url("https://fonts.googleapis.com/css?family=Roboto");
}
```

### Borders

 - ```border-width``` - 10px
 - ```border-color``` - #123ACF
 - ```border-style``` - none, hidden, dotted, dashed, solid, double, groove, ridge, inset, outset
 - ```border-top-[style, color, width]``` - set to each side
 - ```border``` - complex selector { size style color }, none, 0 
 - ```border-radius``` - 10px, 20% (50% is max) or set to every edge { 10px 0 20px 5px } 

### Box Shadow
```css
.box-shadow {
 box-shadow: 2px 2px 5px #ff0000;  /* x, y, blur, color */
}
```
### Background

##### Common Background properties

- ```background-color``` - #123cdf
- ```background-size``` - uvelichava ili namalq kartinkata, 40%
- ```background-position``` - top-left, top-right, center / 20% 30% / 10px 15px
 - used in **sprites** multiple small images in one big image
- ```background-image``` - url("./images/bg.jpg") , can load multiple images
- ```background-repeat``` - repeat, no-repeat, repeat-x, repeat-y
- ```background``` - #423fcd url("image.png") repeat-x (sykraten zapis)
- ```background-attachment``` - scroll, fixed, local

##### Gradients

Use **[ColorZilla](http://www.colorzilla.com/gradient-editor/)** for gradient  
Or **[ColorTools](http://www.colorzilla.com/chrome/)** to install in browser

### Opacity
```css
opacity: 0.5 /* makes element half-visible, property is inherited from parents */
```

# Layout

### Sizes

- **```width```** - in pixels 50px, cm, %, can use **rem** or **em** too relative to font size
- **```min-width```** - overrides if auto is smaller
- **```max-width```** - overrides if auto is wider

### Overflow
 - **```overflow```**
  - **visible** - prehvyrlq containera
  - **hidden** - otrqzva teksta (elementa)
  - **scroll** - postavq scrolls vinagi
  - **auto** - dobavq scrolls ako ima nujda

### Display
- **```display```**
 - **inline** - no breaks are placed, no new line
 - **block** - izpolzva cqlata shirina i se prenasq nq nov red
 - **inline-block** - dyrji se kato block, no ne zaema cqlata shirina
 - **none** - elementa izchezva
 - **table** - table-row, table-cell
- **```visibility```** 
 - **hidden** - izchezva, no ostava kato poziciq i zaema mqsto
 - **collapsed** - za tablici
 - **visible** - pokazva se sled hidden
- **```margin```** - izbutva sysednite
- **```padding```** - razshirqva elementa

### Box model

**```box-sizing```**  
-------
Example of **content-box** and **content-box**  
![](http://crypt.codemancers.com/assets/images/boxmodel/compare_models-ec8c849825b4fb3e1e6177e49e15d800cb77bdeaa99e6adcf896a65af62ab99f.png)

### Positioning

- **```position```**  
 - **relative** - zadava se poziciq sprqmo sobstvenoto polojenie (za predpochitame **margin**)  
   ``` top: 10px;``` 
   ```left: 30px;```  
   ```bottom: 50px```  
   ```right: -22px```  
 - **absolute** - zadava poziciq sprqmo nachalniq element, roditel, koito ne e static (ne mu e zadaden position)
 - **static** - default position
 - **fixed** - vinagi sedi na opredeleno mqsto, dokato ostanaloto se dviji
- **```z-index```** - -5, 1, 100, 200, 300 ili kolkoto iskame, vajnoto e da se razlichavat 
- **```vertical-align```** - raboti samo pri **inline** elementi
 - baseline, length, sub, super, top, text-top, middle, bottom, text-bottom, initial, inherit  
 
##### Float

- **```float```** - none, left, right  

use **clear** to stop floating on elements after this  

```css
.next-element {
    clear: both; /* left, right, both */
}
```

to use float we nead this hack to clean floating after  
using float of child elements of element **.parent**

```css
.parent:after {
   content: "";
   display: table;
   clear: both; /* left, right, both */
}
```

ili da slojim nov div sled **.parent**

```html
<div class="clear"></div>
```
```css
.clear {
    clear: both; /* left, right, both */
}
```
### Flexbox
Main terminology

![](https://mdn.mozillademos.org/files/3739/flex_terms.png)

parent properties
```css
.container {
   display: flex; /* zadava se na parent elementa */
   flex-direction: row | column | wrap | no-wrap; /* zadavame podredbata */
   justify-content: center | space-around | space-between; /* centrira elementite po cross axis */
   align-items: center | flex-start | flex-end | space-between; /* centrira elementie pootdelno */
   align-content: center /* kogato imame multiple lines, centrira celiq content; */
}
```
children properties
```css
.first {
  order: 1; /* podrejda elementa sprqmo ostanalite */
  flex-grow: 4; /* razpredelq v syotnoshenie ostatychnoto mqsto */
  flex-shrink: 3; /* namalq gi kato otnema mqsto v tova syotnoshenie */
  flex-basis: <length> | auto;
  align-self: flex-end; /* samo edin element izmestvame */
}
.second {
   order: 2; 
   flex-grow: 6;
   flex-shrink: 3; 
}
```
##### Shortland declaration
```css
.item {
   flex: none | [ <'flex-grow'> <'flex-shrink'>? || <'flex-basis'> ];
}
```
