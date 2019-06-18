using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    public class Doctor : Personal,ISigorta
    {
        public string Profession { get; set; }
        public bool isOperator { get; set; }
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
            Console.WriteLine("eksik yatir");
        }

        public void PrimDurumu()
        {
            Console.WriteLine("eksik yatir");
        }

        public void BESdurumu()
        {
            throw new NotImplementedException();
        }
    }
}
