using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDependencyInjectionExample.Model
{
    public class B
    {

        private readonly A _aService;

        public B(A a) {

            this._aService = a;

        }
    }
}
