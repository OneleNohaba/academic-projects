//check if fields are empty
function testFunc(){
    if ( document.forms["contactMe"]["from"].value != "" && document.forms["contactMe"]["user_name"].value !=""){
        document.forms["contactMe"]["submit"].disabled = false;
        document.getElementById("submit").style.backgroundColor = "#ff9900cc";
        document.getElementById("submit").style.cursor ="pointer";
        
}
else{
    document.forms["contactMe"]["submit"].disabled = true;
    document.getElementById("submit").style.cursor = "not-allowed";
    document.getElementById("submit").style.backgroundColor = "#f3343486";
}
if ( document.forms["contactMe"]["from"].value != "" && document.forms["contactMe"]["user_name"].value !="" && document.forms["contactMe"]["message"].value != ""){
    document.getElementById("submit").style.backgroundColor = "#11c71a94";
    
}
};

function submissionFunction(){
        console.log("Name: "+document.forms["contactMe"]["user_name"].value+ "\n" +
                "E-mail: "+document.forms["contactMe"]["from"].value +"\n" +
                "Message: "+ document.forms["contactMe"]["message"].value );
        alert("Name: "+document.forms["contactMe"]["user_name"].value+ "\n" +
                "E-mail: "+document.forms["contactMe"]["from"].value +"\n" +
                "Message: "+ document.forms["contactMe"]["message"].value );
};
if ( window.history.replaceState ) {
    window.history.replaceState( null, null, window.location.href );
  };

;

//About page stuff
function hover (){
    let curpos = document.getElementById("box-3").style.left.value;
    //alert(curpos);
}

function counterUp(){let x = document.getElementById("num").innerText
    x++
    document.getElementById("num").innerHTML = x;
    if( x > 0){
        document.getElementById("num").style.color = "green";
    }
};
function counterDown(){let x = document.getElementById("num").innerText
x--;
document.getElementById("num").innerHTML = x;
if( x < 0){
        document.getElementById("num").style.color = "Red";
    }
}