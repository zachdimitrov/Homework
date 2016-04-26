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
```html
<b> - makes text bold
<strong> - makes text significant (and bold)
<i> - italic
<em> - emphasised (italic)
<u> - underlined
<pre> - preformatted text - запазва текстов блок както е написан
<sub> and <sup> - subscript and superscript
```
##### attachment and links
```html
<a href="http://www.telerik.com/" title="Telerik">Link to Telerik Web site</a> <!-- links -->
<img src="logo.gif" alt="logo" />                                              <!-- image -->
```
##### other tags and attributes
```html
<h1> <h2> ... <h6> - heading tags
<p> - paragraph
<div> - divider tag - block element
<span> - inline element
```
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
```
##### semantic tags 
```html
    <header> … </header>    - header element - can be part of other elements
    <nav> … </nav>          - navigation
    <aside> … </aside>      - aside
    <section> … </section>  - middle element can contain <article>
    <footer> … </footer>    - final part
```
##### tables in html
```html
    <table>  - begin/end table definition with attributes - cellspacing = "0" cellpadding = "5"
    <tr>     - create a table row (group of elements - it can contain only table elements)
    <td>     - create a cell in a table
    <th>     - create a header cell (bold and centered)

<table cellspacing="15" cellpadding="0">          <!-- attributes of table
  <colgroup>                                      <!-- defines table columns (width) -->
    <col style="width:100px" /></col>
  </colgroup>
  <thead>                                         <!-- head containts only th cells -->
    <tr><th>Column 1</th><th>Column 2</th></tr>
  </thead>
  <tfoot>                                         <!-- footer - but before the body tag! -->
    <tr><td>Footer 1</td><td>Footer 2</td></tr>   <!-- footer is displayed last -->
  </tfoot>
  <tbody>                                         <!-- body - contain the important data -->
    <tr><td>Cell 1.1</td><td>Cell 1.2</td></tr>
    <tr><td>Cell 2.1</td><td>Cell 2.2</td></tr>
  </tbody>
</table>
```
colspan = "2" - merges the cells in 2 neighbour columns
rowspan = "2" - merges cells in neighbour lines
##### forms in html
```html
<form name="myForm" method="post" action="path/to/some-script.php">
    <!-- create a form block with attributes -->
<input type="text" name="FirstName" value="This is a text field" /> <!-- single line text -->
<textarea name="Comments">  <!--This is a multi-line text field --> </textarea>
<input type="password" name="pass" /> <!-- a password field -->
<input type="reset" name="resetBtn" value="Reset the form" /> <!-- resets the form -->
<input type="submit" src="submit.gif" name="submitBtn" alt="Submit" /> <!-- submit -->
<input type="image" value="click me" /> 
<input type="button" value="Apply Now" />
<input type="checkbox" name="fruit" value="apple" />
<input type="radio" name="title" value="Mr." />        <!-- "name" groups the buttons -->
<input type="hidden" name="Account" value="This is a hidden text field" />
<input type="range" min="0" max="100" />
<input type="number" min="0" max="100" />
<input type="email" required="true" pattern="[^ @]*@[^ @].[^ @]"/> <!-- validation -->
<input type="url" required="true" />  <!-- validation of URL-->
<input type="tel" required="true" />  <!-- validation of telephpne-->

```
attributes: 
*autocomplete, autofocus, required, tabindex *
###### dropdown
```html
<select name="gender">
  <option value="Value 1"
    selected="selected">Male</option>
  <option value="Value 2">Female</option>
  <option value="Value 3">Other</option>
</select>
```
###### label - explains the form field using ID
```html
<label for="fn">First Name</label>
<input type="text" id="fn" />
````
###### fieldset
```html
<form method="post" action="form.aspx">
   <fieldset>
      <legend>Client Details</legend>
      <input type="text" id="Name" />
      <input type="text" id="Phone" />
   </fieldset>
</form>
```
##### frames
```html <noframes>``` - is used for older browsers
```html <frameset>``` - show another website inside html
```html
<html>
  <head><title>Frames _Example_</title></head>
  <frameset cols="180px,*,150px">   <!-- for multiple web pages in one -->
    <frame src="left.html" ></frame>
    <frame src="middle.html" ></frame>
    <frame src="right.html" ></frame>
  </frameset>
</html>
```
###### iframe
```html
<iframe name="iframeYoutube"
        width="600"
        height="400"
        src="https://www.youtube.com/"
        frameborder="yes"
        scrolling="yes">
</iframe>
```
