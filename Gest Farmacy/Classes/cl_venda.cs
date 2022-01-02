using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace M17.GestFarmacy.cl_venda
{
    class cl_venda
    {
        public DataView view;

     

        public cl_venda() {
           
        }

        public cl_venda(DataView view)
        {
            // TODO: Complete member initialization
            this.view = view;
        }


        public DataView Retorno() {

            return this.view;
        
        }

    }
}
