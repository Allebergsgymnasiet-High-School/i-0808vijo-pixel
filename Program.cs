using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
Console.WriteLine("======================================");
Console.WriteLine("=        Frågesport! Advanced        =");
Console.WriteLine("=       Press any key to Start       =");
Console.WriteLine("======================================");
Console.ReadLine();

bool exit = false;

while (!exit)
{
    Console.WriteLine("======================================");
    Console.WriteLine("=             Main Menu:             =");
    Console.WriteLine("======================================");
    Console.ReadLine();

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
            Console.WriteLine("Varför vill du låsa upp fusk?\nSpela spelet normalt!");
            break;

        case "exit game":
            Console.WriteLine("Avslutar spelet...");
            exit = true;
            break;

        default:
            Console.WriteLine("Ogiltigt val, försök igen");
            break;
    }

    if (menu.ToLower() == "start")
    {
        Console.WriteLine("======================================");
        Console.WriteLine("=         Välkommen till min         =");
        Console.WriteLine("=            Frågesport!             =");
        Console.WriteLine("=        Välj ett alternativ:        =");
        Console.WriteLine("=              Historia              =");
        Console.WriteLine("=               Gaming               =");
        Console.WriteLine("======================================");

        string amne = "";
        
        while (amne.ToLower() != "historia")
        {
        if (amne.ToLower() == "gaming")
            Console.WriteLine("Tyvärr, detta ämne är inte tillgängligt ännu!\nVänligen välj historia istället.");
        Console.WriteLine("Vänligen välj ett ämne:");
        amne = Console.ReadLine();
            break;
            
        
        else if (amne.ToLower() != "historia" && amne.ToLower() != "gaming")
            {
                Console.WriteLine("Ogiltigt val, vänligen välj historia istället.");
                break;



            }

    }

    Console.WriteLine("Hej!\nVälkommen till frågesporten om historia!");

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

    Console.WriteLine("fråga 5: Vilka var de allierade under första världskriget?");
    string allierade = Console.ReadLine();

    switch (allierade.ToLower())
    {
        case "storbritannien, frankrike, ryssland och serbien":
        case "storbritannien frankrike ryssland och serbien":
        case "storbritannien, frankrike, ryssland och serbien.":
        case "storbritannien frankrike ryssland och serbien.":
            Console.WriteLine("Rätt svar!");

            poang += 1;

            break;
        case "tyskland, österrike-ungern och osmanska riket":
        case "tyskland österrike-ungern och osmanska riket":
        case "tyskland, österrike-ungern och osmanska riket.":
        case "tyskland österrike-ungern och osmanska riket.":
            Console.WriteLine("Fel svar, det var Storbritannien, Frankrike, Ryssland och Serbien");
            break;
        default:
            Console.WriteLine("Fel svar, det var Storbritannien, Frankrike, Ryssland och Serbien");
            poang -= 1;
            break;
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
            while (inborskrig != "1861" && inborskrig != "1796" && inborskrig != "1882" && inborskrig != "1903")
            {
                Console.WriteLine("Välj svaret som stämmer in på följande fråga\nVilket år började den amerikanska inbördeskriget?\nA. 1903\nB. 1882\nC. 1861\nD. 1796");
                inborskrig = Console.ReadLine();
            }
            break;

    }

    Console.WriteLine("fråga 17: Vem var den sista tsaren av Ryssland?");
    string tsar = Console.ReadLine().ToLower();
    switch (tsar)
    {
        case "nikolaj ii":
        case "nikolaj":
        case "nikolai":
            Console.WriteLine("Rätt svar!");

            poang += 1;

            break;
        case "alexander iii":
        case "alexander":
        case "peter den store":
        case "peter":
            Console.WriteLine("Fel svar, det var Nikolaj II");
            break;
        default:
            Console.WriteLine("Fel svar, det var Nikolaj II");
            poang -= 1;
            break;

    }

    Console.WriteLine("fråga 18: Vilket år inträffade den ryska revolutionen?");
    string ryska = Console.ReadLine();
    if (ryska == "1917")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var 1917");
        poang -= 1;
    }

    Console.WriteLine("Välj svaret som stämmer in på följande fråga\nfråga 19: Vem var den första människan på månen?\nA. Buzz Aldrin\nB. Neil Armstrong\nC. Michael Collins\nD. Yuri Gagarin");
    string manen = Console.ReadLine();

    switch (manen.ToLower())
    {
        case "neil armstrong":
        case "armstrong":
        case "neil":
            Console.WriteLine("Rätt svar!");

            poang += 1;

            break;
        case "buzz aldrin":
        case "aldrin":
        case "buzz":
            Console.WriteLine("Fel svar, det var Neil Armstrong");
            break;
        default:
            Console.WriteLine("Fel svar, det var Neil Armstrong");
            poang -= 1;
            break;

    }
    Console.WriteLine("bonus fråga! Du ska nu få gissa årtiondet för när internet uppfanns!\nOm du gissar rätt får du 5 poäng extra!\nOm du gissar fel förlorar du 3 poäng!\nDu har 5 försök på dig att gissa rätt!\nHar du förstått reglerna?");
    string internet = Console.ReadLine();
    if (internet.ToLower() == "ja" || internet.ToLower() == "ja!")
        if (internet.ToLower() == "nej" || internet.ToLower() == "nej!")
        {
            Console.WriteLine("Okej, jag förklarar igen!\nDu ska nu få gissa årtiondet för när internet uppfanns!\nOm du gissar rätt får du 5 poäng extra!\nOm du gissar fel förlorar du 3 poäng!\nDu har 5 försök på dig att gissa rätt!\nHar du förstått reglerna nu?");
        }
    if (internet.ToLower() == "ja" || internet.ToLower() == "ja!")
        if (internet.ToLower() == "nej" || internet.ToLower() == "nej!")
        {
            Console.WriteLine("Okej, jag förklarar en sista gång!\nDu ska nu få gissa årtiondet för när internet uppfanns!\nOm du gissar rätt får du 5 poäng extra!\nOm du gissar fel förlorar du 3 poäng!\nDu har 5 försök på dig att gissa rätt!\nHoppas du har förstått nu, annars får du fråga någon annan om hjälp.");
        }
    if (internet.ToLower() == "ja" || internet.ToLower() == "ja!")
    {
        Console.WriteLine("Toppen! Då kör vi igång!");
    }
    int forsok = 0;
    while (forsok < 5)
    {
        Console.WriteLine("Vilket årtionde uppfanns internet?");
        string internetar = Console.ReadLine();
        if (internetar.ToLower() == "1960-talet" || internetar.ToLower() == "60-talet" || internetar.ToLower() == "1960talet" || internetar.ToLower() == "60talet")
        {
            Console.WriteLine("Rätt svar! Du får 5 poäng extra!");

            poang += 5;
            break;
        }
        else
        {
            Console.WriteLine("Fel svar, försök igen!");
            forsok += 1;
            if (forsok == 5)
            {
                Console.WriteLine("Tyvärr, du har inga fler försök kvar! Det rätta svaret var 1960-talet! Du förlorar 3 poäng!");
                poang -= 3;
                break;
            }
        }
    }
    Console.WriteLine("fråga 20: Vilket årtionde uppfanns hjulet?");
    string hjulet = Console.ReadLine();
    if (hjulet.ToLower() == "4000-talet f.kr" || hjulet.ToLower() == "4000 f.kr" || hjulet.ToLower() == "4000-talet före kristus" || hjulet.ToLower() == "4000 före kristus" || hjulet.ToLower() == "4000-talet f.kr." || hjulet.ToLower() == "4000 f.kr." || hjulet.ToLower() == "4000-talet före kristus." || hjulet.ToLower() == "4000 före kristus.")
    {
        Console.WriteLine("Rätt svar!");

        poang += 1;
    }
    else
    {
        Console.WriteLine("Fel svar, det var 4000-talet f.Kr");
        poang -= 1;
    }

    Console.WriteLine($"Du fick totalt {poang} poäng av 20 möjliga!");


    Console.WriteLine($"Tack för att du spelade {namn}!\nHoppas du hade kul!");

}










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