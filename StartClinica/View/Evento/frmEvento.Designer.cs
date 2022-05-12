
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
            this.cmbHorario = new MaterialSkin.Controls.MaterialComboBox();
            this.txtData = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSalvarEvento = new MaterialSkin.Controls.MaterialButton();
            this.txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCadastrarCliente = new MaterialSkin.Controls.MaterialButton();
            this.cmbClientes = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            this.materialCard1.Controls.Add(this.cmbHorario);
            this.materialCard1.Controls.Add(this.txtData);
            this.materialCard1.Controls.Add(this.btnSalvarEvento);
            this.materialCard1.Controls.Add(this.txtDescricao);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.btnCadastrarCliente);
            this.materialCard1.Controls.Add(this.cmbClientes);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 96);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1017, 311);
            this.materialCard1.TabIndex = 4;
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
            this.cmbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.IntegralHeight = false;
            this.cmbHorario.ItemHeight = 43;
            this.cmbHorario.Items.AddRange(new object[] {
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "20:00",
            "20:15",
            "20:30",
            "20:45",
            "21:00",
            "21:15",
            "21:30",
            "21:45",
            "22:00",
            "22:15",
            "22:30",
            "22:45"});
            this.cmbHorario.Location = new System.Drawing.Point(244, 129);
            this.cmbHorario.MaxDropDownItems = 4;
            this.cmbHorario.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(121, 49);
            this.cmbHorario.StartIndex = 0;
            this.cmbHorario.TabIndex = 11;
            // 
            // txtData
            // 
            this.txtData.AnimateReadOnly = false;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.LeadingIcon = null;
            this.txtData.Location = new System.Drawing.Point(28, 128);
            this.txtData.MaxLength = 50;
            this.txtData.MouseState = MaterialSkin.MouseState.OUT;
            this.txtData.Multiline = false;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(206, 50);
            this.txtData.TabIndex = 10;
            this.txtData.Text = "";
            this.txtData.TrailingIcon = null;
            // 
            // btnSalvarEvento
            // 
            this.btnSalvarEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvarEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvarEvento.Depth = 0;
            this.btnSalvarEvento.HighEmphasis = true;
            this.btnSalvarEvento.Icon = null;
            this.btnSalvarEvento.Location = new System.Drawing.Point(645, 266);
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
            this.btnSalvarEvento.Click += new System.EventHandler(this.btnSalvarEvento_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricao.LeadingIcon = null;
            this.txtDescricao.Location = new System.Drawing.Point(28, 207);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(794, 50);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.Text = "Consulta";
            this.txtDescricao.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(28, 185);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Descrição";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(244, 106);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Horário";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 106);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(35, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Data";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrarCliente.Depth = 0;
            this.btnCadastrarCliente.HighEmphasis = true;
            this.btnCadastrarCliente.Icon = null;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(642, 63);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrarCliente.Size = new System.Drawing.Size(180, 36);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "CADASTRAR CLIENTE +";
            this.btnCadastrarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrarCliente.UseAccentColor = false;
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
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
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.IntegralHeight = false;
            this.cmbClientes.ItemHeight = 43;
            this.cmbClientes.Location = new System.Drawing.Point(28, 50);
            this.cmbClientes.MaxDropDownItems = 4;
            this.cmbClientes.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(607, 49);
            this.cmbClientes.StartIndex = 0;
            this.cmbClientes.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Cliente";
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 558);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblDataHoje);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEvento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE EVENTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEvento_Load);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnSalvarEvento;
        private MaterialSkin.Controls.MaterialComboBox cmbHorario;
        private MaterialSkin.Controls.MaterialTextBox txtData;
    }
}