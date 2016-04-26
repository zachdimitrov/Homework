##### structure
```html
<!DOCTYPE html>
<html>
  <head>
    <title> Test Site </title>
  </head>
  <body>
  </body>
</html>
```
##### comments
```html
<!-- This is a comment -->
```
##### text formatting tags
<b> - makes text bold
<strong> - makes text significant (and bold)
<i> - italic
<em> - emphasised (italic)
<u> - underlined
<pre> - preformatted text - запазва текстов блок както е написан
<sub> and <sup> - subscript and superscript
##### attachment and links
```html
<a href="http://www.telerik.com/" title="Telerik">Link to Telerik Web site</a> <!-- links -->
<img src="logo.gif" alt="logo" />                                              <!-- image -->
```
##### other tags and attributes
<h1> <h2> ... <h6> - heading tags
<p> - paragraph
<div> - divider tag - block element
<span> - inline element
##### lists
```html
<ol type="1">          <!-- ordered list - type can be (1, A, a, I, i) -->
  <li>Orange</li>
  <li>Grapefruit</li>
</ol>

<ul> <li></li> </ul>   <!-- unordered list - tupe can be (disk, circle, square) -->

<dl>                   <!-- definition list - no bullets - has indentation -->
  <dt>HTML</dt>
    <dd>A markup language …</dd>
  <dt>CSS</dt>
    <dd>Language used to …</dd>
</dl>
##### semantic tags 
    <header> … </header>    - header element - can be part of other elements
    <nav> … </nav>          - navigation
    <aside> … </aside>      - aside
    <section> … </section>  - middle element can contain <article>
    <footer> … </footer>    - final part
##### tables in html
    <table>  - begin/end table definition with attributes - cellspacing = "0" cellpadding = "5"
    <tr>     - create a table row (group of elements - it can contain only table elements)
    <td>     - create a cell in a table
    <th>     - create a header cell (bold and centered)
```html
<table>
  <colgroup>                                      <-- defines table columns (width) -->
    <col style="width:100px" /></col>
  </colgroup>
  <thead>                                         <-- head containts only th cells -->
    <tr><th>Column 1</th><th>Column 2</th></tr>
  </thead>
  <tfoot>                                         <-- footer - but before the body tag! -->
    <tr><td>Footer 1</td><td>Footer 2</td></tr>
  </tfoot>
  <tbody>                                         <-- body - contain the important data -->
    <tr><td>Cell 1.1</td><td>Cell 1.2</td></tr>
    <tr><td>Cell 2.1</td><td>Cell 2.2</td></tr>
  </tbody>
</table>
```
