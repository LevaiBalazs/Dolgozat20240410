using Szamla;

Szamlak sz1 =new Szamlak("1",200,"Aladár",DateTime.Parse("2024.04.06"));
Szamlak sz2 =new Szamlak("2",3000,"Aladár",DateTime.Parse("2024.04.07"));

Console.WriteLine(sz1);

sz1.TotalAmount();