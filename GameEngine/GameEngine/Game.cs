using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Game : IGame
    {
        private IRenderer m_renderer;

        // Constructor
        Game( IRenderer renderer )
        {
            m_renderer = renderer;
        }

        public void Render()
        {
            m_renderer.Render();
        }
    }
}
