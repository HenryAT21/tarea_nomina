using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmVisor : Form
    {
        public frmVisor(string nombre_reporte)
        {
            InitializeComponent();
            //Clase de Crystal Report para manejar los datos en el crystalReportViewer
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(nombre_reporte);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
