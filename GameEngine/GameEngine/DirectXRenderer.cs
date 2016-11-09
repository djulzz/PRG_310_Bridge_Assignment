using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class DirectXRenderer: IRender
    {
        public void Render()
        {
            Console.WriteLine("Open Direct X Running");
        }
    }
}
