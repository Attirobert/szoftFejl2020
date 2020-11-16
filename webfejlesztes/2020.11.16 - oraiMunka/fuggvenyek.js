//funcion
//valtozóban is meglehet adni fuggvenyt

//Fv visszatérési értékkel
var greetingFactory=function(){
    return function(hero, h2){
        return "Hello, a nevem " + hero + "és nem " + h2 +"!";
    }
}

var greeting = greetingFactory();
greeting("Superman","Pókember");

