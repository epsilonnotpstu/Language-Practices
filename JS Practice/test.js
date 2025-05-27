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