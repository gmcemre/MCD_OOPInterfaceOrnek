using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek
{
    class Ogrenci : Insan, IYetenek1, IYetenek2
    {
        void IYetenek2.A()
        {
            throw new NotImplementedException();
        }

        void IYetenek2.B()
        {
            throw new NotImplementedException();
        }

        // Bir class ve bir interface'ten bir kalıtım almamız gerektiğinde önce class sonra interface yazılır.

        //Bir class bir class'tan kalıtım alır.(Birden fazla olmaz**)
        //Bir class birden çok interface'den kalıtım alabilir.

        void IYetenek1.X()
        {
            throw new NotImplementedException();
        }

        void IYetenek2.X()
        {
            throw new NotImplementedException();
        }

        void IYetenek1.Y()
        {
            throw new NotImplementedException();
        }

        void IYetenek1.Z()
        {
            throw new NotImplementedException();
        }
    }
}
