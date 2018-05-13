using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    class Interseccion
    {
        private Interseccion _derecha;
        private Interseccion _izquierda;
        private Interseccion _arriba;
        private Interseccion _abajo;
        public Interseccion derecha { get { return _derecha; } set { _derecha = value; } }
        public Interseccion iquierda { get { return _izquierda; } set { _izquierda = value; } }
        public Interseccion arriba { get { return _arriba; } set {  _arriba = value; } }
        public Interseccion abajo { get { return _abajo; } set { _abajo = value; } }
        private System.Drawing.Point _p;
        public System.Drawing.Point p { get { return _p; } }
        public Interseccion(int x, int y)
        {
            _p.X = x;
            _p.Y = y;
        }
    }
}
