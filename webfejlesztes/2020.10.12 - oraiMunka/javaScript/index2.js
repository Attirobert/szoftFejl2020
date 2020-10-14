function muvelet(szoveg,szam){
    document.write(szoveg + szam + "<br><br>");
}

function henger(r,m){
    alert(`alap adatok: ${r} ${m}`)
    let c =Math.pow(parseFloat(r),2)*Math.PI*parseFloat(m);
    alert(`henger térfogata =${c}`);
}