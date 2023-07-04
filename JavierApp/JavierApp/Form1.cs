using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavierApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DeleteAllTxts();
            cbTipoFiltro.SelectedItem = "Usuarios";
        }
        
        private void DeleteAllTxts()
        {
            //foreach (string sFile in Directory.GetFiles(ConfigurationManager.AppSettings["Directory"], "*.txt"))
            //{                
            //    File.Delete(sFile);
            //}
            File.Delete(ConfigurationManager.AppSettings["OutputTXT"]);
            File.Delete(ConfigurationManager.AppSettings["ErrorTXT"]);
        }

        List<string> filtros = new List<string>();
        string tipo;
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (cbTipoFiltro.SelectedItem == null || string.IsNullOrWhiteSpace(tbFiltros.Text))
                return;
            if (string.IsNullOrWhiteSpace(tipo))
            {
                tipo = cbTipoFiltro.SelectedItem.ToString();
                cbTipoFiltro.Enabled = false;
            }

            string filtro;
            switch (tipo)
            {
                case "Usuarios":
                case "Grupos":
                    filtro = tbFiltros.Text.Substring(0, tbFiltros.Text.Length > 8 ? 8 : tbFiltros.Text.Length);
                    break;
                case "Transacciones":
                    filtro = tbFiltros.Text.Substring(0, tbFiltros.Text.Length > 4 ? 4 : tbFiltros.Text.Length);
                    break;
                case "Perfiles":
                    filtro = tbFiltros.Text.Substring(0, tbFiltros.Text.Length > 44 ? 44 : tbFiltros.Text.Length);
                    break;
                default:
                    filtro = "";
                    break;
            }
            filtros.Add(filtro);
            rtbFiltros.Text += filtro + Environment.NewLine;

            tbFiltros.Clear();
            tbFiltros.Focus();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tipo))
            {
                string header = "**" + tipo + "--" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "\\(" + GetIPAddress() + ")";
                WriteTxt(ConfigurationManager.AppSettings["FiltrosTXT"], header, filtros);

                ExecuteBAT();

                ClearAll();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearAll()
        {
            filtros.Clear();
            rtbFiltros.Text = "";
            tbFiltros.Clear();
            tipo = string.Empty;
            cbTipoFiltro.Enabled = true;
        }

        private void WriteTxt(string txtPath, string header, List<string> values)
        {
            if (!File.Exists(txtPath))
            {
                File.Create(txtPath).Close();
            }
            TextWriter clean = new StreamWriter(txtPath);
            clean.Write("");
            clean.Close();

            TextWriter tw = new StreamWriter(txtPath, true);
            if (!string.IsNullOrWhiteSpace(header))
                tw.WriteLine(header);

            foreach (var value in values)
            {
                tw.WriteLine(value);
            }
            tw.Close();
        }

        private void WriteTxt(string txtPath, string header, string value)
        {
            if (!File.Exists(txtPath))
            {
                File.Create(txtPath).Close();
            }
            TextWriter clean = new StreamWriter(txtPath);
            clean.Write("");
            clean.Close();

            TextWriter tw = new StreamWriter(txtPath, true);
            if (!string.IsNullOrWhiteSpace(header))
                tw.WriteLine(header);

            tw.WriteLine(value);
            tw.Close();
        }

        private string GetIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void ExecuteBAT()
        {
            var processInfo = new ProcessStartInfo(ConfigurationManager.AppSettings["FTPBAT"]);

            processInfo.CreateNoWindow = true;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.Start();

            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            WriteTxt(ConfigurationManager.AppSettings["OutputTXT"], "", output);
            string error = process.StandardError.ReadToEnd();
            WriteTxt(ConfigurationManager.AppSettings["ErrorTXT"], "", error);
        }

        private void cbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFiltros.Focus();
        }
    }
}
