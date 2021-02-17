/*Name this external file gallery.js*/
function upDate(previewPic){
  pic = document.getElementById("image");
  //pic.style.backgroundImage = "url('https://s3-us-west-2.amazonaws.com/s.cdpn.io/389177/bacon.jpg')";
    console.log("url('" + previewPic.src + "')" );
  pic.style.backgroundImage = "url('" + previewPic.src + "')";
  pic.innerHTML = previewPic.alt;
   }

function unDo(){
  pic = document.getElementById("image");
  pic.style.backgroundImage = "url('')";
  pic.innerHTML = "Hover over an image below to display here.";    
   }