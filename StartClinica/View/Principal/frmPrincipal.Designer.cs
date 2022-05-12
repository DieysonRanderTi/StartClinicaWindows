
namespace StartClinica
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabMenuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarMes = new MaterialSkin.Controls.MaterialButton();
            this.btnAvancarMes = new MaterialSkin.Controls.MaterialButton();
            this.painelCalendario = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewEventosHome = new System.Windows.Forms.DataGridView();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.rbEventosDeHoje = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbTodoEventos = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.lblMesAno = new MaterialSkin.Controls.MaterialLabel();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnCadastrarCliente = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridViewListaClientes = new System.Windows.Forms.DataGridView();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.tabFinanceiro = new System.Windows.Forms.TabPage();
            this.tabConfiguracoes = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabMenuPrincipal.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventosHome)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenuPrincipal
            // 
            this.tabMenuPrincipal.Controls.Add(this.tabHome);
            this.tabMenuPrincipal.Controls.Add(this.tabClientes);
            this.tabMenuPrincipal.Controls.Add(this.tabEventos);
            this.tabMenuPrincipal.Controls.Add(this.tabFinanceiro);
            this.tabMenuPrincipal.Controls.Add(this.tabConfiguracoes);
            this.tabMenuPrincipal.Depth = 0;
            this.tabMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenuPrincipal.ImageList = this.imageList1;
            this.tabMenuPrincipal.Location = new System.Drawing.Point(3, 64);
            this.tabMenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabMenuPrincipal.Multiline = true;
            this.tabMenuPrincipal.Name = "tabMenuPrincipal";
            this.tabMenuPrincipal.SelectedIndex = 0;
            this.tabMenuPrincipal.Size = new System.Drawing.Size(1175, 632);
            this.tabMenuPrincipal.TabIndex = 5;
            this.tabMenuPrincipal.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabMenuPrincipal_Selecting);
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.label7);
            this.tabHome.Controls.Add(this.label5);
            this.tabHome.Controls.Add(this.label6);
            this.tabHome.Controls.Add(this.label3);
            this.tabHome.Controls.Add(this.label4);
            this.tabHome.Controls.Add(this.label2);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Controls.Add(this.btnVoltarMes);
            this.tabHome.Controls.Add(this.btnAvancarMes);
            this.tabHome.Controls.Add(this.painelCalendario);
            this.tabHome.Controls.Add(this.dataGridViewEventosHome);
            this.tabHome.Controls.Add(this.materialCard1);
            this.tabHome.Controls.Add(this.materialCard5);
            this.tabHome.ImageKey = "casa.png";
            this.tabHome.Location = new System.Drawing.Point(4, 39);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1167, 589);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Domingo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(720, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sábado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(610, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sexta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(499, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quinta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(386, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quarta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(277, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Terça";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Segunda";
            // 
            // btnVoltarMes
            // 
            this.btnVoltarMes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltarMes.AutoSize = false;
            this.btnVoltarMes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoltarMes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVoltarMes.Depth = 0;
            this.btnVoltarMes.HighEmphasis = true;
            this.btnVoltarMes.Icon = null;
            this.btnVoltarMes.Location = new System.Drawing.Point(525, 544);
            this.btnVoltarMes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltarMes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltarMes.Name = "btnVoltarMes";
            this.btnVoltarMes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVoltarMes.Size = new System.Drawing.Size(94, 36);
            this.btnVoltarMes.TabIndex = 5;
            this.btnVoltarMes.Text = "< Voltar";
            this.btnVoltarMes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVoltarMes.UseAccentColor = false;
            this.btnVoltarMes.UseVisualStyleBackColor = true;
            this.btnVoltarMes.Click += new System.EventHandler(this.btnVoltarMes_Click);
            // 
            // btnAvancarMes
            // 
            this.btnAvancarMes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAvancarMes.AutoSize = false;
            this.btnAvancarMes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAvancarMes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAvancarMes.Depth = 0;
            this.btnAvancarMes.HighEmphasis = true;
            this.btnAvancarMes.Icon = null;
            this.btnAvancarMes.Location = new System.Drawing.Point(627, 544);
            this.btnAvancarMes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAvancarMes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAvancarMes.Name = "btnAvancarMes";
            this.btnAvancarMes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAvancarMes.Size = new System.Drawing.Size(94, 36);
            this.btnAvancarMes.TabIndex = 4;
            this.btnAvancarMes.Text = "Avançar >";
            this.btnAvancarMes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAvancarMes.UseAccentColor = false;
            this.btnAvancarMes.UseVisualStyleBackColor = true;
            this.btnAvancarMes.Click += new System.EventHandler(this.btnAvancarMes_Click);
            // 
            // painelCalendario
            // 
            this.painelCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.painelCalendario.Location = new System.Drawing.Point(6, 106);
            this.painelCalendario.Name = "painelCalendario";
            this.painelCalendario.Size = new System.Drawing.Size(841, 429);
            this.painelCalendario.TabIndex = 3;
            // 
            // dataGridViewEventosHome
            // 
            this.dataGridViewEventosHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEventosHome.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEventosHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEventosHome.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEventosHome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEventosHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEventosHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEventosHome.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEventosHome.EnableHeadersVisualStyles = false;
            this.dataGridViewEventosHome.Location = new System.Drawing.Point(849, 117);
            this.dataGridViewEventosHome.Name = "dataGridViewEventosHome";
            this.dataGridViewEventosHome.RowHeadersVisible = false;
            this.dataGridViewEventosHome.RowTemplate.Height = 25;
            this.dataGridViewEventosHome.Size = new System.Drawing.Size(311, 466);
            this.dataGridViewEventosHome.TabIndex = 2;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialTextBox1);
            this.materialCard1.Controls.Add(this.rbEventosDeHoje);
            this.materialCard1.Controls.Add(this.rbTodoEventos);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(849, 15);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(311, 93);
            this.materialCard1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(209, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Pesquisar";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(208, 33);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(86, 50);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // rbEventosDeHoje
            // 
            this.rbEventosDeHoje.AutoSize = true;
            this.rbEventosDeHoje.Depth = 0;
            this.rbEventosDeHoje.Location = new System.Drawing.Point(81, 25);
            this.rbEventosDeHoje.Margin = new System.Windows.Forms.Padding(0);
            this.rbEventosDeHoje.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEventosDeHoje.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEventosDeHoje.Name = "rbEventosDeHoje";
            this.rbEventosDeHoje.Ripple = true;
            this.rbEventosDeHoje.Size = new System.Drawing.Size(90, 37);
            this.rbEventosDeHoje.TabIndex = 1;
            this.rbEventosDeHoje.TabStop = true;
            this.rbEventosDeHoje.Text = "De Hoje";
            this.rbEventosDeHoje.UseVisualStyleBackColor = true;
            this.rbEventosDeHoje.CheckedChanged += new System.EventHandler(this.rbEventosDeHoje_CheckedChanged);
            // 
            // rbTodoEventos
            // 
            this.rbTodoEventos.AutoSize = true;
            this.rbTodoEventos.Checked = true;
            this.rbTodoEventos.Depth = 0;
            this.rbTodoEventos.Location = new System.Drawing.Point(1, 25);
            this.rbTodoEventos.Margin = new System.Windows.Forms.Padding(0);
            this.rbTodoEventos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTodoEventos.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTodoEventos.Name = "rbTodoEventos";
            this.rbTodoEventos.Ripple = true;
            this.rbTodoEventos.Size = new System.Drawing.Size(80, 37);
            this.rbTodoEventos.TabIndex = 0;
            this.rbTodoEventos.TabStop = true;
            this.rbTodoEventos.Text = "Todos";
            this.rbTodoEventos.UseVisualStyleBackColor = true;
            this.rbTodoEventos.CheckedChanged += new System.EventHandler(this.rbTodoEventos_CheckedChanged);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.lblMesAno);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(6, 15);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(841, 51);
            this.materialCard5.TabIndex = 14;
            // 
            // lblMesAno
            // 
            this.lblMesAno.AutoSize = true;
            this.lblMesAno.Depth = 0;
            this.lblMesAno.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMesAno.Location = new System.Drawing.Point(380, 14);
            this.lblMesAno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMesAno.Name = "lblMesAno";
            this.lblMesAno.Size = new System.Drawing.Size(70, 19);
            this.lblMesAno.TabIndex = 13;
            this.lblMesAno.Text = "MÊS ANO";
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.White;
            this.tabClientes.Controls.Add(this.materialCard2);
            this.tabClientes.Controls.Add(this.dataGridViewListaClientes);
            this.tabClientes.ImageKey = "add-user.png";
            this.tabClientes.Location = new System.Drawing.Point(4, 39);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(1167, 589);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnCadastrarCliente);
            this.materialCard2.Controls.Add(this.materialTextBox2);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(10, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1147, 73);
            this.materialCard2.TabIndex = 9;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrarCliente.Depth = 0;
            this.btnCadastrarCliente.HighEmphasis = true;
            this.btnCadastrarCliente.Icon = null;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(971, 18);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrarCliente.Size = new System.Drawing.Size(162, 36);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "Cadastrar Novo +";
            this.btnCadastrarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrarCliente.UseAccentColor = false;
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(94, 8);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(498, 50);
            this.materialTextBox2.TabIndex = 1;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 28);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Pesquisar";
            // 
            // dataGridViewListaClientes
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListaClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListaClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewListaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewListaClientes.Location = new System.Drawing.Point(10, 94);
            this.dataGridViewListaClientes.Name = "dataGridViewListaClientes";
            this.dataGridViewListaClientes.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewListaClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewListaClientes.RowTemplate.Height = 25;
            this.dataGridViewListaClientes.ShowEditingIcon = false;
            this.dataGridViewListaClientes.Size = new System.Drawing.Size(1147, 320);
            this.dataGridViewListaClientes.TabIndex = 8;
            // 
            // tabEventos
            // 
            this.tabEventos.BackColor = System.Drawing.Color.White;
            this.tabEventos.ImageKey = "add.png";
            this.tabEventos.Location = new System.Drawing.Point(4, 39);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Size = new System.Drawing.Size(1167, 589);
            this.tabEventos.TabIndex = 2;
            this.tabEventos.Text = "Eventos";
            // 
            // tabFinanceiro
            // 
            this.tabFinanceiro.BackColor = System.Drawing.Color.White;
            this.tabFinanceiro.ImageKey = "cash-payment.png";
            this.tabFinanceiro.Location = new System.Drawing.Point(4, 39);
            this.tabFinanceiro.Name = "tabFinanceiro";
            this.tabFinanceiro.Size = new System.Drawing.Size(1167, 589);
            this.tabFinanceiro.TabIndex = 3;
            this.tabFinanceiro.Text = "Financeiro";
            // 
            // tabConfiguracoes
            // 
            this.tabConfiguracoes.BackColor = System.Drawing.Color.White;
            this.tabConfiguracoes.ImageKey = "engrenagens-de-configuracoes.png";
            this.tabConfiguracoes.Location = new System.Drawing.Point(4, 39);
            this.tabConfiguracoes.Name = "tabConfiguracoes";
            this.tabConfiguracoes.Size = new System.Drawing.Size(1167, 589);
            this.tabConfiguracoes.TabIndex = 4;
            this.tabConfiguracoes.Text = "Configurações";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Button-Check-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Close-icon (1).png");
            this.imageList1.Images.SetKeyName(2, "Button-Reload-icon.png");
            this.imageList1.Images.SetKeyName(3, "Button-White-Add-icon.png");
            this.imageList1.Images.SetKeyName(4, "Button-White-Remove-icon.png");
            this.imageList1.Images.SetKeyName(5, "error-button-icon.png");
            this.imageList1.Images.SetKeyName(6, "search-button-green-icon.png");
            this.imageList1.Images.SetKeyName(7, "add.png");
            this.imageList1.Images.SetKeyName(8, "add-user.png");
            this.imageList1.Images.SetKeyName(9, "casa.png");
            this.imageList1.Images.SetKeyName(10, "cash-payment.png");
            this.imageList1.Images.SetKeyName(11, "engrenagens-de-configuracoes.png");
            this.imageList1.Images.SetKeyName(12, "user.png");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1181, 699);
            this.Controls.Add(this.tabMenuPrincipal);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabMenuPrincipal;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabMenuPrincipal.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventosHome)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabEventos;
        private System.Windows.Forms.TabPage tabFinanceiro;
        private System.Windows.Forms.TabPage tabConfiguracoes;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialRadioButton rbEventosDeHoje;
        private MaterialSkin.Controls.MaterialRadioButton rbTodoEventos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.DataGridView dataGridViewEventosHome;
        private System.Windows.Forms.DataGridView dataGridViewListaClientes;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton btnCadastrarCliente;
        private MaterialSkin.Controls.MaterialTabControl tabMenuPrincipal;
        private System.Windows.Forms.FlowLayoutPanel painelCalendario;
        private MaterialSkin.Controls.MaterialButton btnVoltarMes;
        private MaterialSkin.Controls.MaterialButton btnAvancarMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel lblMesAno;
        private MaterialSkin.Controls.MaterialCard materialCard5;
    }
}

