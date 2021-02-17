/*Add the JavaScript here for the function billingFunction().  
It is responsible for setting and clearing the fields in 
Billing Information 
  //id = "shippingName" id = "shippingZip
  //id = "billingName" id = "billingZip"
*/
  function billingFunction(){

  var shipName  = document.getElementById("shippingName");
  var shipZip   = document.getElementById('shippingZip');
  var billName2 = document.getElementById("billingName"); 
  var billZip2  = document.getElementById("billingZip");
  var getState  = document.getElementById("same");
 
  if(getState.checked == true){
    billName2.value  = shipName.value;
    billZip2.value   = shipZip.value;
  } else{
    billName2.value  = "";
    billZip2.value   = "";
  }
  
  console.log("billzip = " + billZip2.value + "  checkbox state = " +getState.checked);
}
