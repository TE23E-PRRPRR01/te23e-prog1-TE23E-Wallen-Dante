Console.Clear();

List<String> listaKombinationer = ["A0", "B3", "C4", "D8", "E9"];
Console.WriteLine($"Fem kombinationer är {string.Join(", ", listaKombinationer)}");

List<int> listaSiffror = [10, 20, 30, 40, 50, 60];
Console.WriteLine($"Fem siffror är '{string.Join("', '", listaSiffror)}'");

List<String> listaSpråk = ["Svenska", "Tyska", "Fuska", "Kinesiska", "Engelska"];
Console.WriteLine($"Fem kombinationer är {string.Join(", ", listaSpråk)}");

Console.WriteLine($"Första språket av {listaSpråk.Count}: " + listaSpråk.First());
Console.WriteLine($"Sista språket av {listaSpråk.Count}: " + listaSpråk.Last());

List<string> listaKortnummer = ["1234 5678 9012 3456", "2345 6789 0123 4567", "3456 7890 1234 5678", "4567 8901 2345 6789", "5678 9012 3456 7890"];