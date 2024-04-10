using ClassLibrary1.Data;
using ClassLibrary1.Models;

namespace Program

{
    static public class Program
    {
        static void KiIr(IEnumerable<object> adatok)
        {
            foreach (var item in adatok)
                Console.WriteLine(item);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {

            EmberContext db = new EmberContext();

            if (!db.Emberek.Any())
            {
                var sorok = File.ReadAllLines(@"c:\adat\6.csv").Skip(1);
                foreach (var line in sorok)
                    db.Emberek.Add(new Ember(line));
                db.SaveChanges();
            }

            KiIr(db.Emberek);
            
        }
    }
}

