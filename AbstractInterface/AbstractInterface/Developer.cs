using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    public class Developer : Personal,ISigorta
    {
        public string Profession { get; set; }
        public bool isSenior { get; set; }
        public override void cocukMasrafi()
        {
            throw new NotImplementedException();
        }

        public override void Temizlik()
        {
            throw new NotImplementedException();
        }

        public void SigortaDurumu()
        {
            Console.WriteLine("tam yatir");
        }

        public void PrimDurumu()
        {
            Console.WriteLine("tam yatir");
        }

        public void BESdurumu()
        {
            throw new NotImplementedException();
        }
    }
}
