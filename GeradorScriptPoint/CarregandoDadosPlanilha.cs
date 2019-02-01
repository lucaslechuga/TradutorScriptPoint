using Logic;
using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace GeradorScriptPoint
{
    public partial class frmCarregandoDadosPlanilha : Form
    {
        private frmPrincipal _frmPrincipal;
        private Logic.Logic _logic;

        public frmCarregandoDadosPlanilha(frmPrincipal ParentForm)
        {
            InitializeComponent();
            _frmPrincipal = ParentForm;
            _logic = new Logic.Logic(_frmPrincipal._diretorioArquivo, _frmPrincipal._nomeDB, _frmPrincipal._scriptPointVM.GrupoScriptPoints, _frmPrincipal._scriptPointVM.CodigosScriptPointsExistentes);
        }

        private void CarregandoDadosPlanilha_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            PreencherScriptPoints();
            Close();
        }

        private void PreencherScriptPoints()
        {
            _frmPrincipal._scriptPointVM = _logic.PreencherScriptPoints();
        }
    }
}
