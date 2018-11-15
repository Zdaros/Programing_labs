class Bookmarks {
    constructor(id, name, description, link, IdExist) {
        this.id = id;
        this.name = name;
        this.description = description;
        this.link = link;
        this.IdExist = IdExist;

        this.str = "<li id='" + this.id + "'><a href='" + this.link + "'><b>" + this.name + ": </b>" + this.description + "</a></li>";
        if (IdExist == false) {
          $("#ForBookmarks").html($("#ForBookmarks").html()+this.str);
        }
        else {
          $("#"+id).html("<a href='" + this.link + "'><b>" + this.name + ": </b>" + this.description + "</a>");
        }
    }
}

var ArrayOfID = [];

function AddLisner () {
  var id = prompt("Id:"); //може захотіти стати int
  id = parseInt(id);
  if (id == ArrayOfID[id-1]){
    let bookmark = new Bookmarks (id,prompt("Name:"),prompt("Description:"),prompt("Link:"), true);
  }
  else {
    let bookmark = new Bookmarks (id,prompt("Name:"),prompt("Description:"),prompt("Link:"), false);
    ArrayOfID[id-1] = id;
  }
}

function DeleteLisner () {
  var id = prompt("Chose id to delete element"); // може захотіти конвертуватись в int
  id = parseInt(id);
  if (id == ArrayOfID[id-1]) {
    $("#ForBookmarks li:nth-child(" + id + ")").html("");
  }
  else
    alert ("There is no such id plese try again");
}
