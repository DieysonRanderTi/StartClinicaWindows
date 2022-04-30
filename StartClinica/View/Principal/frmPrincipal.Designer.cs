
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTÃOFINANCEIRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbEventosDia = new System.Windows.Forms.RadioButton();
            this.rdbTodosEventos = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.gESTÃOFINANCEIRAToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.AutoSize = false;
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(100, 50);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            this.cadastroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // gESTÃOFINANCEIRAToolStripMenuItem
            // 
            this.gESTÃOFINANCEIRAToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.gESTÃOFINANCEIRAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gESTÃOFINANCEIRAToolStripMenuItem.Image")));
            this.gESTÃOFINANCEIRAToolStripMenuItem.Name = "gESTÃOFINANCEIRAToolStripMenuItem";
            this.gESTÃOFINANCEIRAToolStripMenuItem.Size = new System.Drawing.Size(99, 50);
            this.gESTÃOFINANCEIRAToolStripMenuItem.Text = "Financeiro";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.AutoSize = false;
            this.agendaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.agendaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendaToolStripMenuItem.Image")));
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(99, 50);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridViewAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Location = new System.Drawing.Point(572, 176);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewAgenda.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAgenda.RowTemplate.Height = 25;
            this.dataGridViewAgenda.Size = new System.Drawing.Size(597, 342);
            this.dataGridViewAgenda.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rdbEventosDia);
            this.groupBox1.Controls.Add(this.rdbTodosEventos);
            this.groupBox1.Location = new System.Drawing.Point(572, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "FILTRO/PESQUISA";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(584, 23);
            this.textBox1.TabIndex = 2;
            // 
            // rdbEventosDia
            // 
            this.rdbEventosDia.AutoSize = true;
            this.rdbEventosDia.Checked = true;
            this.rdbEventosDia.Location = new System.Drawing.Point(6, 88);
            this.rdbEventosDia.Name = "rdbEventosDia";
            this.rdbEventosDia.Size = new System.Drawing.Size(64, 19);
            this.rdbEventosDia.TabIndex = 1;
            this.rdbEventosDia.TabStop = true;
            this.rdbEventosDia.Text = "DO DIA";
            this.rdbEventosDia.UseVisualStyleBackColor = true;
            this.rdbEventosDia.CheckedChanged += new System.EventHandler(this.rdbEventosDia_CheckedChanged);
            // 
            // rdbTodosEventos
            // 
            this.rdbTodosEventos.AutoSize = true;
            this.rdbTodosEventos.Location = new System.Drawing.Point(76, 88);
            this.rdbTodosEventos.Name = "rdbTodosEventos";
            this.rdbTodosEventos.Size = new System.Drawing.Size(62, 19);
            this.rdbTodosEventos.TabIndex = 0;
            this.rdbTodosEventos.TabStop = true;
            this.rdbTodosEventos.Text = "TODOS";
            this.rdbTodosEventos.UseVisualStyleBackColor = true;
            this.rdbTodosEventos.CheckedChanged += new System.EventHandler(this.rdbTodosEventos_CheckedChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1181, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewAgenda);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTÃOFINANCEIRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbEventosDia;
        private System.Windows.Forms.RadioButton rdbTodosEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

