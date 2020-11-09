function muvelet(szoveg,szam){
    document.write(szoveg + szam + "<br><br>");
}

function henger(r,m){
    this.magassag=m;
    alert(`alap adatok: ${r} ${this.magassag}`)
    let c =Math.pow(parseFloat(r),2)*Math.PI*parseFloat(m);
    alert(`henger térfogata =${c}`);
}

var kishenger= new henger(2,5);
kishenger.magassag;

var Ember ={
    szin: "feher",
    magassag: 2,
    kor: 99,
    koszones: function koszon(hello){
        document.write(hello);
    }
};

function Person(first, last, age, eye) {
    this.firstName = first;
    this.lastName = last;
    this.age = age;
    this.eyeColor = eye;
  }