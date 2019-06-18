using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    interface ISigorta:IBes
    {
        void SigortaDurumu();
        void PrimDurumu();

        //Interface üzerinde method govdeleri bos birakilmak zorundadır.


    }
}
