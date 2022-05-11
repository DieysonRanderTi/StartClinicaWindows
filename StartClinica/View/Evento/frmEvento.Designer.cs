
namespace StartClinica.View
{
    partial class frmEvento
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
            this.lblDataHoje = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbClientes = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCadastrarCliente = new MaterialSkin.Controls.MaterialButton();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbHorario = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSalvarEvento = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataHoje
            // 
            this.lblDataHoje.AutoSize = true;
            this.lblDataHoje.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataHoje.Location = new System.Drawing.Point(883, 72);
            this.lblDataHoje.Name = "lblDataHoje";
            this.lblDataHoje.Size = new System.Drawing.Size(0, 21);
            this.lblDataHoje.TabIndex = 3;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnSalvarEvento);
            this.materialCard1.Controls.Add(this.txtDescricao);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.cmbHorario);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.dtpData);
            this.materialCard1.Controls.Add(this.btnCadastrarCliente);
            this.materialCard1.Controls.Add(this.cmbClientes);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1017, 311);
            this.materialCard1.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.AutoResize = false;
            this.cmbClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbClientes.Depth = 0;
            this.cmbClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbClientes.DropDownHeight = 174;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.DropDownWidth = 121;
            this.cmbClientes.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.IntegralHeight = false;
            this.cmbClientes.ItemHeight = 43;
            this.cmbClientes.Location = new System.Drawing.Point(17, 36);
            this.cmbClientes.MaxDropDownItems = 4;
            this.cmbClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(607, 49);
            this.cmbClientes.StartIndex = 0;
            this.cmbClientes.TabIndex = 1;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrarCliente.Depth = 0;
            this.btnCadastrarCliente.HighEmphasis = true;
            this.btnCadastrarCliente.Icon = null;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(631, 49);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrarCliente.Size = new System.Drawing.Size(179, 36);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "CADASTRAR CLIENTE +";
            this.btnCadastrarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrarCliente.UseAccentColor = false;
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(17, 136);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 23);
            this.dtpData.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 88);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(35, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Data";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(228, 88);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Horário";
            // 
            // cmbHorario
            // 
            this.cmbHorario.AutoResize = false;
            this.cmbHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbHorario.Depth = 0;
            this.cmbHorario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbHorario.DropDownHeight = 174;
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.DropDownWidth = 121;
            this.cmbHorario.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.IntegralHeight = false;
            this.cmbHorario.ItemHeight = 43;
            this.cmbHorario.Location = new System.Drawing.Point(228, 110);
            this.cmbHorario.MaxDropDownItems = 4;
            this.cmbHorario.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(173, 49);
            this.cmbHorario.StartIndex = 0;
            this.cmbHorario.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 162);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricao.LeadingIcon = null;
            this.txtDescricao.Location = new System.Drawing.Point(17, 184);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(983, 50);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.Text = "";
            this.txtDescricao.TrailingIcon = null;
            // 
            // btnSalvarEvento
            // 
            this.btnSalvarEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvarEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvarEvento.Depth = 0;
            this.btnSalvarEvento.HighEmphasis = true;
            this.btnSalvarEvento.Icon = null;
            this.btnSalvarEvento.Location = new System.Drawing.Point(823, 243);
            this.btnSalvarEvento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvarEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvarEvento.Name = "btnSalvarEvento";
            this.btnSalvarEvento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvarEvento.Size = new System.Drawing.Size(177, 36);
            this.btnSalvarEvento.TabIndex = 9;
            this.btnSalvarEvento.Text = "CADASTRAR EVENTO +";
            this.btnSalvarEvento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvarEvento.UseAccentColor = false;
            this.btnSalvarEvento.UseVisualStyleBackColor = true;
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 558);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblDataHoje);
            this.Name = "frmEvento";
            this.ShowIcon = false;
            this.Text = "CADASTRO DE EVENTOS";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataHoje;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnCadastrarCliente;
        private MaterialSkin.Controls.MaterialComboBox cmbClientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cmbHorario;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private MaterialSkin.Controls.MaterialButton btnSalvarEvento;
    }
}