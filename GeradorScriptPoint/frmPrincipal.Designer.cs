namespace GeradorScriptPoint
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDuvida = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtArquivoMapaSP = new MetroFramework.Controls.MetroTextBox();
            this.btnSelecionarMapa = new System.Windows.Forms.Button();
            this.openFileDialogMapaSP = new System.Windows.Forms.OpenFileDialog();
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabPageTraducaoMapa = new MetroFramework.Controls.MetroTabPage();
            this.txtTraducaoMapa = new MetroFramework.Controls.MetroTextBox();
            this.tabPageMigration = new MetroFramework.Controls.MetroTabPage();
            this.txtMigration = new MetroFramework.Controls.MetroTextBox();
            this.tabPageSQL = new MetroFramework.Controls.MetroTabPage();
            this.txtTraducaoSQL = new MetroFramework.Controls.MetroTextBox();
            this.tabPageErrosEncontrados = new MetroFramework.Controls.MetroTabPage();
            this.txtErrosEncontrados = new MetroFramework.Controls.MetroTextBox();
            this.lblQtdeSP = new MetroFramework.Controls.MetroLabel();
            this.txtBancoModelado = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnNovaTraducao = new System.Windows.Forms.Button();
            this.btnCopiarClipboard = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigoScriptPoint = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeScriptPoint = new MetroFramework.Controls.MetroTextBox();
            this.listGrupoScriptPoint = new System.Windows.Forms.ListBox();
            this.btnAddGrupoScriptPoint = new System.Windows.Forms.Button();
            this.txtCodigosScriptPointsExistentes = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPageTraducaoMapa.SuspendLayout();
            this.tabPageMigration.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.tabPageErrosEncontrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Indigo;
            this.metroPanel1.Controls.Add(this.btnInfo);
            this.metroPanel1.Controls.Add(this.btnDuvida);
            this.metroPanel1.Controls.Add(this.btnFechar);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, -1);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1328, 57);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInfo.BackgroundImage = global::GeradorScriptPoint.Properties.Resources.info2;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(972, 13);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(32, 31);
            this.btnInfo.TabIndex = 30;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDuvida
            // 
            this.btnDuvida.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDuvida.BackgroundImage = global::GeradorScriptPoint.Properties.Resources.duvidas_8;
            this.btnDuvida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDuvida.FlatAppearance.BorderSize = 0;
            this.btnDuvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuvida.Location = new System.Drawing.Point(1029, 13);
            this.btnDuvida.Name = "btnDuvida";
            this.btnDuvida.Size = new System.Drawing.Size(32, 31);
            this.btnDuvida.TabIndex = 29;
            this.btnDuvida.UseVisualStyleBackColor = false;
            this.btnDuvida.Click += new System.EventHandler(this.btnDuvida_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFechar.BackgroundImage = global::GeradorScriptPoint.Properties.Resources.fechar4;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1082, 13);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 31);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Indigo;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroLabel1.Location = new System.Drawing.Point(20, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(391, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tradutor de Mapa Script Point para C# e SQL";
            // 
            // txtArquivoMapaSP
            // 
            this.txtArquivoMapaSP.Location = new System.Drawing.Point(114, 202);
            this.txtArquivoMapaSP.Name = "txtArquivoMapaSP";
            this.txtArquivoMapaSP.ReadOnly = true;
            this.txtArquivoMapaSP.Size = new System.Drawing.Size(502, 28);
            this.txtArquivoMapaSP.TabIndex = 1;
            // 
            // btnSelecionarMapa
            // 
            this.btnSelecionarMapa.BackColor = System.Drawing.Color.DarkGray;
            this.btnSelecionarMapa.FlatAppearance.BorderSize = 0;
            this.btnSelecionarMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarMapa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarMapa.Location = new System.Drawing.Point(15, 202);
            this.btnSelecionarMapa.Name = "btnSelecionarMapa";
            this.btnSelecionarMapa.Size = new System.Drawing.Size(93, 28);
            this.btnSelecionarMapa.TabIndex = 2;
            this.btnSelecionarMapa.Text = "Selecionar";
            this.btnSelecionarMapa.UseVisualStyleBackColor = false;
            this.btnSelecionarMapa.Click += new System.EventHandler(this.btnSelecionarMapa_Click);
            // 
            // openFileDialogMapaSP
            // 
            this.openFileDialogMapaSP.FileName = "MapaScriptPoint";
            this.openFileDialogMapaSP.Title = "Selecionar arquivo XSLX do Mapa de SP";
            this.openFileDialogMapaSP.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogMapaSP_FileOk);
            // 
            // Tabs
            // 
            this.Tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Tabs.Controls.Add(this.tabPageTraducaoMapa);
            this.Tabs.Controls.Add(this.tabPageMigration);
            this.Tabs.Controls.Add(this.tabPageSQL);
            this.Tabs.Controls.Add(this.tabPageErrosEncontrados);
            this.Tabs.Location = new System.Drawing.Point(11, 295);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1101, 351);
            this.Tabs.Style = MetroFramework.MetroColorStyle.Silver;
            this.Tabs.TabIndex = 11;
            this.Tabs.UseStyleColors = true;
            // 
            // tabPageTraducaoMapa
            // 
            this.tabPageTraducaoMapa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPageTraducaoMapa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageTraducaoMapa.Controls.Add(this.txtTraducaoMapa);
            this.tabPageTraducaoMapa.HorizontalScrollbarBarColor = true;
            this.tabPageTraducaoMapa.Location = new System.Drawing.Point(4, 38);
            this.tabPageTraducaoMapa.Name = "tabPageTraducaoMapa";
            this.tabPageTraducaoMapa.Size = new System.Drawing.Size(1093, 309);
            this.tabPageTraducaoMapa.TabIndex = 0;
            this.tabPageTraducaoMapa.Text = "Tradução do Mapa";
            this.tabPageTraducaoMapa.VerticalScrollbarBarColor = true;
            // 
            // txtTraducaoMapa
            // 
            this.txtTraducaoMapa.Location = new System.Drawing.Point(5, 3);
            this.txtTraducaoMapa.Multiline = true;
            this.txtTraducaoMapa.Name = "txtTraducaoMapa";
            this.txtTraducaoMapa.ReadOnly = true;
            this.txtTraducaoMapa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTraducaoMapa.Size = new System.Drawing.Size(1079, 302);
            this.txtTraducaoMapa.TabIndex = 2;
            // 
            // tabPageMigration
            // 
            this.tabPageMigration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageMigration.Controls.Add(this.txtMigration);
            this.tabPageMigration.HorizontalScrollbarBarColor = true;
            this.tabPageMigration.Location = new System.Drawing.Point(4, 38);
            this.tabPageMigration.Name = "tabPageMigration";
            this.tabPageMigration.Size = new System.Drawing.Size(1093, 309);
            this.tabPageMigration.TabIndex = 1;
            this.tabPageMigration.Text = "Migration";
            this.tabPageMigration.VerticalScrollbarBarColor = true;
            // 
            // txtMigration
            // 
            this.txtMigration.Location = new System.Drawing.Point(5, 3);
            this.txtMigration.Multiline = true;
            this.txtMigration.Name = "txtMigration";
            this.txtMigration.ReadOnly = true;
            this.txtMigration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMigration.Size = new System.Drawing.Size(1079, 302);
            this.txtMigration.TabIndex = 3;
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageSQL.Controls.Add(this.txtTraducaoSQL);
            this.tabPageSQL.HorizontalScrollbarBarColor = true;
            this.tabPageSQL.Location = new System.Drawing.Point(4, 38);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Size = new System.Drawing.Size(1093, 309);
            this.tabPageSQL.TabIndex = 2;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.VerticalScrollbarBarColor = true;
            // 
            // txtTraducaoSQL
            // 
            this.txtTraducaoSQL.Location = new System.Drawing.Point(5, 3);
            this.txtTraducaoSQL.Multiline = true;
            this.txtTraducaoSQL.Name = "txtTraducaoSQL";
            this.txtTraducaoSQL.ReadOnly = true;
            this.txtTraducaoSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTraducaoSQL.Size = new System.Drawing.Size(1079, 302);
            this.txtTraducaoSQL.TabIndex = 3;
            // 
            // tabPageErrosEncontrados
            // 
            this.tabPageErrosEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageErrosEncontrados.Controls.Add(this.txtErrosEncontrados);
            this.tabPageErrosEncontrados.HorizontalScrollbarBarColor = true;
            this.tabPageErrosEncontrados.Location = new System.Drawing.Point(4, 38);
            this.tabPageErrosEncontrados.Name = "tabPageErrosEncontrados";
            this.tabPageErrosEncontrados.Size = new System.Drawing.Size(1093, 309);
            this.tabPageErrosEncontrados.TabIndex = 3;
            this.tabPageErrosEncontrados.Text = "Erros Encontrados";
            this.tabPageErrosEncontrados.VerticalScrollbarBarColor = true;
            // 
            // txtErrosEncontrados
            // 
            this.txtErrosEncontrados.Location = new System.Drawing.Point(5, 3);
            this.txtErrosEncontrados.Multiline = true;
            this.txtErrosEncontrados.Name = "txtErrosEncontrados";
            this.txtErrosEncontrados.ReadOnly = true;
            this.txtErrosEncontrados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrosEncontrados.Size = new System.Drawing.Size(1079, 302);
            this.txtErrosEncontrados.TabIndex = 3;
            // 
            // lblQtdeSP
            // 
            this.lblQtdeSP.AutoSize = true;
            this.lblQtdeSP.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblQtdeSP.Location = new System.Drawing.Point(15, 647);
            this.lblQtdeSP.Name = "lblQtdeSP";
            this.lblQtdeSP.Size = new System.Drawing.Size(82, 25);
            this.lblQtdeSP.TabIndex = 13;
            this.lblQtdeSP.Text = "SP Valido";
            // 
            // txtBancoModelado
            // 
            this.txtBancoModelado.Location = new System.Drawing.Point(15, 110);
            this.txtBancoModelado.Name = "txtBancoModelado";
            this.txtBancoModelado.Size = new System.Drawing.Size(601, 28);
            this.txtBancoModelado.TabIndex = 14;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(15, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(189, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Banco de dados modelado";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 90);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(106, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Nome do banco";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(15, 155);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(129, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Mapa Script Point";
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTraduzir.FlatAppearance.BorderSize = 0;
            this.btnTraduzir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraduzir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraduzir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTraduzir.Location = new System.Drawing.Point(15, 253);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(134, 28);
            this.btnTraduzir.TabIndex = 26;
            this.btnTraduzir.Text = "Traduzir";
            this.btnTraduzir.UseVisualStyleBackColor = false;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(15, 180);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(275, 19);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Selecionar o mapa script point para tradução";
            // 
            // btnNovaTraducao
            // 
            this.btnNovaTraducao.BackColor = System.Drawing.Color.Brown;
            this.btnNovaTraducao.FlatAppearance.BorderSize = 0;
            this.btnNovaTraducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaTraducao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaTraducao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovaTraducao.Location = new System.Drawing.Point(773, 253);
            this.btnNovaTraducao.Name = "btnNovaTraducao";
            this.btnNovaTraducao.Size = new System.Drawing.Size(139, 28);
            this.btnNovaTraducao.TabIndex = 28;
            this.btnNovaTraducao.Text = "Nova tradução";
            this.btnNovaTraducao.UseVisualStyleBackColor = false;
            this.btnNovaTraducao.Click += new System.EventHandler(this.btnNovaTraducao_Click);
            // 
            // btnCopiarClipboard
            // 
            this.btnCopiarClipboard.BackColor = System.Drawing.Color.DimGray;
            this.btnCopiarClipboard.FlatAppearance.BorderSize = 0;
            this.btnCopiarClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarClipboard.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarClipboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCopiarClipboard.Location = new System.Drawing.Point(928, 253);
            this.btnCopiarClipboard.Name = "btnCopiarClipboard";
            this.btnCopiarClipboard.Size = new System.Drawing.Size(180, 28);
            this.btnCopiarClipboard.TabIndex = 29;
            this.btnCopiarClipboard.Text = "Copiar para o clipboard";
            this.btnCopiarClipboard.UseVisualStyleBackColor = false;
            this.btnCopiarClipboard.Click += new System.EventHandler(this.btnCopiarClipboard_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(644, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 19);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Grupo de Script Point";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(644, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "Código";
            // 
            // txtCodigoScriptPoint
            // 
            this.txtCodigoScriptPoint.Location = new System.Drawing.Point(644, 110);
            this.txtCodigoScriptPoint.Name = "txtCodigoScriptPoint";
            this.txtCodigoScriptPoint.Size = new System.Drawing.Size(61, 28);
            this.txtCodigoScriptPoint.TabIndex = 31;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(731, 90);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(106, 19);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Nome do grupo";
            // 
            // txtNomeScriptPoint
            // 
            this.txtNomeScriptPoint.Location = new System.Drawing.Point(731, 110);
            this.txtNomeScriptPoint.Name = "txtNomeScriptPoint";
            this.txtNomeScriptPoint.Size = new System.Drawing.Size(124, 28);
            this.txtNomeScriptPoint.TabIndex = 33;
            // 
            // listGrupoScriptPoint
            // 
            this.listGrupoScriptPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listGrupoScriptPoint.FormattingEnabled = true;
            this.listGrupoScriptPoint.Location = new System.Drawing.Point(644, 151);
            this.listGrupoScriptPoint.Name = "listGrupoScriptPoint";
            this.listGrupoScriptPoint.Size = new System.Drawing.Size(275, 80);
            this.listGrupoScriptPoint.TabIndex = 35;
            // 
            // btnAddGrupoScriptPoint
            // 
            this.btnAddGrupoScriptPoint.BackColor = System.Drawing.Color.DimGray;
            this.btnAddGrupoScriptPoint.FlatAppearance.BorderSize = 0;
            this.btnAddGrupoScriptPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGrupoScriptPoint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrupoScriptPoint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddGrupoScriptPoint.Location = new System.Drawing.Point(866, 110);
            this.btnAddGrupoScriptPoint.Name = "btnAddGrupoScriptPoint";
            this.btnAddGrupoScriptPoint.Size = new System.Drawing.Size(53, 28);
            this.btnAddGrupoScriptPoint.TabIndex = 36;
            this.btnAddGrupoScriptPoint.Text = "Add";
            this.btnAddGrupoScriptPoint.UseVisualStyleBackColor = false;
            this.btnAddGrupoScriptPoint.Click += new System.EventHandler(this.btnAddGrupoScriptPoint_Click);
            // 
            // txtCodigosScriptPointsExistentes
            // 
            this.txtCodigosScriptPointsExistentes.Location = new System.Drawing.Point(952, 110);
            this.txtCodigosScriptPointsExistentes.Multiline = true;
            this.txtCodigosScriptPointsExistentes.Name = "txtCodigosScriptPointsExistentes";
            this.txtCodigosScriptPointsExistentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodigosScriptPointsExistentes.Size = new System.Drawing.Size(156, 121);
            this.txtCodigosScriptPointsExistentes.TabIndex = 37;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(952, 66);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(156, 19);
            this.metroLabel9.TabIndex = 38;
            this.metroLabel9.Text = "Script Point Existentes";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(952, 88);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(112, 19);
            this.metroLabel10.TabIndex = 39;
            this.metroLabel10.Text = "Códigos existente";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 682);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtCodigosScriptPointsExistentes);
            this.Controls.Add(this.btnAddGrupoScriptPoint);
            this.Controls.Add(this.listGrupoScriptPoint);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtNomeScriptPoint);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtCodigoScriptPoint);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnCopiarClipboard);
            this.Controls.Add(this.btnNovaTraducao);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtBancoModelado);
            this.Controls.Add(this.lblQtdeSP);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.btnSelecionarMapa);
            this.Controls.Add(this.txtArquivoMapaSP);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabPageTraducaoMapa.ResumeLayout(false);
            this.tabPageMigration.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.tabPageErrosEncontrados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtArquivoMapaSP;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionarMapa;
        private System.Windows.Forms.OpenFileDialog openFileDialogMapaSP;
        private MetroFramework.Controls.MetroTabControl Tabs;
        private MetroFramework.Controls.MetroTabPage tabPageTraducaoMapa;
        private MetroFramework.Controls.MetroTextBox txtTraducaoMapa;
        private MetroFramework.Controls.MetroTabPage tabPageMigration;
        private MetroFramework.Controls.MetroTextBox txtMigration;
        private MetroFramework.Controls.MetroTabPage tabPageSQL;
        private MetroFramework.Controls.MetroTextBox txtTraducaoSQL;
        private MetroFramework.Controls.MetroTabPage tabPageErrosEncontrados;
        private MetroFramework.Controls.MetroTextBox txtErrosEncontrados;
        private MetroFramework.Controls.MetroLabel lblQtdeSP;
        private MetroFramework.Controls.MetroTextBox txtBancoModelado;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Button btnTraduzir;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Button btnNovaTraducao;
        private System.Windows.Forms.Button btnDuvida;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCopiarClipboard;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCodigoScriptPoint;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNomeScriptPoint;
        private System.Windows.Forms.ListBox listGrupoScriptPoint;
        private System.Windows.Forms.Button btnAddGrupoScriptPoint;
        private MetroFramework.Controls.MetroTextBox txtCodigosScriptPointsExistentes;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}

