document.getElementById('item1').innerHTML = 'What the fuck!';
document.getElementsByClassName('ending')[0].children[0].innerHTML = '<strong>opaaaaa</strong>';
document.getElementsByClassName('ending')[0].children[1].innerHTML = `<ul class="lista1" style = "list-style: none; color: red;">
    <li id="item6">More Home</li>
	<li id="item6">More Project</li>
	<li id="item8">More Work</li>
    <li id="item9">More Contact</li>
    <li id="item10">More Help</li>
</ul>`;
var list = document.getElementsByClassName('lista1')[0];
for (var i = 0; i < list.children.length; i++) {
    var element = list.children[i];
    element.innerHTML = 'this is item ' + i;
}
