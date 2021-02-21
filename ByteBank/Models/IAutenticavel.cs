using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Models
{
    public interface IAutenticavel
    {

         bool Autenticar(string senha);
        
    }
}
