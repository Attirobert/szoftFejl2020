var telepulesArray= "Álmosd,Ártánd,Bagamér,Bakonszeg,Balmazújváros,Báránd,Bedő,Berekböszörmény,Berettyóújfalu,Bihardancsháza,Biharkeresztes,Biharnagybajom,Bihartorda,Bocskaikert,Bojt,Csökmő,Darvas,Debrecen,Derecske,Ebes,Egyek,Esztár,Folyás,Földes,Furta,Fülöp,Gáborján,Görbeháza,Hajdúbagos,Hajdúböszörmény,Hajdúdorog,Hajdúhadház,Hajdúnánás,Hajdúsámson,Hajdúszoboszló,Hajdúszovát,Hencida,Hortobágy,Hosszúpályi,Kaba,Kismarja,Kokad,Komádi,Konyár,Körösszakál,Körösszegapáti,Létavértes,Magyarhomorog,Mezőpeterd,Mezősas,Mikepércs,Monostorpályi,Nádudvar,Nagyhegyes,Nagykereki,Nagyrábé,Nyírábrány,Nyíracsád,Nyíradony,Nyírmártonfalva,Pocsaj,Polgár,Püspökladány,Sáp,Sáránd,Sárrétudvari,Szentpéterszeg,Szerep,Téglás,Tépe,Tetétlen,Tiszacsege,Tiszagyulaháza,Told,Újiráz,Újléta,Újszentmargita,Újtikos,Vámospércs,Váncsod,Vekerd,Zsáka".split(",");
var varosArray="Balmazújváros Berettyóújfalu Biharkeresztes Debrecen Derecske Hajdúböszörmény Hajdúdorog Hajdúhadház Hajdúnánás Hajdúsámson Hajdúszoboszló Kaba Komádi Létavértes Nádudvar Nyíradony Polgár Püspökladány Téglás Tiszacsege Vámospércs".split(" ");

function feladat1(){
    var soBer=telepulesArray.indexOf("Berettyóújfalu");
    let x = document.getElementById("feladat1");
    x.querySelector("p").innerHTML = ++soBer;
}

function feladat2(){
    var soBer=telepulesArray.indexOf("Lánycsók");
    let x = document.getElementById("feladat2");
    x.querySelector("p").innerHTML = ++soBer;
}

function feladat3(){
    var minkar = Number.MAX_VALUE;
    //telepulesArray.forEach((item)=>{(item.length< minkar)? minkar=item.length: minkar =minkar; return minkar;}); //tanáré
    telepulesArray.forEach((item)=>{return minkar= item.length< minkar ? item.length : minkar; }); //enyém

}

function feladat4(){
    var maxkar= Number.MIN_VALUE;
    telepulesArray.forEach(item=> maxkar= item.length> maxkar ? item.length : maxkar);
}

function feladat4(){
    telepulesArray.forEach((item)=>{if(item.length== minkar) document.write(item)});
}

function feladat5(){
    var minNames= telepulesArray.filter((item)=>(item.length==minkar));
}

function feladat6(){
    var maxNames=telepulesArray.filter((item)=>(item.length==maxkar));
}

function feladat7(){
    var telNev9=telepulesArray.reduce((prev,item)=>  {if(item.length<10) return prev=++prev; return pev;},0);
}

function feladat8(){
    var telNev9=telepulesArray.reduce((prev,item)=>  {if(item.length>9) return prev=++prev; return pev;},0);
}

function feladat9(){
    telepulesArray.forEach((item, index, arr)=>{if(varosArray.find((item2) => (item ==item2))) delete arr[index];});
}

function feladat10(){
    var stringTelep=telepulesArray.join(";");
}

function feladat11(){
    var lenName=telepulesArray.every((item)=>(item.length>3)); //akkor ad vissza értéket ha minden értéke ture
}

function felada12(){
    var name15=telepulesArray.some((item)=>(item.length >14));
}

function feladat13(){
    var regexp=/^\w*$/ig;
    var engTelep=telepulesArray.filter(item=>regexp.test(item));
}