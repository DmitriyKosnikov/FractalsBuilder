using System;
using System.Collections.Generic;
using System.Text;

namespace FractalsDrawer
{
    /// <summary>
    /// Базовый класс для фракталов.
    /// </summary>
    public class Fractal
    {
        private int maxRec = 10;
        public virtual void Draw() { }

    }
}
