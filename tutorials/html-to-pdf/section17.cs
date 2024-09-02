var source =
    @"<div class=""entry"">
        <h1>{{title}}</h1>
        <div class=""body"">
            {{body}}
        </div>
    </div>";
var template = Handlebars.Compile(source);

var data = (title: "My new post", body: "This is my first post!");

var result = template(data);

/* Would render:
<div class="entry">
  <h1>My New Post</h1>
  <div class="body">
    This is my first post!
  </div>
</div>
*/