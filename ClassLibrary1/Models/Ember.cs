using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1.Models
{
    public class Ember
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age{ get; set; }
        public string Country { get; set; }
        public string Job { get; set; }
        public string Hobby { get; set; }


        public Ember(string sor)
        {
            string[] emberek = sor.Split(';');

            Name = emberek[0];
            Age = Convert.ToInt32(emberek[1]);
            Country = emberek[2];
            Job = emberek[3];
            Hobby = emberek[4];
        }

        public Ember()
        {
        }

        public override string? ToString()
        {
            return $"{this.Name},{this.Age},{this.Country},{this.Job},{this.Hobby}";
        }
    }
    
}

