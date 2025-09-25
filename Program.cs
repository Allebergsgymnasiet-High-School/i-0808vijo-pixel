using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
Console.WriteLine("======================================");
Console.WriteLine("=        Frågesport! Advanced        =");
Console.WriteLine("=        Press Enter to Start        =");
Console.WriteLine("======================================");
Console.ReadLine();

bool exit = false;


    Console.WriteLine("======================================");
    Console.WriteLine("=             Main Menu:             =");
    Console.WriteLine("======================================");
    Console.ReadLine();
while (!exit)
{
    Console.WriteLine("======================================");
    Console.WriteLine("=               Start!               =");
    Console.WriteLine("=            Unlock Cheat            =");
    Console.WriteLine("=             Exit  Game             =");
    Console.WriteLine("======================================");
    string menu = Console.ReadLine();


    switch (menu.ToLower())
    {

        case "start":
            Console.WriteLine("Loading...");
            break;

        case "unlock cheat":
            break;

        case "exit game":
            break;

        default:
            Console.WriteLine("Ogiltigt val, försök igen");
            continue;
            break;
    }
    if (menu.ToLower() != "start" && menu.ToLower() != "unlock cheat" && menu.ToLower() != "exit game")
    {
        Console.WriteLine("Ogiltigt val, försök igen");
        continue;
    }
    if (menu.ToLower() != "start" && menu.ToLower() != "exit game")
    {
        if (menu.ToLower() == "unlock cheat")
        {


            Console.WriteLine("Varför vill du låsa upp fusk?\nSpela spelet normalt!");

            Console.WriteLine(" ");
            Console.ReadLine();

            Console.WriteLine("Återgår till huvudmenyn...");



            continue;



        }




        if (menu.ToLower() == "exit game" || menu.ToLower() == "exit")
        {
            Console.WriteLine("Avslutar spelet...");
            exit = true;
            break;
        }
    }

    if (menu.ToLower() == "start")
    {
        Console.WriteLine("======================================");
        Console.WriteLine("=         Välkommen till min         =");
        Console.WriteLine("=             Frågesport             =");
        Console.WriteLine("=        Välj ett alternativ:        =");
        Console.WriteLine("=              Historia              =");
        Console.WriteLine("=               Gaming               =");
        Console.WriteLine("======================================");

        string amne = Console.ReadLine();

        while (amne.ToLower() != "historia")
        {
            if (amne.ToLower() == "gaming")
                Console.WriteLine("Tyvärr, detta ämne är inte tillgängligt ännu!\nVänligen välj historia istället.");
            Console.WriteLine("Vänligen välj ett ämne:");
            amne = Console.ReadLine();

            if (amne.ToLower() != "historia" && amne.ToLower() != "gaming")
            {
                Console.WriteLine("Ogiltigt val, vänligen välj historia istället.");
                break;



            }
        }
    }


    Console.WriteLine("Hej!\nVälkommen till frågesporten om historia!");

    Console.WriteLine("Först och främst!\nVad heter du?");

    string namn = Console.ReadLine();
    Console.WriteLine($"Hej {namn}!\nKul att du vill spela min frågesport!\nÄr du redo att börja?");

    string svar = Console.ReadLine();
    if (svar.ToLower() == "ja" || svar.ToLower() == "ja!")
    {
        Console.WriteLine("Toppen! Då kör vi igång!");
    }
    else
    {
        Console.WriteLine("Okej, säg till när du är redo!");
        Console.ReadLine();
        Console.WriteLine("Toppen! Då kan vi köra igång!");
    }

    Console.WriteLine("Du kommer att få svara på 40 frågor om ämnet historia.\nFör varje rätt svar får du 1 poäng samt förlora en poäng för varje fel svar!\nHar du förstått spelreglerna?");
    string regler = Console.ReadLine();
    int poang = 0;

    if (regler.ToLower() == "ja" || regler.ToLower() == "ja!")
        if (regler.ToLower() == "nej" || regler.ToLower() == "nej!")
        {
            Console.WriteLine("Okej, jag förklarar igen!\nDu kommer att få svara på 40 frågor om ämnet historia.\nFör varje rätt svar får du 1 poäng samt förlora en poäng för varje fel svar!\nHar du förstått spelreglerna nu?");
        }
    if (regler.ToLower() == "ja" || regler.ToLower() == "ja!")

    {
        Console.WriteLine("Toppen! Då kör vi igång!");
    }
    else
    {
        Console.WriteLine("Okej, jag förklarar igen!\nDu kommer att få svara på 40 frågor om ämnet historia.\nFör varje rätt svar får du 1 poäng samt förlora en poäng för varje fel svar!\nHar du förstått spelreglerna nu?");
        string regler2 = Console.ReadLine();
        if (regler2.ToLower() == "ja" || regler2.ToLower() == "ja!")
        {
            Console.WriteLine("Toppen! Då kör vi igång!");
        }
        else
        {
            Console.WriteLine("Okej, jag förklarar en sista gång!\nDu kommer att få svara på 40 frågor om ämnet historia.\nFör varje rätt svar får du 1 poäng samt förlora en poäng för varje fel svar!\nHoppas du har förstått nu, annars får du fråga någon annan om hjälp.");
        }
    }

    Thread.Sleep(6000);
    Console.WriteLine("Jag kommer vara snäll med att inte ge dig minus poäng på den första frågan ifall du svarar fel!\nLycka till!");


    Console.WriteLine("Fråga 1: Rysslands första president var Vladimir Putin?\n Sant eller Falskt?");
    string president = Console.ReadLine();

    if (president.ToLower() == "falskt" || president.ToLower() == "falsk")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
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

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det hette Sovjetunionen");
        poang -= 1;
    }

    Console.WriteLine("Fråga 3: Vilket årtionde inträffade andra världskriget?");
    string artionde = Console.ReadLine();
    if (artionde == "1940-talet" || artionde == "40-talet" || artionde == "1940talet" || artionde == "40talet")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var 1940-talet");
        poang -= 1;
    }

    Console.WriteLine("fråga 4: Vem var tysklands rikskansler mellan år 1930 och 1932?");
    string kansler = Console.ReadLine();
    if (kansler.ToLower() == "heinrich brüning" || kansler.ToLower() == "brüning" || kansler.ToLower() == "heinrich")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Heinrich Brüning");
        poang -= 1;
    }

    Console.WriteLine("fråga 5: Vilket av de följande länderna var med de allierade under första världskriget?\nA. Tyskland\nB. Österrike-Ungern\nC. Italien\nD. Osmanska riket");
    string allierade = Console.ReadLine();
    if (allierade.ToLower() == "c" || allierade.ToLower() == "italien")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Italien");
        poang -= 1;


    }

    Console.WriteLine("fråga 6: Vilket år började första världskriget?");
    string ar1vk = Console.ReadLine();

    if (ar1vk == "1914")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var 1914");
        poang -= 1;
    }

    Console.WriteLine("fråga 7: Vilket år slutade första världskriget?");
    string ar1vkslut = Console.ReadLine();

    if (ar1vkslut == "1918")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var 1918");
        poang -= 1;
    }

    Console.WriteLine("fråga 8: Vilket land skapade den första fungerande stridsvagnen?");
    string stridsvagn = Console.ReadLine();

    if (stridsvagn.ToLower() == "storbritannien" || stridsvagn.ToLower() == "england" || stridsvagn.ToLower() == "uk")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Storbritannien");
        poang -= 1;
    }

    Console.WriteLine("fråga 9: Vilket land var först med att införa allmän rösträtt?");
    string rostratt = Console.ReadLine();

    if (rostratt.ToLower() == "nya zeeland" || rostratt.ToLower() == "new zealand")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Nya Zeeland");
        poang -= 1;
    }

    Console.WriteLine("Bonus fråga: Vilken kung i Sverige införde den så kallade reduktionspolitiken, där adeln fick lämna tillbaka mycket av den mark de tidigare fått i gåvor?\n A. Gustav Vasa\nB. Karl XI\nC. Gustav III\nD. Karl XII");
    string reduktion = Console.ReadLine();





    Console.WriteLine("fråga 10: Vilket land förlorade ett väpnat krig mot fåglar?");
    string krig = Console.ReadLine();

    if (krig.ToLower() == "australien" || krig.ToLower() == "australia")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Australien");
        poang -= 1;
    }

    Console.WriteLine("fråga 11: Vem var den första kejsaren av det tysk-romerska riket?");
    string kejsare = Console.ReadLine();

    if (kejsare.ToLower() == "otto den store" || kejsare.ToLower() == "otto" || kejsare.ToLower() == "otto 1")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Otto den store");
        poang -= 1;
    }

    Console.WriteLine("fråga 12: Vilket samvälde försvann från kartan mellan 1772 och 1795 som sedan återvände år 1918?");
    string samvalde = Console.ReadLine();

    if (samvalde.ToLower() == "polen" || samvalde.ToLower() == "polska samväldet")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Polen");
        poang -= 1;
    }

    Console.WriteLine("fråga 13: Vilket land var först med att använda gevär?");
    string gevär = Console.ReadLine();

    if (gevär.ToLower() == "kina" || gevär.ToLower() == "kineserna")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Kina");
        poang -= 1;
    }

    Console.WriteLine("fråga 14: Vilket århundrade inträffade den franska revolutionen?");
    string arhundrade = Console.ReadLine();

    if (arhundrade.ToLower() == "1700-talet" || arhundrade.ToLower() == "18-talet" || arhundrade.ToLower() == "1700talet" || arhundrade.ToLower() == "18talet")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var 1700-talet");
        poang -= 1;
    }

    Console.WriteLine("fråga 15: Vem var den första presidenten i USA?");
    string presidentusa = Console.ReadLine();

    if (presidentusa.ToLower() == "george washington" || presidentusa.ToLower() == "washington" || presidentusa.ToLower() == "george")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var George Washington");
        poang -= 1;
    }

    Console.WriteLine("fråga 16: Välj svaret som stämmer in på följande fråga\nVilket år började den amerikanska inbördeskriget?\nA. 1903\nB. 1882\nC. 1861\nD. 1796");
    string inborskrig = Console.ReadLine();

    switch (inborskrig)
    {
        case "1861":
            Console.WriteLine("Rätt svar!");

            poang += 1;

            break;
        case "1796":
        case "1882":
        case "1903":
            Console.WriteLine("Fel svar, det var 1861");
            poang -= 1;
            break;
        default:
            Console.WriteLine("Det var inte ett giltigt svar, försök igen");

            while (true)
            {
                Console.WriteLine("Välj svaret som stämmer in på följande fråga\nVilket år började den amerikanska inbördeskriget?\nA. 1903\nB. 1882\nC. 1861\nD. 1796");
                inborskrig = Console.ReadLine();
                if (inborskrig == "1861")
                {
                    Console.WriteLine("Rätt svar!");
                    poang += 1;
                    break;
                }
                else if (inborskrig == "1796" || inborskrig == "1882" || inborskrig == "1903")
                {
                    Console.WriteLine("Fel svar, det var 1861");
                    poang -= 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Det var inte ett giltigt svar, försök igen");
                }
            }
            break;
    }


    Console.WriteLine("fråga 17: Vad hette projektet som utvecklade atombomben ?");
    string atombomb = Console.ReadLine();
    if (atombomb.ToLower() == "manhattanprojektet" || atombomb.ToLower() == "manhattan projektet" || atombomb.ToLower() == "manhattan")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Manhattanprojektet");
        poang -= 1;
    }

    Console.WriteLine("fråga 18: Vilket årtionde inträffade den industriella revolutionen?");
    string industriella = Console.ReadLine();

    if (industriella.ToLower() == "1760-talet" || industriella.ToLower() == "1760talet")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var 1760-talet");
        poang -= 1;
    }

    Console.WriteLine("fråga 19: Vem var den första människan att sätta sin fot på månen?\n A. Buzz Aldrin\nB. Neil Armstrong\nC. Michael Collins\nD. Yuri Gagarin");
    string neilarmstrong = Console.ReadLine();

    if (neilarmstrong == "B" || neilarmstrong == "b" || neilarmstrong.ToLower() == "neil armstrong" || neilarmstrong.ToLower() == "armstrong" || neilarmstrong.ToLower() == "neil")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var Neil Armstrong");
        poang -= 1;
    }

    for (int forsok = 0; forsok < 10; forsok++)
    {



        Console.WriteLine("Bonus fråga: Vilket årtal skapades internet?\n Du får 5 poäng om du svarar rätt på denna fråga men du förlorar 3 poäng om du svarar fel!");
        string internet = Console.ReadLine();
        int internetTal = Convert.ToInt32(internet);
        if (internetTal == 1969)
        {
            Console.WriteLine("Rätt svar!");
            break;
            poang += 5;
        }
        else if (internetTal > 1969 && internetTal < 1980)
        {
            Console.WriteLine("Lite för högt, men nära skjuter ingen hare!\nFörsök igen!");
        }
        else if (internetTal < 1969 && internetTal > 1900)
        {
            Console.WriteLine("Lite för lågt, skjut lite högre!\nFörsök igen!");
        }
        else if (internetTal >= 1980 || internetTal <= 1900)
        {
            Console.WriteLine("Oj, det där var väldigt långt ifrån!\nFörsök igen!");
        }
        else
        {
            Console.WriteLine("Fel svar, det var 1960-talet");
            poang -= 3;
        }
    }

    Console.WriteLine("fråga 20: Vilket år föll berlinmuren?");
    string berlinmur = Console.ReadLine();

    if (berlinmur == "1989")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var 1989");
        poang -= 1;
    }

    Console.WriteLine($"Grattis {namn}, du har fått {poang} poäng!");
    if (poang >= 30)
    {
        Console.WriteLine("Wow, du är ett riktigt historia proffs!");
    }
    else if (poang >= 20 && poang < 30)
    {
        Console.WriteLine("Bra jobbat, du har ganska bra koll på historia!");
    }
    else if (poang >= 10 && poang < 20)
    {
        Console.WriteLine("Inte illa,du har viss koll på historia!");
    }
    else if (poang >= 0 && poang < 10)
    {
        Console.WriteLine("Du kanske borde läsa lite mer om historia!");
    }
    else if (poang < 0)
    {
        Console.WriteLine("Oj, du fick minus poäng!\nDu borde verkligen läsa mer om historia!");
    }
    Console.WriteLine($"Tack för att du spelade min frågesport {namn}!\nHoppas du hade kul!");
    Console.WriteLine("Vill du återgå till huvudmenyn?");
    Console.WriteLine("====================");
    Console.WriteLine("=        Ja        =");
    Console.WriteLine("=        Nej       =");
    Console.WriteLine("====================");

    string huvudmeny = Console.ReadLine();
    if (huvudmeny.ToLower() == "ja" || huvudmeny.ToLower() == "ja!")
    {
        Console.WriteLine("Återgår till huvudmenyn...");
        Thread.Sleep(6000);
        continue;
    }
    else
    {
        Console.WriteLine("Avslutar spelet...");
        exit = true;
        break;
    }


}
        



// using System.Threading;
// int counter = 1;

// while (counter <= 20)
// {
//     Console.WriteLine(counter);
//     counter++;

//     Thread.Sleep(1000);
    
    
// }
// for(int i = 60; i >= 0; i -= 1)
//     {
//         Console.WriteLine(i);
//         Thread.Sleep(1000);
//     }

// Console.WriteLine("Välkommen!");

// Console.WriteLine("Vad heter du?");
// string name = Console.ReadLine();

// Console.WriteLine($"Hej ditt namn {name}.\nSkriv ett heltal");

// string inm1 = Console.ReadLine();
// int tal1 = Convert.ToInt32(inm1);
// // int tal1 = Convert.ToInt32(inm1);

// Console.WriteLine($"Vad blir {tal1}- 5?");

// int corrAns = tal1 - 5;

// int talSvar = Convert.ToInt32(Console.ReadLine());

// if (talSvar == corrAns)
// {
//     Console.WriteLine("Rätt svar!");
// }
// else
// {
//     Console.WriteLine("Fel svar");
// }

// Random rand = new Random();
// int slump = rand.Next(1, 11);

// Console.WriteLine("Jag tänkte på ett tal mellan 1 och 10?");

// int gissning = 0;

// while (gissning != slump)
// {
//     gissning = Convert.ToInt32(Console.ReadLine());
//     if (gissning == slump)
//     {
//         Console.WriteLine("Rätt svar!");
//     }
//     else
//     {
//         Console.WriteLine("Fel svar, gissa igen.");
//     }
// }


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