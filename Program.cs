using System.Diagnostics;
using System.Threading;
Console.WriteLine("======================================");
Console.WriteLine("=        Frågesport! Advanced        =");
Console.WriteLine("=        Press Enter to Start        =");
Console.WriteLine("======================================");
Console.ReadLine();

bool exit = false;
Random thread = new Random();

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
            int waiting = thread.Next(4000, 35000);
            if (waiting > 15000)
            {
                waiting = 15000;
            }
            
             string dots = ".";
            for (int i = 0; i < waiting; i += 1000)
            {
                Console.Clear();
                if (dots.Length == 4)
                {
                    dots = ".";
                }

                Console.Write("Loading" + dots);
                dots += ".";
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("ERR_CONNECTION_TIMED_OUT\nAnledning: Spelet tog för lång tid att svara.");
            Thread.Sleep(5000);
            Console.Clear();
            if(waiting == 15000)
            {
                continue;
            }


            int hintsLeft = 5;

            while (true)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("=         Välkommen till min         =");
                Console.WriteLine("=             Frågesport             =");
                Console.WriteLine("=        Välj ett alternativ:        =");
                Console.WriteLine("=              Historia              =");
                Console.WriteLine("=               Gaming               =");
                Console.WriteLine("======================================");

                string amne = Console.ReadLine();
                if (amne.ToLower() == "historia")
                {
                    break;
                }
                else if (amne.ToLower() == "gaming")
                {
                    Console.WriteLine("Tyvärr, detta ämne är inte tillgängligt ännu!");
                    Thread.Sleep(2500);
                    Console.WriteLine("Vänligen välj historia istället.");
                    Thread.Sleep(2500);
                    continue;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val, vänligen välj historia istället.");
                    Thread.Sleep(4000);
                    continue;
                }
            }


            Console.WriteLine("Hej!");
            Thread.Sleep(1000);
            Console.WriteLine("Välkommen till frågesporten om historia!");
            Thread.Sleep(2000);

            Console.WriteLine("Först och främst...");
            Thread.Sleep(2000);
            Console.WriteLine("Vad heter du?");

            string namn = Console.ReadLine();
            Console.WriteLine($"Hej {namn}!");
            Thread.Sleep(2000);
            Console.WriteLine("Kul att du vill spela min frågesport!");
            Thread.Sleep(2000);
            Console.WriteLine("Är du redo att börja?");

            string svar = Console.ReadLine();
            if (svar.ToLower() == "ja" || svar.ToLower() == "ja!")
            {
                Console.WriteLine("Toppen! Då kör vi igång!");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Okej, säg till när du är redo!");
                Console.ReadLine();
                Console.WriteLine("Toppen! Då kan vi köra igång!");
                Thread.Sleep(2000);
            }

            Console.WriteLine("Du kommer att få svara på 30 frågor om ämnet historia.");
            Thread.Sleep(3000);
            Console.WriteLine("För varje rätt svar får du 1 poäng samt förlora en poäng för varje fel svar!");
            Thread.Sleep(3500);
            Console.WriteLine("Har du förstått spelreglerna?");
            string regler = Console.ReadLine();
            int poang = 0;

            if (regler.ToLower() == "ja" || regler.ToLower() == "ja!")
                if (regler.ToLower() == "nej" || regler.ToLower() == "nej!")
                {
                    Console.WriteLine("Okej, jag förklarar igen!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Du kommer att få svara på 30 frågor om ämnet historia.");
                    Thread.Sleep(3000);
                    Console.WriteLine("För varje rätt svar får du 1 poäng samt förlora en poäng för varje fel svar!");
                    Thread.Sleep(3500);
                    Console.WriteLine("Har du förstått spelreglerna nu?");
                }
            if (regler.ToLower() == "ja" || regler.ToLower() == "ja!")

            {
                Console.WriteLine("Toppen! Då kör vi igång!");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Okej, jag förklarar igen!");
                Thread.Sleep(2000);
                Console.WriteLine("Du kommer att få svara på 30 frågor om ämnet historia.");
                Thread.Sleep(3000);
                Console.WriteLine("För varje rätt svar får du 1 poäng samt förlora en poäng för varje fel svar!");
                Thread.Sleep(3500);
                Console.WriteLine("Har du förstått spelreglerna nu?");
                string regler2 = Console.ReadLine();
                if (regler2.ToLower() == "ja" || regler2.ToLower() == "ja!")
                {
                    Console.WriteLine("Toppen! Då kör vi igång!");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Okej, jag förklarar en sista gång!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Du kommer att få svara på 30 frågor om ämnet historia.");
                    Thread.Sleep(3000);
                    Console.WriteLine("För varje rätt svar får du 1 poäng samt förlora en poäng för varje fel svar!");
                    Thread.Sleep(3500);
                    Console.WriteLine("Hoppas du har förstått nu, annars får du fråga någon annan om hjälp.");
                    Thread.Sleep(3500);
                }
            }

            Console.WriteLine("Jag kommer vara snäll med att inte ge dig minus poäng på den första frågan ifall du svarar fel\nLycka till!");
            Thread.Sleep(8000);


            Console.WriteLine("Fråga 1: Rysslands första president var Vladimir Putin?");
            Thread.Sleep(2000);
            Console.WriteLine("Sant eller Falskt?");
            string president = Console.ReadLine();

            if (president.ToLower() == "falskt" || president.ToLower() == "falsk " || president.ToLower() == "false")
            {
                Console.WriteLine("Rätt svar! Rysslands första president var Boris Jeltsin");
                Thread.Sleep(2000);


                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Boris Jeltsin");
                Thread.Sleep(2000);
            }


            Console.WriteLine("Fråga 2: Vad hette Ryssland under andra världskriget?");
            string land = Console.ReadLine();
            if (land.ToLower() == "sovjetunionen" || land.ToLower() == "sovjet")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det hette Sovjetunionen");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("Fråga 3: Vilket årtionde inträffade andra världskriget?");
            string artionde = Console.ReadLine();
            if (artionde == "1940-talet" || artionde == "40-talet" || artionde == "1940talet" || artionde == "40talet" || artionde.ToLower() == "sent 1930-tal" || artionde.ToLower() == "1930-talet" || artionde.ToLower() == "1930 talet" || artionde.ToLower() == " sena 1930-talet"
            )
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var 1940-talet");
                Thread.Sleep(2000);
                poang -= 1;
            }


            {
                Console.WriteLine("fråga 4: Vem var tysklands rikskansler mellan år 1930 och 1932?");
                if (hintsLeft > 0)
                {
                    Console.WriteLine($"Du har {hintsLeft} ledtrådar kvar. Vill du använda en? (ja/nej)");
                    string useHint = Console.ReadLine();
                    if (useHint.ToLower() == "ja" || useHint.ToLower() == "ja!")
                    {
                        Console.WriteLine("Ledtråd: Han var medlem i Centrumpartiet och tjänstgjorde som rikskansler under Weimarrepubliken.");
                        hintsLeft--;
                    }
                    else if (useHint.ToLower() == "nej" || useHint.ToLower() == "no")
                    {
                        Console.WriteLine("Okej, ingen ledtråd använd.");
                        Thread.Sleep(2000);
                    }
                }
                string kansler = Console.ReadLine();
                if (kansler.ToLower() == "heinrich brüning" || kansler.ToLower() == "brüning" || kansler.ToLower() == "heinrich" || kansler.ToLower() == "heinrich bruning")
                {
                    Console.WriteLine("Rätt svar!");
                    Thread.Sleep(2000);
                    poang += 1;

                }
                else
                {
                    Console.WriteLine("Fel svar, det var Heinrich Brüning");
                    Thread.Sleep(2000);
                    poang -= 1;
                }
            }

            {
                Console.WriteLine("fråga 5: Vilket av de följande länderna var med de allierade under första världskriget?\nA. Tyskland\nB. Österrike-Ungern\nC. Italien\nD. Osmanska riket");
                if (hintsLeft > 0)
                {
                    Console.WriteLine($"Du har {hintsLeft} ledtrådar kvar. Vill du använda en? (ja/nej)");
                    string useHint = Console.ReadLine();
                    if (useHint.ToLower() == "ja" || useHint.ToLower() == "ja!")
                    {
                        Console.WriteLine("Ledtråd: Detta land är känt för sin rika kultur, konst och mat.");
                        Thread.Sleep(3000);
                        hintsLeft--;
                    }
                    else if (useHint.ToLower() == "nej" || useHint.ToLower() == "no")
                    {
                        Console.WriteLine("Okej, ingen ledtråd använd.");
                        Thread.Sleep(2000);
                    }
                }
                string allierade = Console.ReadLine();
                if (allierade.ToLower() == "c" || allierade.ToLower() == "italien")
                {
                    Console.WriteLine("Rätt svar!");
                    Thread.Sleep(2000);
                    poang += 1;
                }
                else
                {
                    Console.WriteLine("Fel svar, det var Italien");
                    Thread.Sleep(2000);
                    poang -= 1;


                }
            }

            Console.WriteLine("fråga 6: Vilket år började första världskriget?");
            string ar1vk = Console.ReadLine();

            if (ar1vk == "1914")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var 1914");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 7: Vilket år slutade första världskriget?");
            string ar1vkslut = Console.ReadLine();

            if (ar1vkslut == "1918")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var 1918");
                Thread.Sleep(2000);
                poang -= 1;
            }

            {
                Console.WriteLine("fråga 8: Vilket land skapade den första fungerande stridsvagnen?");
                if (hintsLeft > 0)
                {
                    Console.WriteLine($"Du har {hintsLeft} ledtrådar kvar. Vill du använda en? (ja/nej)");
                    string useHint = Console.ReadLine();
                    if (useHint.ToLower() == "ja" || useHint.ToLower() == "ja!")
                    {
                        Console.WriteLine("Ledtråd: Ett europeiskt imperium under första världskriget — deras tidiga modell kallades Mark I");
                        Thread.Sleep(4500);
                        hintsLeft--;
                    }
                    else if (useHint.ToLower() == "nej" || useHint.ToLower() == "no")
                    {
                        Console.WriteLine("Okej, ingen ledtråd använd.");
                        Thread.Sleep(2000);
                    }
                }

                string stridsvagn = Console.ReadLine();

                if (stridsvagn.ToLower() == "storbritannien" || stridsvagn.ToLower() == "england" || stridsvagn.ToLower() == "uk")
                {
                    Console.WriteLine("Rätt svar!");
                    Thread.Sleep(2000);
                    poang += 1;
                }
                else
                {
                    Console.WriteLine("Fel svar, det var Storbritannien");
                    Thread.Sleep(2000);
                    poang -= 1;
                }

            }

            {
                Console.WriteLine("fråga 9: Vilket land var först med att införa allmän rösträtt?");
                if (hintsLeft > 0)
                {
                    Console.WriteLine($"Du har {hintsLeft} ledtrådar kvar. Vill du använda en? (ja/nej)");
                    string useHint = Console.ReadLine();
                    if (useHint.ToLower() == "ja" || useHint.ToLower() == "ja!")
                    {
                        Console.WriteLine("Ledtråd: Detta land är känt för sina stora berg, fjordar och är en av världens mest isolerade platser.");
                        Thread.Sleep(5000);
                        hintsLeft--;
                    }
                    else if (useHint.ToLower() == "nej" || useHint.ToLower() == "no")
                    {
                        Console.WriteLine("Okej, ingen ledtråd använd.");
                        Thread.Sleep(2000);
                    }
                }

                string rostratt = Console.ReadLine();
                if (rostratt.ToLower() == "nya zeeland" || rostratt.ToLower() == "new zealand")
                {
                    Console.WriteLine("Rätt svar!");
                    Thread.Sleep(2000);
                    poang += 1;
                }
                else
                {
                    Console.WriteLine("Fel svar, det var Nya Zeeland");
                    Thread.Sleep(2000);
                    poang -= 1;
                }
            }

            Console.WriteLine("Bonus fråga: Vilken kung i Sverige införde den så kallade reduktionspolitiken,");
            Thread.Sleep(5000);
            Console.WriteLine("där adeln fick lämna tillbaka mycket av den mark de tidigare fått i gåvor?");
            Thread.Sleep(5000);
            Console.WriteLine("Du får 5 poäng om du svarar rätt på denna fråga men du kommer att förlora 3 poäng om du svarar fel!");
            Thread.Sleep(5000);
            Console.WriteLine("A. Gustav Vasa\nB. Karl XI\nC. Gustav III\nD. Karl XII");
            string reduktion = Console.ReadLine();

            if (reduktion.ToLower() == "b" || reduktion.ToLower() == "karl xi" || reduktion.ToLower() == "karl 11" || reduktion.ToLower() == "karl den elfte")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 5;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Karl XI");
                Thread.Sleep(2000);
                poang -= 3;
            }

            Console.WriteLine("fråga 10: Vilket land förlorade ett väpnat krig mot fåglar?");
            if (hintsLeft > 0)
            {
                Console.WriteLine($"Du har {hintsLeft} ledtrådar kvar. Vill du använda en? (ja/nej)");
                string useHint = Console.ReadLine();
                if (useHint.ToLower() == "ja" || useHint.ToLower() == "ja!")
                {
                    Console.WriteLine("Ledtråd: Detta land är störst i Oceanien och kändes för sin unika fauna.");
                    Thread.Sleep(3500);
                    hintsLeft--;
                }
                    else if (useHint.ToLower() == "nej" || useHint.ToLower() == "no")
                    {
                        Console.WriteLine("Okej, ingen ledtråd använd.");
                        Thread.Sleep(2000);
                    }
            }

            string krig = Console.ReadLine();

            if (krig.ToLower() == "australien" || krig.ToLower() == "australia")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Australien");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 11: Vem var den första kejsaren av det tysk-romerska riket?");
            if (hintsLeft > 0)
            {
                Console.WriteLine($"Du har {hintsLeft} ledtrådar kvar. Vill du använda en? (ja/nej)");
                string useHint = Console.ReadLine();
                if (useHint.ToLower() == "ja" || useHint.ToLower() == "ja!")
                {
                    Console.WriteLine("Ledtråd: Han var kung av Tyskland och blev kejsare år 962.");
                    Thread.Sleep(3000);
                    hintsLeft--;
                }
                    else if (useHint.ToLower() == "nej" || useHint.ToLower() == "no")
                    {
                        Console.WriteLine("Okej, ingen ledtråd använd.");
                        Thread.Sleep(2000);
                    }
            }

            string kejsare = Console.ReadLine();

            if (kejsare.ToLower() == "otto den store" || kejsare.ToLower() == "otto" || kejsare.ToLower() == "otto 1")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Otto den store");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 12: Vilket samvälde försvann från kartan mellan 1772 och 1795 som sedan återvände år 1918?");
            if (hintsLeft > 0)
            {
                Console.WriteLine($"Du har {hintsLeft} ledtrådar kvar. Vill du använda en? (ja/nej)");
                string useHint = Console.ReadLine();
                if (useHint.ToLower() == "ja" || useHint.ToLower() == "ja!")
                {
                    Console.WriteLine("Ledtråd: Detta land är störst i Europa och har en rik historia med kejsardömmen och upprorestider.");
                    Thread.Sleep(3500);
                    hintsLeft--;
                }
                    else if (useHint.ToLower() == "nej" || useHint.ToLower() == "no")
                    {
                        Console.WriteLine("Okej, ingen ledtråd använd.");
                        Thread.Sleep(2000);
                    }
            }

            string samvalde = Console.ReadLine();

            if (samvalde.ToLower() == "polen" || samvalde.ToLower() == "polska samväldet")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Polen");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 13: Vilket land var först med att använda gevär?");
            if (hintsLeft > 0)
            {
                Console.WriteLine($"Du har {hintsLeft} ledtrådar kvar. Vill du använda en? (ja/nej)");
                string useHint = Console.ReadLine();
                if (useHint.ToLower() == "ja" || useHint.ToLower() == "ja!")
                {
                    Console.WriteLine("Ledtråd: Landet där krutet först uppfanns");
                    Thread.Sleep(3000);
                    hintsLeft--;
                }
                    else if (useHint.ToLower() == "nej" || useHint.ToLower() == "no")
                    {
                        Console.WriteLine("Okej, ingen ledtråd använd.");
                        Thread.Sleep(2000);
                    }
            }

            string gevär = Console.ReadLine();

            if (gevär.ToLower() == "kina" || gevär.ToLower() == "kineserna")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Kina");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 14: Vilket århundrade inträffade den franska revolutionen?");
            string arhundrade = Console.ReadLine();

            if (arhundrade.ToLower() == "1700-talet" || arhundrade.ToLower() == "18-talet" || arhundrade.ToLower() == "1700talet" || arhundrade.ToLower() == "18talet")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var 1700-talet");
                Thread.Sleep(2000);
                poang -= 1;

            }

            Console.WriteLine("fråga 15: Vem var den första presidenten i USA?");
            string presidentusa = Console.ReadLine();

            if (presidentusa.ToLower() == "george washington" || presidentusa.ToLower() == "washington" || presidentusa.ToLower() == "george")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var George Washington");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 16: Välj svaret som stämmer in på följande fråga\nVilket år började det amerikanska inbördeskriget?\n1903\n1882\n1861\n1796");
            string inborskrig = Console.ReadLine();

            switch (inborskrig)
            {
                case "1861":
                    Console.WriteLine("Rätt svar!");
                    Thread.Sleep(2000);
                    poang += 1;

                    break;

                case "1796":
                case "1882":
                case "1903":
                    Console.WriteLine("Fel svar, det var 1861");
                    Thread.Sleep(2000);
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
                            Thread.Sleep(2000);
                            poang += 1;
                            break;
                        }
                        else if (inborskrig == "1796" || inborskrig == "1882" || inborskrig == "1903")
                        {
                            Console.WriteLine("Fel svar, det var 1861");
                            Thread.Sleep(2000);
                            poang -= 1;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Det var inte ett giltigt svar, försök igen");
                            Thread.Sleep(2000);
                        }
                    }
                    break;
            }


            Console.WriteLine("fråga 17: Vad hette projektet som utvecklade atombomben ?");
            string atombomb = Console.ReadLine();
            if (atombomb.ToLower() == "manhattanprojektet" || atombomb.ToLower() == "manhattan projektet" || atombomb.ToLower() == "manhattan")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Manhattanprojektet");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 18: Vilket årtionde inträffade den industriella revolutionen?");
            string industriella = Console.ReadLine();

            if (industriella.ToLower() == "1760-talet" || industriella.ToLower() == "1760talet")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var 1760-talet");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 19: Vem var den första människan att sätta sin fot på månen?\nA. Buzz Aldrin\nB. Neil Armstrong\nC. Michael Collins\nD. Yuri Gagarin");
            string neilarmstrong = Console.ReadLine();

            if (neilarmstrong == "B" || neilarmstrong == "b" || neilarmstrong.ToLower() == "neil armstrong" || neilarmstrong.ToLower() == "armstrong" || neilarmstrong.ToLower() == "neil")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Neil Armstrong");
                Thread.Sleep(2000);
                poang -= 1;
            }

            int forsok = 0;
            while (forsok < 10)
            {

                Console.WriteLine("Bonus fråga: Vilket årtal skapades internet?\n Du får 5 poäng om du svarar rätt på denna fråga men du förlorar 3 poäng om du svarar fel!");
                string internet = Console.ReadLine();
                int internetTal;
                if (!int.TryParse(internet, out internetTal))
                {
                    Console.WriteLine("Ogiltigt svar, vänligen ange ett årtal i siffror.");
                    continue;
                }
                forsok++;

                if (internetTal == 1969)
                {
                    Console.WriteLine("Rätt svar!");
                    Thread.Sleep(2000);
                    poang += 5;
                    break;
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
                    Thread.Sleep(2000);
                    poang -= 3;
                }
            }

            Console.WriteLine("fråga 20: Vilket år föll berlinmuren?");
            string berlinmur = Console.ReadLine();

            if (berlinmur == "1989")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var 1989");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 21: Vem var den första kvinnliga premiärministern i Storbritannien?");
            Thread.Sleep(5000);
            Console.WriteLine("A. Theresa May\nB. Margaret Thatcher\nC. Elizabeth II\nD. Angela Merkel");
            string premiarministern = Console.ReadLine();
            if (premiarministern.ToLower() == "margaret thatcher" || premiarministern.ToLower() == "thatcher" || premiarministern.ToLower() == "margaret" || premiarministern.ToLower() == "b")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var Margaret Thatcher");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine("fråga 22: Vilket år inträffade den ryska revolutionen?");
            string ryska = Console.ReadLine();
            if (ryska == "1917")
            {
                Console.WriteLine("Rätt svar!");
                Thread.Sleep(2000);
                poang += 1;
            }
            else
            {
                Console.WriteLine("Fel svar, det var 1917");
                Thread.Sleep(2000);
                poang -= 1;
            }

            Console.WriteLine($"Grattis {namn}, du har fått {poang} poäng!");
            Thread.Sleep(2000);
            if (poang >= 30 && poang <= 40)
            {
                Console.WriteLine("Wow, du är ett riktigt historia proffs!");
                Thread.Sleep(2000);
            }
            else if (poang >= 20 && poang < 30)
            {
                Console.WriteLine("Bra jobbat, du har ganska bra koll på historia!");
                Thread.Sleep(2000);
            }
            else if (poang >= 10 && poang < 20)
            {
                Console.WriteLine("Inte illa, du har viss koll på historia!");
                Thread.Sleep(2000);
            }
            else if (poang >= 0 && poang < 10)
            {
                Console.WriteLine("Du kanske borde läsa lite mer om historia!");
                Thread.Sleep(2000);
            }
            else if (poang < 0)
            {
                Console.WriteLine("Oj, du fick minus poäng!\nDu borde verkligen läsa mer om historia!");
                Thread.Sleep(3500);
            }
            bool startover = false;
            bool exitgame = false;
            while (!exitgame)
            {
                Console.WriteLine($"Tack för att du spelade min frågesport {namn}!\nHoppas du hade kul!");
                Thread.Sleep(3000);
                Console.WriteLine("Vill du återgå till huvudmenyn?");
                Thread.Sleep(2000);

                Console.WriteLine("===============================");
                Console.WriteLine("=             Ja              =");
                Console.WriteLine("=             Nej             =");
                Console.WriteLine("===============================");

                string huvudmeny = Console.ReadLine();
                if (huvudmeny.ToLower() == "ja" || huvudmeny.ToLower() == "ja!")
                {
                    Console.WriteLine("Återgår till huvudmenyn...");
                    Thread.Sleep(3000);
                    exitgame = true;
                    startover = true;

                }
                else if (huvudmeny.ToLower() == "nej" || huvudmeny.ToLower() == "nej!")
                {
                    Console.WriteLine("Avslutar spelet...");
                    exit = true;
                    exitgame = true;

                }
                else
                {
                    Console.WriteLine("Ogiltigt val, vänligen välj ett av alternativen");
                    Thread.Sleep(3000);
                }
            }
            if (startover)
            {
                continue;
            }
            break;

        case "unlock cheat":
            Console.WriteLine("Varför vill du låsa upp fusk?");
            Thread.Sleep(2000);
            Console.WriteLine("Spela spelet normalt istället!");
            Thread.Sleep(2000);
            Console.WriteLine("Återgår till huvudmenyn...");
            Thread.Sleep(3000);
            continue;

        case "exit game":
        case "exit":
            Console.WriteLine("Avslutar spelet...");
            exit = true;
            break;

        default:
            Console.WriteLine("Ogiltigt val, försök igen");
            Thread.Sleep(3000);
            continue;
    }
}



// Console.WriteLine("hello world");
// bool go = true;

// while (go == true)
// {
//     Console.WriteLine("Skriv ett alternativ");
//     Console.WriteLine("A. Ett skämt");
//     Console.WriteLine("B. En gåta");
//     Console.WriteLine("C. Avsluta programmet");

//     string val = Console.ReadLine().ToLower();

//     switch (val)
//     {
//         case "a":
//             Console.WriteLine("En nycklad bil kallas för cadillac");
//             break;
//         case "b":
//             for (int x = 1; x <= 5; x++)
//             {
//                 int y = x * x + 4;
//                 Console.WriteLine($"x: {x}\ty: {y}");
//             }
//             break;
//         case "c":
//             go = false;
//             break;
//        }
// }



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