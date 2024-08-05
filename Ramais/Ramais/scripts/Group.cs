using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramais.scripts
{
    public class Group
    {
        public string Name { get; private set; }

        public Group(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Nome é Obrigatorio");
            }

        }


    }    
}
