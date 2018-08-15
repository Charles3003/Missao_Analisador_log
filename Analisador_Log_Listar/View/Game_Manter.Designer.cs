namespace Analisador_Log_Listar.View
{
    partial class Game_Manter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Manter));
            this.pnl_Fill = new System.Windows.Forms.Panel();
            this.gb_Game = new System.Windows.Forms.GroupBox();
            this.lbl_Nome = new DevExpress.XtraEditors.LabelControl();
            this.txt_Nome_Game = new DevExpress.XtraEditors.TextEdit();
            this.txt_Total_Morte = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_Botao = new System.Windows.Forms.Panel();
            this.btn_Fechar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Salvar = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_Fill.SuspendLayout();
            this.gb_Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Game.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Total_Morte.Properties)).BeginInit();
            this.pnl_Botao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Fill
            // 
            this.pnl_Fill.Controls.Add(this.gb_Game);
            this.pnl_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fill.Location = new System.Drawing.Point(0, 5);
            this.pnl_Fill.Name = "pnl_Fill";
            this.pnl_Fill.Size = new System.Drawing.Size(459, 126);
            this.pnl_Fill.TabIndex = 8;
            // 
            // gb_Game
            // 
            this.gb_Game.Controls.Add(this.lbl_Nome);
            this.gb_Game.Controls.Add(this.txt_Nome_Game);
            this.gb_Game.Controls.Add(this.txt_Total_Morte);
            this.gb_Game.Controls.Add(this.labelControl2);
            this.gb_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Game.Location = new System.Drawing.Point(0, 0);
            this.gb_Game.Name = "gb_Game";
            this.gb_Game.Size = new System.Drawing.Size(459, 126);
            this.gb_Game.TabIndex = 5;
            this.gb_Game.TabStop = false;
            this.gb_Game.Text = "Game";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Location = new System.Drawing.Point(35, 31);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(61, 13);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome Game:";
            // 
            // txt_Nome_Game
            // 
            this.txt_Nome_Game.Location = new System.Drawing.Point(102, 28);
            this.txt_Nome_Game.Name = "txt_Nome_Game";
            this.txt_Nome_Game.Size = new System.Drawing.Size(315, 20);
            this.txt_Nome_Game.TabIndex = 3;
            // 
            // txt_Total_Morte
            // 
            this.txt_Total_Morte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Total_Morte.Location = new System.Drawing.Point(102, 54);
            this.txt_Total_Morte.Name = "txt_Total_Morte";
            this.txt_Total_Morte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Total_Morte.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_Total_Morte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_Total_Morte.Size = new System.Drawing.Size(124, 20);
            this.txt_Total_Morte.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Total Morte:";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 131);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(459, 5);
            this.pnl_Bottom.TabIndex = 7;
            // 
            // pnl_Right
            // 
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Right.Location = new System.Drawing.Point(459, 5);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(5, 131);
            this.pnl_Right.TabIndex = 6;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(464, 5);
            this.pnl_Top.TabIndex = 5;
            // 
            // pnl_Botao
            // 
            this.pnl_Botao.Controls.Add(this.btn_Fechar);
            this.pnl_Botao.Controls.Add(this.btn_Salvar);
            this.pnl_Botao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botao.Location = new System.Drawing.Point(0, 92);
            this.pnl_Botao.Name = "pnl_Botao";
            this.pnl_Botao.Size = new System.Drawing.Size(459, 39);
            this.pnl_Botao.TabIndex = 0;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.ImageOptions.Image")));
            this.btn_Fechar.Location = new System.Drawing.Point(236, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(125, 33);
            this.btn_Fechar.TabIndex = 2;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.ImageOptions.Image")));
            this.btn_Salvar.Location = new System.Drawing.Point(105, 3);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(125, 33);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 87);
            this.panel4.TabIndex = 9;
            // 
            // Analisar_Log_Manter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 136);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_Botao);
            this.Controls.Add(this.pnl_Fill);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Analisar_Log_Manter";
            this.Text = "Cadastrar Game";
            this.pnl_Fill.ResumeLayout(false);
            this.gb_Game.ResumeLayout(false);
            this.gb_Game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Game.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Total_Morte.Properties)).EndInit();
            this.pnl_Botao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fill;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel pnl_Botao;
        private DevExpress.XtraEditors.SimpleButton btn_Salvar;
        private DevExpress.XtraEditors.SimpleButton btn_Fechar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbl_Nome;
        private DevExpress.XtraEditors.TextEdit txt_Nome_Game;
        private DevExpress.XtraEditors.SpinEdit txt_Total_Morte;
        private System.Windows.Forms.GroupBox gb_Game;
        private System.Windows.Forms.Panel panel4;
    }
}