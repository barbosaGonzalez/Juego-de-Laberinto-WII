using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto
{
    class Lab
    {
        public Interseccion[] p = new Interseccion[41];       
        public Lab()
        {
            p[1] = new Interseccion(-1, 12);            
            p[2] = new Interseccion(208,12);
            p[1].derecha = p[2]; p[2].iquierda = p[1];
            p[3] = new Interseccion(209,169);
            p[2].abajo = p[3]; p[3].arriba = p[2];
            p[4] = new Interseccion(166,169);
            p[3].iquierda = p[4];
            p[5] = new Interseccion(166,49);
            p[6] = new Interseccion(166,211);
            p[4].derecha = p[3]; p[4].arriba = p[5]; p[5].abajo = p[4]; p[4].abajo = p[6];
            p[7] = new Interseccion(344,169);
            p[7].iquierda = p[3]; p[3].derecha = p[7];
            p[8] = new Interseccion(344, 211);
            p[7].abajo = p[8]; p[8].arriba = p[7];
            p[6].derecha = p[8]; p[8].iquierda = p[6]; p[6].arriba = p[4];
            p[9] = new Interseccion(344,289);
            p[9].arriba = p[8]; p[8].abajo = p[9];
            p[10] = new Interseccion(387, 289);
            p[11] = new Interseccion(387,171);
            p[9].derecha = p[10]; p[10].iquierda = p[9];
            p[10].arriba = p[11]; p[11].abajo = p[10];
            p[12] = new Interseccion(387, 331);
            p[13] = new Interseccion(347, 331);
            p[14] = new Interseccion(347,371);
            p[15] = new Interseccion(308, 371);
            p[16] = new Interseccion(308, 249);
            p[10].abajo = p[12]; p[12].arriba = p[10];
            p[12].iquierda = p[13]; p[13].derecha = p[12];
            p[13].abajo = p[14]; p[14].arriba = p[13];
            p[14].iquierda = p[15]; p[15].derecha = p[14];
            p[15].arriba = p[16]; p[16].abajo = p[15];
            p[17] = new Interseccion(387,411);
            p[18] = new Interseccion(307,411);
            p[19] = new Interseccion(307,531);
            p[20] = new Interseccion(347,531);
            p[21] = new Interseccion(347, 448);
            p[22] = new Interseccion(386, 448);
            p[12].abajo = p[17]; p[17].arriba = p[12];
            p[17].iquierda = p[18]; p[18].derecha = p[17];
            p[18].abajo = p[19]; p[19].arriba = p[18];
            p[19].derecha = p[20]; p[20].iquierda = p[19];
            p[20].arriba = p[21]; p[21].abajo = p[20];
            p[21].derecha = p[22]; p[22].iquierda = p[21];
            p[23] = new Interseccion(547, 331);
            p[12].derecha = p[23]; p[23].iquierda = p[12];
            p[24] = new Interseccion(547, 288);
            p[25] = new Interseccion(587, 288);
            p[26] = new Interseccion(587, 491);
            p[27] = new Interseccion(627, 491);
            p[28] = new Interseccion(627, 369);
            p[29] = new Interseccion(667, 369);
            p[30] = new Interseccion(667, 491);
            p[23].arriba = p[24]; p[24].abajo = p[23];
            p[24].derecha = p[25]; p[25].iquierda = p[24];
            p[25].abajo = p[26]; p[26].arriba = p[25];
            p[26].derecha = p[27]; p[27].iquierda = p[26];
            p[27].arriba = p[28]; p[28].abajo = p[27];
            p[28].derecha = p[29]; p[29].iquierda = p[28];
            p[29].abajo = p[30]; p[30].arriba = p[29];
            p[31] = new Interseccion(547, 369);
            p[23].abajo = p[31]; p[31].arriba = p[23];
            p[32] = new Interseccion(547, 488);
            p[33] = new Interseccion(506, 488);
            p[34] = new Interseccion(506, 411);            
            p[35] = new Interseccion(467, 411);
            p[31].abajo = p[32]; p[32].arriba = p[31];
            p[32].iquierda = p[33]; p[33].derecha = p[32];
            p[33].arriba = p[34]; p[34].abajo = p[33];
            p[34].iquierda = p[35]; p[35].derecha = p[34];
            p[36] = new Interseccion(428, 371);
            p[37] = new Interseccion(428, 451);
            p[38] = new Interseccion(468, 453);
            p[39] = new Interseccion(468, 528);
            p[40] = new Interseccion(667,531);
            p[31].iquierda = p[36]; p[36].derecha = p[31];
            p[36].abajo = p[37]; p[37].arriba = p[36];
            p[37].derecha = p[38]; p[38].iquierda = p[37];
            p[38].abajo = p[39]; p[39].arriba = p[38];
            p[39].derecha = p[40]; 




        }
        public Interseccion moverIzquierda(Interseccion aux)
        {
            aux = aux.iquierda;
            return aux;
        }
        public Interseccion moverDerecha(Interseccion aux)
        {
            aux = aux.derecha;
            return aux;
        }
        public Interseccion moverArriba(Interseccion aux)
        {
            aux = aux.arriba;
            return aux;
        }
        public Interseccion moverAbajo(Interseccion aux)
        {
            aux = aux.abajo;
            return aux;
        }
    }
}
