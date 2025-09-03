using System.Runtime.CompilerServices;

Console.WriteLine("Hej!\nVälkommen till min frågesport!");

Console.WriteLine("Först och främst!\nVad heter du?");

string namn = Console.ReadLine();
Console.WriteLine($"Hej {namn}!\nKul att du vill spela min frågesport!\nÄr du redo att börja?");

string svar = Console.ReadLine();


Console.WriteLine("Nu kör vi igång med frågesporten!\nDet kommer vara 20 frågor totalt.\nFör varje rätt svar får du 1 poäng!\nHar du förstått spelreglerna?");
string regler = Console.ReadLine();
int poang = 0;

if (regler.ToLower() == "ja" || regler.ToLower() == "ja!")
    if (regler.ToLower() == "nej" || regler.ToLower() == "nej!")
    {
        Console.WriteLine("Okej, jag förklarar igen!\nDet kommer vara 20 frågor totalt.\nFör varje rätt svar får du 1 poäng!\nHar du förstått spelreglerna nu?");
    }
if (regler.ToLower() == "ja" || regler.ToLower() == "ja!")

{
    Console.WriteLine("Toppen! Då kör vi igång!");
}
else
{
    Console.WriteLine("Okej, jag förklarar igen!\nDet kommer vara 20 frågor totalt.\nFör varje rätt svar får du 1 poäng!\nHar du förstått spelreglerna nu?");
    string regler2 = Console.ReadLine();
    if (regler2.ToLower() == "ja" || regler2.ToLower() == "ja!")
    {
        Console.WriteLine("Toppen! Då kör vi igång!");
    }
    else
    {
        Console.WriteLine("Okej, jag förklarar en sista gång!\nDet kommer vara 20 frågor totalt.\nFör varje rätt svar får du 1 poäng!\nHoppas du har förstått nu, annars får du fråga någon annan om hjälp.");
    }
}


Console.WriteLine("Fråga 1: Vem var rysslands första president?");
string president = Console.ReadLine();
if (president.ToLower() == "boris jeltsin" || president.ToLower() == "jeltsin" || president.ToLower() == "boris")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Boris Jeltsin");
}

Console.WriteLine("Fråga 2: Vad hette Ryssland under andra världskriget?");
string land = Console.ReadLine();
if (land.ToLower() == "sovjetunionen" || land.ToLower() == "sovjet")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det hette Sovjetunionen");
}

Console.WriteLine("Fråga 3: Vilket årtionde inträffade andra världskriget?");
string artionde = Console.ReadLine();
if (artionde == "1940-talet" || artionde == "40-talet" || artionde == "1940talet" || artionde == "40talet")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var 1940-talet");
}

Console.WriteLine("fråga 4: Vem var tysklands rikskansler mellan år 1930 och 1932?");
string kansler = Console.ReadLine();
if (kansler.ToLower() == "heinrich brüning" || kansler.ToLower() == "brüning" || kansler.ToLower() == "heinrich")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Heinrich Brüning");
}

Console.WriteLine("fråga 5: Vilka var de allierade under första världskriget?");
string allierade = Console.ReadLine();
if (allierade.ToLower() == "frankrike, storbritannien och ryssland" || allierade.ToLower() == "frankrike storbritannien och ryssland" || allierade.ToLower() == "frankrike, storbritannien och ryssland" || allierade.ToLower() == "frankrike storbritannien och ryssland")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Frankrike, Storbritannien och Ryssland");
}

Console.WriteLine("fråga 6: Vilket år började första världskriget?");
string ar1vk = Console.ReadLine();

if (ar1vk == "1914")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var 1914");
}

Console.WriteLine("fråga 7: Vilket år slutade första världskriget?");
string ar1vkslut = Console.ReadLine();

if (ar1vkslut == "1918")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var 1918");
}

Console.WriteLine("fråga 8: Vilket land skapade den första fungerande stridsvagnen?");
string stridsvagn = Console.ReadLine();

if (stridsvagn.ToLower() == "storbritannien" || stridsvagn.ToLower() == "england" || stridsvagn.ToLower() == "uk")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Storbritannien");
}

Console.WriteLine("fråga 9: Vilket land var först med att införa allmän rösträtt?");
string rostratt = Console.ReadLine();

if (rostratt.ToLower() == "nya zeeland" || rostratt.ToLower() == "new zealand")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Nya Zeeland");
}

Console.WriteLine("fråga 10: Vilket land förlorade ett väpnat krig mot fåglar?");
string krig = Console.ReadLine();

if (krig.ToLower() == "australien" || krig.ToLower() == "australia")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Australien");
}

Console.WriteLine("fråga 11: Vem var den första kejsaren av det tysk-romerska riket?");
string kejsare = Console.ReadLine();

if (kejsare.ToLower() == "otto den store" || kejsare.ToLower() == "otto" || kejsare.ToLower() == "otto 1")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Otto den store");
}

Console.WriteLine("fråga 12: Vilket samvälde försvann från kartan mellan 1772 och 1795 som sedan återvände år 1918?");
string samvalde = Console.ReadLine();

if (samvalde.ToLower() == "polen" || samvalde.ToLower() == "polska samväldet")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Polen");
}

Console.WriteLine("fråga 13: Vilket land var först med att använda gevär?");
string gevär = Console.ReadLine();

if (gevär.ToLower() == "kina" || gevär.ToLower() == "kineserna")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var Kina");
}

Console.WriteLine("fråga 14: Vilket århundrade inträffade den franska revolutionen?");
string arhundrade = Console.ReadLine();

if (arhundrade.ToLower() == "1700-talet" || arhundrade.ToLower() == "18-talet" || arhundrade.ToLower() == "1700talet" || arhundrade.ToLower() == "18talet")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var 1700-talet");
}

Console.WriteLine("fråga 15: Vem var den första presidenten i USA?");
string presidentusa = Console.ReadLine();

if (presidentusa.ToLower() == "george washington" || presidentusa.ToLower() == "washington" || presidentusa.ToLower() == "george")
{
    Console.WriteLine("Rätt svar!");
}
else
{
    Console.WriteLine("Fel svar, det var George Washington");
}
















Console.WriteLine($"Tack för att du spelade {namn}!\nHoppas du hade kul!");













// Console.WriteLine("Välkommen Vincent!\nVänligen skriv in ett heltal");
// String inm1 = Console.ReadLine();

// Console.WriteLine("Skriv nu vänligen in ett decimaltal");
// String inm2 = Console.ReadLine();

// Double tal1 = Convert.ToDouble(inm1);
// Double tal2 = Convert.ToDouble(inm2);

// Double div = tal1 / tal2;

// Console.WriteLine($"{tal1} / {tal2} = {div}");
// // Console.WriteLine("Välkommen!\nVänligen skriv ett heltal");
// // string inm1 = Console.ReadLine();

// // Console.WriteLine ("Skriv nu ett till heltal");
// // string inm2 = Console.ReadLine();

// // int tal1 = Convert.ToInt32(inm1);
// // int tal2 = Convert.ToInt32(inm2);

// // int summa = tal1 + tal2;

// // Console.WriteLine($"{tal1} + {tal2} = {summa}");

// // // Double tal1 = Convert.ToDouble(inm1);
// // // Double tal2 = Convert.ToDouble(inm2);

// // // Double div = tal1 / tal2;
// // // Console.WriteLine("Skriv in ett heltal");
// // // String inm1 = Console.ReadLine();
// // // Console.WriteLine("Skriv in ett till heltal");
// // // String inm2 = Console.ReadLine();

// // // int tal1 = Convert.ToInt32(inm1);
// // // int tal2 = Convert.ToInt32(inm2);

// // // int summa = tal1 + tal2;

// // // Console.WriteLine($"{tal1} + {tal2} = {summa}");



// // // // //skapa en int
// // // // int tal = 5;

// // // // //Fel kod
// // // // Console.WriteLine("Hur gammal är du?");
// // // // String tal1 = Console.ReadLine();

// // // // Console.WriteLine("Hur gammal är din kompis?");
// // // // String tal2 = Console.ReadLine();


// // // // //Rätt kod
// // // // Console.WriteLine("Hur gammal är du på riktigt?");
// // // // String inmatning = Console.ReadLine();
// // // // int talKonv = Convert.ToInt32(inmatning);

// // // // if (talKonv > 17)
// // // // {

// // // //     Console.WriteLine("Välkommen till krogen");

// // // // }



// // // // Console.WriteLine("Välkommen!\nVad heter du?");

// // // // string namn = Console.ReadLine();

// // // // Console.WriteLine("Hej " + namn);
// // // // Console.WriteLine("Vart bor du?");
// // // // String plats = Console.ReadLine();

// // // // Console.WriteLine("Vad gillar du att se på Netflix?");
// // // // String Netflix = Console.ReadLine();

// // // // Console.WriteLine($"Välkommen {namn}. Jag ser att du bor i/på {plats}.\n"
// // // // + $"ikväll tycker jag du ska kolla på {Netflix}");