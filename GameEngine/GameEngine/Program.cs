using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenGLRender renderer = new OpenGLRender();
            Game GE = new Game(renderer);
        }
    }
}
