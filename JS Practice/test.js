function change(){
    let x=5,y=10;
    let z=x+y;
    {
        let z=x-y;
        document.getElementById("demo1").innerHTML=z;
    }
    let $name="afridi alom pranto"
    document.getElementById("demo").innerHTML=z+" "+$name + " " +z;
   
}
let age=25;
let gender="male";
function concatanate(age,gender){
    return age+" "+gender;
}
//let con=concatanate(age,gender);

function print(){
    document.getElementById("demo3").innerHTML=concatanate(age,gender);
}