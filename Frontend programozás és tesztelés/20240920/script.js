//Deklarálj egy let kulcsszóval egy változót, amely egy szöveget tárol. Módosítsd az értékét egy számra, majd írd ki a konzolra.
let string = "Hello World!"; 
string = 5;
console.log(string); 
//Készíts egy person nevű objektumot, amelynek tulajdonságai egy személy nevét, életkorát és hobbijait tárolják.
let Person = {nev: "John", kor: 25, hobbi: ["Kosárlabda", "Foci"]}; 
//Állapítsd meg egy szám és szöveg kombinált összeadásáról (illetve fordítva is szöveg és szám kombinált összeadásáról), hogy milyen típusú! Írasd ki a képernyőre is!
console.log(typeof("5" + 5)); 
console.log(typeof(5 + "5"));
//Deklarálj egy z változót, aminek nem adsz értéket, majd írasd ki a típusát a képernyőre!
let z; 
console.log(typeof(z)); 
//Deklarálj egy x egész számot, majd adj hozzá ötöt a rövid értékadó utasítással!
let x = 5; 
console.log(x += 5); 
//Deklarálj egy y egész számot, majd vonj ki ötöt a rövid értékadó utasítással!
let y = 5; 
console.log(y -= 5); 
//A két kapott számot oszd el maradékosan és írasd ki az eredményt!
console.log(x % y); 
//A korábban készített x, y, z változókkal készíts egy egyenletet, amiben szerepelnie kell osztásnak, szorzásnak, összeadásnak és kivonásnak vegyesen, írasd ki az eredményt! Ezekután változtasd meg az egyenleted precedenciáját egy zárójel közbeiktatásával! Ennek az eredményét is írasd ki!
console.log(x+y-y*y/x); 

console.log((x+y)-y*y/x) 
//Hozz létre egy p változót és emeld a 2 hatványra az új felírással!
let p = 2**2;
//Írj egy programot, amely két számot deklarál let-el, majd kiírja a két szám összegét, különbségét, szorzatát és hányadosát konzolba!
let num1 = 5;
let num2 = 10;
console.log(num1-num2);
console.log(num1+num2);
console.log(num1*num2);
console.log(num1/num2);
//Kérj be egy számot! Használj logikai operátorokat (&&, ||, !) egy összetett feltétel megírásához. Például: "Ha egy szám nagyobb 10-nél és páros, akkor írd ki, hogy 'Nagy páros szám'."
let num3 = prompt("Enter a number: ");
if (num3 >0 && num3 < 10 || num3 == 0 && num3 !=5) {
    console.log("10 és 0 közötti a szám! És nem 5");
    
}
//A korábban deklarált x-et és y-t felhasználva hasonlítsd össze őket és írja ki, ha x nagyobb, vagy kisebb ,esetleg egyenlő y-al!
if (x>y) {
    console.log("x nagyobb mint y");
}
else if (x<y) {
    console.log("y nagyobb mint x");
}
else {
    console.log("x egyenlő y-val");
}
//Az előző részt írd át ternary operátorként és azt is írasd ki!
console.log(x>y ? "x nagyobb mint y" : y>x ? "y nagyobb mint x" : "x egyenlő y-val");

//Biliczki Bence 1/13.D