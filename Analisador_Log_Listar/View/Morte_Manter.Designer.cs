namespace Analisador_Log_Listar.View
{
    partial class Morte_Manter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Morte_Manter));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_Botao = new System.Windows.Forms.Panel();
            this.btn_Fechar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Salvar = new DevExpress.XtraEditors.SimpleButton();
            this.pnl_Fill = new System.Windows.Forms.Panel();
            this.gb_Game = new System.Windows.Forms.GroupBox();
            this.lue_Nome_Player = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lue_Game = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Nome = new DevExpress.XtraEditors.LabelControl();
            this.txt_Nome_Morte = new DevExpress.XtraEditors.TextEdit();
            this.txt_Dano = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_Botao.SuspendLayout();
            this.pnl_Fill.SuspendLayout();
            this.gb_Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Nome_Player.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Game.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Morte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dano.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 134);
            this.panel4.TabIndex = 15;
            // 
            // pnl_Botao
            // 
            this.pnl_Botao.Controls.Add(this.btn_Fechar);
            this.pnl_Botao.Controls.Add(this.btn_Salvar);
            this.pnl_Botao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botao.Location = new System.Drawing.Point(0, 139);
            this.pnl_Botao.Name = "pnl_Botao";
            this.pnl_Botao.Size = new System.Drawing.Size(571, 39);
            this.pnl_Botao.TabIndex = 10;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.ImageOptions.Image")));
            this.btn_Fechar.Location = new System.Drawing.Point(292, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(125, 33);
            this.btn_Fechar.TabIndex = 2;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.ImageOptions.Image")));
            this.btn_Salvar.Location = new System.Drawing.Point(161, 3);
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
            this.pnl_Fill.Size = new System.Drawing.Size(571, 173);
            this.pnl_Fill.TabIndex = 14;
            // 
            // gb_Game
            // 
            this.gb_Game.Controls.Add(this.lue_Nome_Player);
            this.gb_Game.Controls.Add(this.labelControl3);
            this.gb_Game.Controls.Add(this.lue_Game);
            this.gb_Game.Controls.Add(this.labelControl1);
            this.gb_Game.Controls.Add(this.lbl_Nome);
            this.gb_Game.Controls.Add(this.txt_Nome_Morte);
            this.gb_Game.Controls.Add(this.txt_Dano);
            this.gb_Game.Controls.Add(this.labelControl2);
            this.gb_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Game.Location = new System.Drawing.Point(0, 0);
            this.gb_Game.Name = "gb_Game";
            this.gb_Game.Size = new System.Drawing.Size(571, 173);
            this.gb_Game.TabIndex = 5;
            this.gb_Game.TabStop = false;
            this.gb_Game.Text = "Game";
            // 
            // lue_Nome_Player
            // 
            this.lue_Nome_Player.EditValue = "";
            this.lue_Nome_Player.Location = new System.Drawing.Point(102, 23);
            this.lue_Nome_Player.Name = "lue_Nome_Player";
            this.lue_Nome_Player.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_Nome_Player.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nome", "Nome")});
            this.lue_Nome_Player.Properties.DisplayMember = "Nome";
            this.lue_Nome_Player.Properties.NullText = "";
            this.lue_Nome_Player.Properties.ValueMember = "Codigo";
            this.lue_Nome_Player.Size = new System.Drawing.Size(315, 20);
            this.lue_Nome_Player.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Nome Player:";
            // 
            // lue_Game
            // 
            this.lue_Game.EditValue = "";
            this.lue_Game.Location = new System.Drawing.Point(102, 49);
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
            this.lue_Game.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Nome Game:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Location = new System.Drawing.Point(34, 78);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(62, 13);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome Morte:";
            // 
            // txt_Nome_Morte
            // 
            this.txt_Nome_Morte.Location = new System.Drawing.Point(102, 75);
            this.txt_Nome_Morte.Name = "txt_Nome_Morte";
            this.txt_Nome_Morte.Size = new System.Drawing.Size(315, 20);
            this.txt_Nome_Morte.TabIndex = 3;
            // 
            // txt_Dano
            // 
            this.txt_Dano.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_Dano.Location = new System.Drawing.Point(102, 101);
            this.txt_Dano.Name = "txt_Dano";
            this.txt_Dano.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Dano.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_Dano.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_Dano.Size = new System.Drawing.Size(124, 20);
            this.txt_Dano.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(67, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Dano:";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 178);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(571, 5);
            this.pnl_Bottom.TabIndex = 13;
            // 
            // pnl_Right
            // 
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Right.Location = new System.Drawing.Point(571, 5);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(5, 178);
            this.pnl_Right.TabIndex = 12;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(576, 5);
            this.pnl_Top.TabIndex = 11;
            // 
            // Morte_Manter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 183);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_Botao);
            this.Controls.Add(this.pnl_Fill);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Morte_Manter";
            this.Text = "Cadastrar Morte";
            this.Shown += new System.EventHandler(this.Morte_Manter_Shown);
            this.pnl_Botao.ResumeLayout(false);
            this.pnl_Fill.ResumeLayout(false);
            this.gb_Game.ResumeLayout(false);
            this.gb_Game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Nome_Player.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Game.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Morte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Dano.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl_Botao;
        private DevExpress.XtraEditors.SimpleButton btn_Fechar;
        private DevExpress.XtraEditors.SimpleButton btn_Salvar;
        private System.Windows.Forms.Panel pnl_Fill;
        private System.Windows.Forms.GroupBox gb_Game;
        private DevExpress.XtraEditors.LabelControl lbl_Nome;
        private DevExpress.XtraEditors.TextEdit txt_Nome_Morte;
        private DevExpress.XtraEditors.SpinEdit txt_Dano;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Panel pnl_Top;
        private DevExpress.XtraEditors.LookUpEdit lue_Game;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lue_Nome_Player;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}