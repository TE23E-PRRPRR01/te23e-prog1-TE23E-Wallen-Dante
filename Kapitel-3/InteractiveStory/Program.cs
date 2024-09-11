Console.Clear();

Console.WriteLine("Du vaknar upp, helt förvirrad, mitt i ett stort rum. Du ser en dörr på ena sidan av rummet. Vill du öppna dörren? (y/n)");
string answer = Console.ReadLine();
if (answer == "y")
{
    Console.WriteLine("Du öppnar dörren och går ut. Du är i Saint Victorian London, men saker ser inte ut som normalt. Plötsligt stängs dörren bakom dig. Du hoppar till, och blir rädd. På andra sidan gatan står en stenängelstaty. Du tittar på den. Funderar på om du ska närma dig den. Vill du gå närmre? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Du går fram till statyn och ser att den håller i ett brev. Du tittar dig omkring, men ingen annan människa är i närheten. Du skäms över dina egna tankar, men är nyfiken på vad som står i kuvertet. Vill du ta kuvertet från statyns hand? (y/n)");
        answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine(@"Kära vän, jag är ledsen att jag inte kan vara där för att ge dig detta brev personligen. Staden är i fara, och du är den enda som kan stoppa det. Du måste sätta i nyckeln i statyn, nyckeln du fann i det här kuvertet. Lycka till.
            
            Du tittar på statyn och ser att den har ett nyckelhål i ryggen. Vill du sätta in nyckeln? (y/n)");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("Du sätter in nyckeln i nyckehålet och vrider om. Du skjuts bakåt av en underlig kraft, och statyn börjar sväva. Sekunder går och den explorerar och ett starkt ljus bländer dina ögon. När ljuset försvinner ser du att alla människor är tillbaka på gatan. Du har räddat staden. Grattis!");
            }
            else
            {
                Console.WriteLine("Du tittar på nyckeln och funderar på om du ska sätta in den. Du bestämmer dig för att inte göra det och går därifrån. Du går tillbaka till dörren och försöker öppna den men lyckas inte. Det du inte visste var att det redan var för sent. Statyn bakom dig börjar sväva och ögonen lyser rött. Det sista som du märker av i medvetande är att två röda strålar från ögonen på statyn träffar ditt hjärta och du somnar in. Slut.");
            }
        }
        else
        {
            Console.WriteLine("Du tittar runt om dig och funderar över vart alla kan ha tagit vägen. Du beslutar dig till slut för att ta en tupplur och sova; Dock vaknade du aldrig upp igen. Slut.");
        }
    }

    else
    {
        Console.WriteLine("Istället för att närma dig statyn som skrämmer dig från avstånd så vänder du dig mot dörren du precis kom ut ifrån. Det måste ju finnas nåt sätt att öppna den på, tänkte du. Du rycker i handtaget men ingenting fungerar. Efter några minuters försökande vänder du dig om. Statyn har flyttats närmre dig, och sträcker nu kuvertet mot dig, som en gåva. Du blir rädd, men nyfiken. Du funderar på om du ska gå fram och ta kuvertet från statyns hand. Vad gör du? Går du fram? (y/s)");
        answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine("Du går fram till statyn och observerar kuvertet och statyn noggrant. Du skäms över dina egna tankar, men är nyfiken på vad som står i kuvertet. Vill du ta kuvertet från statyns hand? (y/n)");
            answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine(@"Kära vän, jag är ledsen att jag inte kan vara där för att ge dig detta brev personligen. Staden är i fara, och du är den enda som kan stoppa det. Du måste sätta i nyckeln i statyn, nyckeln du fann i det här kuvertet. Lycka till.
            
            Du tittar på statyn och ser att den har ett nyckelhål i ryggen. Vill du sätta in nyckeln? (y/n)");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("Du sätter in nyckeln i nyckehålet och vrider om. Du skjuts bakåt av en underlig kraft, och statyn börjar sväva. Sekunder går och den explorerar och ett starkt ljus bländer dina ögon. När ljuset försvinner ser du att alla människor är tillbaka på gatan. Du har räddat staden. Grattis!");
                }
                else
                {
                    Console.WriteLine("Du tittar på nyckeln och funderar på om du ska sätta in den. Du bestämmer dig för att inte göra det och går därifrån. Du går tillbaka till dörren och försöker öppna den men lyckas inte. Det du inte visste var att det redan var för sent. Statyn bakom dig börjar sväva och ögonen lyser rött. Det sista som du märker av i medvetande är att två röda strålar från ögonen på statyn träffar ditt hjärta och du somnar in. Slut.");
                }
            }
        }
    }
}
