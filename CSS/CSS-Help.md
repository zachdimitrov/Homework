### Text Related Properties

#### Font Related
 - ```color``` - #123ABC, (123, 112, 32, 55)
 - ```font-size``` - 10px, set to **body** and then use 1.7em, or 2.3rem
  - **em** - multiply to previous element size
  - **rem** - multiply to initial size
 - ```font-family``` - Verdana, Arial, Sans-serif
 - ```font-variant``` - normal, small-caps
 - ```font-weight``` - normal, bold, bolder, 100 ... 900
 - ```font-style``` - normal, italic, oblique
 
#### Text Related
 - ```text-decoration``` - none, underline, strike-through, overline, (blink)
 - ```text-align``` - left, right, center, justify
 
#### Short Way to set tet rules
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
```
