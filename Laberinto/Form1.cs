using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiimoteLib;
using System.Threading;
namespace Laberinto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Wiimote wm;
        Lab l;
        Interseccion pelota;    
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            l = new Lab();
            pelota = l.p[1];
            pcbPelota.Location = pelota.p;
            try
            {
                wm = new Wiimote();
            }
            catch (System.IO.IOException ioe)
            {
                Console.WriteLine("No es posible ejecutar la aplicación: " + ioe.Message);
            }            
            try
            {
                wm.Connect();
                wm.SetReportType(InputReport.IRAccel, true);
                wm.WiimoteChanged += new System.EventHandler<WiimoteChangedEventArgs>(wm_WiimoteChanged);
            }
            catch (Exception wnfe)
            {
                Console.WriteLine("No es posible ejecutar la aplicación: " + wnfe.Message);
            }                                    
        }
         
        public void wm_WiimoteChanged(object sender, WiimoteChangedEventArgs args)
        {

            WiimoteState ws = args.WiimoteState;
            ws.IRState.Mode = IRMode.Basic;
            float x=0 , y = 0;
            x = ws.IRState.IRSensors[0].Position.X;
            y = ws.IRState.IRSensors[0].Position.Y;
            if (ws.IRState.IRSensors[0].Found)
            {
                if ((x < 0.3f || x > 0.7f || y < 0.3f || y > 0.7f) && (((x < 0.3f && (y > 0.3f && y < 0.7f)) || (x > 0.7f && (y < 0.7f && y > 0.3f))) || ((y < 0.3f && (x > 0.3f && x < 0.7f)) || (y > 0.7f && (x < 0.7f && x > 0.3f)))))
                {

                    if (x > 0.7f)
                    {
                        //Izq
                        if (pelota.iquierda != null)
                            pelota = l.moverIzquierda(pelota);                        
                    }
                    else if (x < 0.3f)
                    {
                        //der
                        if (pelota.derecha != null)
                            pelota = l.moverDerecha(pelota);                        
                    }
                    else if (y > 0.7f)
                    {
                        //arriba                
                        if (pelota.arriba != null)
                            pelota = l.moverArriba(pelota);                        
                    }
                    else if (y < 0.3f)
                    {
                        //abajo
                        if (pelota.abajo != null)
                            pelota = l.moverAbajo(pelota);                        
                    }
                    pcbPelota.Location = pelota.p;
                    Thread.Sleep(500);
                }
            }            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Up:
                    if (pelota.arriba != null)
                        pelota = l.moverArriba(pelota);
                    break;
                case Keys.Down:
                    if (pelota.abajo != null)
                        pelota = l.moverAbajo(pelota);
                    break;
                case Keys.Left:
                    if (pelota.iquierda != null)
                        pelota = l.moverIzquierda(pelota);
                    break;
                case Keys.Right:
                    if (pelota.derecha != null)
                        pelota = l.moverDerecha(pelota);
                    break;
            }
            pcbPelota.Location = pelota.p;
        }

        private void pcbPelota_Click(object sender, EventArgs e)
        {

        }        
    }
}
