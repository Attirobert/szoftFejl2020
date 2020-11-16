/*
A feladatok tesztadatai a "Közös nevek.txt" és a "Női nevek.txt" fájlokban vannak.
A feladatok megoldásánál használja a nyíl operátort és a tömbkezelő függvényeket!
Ahol más nincs megadva, mindig a közös nevekkel dolgozzon!
 */
var maxkar= Number.MIN_VALUE;
var minkar = Number.MAX_VALUE;

/* 1. feladat
A Közös nevek adataiból készítsen tömböt! */
var kozosNevek="Aba;Abád;Abbás;Abdiás;Abdon;Abdullah;Ábel;Abelárd;Ábner;Abod;Abony;Abos;Abosa;Ábrahám;Ábrám;Ábrán;Ábris;Absa;Absolon;Acél;Achilles;Achillesz;Áchim;Acsád;Adalbert;Ádám;Adeboró;Ádel;Adelmár;Áden;Adeodát;Ádér;Ádin;Adolár;Adolf;Ádomás;Adonisz;Adony;Adorján;Adrián;Adriánó;Agád;Agamemnon;Agapion;Ágas;Agaton;Agenor;Aggeus;Agmánd;Ágost;Ágoston;Ahillész;Áhim;Ahmed;Airton;Ajád;Ajándok;Ajtony;Akács;Akitó;Ákos;Aladár;Aladdin;Aladin;Alajos;Alán;Alap;Alárd;Alarik;Albert;Albin;Aldán;Áldás;Aldó;Áldor;Alek;Alekszej;Alen;Alex;Alexander;Alfonz;Alfréd;Algernon;Ali;Alieu;Almár;Álmos;Alpár;Alperen;;Álváró;Alvián;Alvin;Amadé;Amadeusz;Amadó;Amand;Amar;Amator;Ambos;Ambró;Ambrus;Ámer;Amin;Amir;Ammar;Ammon;Ámon;Amondó;Ámor;Ámos;Anakin;Anasztáz;Anatol;Andon;Andor;Andorás;Andos;András;André;Andrej;Andzseló;Angelus;Angelusz;Ángyán;Anicét;Aníziusz;Antal;Antigon;Anton;Antónió;Antos;Anzelm;Ányos;Apaj;Apollinár;Apolló;Apor;Apostol;Apród;Aracs;Arad;Aragorn;Aram;Aramisz;Árav;Archibald;Árden;Ardó;Arek;Árész;Arétász;Arián;Arie;Ariel;Arif;Arion;Árisz;Arisztid;Ariton;Arkád;Árkád;Árkos;Arlen;Árlen;Armand;Armandó;Ármin;Arnó;Arnold;Arnót;Áron;Árpád;Arszák;Árszen;Arszlán;Artemon;Artúr;Arus;Arvéd;Arvid;Árvin;Arzén;Aser;Áser;Ashraf;Asur;Aszáf;Aszmet;Aszter;Asztor;Asztrik;Ata;Atád;Atakám;Atanáz;Atilla;Atlasz;Aton;Atos;Atosz;Attila;Auguszt;Augusztusz;Aurél;Aurélián;Avenár;Avidan;Avner;Axel;Azár;Azarél;Azim;Aziz;Azriel;Abélia;Abiáta;Abigél;Ada;Adala;Adalberta;Adalbertina;Adalind;Adaora;Adél;Adela;Adéla;Adelaida;Adelgund;Adelgunda;Adelheid;Adélia;Adelin;Adelina;Adelinda;Adema;Adeodáta;Adina;Admira;Adolfina;Adonika;Adóra;Adria;Adriána;Adrianna;Adrienn;Adrienna;Áfonya;Áfra;Afrodita;Afrodité;Afszana;Agapi;Agáta;Ági;Aglája;Aglent;Agnabella;Agnella;Ágnes;Agnéta;Ágosta;Ágota;Agrippína;Aida;Aina;Ainó;Aira;Aisa;Aisah;Ajándék;Ájlin;Ajna;Ajnácska;Ajnó;Ajra;Ajsa;Ajtonka;Akaiéna;Akilina;Alamea;Alaméa;Alana;Alba;Alberta;Albertin;Albertina;Albina;Alda;Áldáska;Aldea;Álea;Aléna;Aleszja;Alesszia;Alett;Aletta;Alexa;Alexandra;Alexandrin;Alexandrina;Alexia;Alfonza;Alfonzin;Alfonzina;Alfréda;Alia;Alica;Alicia;Alícia;Alida;Alina;Alinda;Alinka;Alirán;Alisa;Aliszia;Alissza;Alitta;Aliz;Alíz;Aliza;Alizé;Alízia;Allegra;Alma;Almanda;Almira;Almiréna;Almitra;Aloé;Alojzia;Aloma;Alóma;Alvina;Ama;Amábel;Amadea;Amadil;Amaja;Amál;Amália;Amana;Amanda;Amandina;Amarant;Amaranta;Amarill;Amarilla;Amarillisz;Amáta;Amázia;Ambrózia;Amelda;Ameli;Amélia;Amelita;Ametiszt;Amidala;Amilla;Amina;Ámina;Aminta;Amira;Amrita;Anabel;Anabell;Anabella;Anada;Anaisz;Anaszta;Anasztázia;Anatólia;Ancilla;Anda;Andelin;Andelina;Andi;Andrea;Andreina;Androméda;Anélia;Anelma;Anéta;Anett;Anetta;Ánfissza;Angéla;Angélia;Angelika;Angelina;Angella;Angyal;Angyalka;Ani;Ania;Anica;Anicéta;Aniella;Anika;Anikó;Anilla;Anima;Anina;Anisza;Anissza;Anita;Anitra;Anízia;Ánizs;Anka;Ankisza;Anna;Annabel;Annabell;Annabella;Annabori;Annakarina;Annakata;Annaleila;Annaléna;Annalilla;Annaliza;Annalujza;Annamari;Annamária;Annamira;Annamíra;Annaregina;Annaréka;Annarita;Annaróza;Annasára;Annaszofi;Annaszófia;Annavera;Annavirág;Annelin;Anni;Annika;Annunciáta;Anriett;Antea;Antigoné;Antoaneta;Antoanett;Antonella;Antónia;Antoniett;Antonietta;Anzelma;Ánya;Apol;Apolka;Apollinária;Apollónia;Aporka;Appia;Ápril;Áprilka;Arabella;Aranka;Arany;Aranyka;Aranyos;Arenta;Ari;Aria;Ariadna;Ariadné;Ariana;Arianna;Ariéla;Ariella;Arienn;Arika;Arikán;Arina;Arinka;Arita;Arlena;Arlett;Armanda;Armandina;Armella;Armida;Armilla;Ármina;Arna;Árnika;Arnolda;Arona;Árpádina;Artemisz;Artemízia;Artiana;Árvácska;Árven;Arzénia;Asma;Aszpázia;Asszunta;Asztéria;Asztrid;Asztrida;Atala;Atalanta;Atália;Atanázia;Atára;Aténa;Aténé;Atika;Atina;Auguszta;Augusztina;Aura;Aurea;Aurélia;Aurora;Auróra;Avani;Avarka;Aviána;Avitál;Azálea;Aziza;Azra;Azucséna;Azura;Azurea".split(";");

/* 2. feladat
Az "Annunciáta" név hanyadik helyen van?*/

function feladat2(){
    return kozosNevek.indexOf("Annunciáta")+1;
}

/* 3. feladat
Milyen hosszú a legrövidebb név? */

function feladat3(){
    kozosNevek.forEach((item)=>{return minkar= item.length< minkar ? item.length : minkar});
    return minkar;
}

/* 4. feladat
Milyen hosszú a leghosszabb név? */

function feladat4(){
    kozosNevek.forEach(item=> maxkar= item.length> maxkar ? item.length : maxkar);
    return maxkar;
}

/* 5. feladat
Írassa ki a legrövidebb nevű közös neveket! */

function feladat5(){
    return kozosNevek.filter((item)=>(item.length==minkar));
}

/* 6. feladat
Írassa ki a leghosszabb nevű közös neveket! */

function feladat6(){
    return kozosNevek.filter((item)=>(item.length==maxkar));
}

/* 7. feladat
Hozzon létre új tömböt a legrövidebb nevű közös nevekből! */

function feladat7(){
    return kozosNevek.filter((item) => (item.length == minkar));
}

/* 8. feladat
Hozzon létre új tömböt a leghosszabb nevű közös nevekből!*/

function feladat8(){
    return kozosNevek.filter((item) => (item.length == maxkar));
}

/* 9. feladat
A Női nevek listából készítsen tömböt! */

var noiNevek= "Abélia;Abiáta;Abigél;Ada;Adala;Adalberta;Adalbertina;Adalind;Adaora;Adél;Adela;Adéla;Adelaida;Adelgund;Adelgunda;Adelheid;Adélia;Adelin;Adelina;Adelinda;Adema;Adeodáta;Adina;Admira;Adolfina;Adonika;Adóra;Adria;Adriána;Adrianna;Adrienn;Adrienna;Áfonya;Áfra;Afrodita;Afrodité;Afszana;Agapi;Agáta;Ági;Aglája;Aglent;Agnabella;Agnella;Ágnes;Agnéta;Ágosta;Ágota;Agrippína;Aida;Aina;Ainó;Aira;Aisa;Aisah;Ajándék;Ájlin;Ajna;Ajnácska;Ajnó;Ajra;Ajsa;Ajtonka;Akaiéna;Akilina;Alamea;Alaméa;Alana;Alba;Alberta;Albertin;Albertina;Albina;Alda;Áldáska;Aldea;Álea;Aléna;Aleszja;Alesszia;Alett;Aletta;Alexa;Alexandra;Alexandrin;Alexandrina;Alexia;Alfonza;Alfonzin;Alfonzina;Alfréda;Alia;Alica;Alicia;Alícia;Alida;Alina;Alinda;Alinka;Alirán;Alisa;Aliszia;Alissza;Alitta;Aliz;Alíz;Aliza;Alizé;Alízia;Allegra;Alma;Almanda;Almira;Almiréna;Almitra;Aloé;Alojzia;Aloma;Alóma;Alvina;Ama;Amábel;Amadea;Amadil;Amaja;Amál;Amália;Amana;Amanda;Amandina;Amarant;Amaranta;Amarill;Amarilla;Amarillisz;Amáta;Amázia;Ambrózia;Amelda;Ameli;Amélia;Amelita;Ametiszt;Amidala;Amilla;Amina;Ámina;Aminta;Amira;Amrita;Anabel;Anabell;Anabella;Anada;Anaisz;Anaszta;Anasztázia;Anatólia;Ancilla;Anda;Andelin;Andelina;Andi;Andrea;Andreina;Androméda;Anélia;Anelma;Anéta;Anett;Anetta;Ánfissza;Angéla;Angélia;Angelika;Angelina;Angella;Angyal;Angyalka;Ani;Ania;Anica;Anicéta;Aniella;Anika;Anikó;Anilla;Anima;Anina;Anisza;Anissza;Anita;Anitra;Anízia;Ánizs;Anka;Ankisza;Anna;Annabel;Annabell;Annabella;Annabori;Annakarina;Annakata;Annaleila;Annaléna;Annalilla;Annaliza;Annalujza;Annamari;Annamária;Annamira;Annamíra;Annaregina;Annaréka;Annarita;Annaróza;Annasára;Annaszofi;Annaszófia;Annavera;Annavirág;Annelin;Anni;Annika;Annunciáta;Anriett;Antea;Antigoné;Antoaneta;Antoanett;Antonella;Antónia;Antoniett;Antonietta;Anzelma;Ánya;Apol;Apolka;Apollinária;Apollónia;Aporka;Appia;Ápril;Áprilka;Arabella;Aranka;Arany;Aranyka;Aranyos;Arenta;Ari;Aria;Ariadna;Ariadné;Ariana;Arianna;Ariéla;Ariella;Arienn;Arika;Arikán;Arina;Arinka;Arita;Arlena;Arlett;Armanda;Armandina;Armella;Armida;Armilla;Ármina;Arna;Árnika;Arnolda;Arona;Árpádina;Artemisz;Artemízia;Artiana;Árvácska;Árven;Arzénia;Asma;Aszpázia;Asszunta;Asztéria;Asztrid;Asztrida;Atala;Atalanta;Atália;Atanázia;Atára;Aténa;Aténé;Atika;Atina;Auguszta;Augusztina;Aura;Aurea;Aurélia;Aurora;Auróra;Avani;Avarka;Aviána;Avitál;Azálea;Aziza;Azra;Azucséna;Azura;Azurea".split(";");

/* 10. feladat
Számolja meg, hogy a közös nevek között hánynak a neve rövidebb mint 10 karakter és hánynak nem! */

function feladat10(){
    return kozosNevek.reduce((prev,item)=>  {if(item.length<10) return prev=++prev; return pev;},0);
}

function feladat10_1(){
    return kozosNevek.reduce((prev,item)=>  {if(item.length>9) return prev=++prev; return pev;},0);
}

/* 11. feladat
A közös nevek tömbből törölje a női neveket! */

function feladat11(){
    return kozosNevek.forEach((item, index, arr)=>{if(noiNevek.find((item2) => (item ==item2))) delete arr[index];});
}

/* 12. feladat
A közös nevekből készitsen listát, ahol az elemek elválasztója:"; "! 
*/

function feladat12(){
    return kozosNevek.join(";");
}

/* 13. feladat
Ellenőrizze, hogy minden név hosszabb mint 3 karakter! */

function feladat13(){
    return kozosNevek.every((item)=>(item.length>3));
}

/* 14. feladat
Nézze meg, hogy van e olyan település, melynek a neve legalább 15 karakter! */

function felada14(){
    return kozosNevek.some((item)=>(item.length >14));
}

/* 15. feladat
A Számok.txt fájlban megadott numerikus tömböt rendezze nagyság szerint növekvő 
sorrendbe tömbkezelő függvény segítségével.*/

var szamok= [858, 269, 1281, 987, 793, 1063, 31, 104, 1316, 1095, 1103, 1170, 329, 900, 1299, 267, 1480, 439, 1478, 531, 870, 1187, 143, 103, 207, 1212, 1163, 1332, 1195, 1094, 607, 770, 713, 225, 1404, 1087, 1210, 707, 20, 187, 287, 1405, 580, 1052, 1155, 150, 92, 1119, 552, 257].sort();

