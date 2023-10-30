using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lp_webService_consumeApps;

namespace lp_webService_consumeApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Instancia global para la hacer referencia al WebService (WS)
        consumirApps.WebService1SoapClient consumidor = new consumirApps.WebService1SoapClient();
        
        // Evento para abrir la aplicación de Notepad++
        private void btnNotepadPLUSPLUS_Click(object sender, EventArgs e)
        {
            string notepad = "notepad++.exe";
            consumidor.NotepadPlusPlus(notepad);
        }

        private void btnCPUZ_Click(object sender, EventArgs e)
        {
            string cpuz = "cpuz.exe";
            consumidor.CPUz(cpuz);
        }

        private void btnBrave_Click(object sender, EventArgs e)
        {
            string brave = "brave.lnk";
            consumidor.Brave(brave);
        }

        private void btnJFLAP_Click(object sender, EventArgs e)
        {
            string jflap = "jflap.jar";
            consumidor.JFLAP(jflap);
        }

        private void btnWinRAR_Click(object sender, EventArgs e)
        {
            string winrar = "winrar.exe";
            consumidor.WinRAR(winrar);
        }
    }
}
