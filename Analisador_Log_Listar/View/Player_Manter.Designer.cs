namespace Analisador_Log_Listar.View
{
    partial class Player_Manter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player_Manter));
            this.pnl_Botao = new System.Windows.Forms.Panel();
            this.btn_Fechar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Salvar = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_Fill = new System.Windows.Forms.Panel();
            this.gb_Game = new System.Windows.Forms.GroupBox();
            this.lbl_Nome = new DevExpress.XtraEditors.LabelControl();
            this.txt_Nome_Morte = new DevExpress.XtraEditors.TextEdit();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.lue_Game = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnl_Botao.SuspendLayout();
            this.pnl_Fill.SuspendLayout();
            this.gb_Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Morte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Game.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Botao
            // 
            this.pnl_Botao.Controls.Add(this.btn_Fechar);
            this.pnl_Botao.Controls.Add(this.btn_Salvar);
            this.pnl_Botao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botao.Location = new System.Drawing.Point(0, 89);
            this.pnl_Botao.Name = "pnl_Botao";
            this.pnl_Botao.Size = new System.Drawing.Size(501, 39);
            this.pnl_Botao.TabIndex = 15;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.ImageOptions.Image")));
            this.btn_Fechar.Location = new System.Drawing.Point(256, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(125, 33);
            this.btn_Fechar.TabIndex = 2;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.ImageOptions.Image")));
            this.btn_Salvar.Location = new System.Drawing.Point(125, 3);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(125, 33);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // pnl_Fill
            // 
            this.pnl_Fill.Controls.Add(this.gb_Game);
            this.pnl_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fill.Location = new System.Drawing.Point(0, 5);
            this.pnl_Fill.Name = "pnl_Fill";
            this.pnl_Fill.Size = new System.Drawing.Size(501, 123);
            this.pnl_Fill.TabIndex = 19;
            // 
            // gb_Game
            // 
            this.gb_Game.Controls.Add(this.lue_Game);
            this.gb_Game.Controls.Add(this.labelControl1);
            this.gb_Game.Controls.Add(this.lbl_Nome);
            this.gb_Game.Controls.Add(this.txt_Nome_Morte);
            this.gb_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Game.Location = new System.Drawing.Point(0, 0);
            this.gb_Game.Name = "gb_Game";
            this.gb_Game.Size = new System.Drawing.Size(501, 123);
            this.gb_Game.TabIndex = 5;
            this.gb_Game.TabStop = false;
            this.gb_Game.Text = "Cadastrar Player";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Location = new System.Drawing.Point(50, 29);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(31, 13);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_Nome_Morte
            // 
            this.txt_Nome_Morte.Location = new System.Drawing.Point(87, 26);
            this.txt_Nome_Morte.Name = "txt_Nome_Morte";
            this.txt_Nome_Morte.Size = new System.Drawing.Size(315, 20);
            this.txt_Nome_Morte.TabIndex = 3;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 128);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(501, 5);
            this.pnl_Bottom.TabIndex = 18;
            // 
            // pnl_Right
            // 
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Right.Location = new System.Drawing.Point(501, 5);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(5, 128);
            this.pnl_Right.TabIndex = 17;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(506, 5);
            this.pnl_Top.TabIndex = 16;
            // 
            // lue_Game
            // 
            this.lue_Game.Location = new System.Drawing.Point(87, 52);
            this.lue_Game.Name = "lue_Game";
            this.lue_Game.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_Game.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome_Game", "Nome")});
            this.lue_Game.Properties.DisplayMember = "Nome_Game";
            this.lue_Game.Properties.NullText = "";
            this.lue_Game.Properties.ValueMember = "Codigo";
            this.lue_Game.Size = new System.Drawing.Size(315, 20);
            this.lue_Game.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Nome Game:";
            // 
            // Player_Manter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 133);
            this.Controls.Add(this.pnl_Botao);
            this.Controls.Add(this.pnl_Fill);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Player_Manter";
            this.Text = "Player_Manter";
            this.Shown += new System.EventHandler(this.Player_Manter_Shown);
            this.pnl_Botao.ResumeLayout(false);
            this.pnl_Fill.ResumeLayout(false);
            this.gb_Game.ResumeLayout(false);
            this.gb_Game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Morte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Game.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Botao;
        private DevExpress.XtraEditors.SimpleButton btn_Fechar;
        private DevExpress.XtraEditors.SimpleButton btn_Salvar;
        private System.Windows.Forms.Panel pnl_Fill;
        private System.Windows.Forms.GroupBox gb_Game;
        private DevExpress.XtraEditors.LabelControl lbl_Nome;
        private DevExpress.XtraEditors.TextEdit txt_Nome_Morte;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Panel pnl_Top;
        private DevExpress.XtraEditors.LookUpEdit lue_Game;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}