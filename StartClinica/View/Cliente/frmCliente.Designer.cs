
namespace StartClinica.View
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.label9 = new System.Windows.Forms.Label();
            this.pctFotoCliente = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.chkAtivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.mskCPF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mskTelefone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btnSalvarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnBuscarCEP = new MaterialSkin.Controls.MaterialButton();
            this.mskCEP = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtComplemento = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEstado = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCidade = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBairro = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRua = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoCliente)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(537, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "( * ) Campos Obrigatórios";
            // 
            // pctFotoCliente
            // 
            this.pctFotoCliente.Image = ((System.Drawing.Image)(resources.GetObject("pctFotoCliente.Image")));
            this.pctFotoCliente.Location = new System.Drawing.Point(541, 35);
            this.pctFotoCliente.Name = "pctFotoCliente";
            this.pctFotoCliente.Size = new System.Drawing.Size(126, 97);
            this.pctFotoCliente.TabIndex = 24;
            this.pctFotoCliente.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.chkAtivo);
            this.materialCard1.Controls.Add(this.dtpDataNascimento);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.mskCPF);
            this.materialCard1.Controls.Add(this.label9);
            this.materialCard1.Controls.Add(this.pctFotoCliente);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.mskTelefone);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.txtNome);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(982, 249);
            this.materialCard1.TabIndex = 5;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Depth = 0;
            this.chkAtivo.Location = new System.Drawing.Point(298, 198);
            this.chkAtivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkAtivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAtivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.ReadOnly = false;
            this.chkAtivo.Ripple = true;
            this.chkAtivo.Size = new System.Drawing.Size(71, 37);
            this.chkAtivo.TabIndex = 8;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataNascimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(273, 130);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(215, 27);
            this.dtpDataNascimento.TabIndex = 7;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(273, 93);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(145, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Data de Nascimento";
            // 
            // mskCPF
            // 
            this.mskCPF.AllowPromptAsInput = true;
            this.mskCPF.AnimateReadOnly = false;
            this.mskCPF.AsciiOnly = false;
            this.mskCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mskCPF.BeepOnError = false;
            this.mskCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskCPF.Depth = 0;
            this.mskCPF.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mskCPF.HidePromptOnLeave = false;
            this.mskCPF.HideSelection = true;
            this.mskCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mskCPF.LeadingIcon = null;
            this.mskCPF.Location = new System.Drawing.Point(18, 178);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.MaxLength = 32767;
            this.mskCPF.MouseState = MaterialSkin.MouseState.OUT;
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.PasswordChar = '\0';
            this.mskCPF.PrefixSuffixText = null;
            this.mskCPF.PromptChar = '_';
            this.mskCPF.ReadOnly = false;
            this.mskCPF.RejectInputOnFirstFailure = false;
            this.mskCPF.ResetOnPrompt = true;
            this.mskCPF.ResetOnSpace = true;
            this.mskCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskCPF.SelectedText = "";
            this.mskCPF.SelectionLength = 0;
            this.mskCPF.SelectionStart = 0;
            this.mskCPF.ShortcutsEnabled = true;
            this.mskCPF.Size = new System.Drawing.Size(250, 48);
            this.mskCPF.SkipLiterals = true;
            this.mskCPF.TabIndex = 5;
            this.mskCPF.TabStop = false;
            this.mskCPF.Text = "   .   .   -";
            this.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskCPF.TrailingIcon = null;
            this.mskCPF.UseSystemPasswordChar = false;
            this.mskCPF.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(18, 161);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(30, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "CPF";
            // 
            // mskTelefone
            // 
            this.mskTelefone.AllowPromptAsInput = true;
            this.mskTelefone.AnimateReadOnly = false;
            this.mskTelefone.AsciiOnly = false;
            this.mskTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mskTelefone.BeepOnError = false;
            this.mskTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskTelefone.Depth = 0;
            this.mskTelefone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mskTelefone.HidePromptOnLeave = false;
            this.mskTelefone.HideSelection = true;
            this.mskTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mskTelefone.LeadingIcon = null;
            this.mskTelefone.Location = new System.Drawing.Point(17, 110);
            this.mskTelefone.Mask = "(00)00000-0000";
            this.mskTelefone.MaxLength = 32767;
            this.mskTelefone.MouseState = MaterialSkin.MouseState.OUT;
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.PasswordChar = '\0';
            this.mskTelefone.PrefixSuffixText = null;
            this.mskTelefone.PromptChar = '_';
            this.mskTelefone.ReadOnly = false;
            this.mskTelefone.RejectInputOnFirstFailure = false;
            this.mskTelefone.ResetOnPrompt = true;
            this.mskTelefone.ResetOnSpace = true;
            this.mskTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTelefone.SelectedText = "";
            this.mskTelefone.SelectionLength = 0;
            this.mskTelefone.SelectionStart = 0;
            this.mskTelefone.ShortcutsEnabled = true;
            this.mskTelefone.Size = new System.Drawing.Size(250, 48);
            this.mskTelefone.SkipLiterals = true;
            this.mskTelefone.TabIndex = 3;
            this.mskTelefone.TabStop = false;
            this.mskTelefone.Text = "(  )     -";
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskTelefone.TrailingIcon = null;
            this.mskTelefone.UseSystemPasswordChar = false;
            this.mskTelefone.ValidatingType = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 93);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(18, 35);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(470, 50);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nome";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.btnSalvarCliente);
            this.materialCard2.Controls.Add(this.btnBuscarCEP);
            this.materialCard2.Controls.Add(this.mskCEP);
            this.materialCard2.Controls.Add(this.materialLabel11);
            this.materialCard2.Controls.Add(this.txtComplemento);
            this.materialCard2.Controls.Add(this.materialLabel10);
            this.materialCard2.Controls.Add(this.txtEstado);
            this.materialCard2.Controls.Add(this.materialLabel9);
            this.materialCard2.Controls.Add(this.txtNumero);
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.txtCidade);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.txtBairro);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.txtRua);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 331);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(982, 440);
            this.materialCard2.TabIndex = 6;
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.AutoSize = false;
            this.btnSalvarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvarCliente.BackColor = System.Drawing.Color.Green;
            this.btnSalvarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvarCliente.Depth = 0;
            this.btnSalvarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarCliente.HighEmphasis = true;
            this.btnSalvarCliente.Icon = null;
            this.btnSalvarCliente.Location = new System.Drawing.Point(537, 319);
            this.btnSalvarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvarCliente.Size = new System.Drawing.Size(100, 36);
            this.btnSalvarCliente.TabIndex = 7;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvarCliente.UseAccentColor = false;
            this.btnSalvarCliente.UseVisualStyleBackColor = false;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
            // 
            // btnBuscarCEP
            // 
            this.btnBuscarCEP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCEP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarCEP.Depth = 0;
            this.btnBuscarCEP.HighEmphasis = true;
            this.btnBuscarCEP.Icon = null;
            this.btnBuscarCEP.Location = new System.Drawing.Point(276, 49);
            this.btnBuscarCEP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarCEP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCEP.Name = "btnBuscarCEP";
            this.btnBuscarCEP.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarCEP.Size = new System.Drawing.Size(77, 36);
            this.btnBuscarCEP.TabIndex = 14;
            this.btnBuscarCEP.Text = "Buscar";
            this.btnBuscarCEP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarCEP.UseAccentColor = false;
            this.btnBuscarCEP.UseVisualStyleBackColor = true;
            // 
            // mskCEP
            // 
            this.mskCEP.AllowPromptAsInput = true;
            this.mskCEP.AnimateReadOnly = false;
            this.mskCEP.AsciiOnly = false;
            this.mskCEP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mskCEP.BeepOnError = false;
            this.mskCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskCEP.Depth = 0;
            this.mskCEP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mskCEP.HidePromptOnLeave = false;
            this.mskCEP.HideSelection = true;
            this.mskCEP.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mskCEP.LeadingIcon = null;
            this.mskCEP.Location = new System.Drawing.Point(19, 37);
            this.mskCEP.Mask = "00,000-000";
            this.mskCEP.MaxLength = 32767;
            this.mskCEP.MouseState = MaterialSkin.MouseState.OUT;
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.PasswordChar = '\0';
            this.mskCEP.PrefixSuffixText = null;
            this.mskCEP.PromptChar = '_';
            this.mskCEP.ReadOnly = false;
            this.mskCEP.RejectInputOnFirstFailure = false;
            this.mskCEP.ResetOnPrompt = true;
            this.mskCEP.ResetOnSpace = true;
            this.mskCEP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskCEP.SelectedText = "";
            this.mskCEP.SelectionLength = 0;
            this.mskCEP.SelectionStart = 0;
            this.mskCEP.ShortcutsEnabled = true;
            this.mskCEP.Size = new System.Drawing.Size(250, 48);
            this.mskCEP.SkipLiterals = true;
            this.mskCEP.TabIndex = 13;
            this.mskCEP.TabStop = false;
            this.mskCEP.Text = "  .   -";
            this.mskCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskCEP.TrailingIcon = null;
            this.mskCEP.UseSystemPasswordChar = false;
            this.mskCEP.ValidatingType = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(17, 14);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(30, 19);
            this.materialLabel11.TabIndex = 12;
            this.materialLabel11.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.AnimateReadOnly = false;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComplemento.Depth = 0;
            this.txtComplemento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtComplemento.LeadingIcon = null;
            this.txtComplemento.Location = new System.Drawing.Point(298, 260);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComplemento.Multiline = false;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(339, 50);
            this.txtComplemento.TabIndex = 11;
            this.txtComplemento.Text = "";
            this.txtComplemento.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(298, 238);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(100, 19);
            this.materialLabel10.TabIndex = 10;
            this.materialLabel10.Text = "Complemento";
            // 
            // txtEstado
            // 
            this.txtEstado.AnimateReadOnly = false;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Depth = 0;
            this.txtEstado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(441, 184);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(196, 50);
            this.txtEstado.TabIndex = 9;
            this.txtEstado.Text = "";
            this.txtEstado.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(441, 162);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(50, 19);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "Estado";
            // 
            // txtNumero
            // 
            this.txtNumero.AnimateReadOnly = false;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Depth = 0;
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumero.LeadingIcon = null;
            this.txtNumero.Location = new System.Drawing.Point(441, 111);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(196, 50);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.Text = "";
            this.txtNumero.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(441, 89);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(57, 19);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "Número";
            // 
            // txtCidade
            // 
            this.txtCidade.AnimateReadOnly = false;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Depth = 0;
            this.txtCidade.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCidade.LeadingIcon = null;
            this.txtCidade.Location = new System.Drawing.Point(20, 258);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCidade.Multiline = false;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(249, 50);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Text = "";
            this.txtCidade.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(20, 235);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(50, 19);
            this.materialLabel7.TabIndex = 4;
            this.materialLabel7.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.AnimateReadOnly = false;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Depth = 0;
            this.txtBairro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBairro.LeadingIcon = null;
            this.txtBairro.Location = new System.Drawing.Point(18, 185);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBairro.Multiline = false;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(400, 50);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.Text = "";
            this.txtBairro.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(18, 162);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(43, 19);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Bairro";
            // 
            // txtRua
            // 
            this.txtRua.AnimateReadOnly = false;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRua.Depth = 0;
            this.txtRua.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRua.LeadingIcon = null;
            this.txtRua.Location = new System.Drawing.Point(19, 112);
            this.txtRua.MaxLength = 50;
            this.txtRua.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRua.Multiline = false;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(400, 50);
            this.txtRua.TabIndex = 1;
            this.txtRua.Text = "";
            this.txtRua.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(19, 89);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(29, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Rua";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 788);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE CLIENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFotoCliente)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pctFotoCliente;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMaskedTextBox mskCPF;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox mskTelefone;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox chkAtivo;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnBuscarCEP;
        private MaterialSkin.Controls.MaterialMaskedTextBox mskCEP;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox txtComplemento;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox txtEstado;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtNumero;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox txtCidade;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txtBairro;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtRua;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnSalvarCliente;
    }
}