using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class DummyIRenderer:IRender
    {
        public void Render()
        {
            Console.WriteLine("Open Dummy Running");
        }
    }
}
