using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    public abstract class Personal
    {
        //Instance alinamazlar
        //tek basina bir anlami yok
        //kalitim vermek zorunda
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }

        //abstract class içerisinde ki methodlar abstract keywordu ile işaretlenmelidir sebebi ise abstract classlar kalitim vermek zorundadir ve kalitim verdiği sinif içerisinde govdesi doldurulmalıdır.
        public abstract void cocukMasrafi();
        public abstract void Temizlik();
    }
}
