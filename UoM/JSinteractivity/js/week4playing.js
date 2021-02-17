var newList = [10,10,10];
var i;
var sum = 0.0;
//newList.push(9,10,11,12);
for(i=0;i<newList.length;i+=2)
{
  document.write(newList[i] );
  if(!(parseInt(i+1) >= newList.length)){
    document.write("     " + newList[i+1]);
    document.write("<br>");
    var sum = sum+=(newList[i]+newList[i+1]);
} else {
  document.write("<br>");
  var sum = sum+=newList[i];
}
  
}
var avg = 0.0;
avg = sum/newList.length;
document.write("sum: " + sum +"<br>");
//document.write("<br>");
document.write("avg: " + avg);
document.write("<br>");
document.write("**********"+"<br>");

var grades= [2, 5, , , 9, 8, , 8];
var sum = 0;
var count = 0;

if (grades.length > 0){
  for (index = 0; index < grades.length; index++){
    if (grades[index] != undefined){
		  sum += grades[index]; 
      count = count + 1;
    }
  }
  //Do we really want to divide by the size of the array?
  document.write(sum/count);
}
else
  document.write("Empty Array");
