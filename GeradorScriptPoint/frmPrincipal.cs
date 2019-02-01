using Logic.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorScriptPoint
{
    public partial class frmPrincipal : MetroForm
    {
        public string _diretorioArquivo;
        public string _nomeDB;
        public ScriptPointVM _scriptPointVM;
        public frmPrincipal()
        {
            InitializeComponent();
            
            _scriptPointVM = new ScriptPointVM();
            _scriptPointVM.CodigosScriptPointsExistentes = new List<int>();
            _scriptPointVM.GrupoScriptPoints = new List<GrupoScriptPoint>();
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(1, "Identificacao"));
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(2, "Lacuna"));
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(3, "MenuPrincipal"));
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(4, "Saudacao"));
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(5, "PerdaRoubo"));
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(6, "Cancelamento"));
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(7, "Financeiro"));
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(8, "MenuFinanciamento"));
            _scriptPointVM.GrupoScriptPoints.Add(CriarGrupoScriptPoint(9, "ProdutosEServicos"));
        }


        #region Eventos
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AtivarDesativarTela(false);
        }
        
        private void btnSelecionarMapa_Click(object sender, EventArgs e)
        {
            openFileDialogMapaSP.ShowDialog();
        }

        private void openFileDialogMapaSP_FileOk(object sender, CancelEventArgs e)
        {
            _diretorioArquivo = openFileDialogMapaSP.FileNames[0];
            txtArquivoMapaSP.Text = _diretorioArquivo;
        }
        
        private void btnTraduzir_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrEmpty(txtBancoModelado.Text))
            {
                MensagemAoUsuario("Favor informar o nome do banco modelado do Atende!", "Banco de dados", MessageBoxIcon.Exclamation);
                return;
            }
            else if (string.IsNullOrEmpty(txtArquivoMapaSP.Text))
            {
                MensagemAoUsuario("Favor selecionar o arquivo de Mapa Script Point!", "Selecionar Mapa Script Point", MessageBoxIcon.Exclamation);
                return;
            }
            PreencherCodigosScriptPointsExistentes();
            _nomeDB = txtBancoModelado.Text;
            ChamarGeradorScript();
        }
        
        private void btnDuvida_Click(object sender, EventArgs e)
        {
            new Duvidas(this).ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new Info(this).ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovaTraducao_Click(object sender, EventArgs e)
        {
            txtArquivoMapaSP.Clear();
            txtBancoModelado.Clear();
            txtErrosEncontrados.Clear();
            txtMigration.Clear();
            txtTraducaoMapa.Clear();
            txtTraducaoSQL.Clear();
            lblQtdeSP.Text = "";
            AtivarDesativarTela(false);
        }

        private void btnCopiarClipboard_Click(object sender, EventArgs e)
        {
            CopiarInformacoesDaAbaParaClipboard();
        }
        #endregion //Fim de Eventos
        

        public void AtivarDesativarTela(bool ativar)
        {
            this.Tabs.Enabled = ativar;
            this.lblQtdeSP.Visible = ativar;
            if (ativar)
            {
                this.lblQtdeSP.ForeColor = Color.Black;
            }
            else
            {
                this.lblQtdeSP.ForeColor = Color.SlateGray;
            }
        }

        private void QuantidadeScriptPoints(int qtdeValidos, int qtdeComErro)
        {
            if (qtdeValidos > 0 && qtdeComErro > 0)
            {
                lblQtdeSP.Text = string.Format("Foi localizado {0} script point(s) válidos e também foi localizado {1} script point(s) com erro!", qtdeValidos, qtdeComErro);
            }
            else if (qtdeValidos <= 0 && qtdeComErro > 0)
            {
                lblQtdeSP.Text = string.Format("Foi localizado {0} script point(s) com erro e nenhum script point válido!", qtdeComErro);
            }
            else
            {
                lblQtdeSP.Text = string.Format("Foi localizado {0} script point(s) válido(s) e nenhum script point com erro!", qtdeComErro);
            }
        }

        private void ChamarGeradorScript()
        {
            frmCarregandoDadosPlanilha frmCarregarDados = new frmCarregandoDadosPlanilha(this);
            frmCarregarDados.ShowDialog();
            PreencherVM();
        }

        private void PreencherVM()
        {
            txtTraducaoMapa.Text = _scriptPointVM.TraducaoMapa;
            txtMigration.Text = _scriptPointVM.TraducaoMigration;
            txtErrosEncontrados.Text = _scriptPointVM.TraducaoErrosEncontrados;
            txtTraducaoSQL.Text = _scriptPointVM.TraducaoSQL;
            QuantidadeScriptPoints(_scriptPointVM.QuantidadeScriptPointValidos, _scriptPointVM.QuantidadeScriptPointComErro);
            AtivarDesativarTela(true);
        }

        private void MensagemAoUsuario(string Mensagem, string Titulo, MessageBoxIcon tipoIcon)
        {
            MessageBox.Show(Mensagem, Titulo, MessageBoxButtons.OK, tipoIcon);
        }
        
        private void CopiarInformacoesDaAbaParaClipboard()
        {
            if (Tabs.SelectedTab == tabPageTraducaoMapa)
            {
                Clipboard.SetText(txtTraducaoMapa.Text);
            }
            else if (Tabs.SelectedTab == tabPageMigration)
            {
                Clipboard.SetText(txtMigration.Text);
            }
            else if (Tabs.SelectedTab == tabPageSQL)
            {
                Clipboard.SetText(txtTraducaoSQL.Text);
            }
            else
            {
                Clipboard.SetText(txtErrosEncontrados.Text);
            }
        }

        private void btnAddGrupoScriptPoint_Click(object sender, EventArgs e)
        {
            int codigoScriptPoint;
            bool testeInt = int.TryParse(txtCodigoScriptPoint.Text, out codigoScriptPoint);

            if (string.IsNullOrEmpty(txtNomeScriptPoint.Text)
                || string.IsNullOrEmpty(txtCodigoScriptPoint.Text)
                || !testeInt)
            {
                MensagemAoUsuario("Preencha corretamente as informações do Grupo Script Point!", "Grupo Script Point", MessageBoxIcon.Exclamation);
                return;
            }

            listGrupoScriptPoint.Items.Add(string.Format("{0} - {1}", txtCodigoScriptPoint.Text, txtNomeScriptPoint.Text));
            _scriptPointVM.GrupoScriptPoints.Add(new GrupoScriptPoint()
            {
                Codigo = codigoScriptPoint,
                Grupo = txtNomeScriptPoint.Text
            });

            txtNomeScriptPoint.Clear();
            txtCodigoScriptPoint.Clear();
        }

        private GrupoScriptPoint CriarGrupoScriptPoint(int codigo, string grupo)
        {
            var _grupo = new GrupoScriptPoint()
            {
                Codigo = codigo,
                Grupo = grupo
            };

            listGrupoScriptPoint.Items.Add(string.Format("{0} - {1}", codigo, grupo));

            return _grupo;
        }

        private void PreencherCodigosScriptPointsExistentes()
        {
            string codigos = txtCodigosScriptPointsExistentes.Text.Replace("\r", "-").Replace("\n", ""); 
            var lista = codigos.Split('-');
            foreach (var item in lista)
            {
                _scriptPointVM.CodigosScriptPointsExistentes.Add(int.Parse(item));
            }
        }
    }
}
