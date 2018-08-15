namespace Analisador_Log_Listar
{
    partial class Analisador_Log_Listar
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analisador_Log_Listar));
            this.Listar_Mortes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bol_Codigo_Morte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nome_Player = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Dano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Log = new DevExpress.XtraGrid.GridControl();
            this.gv_Log = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nome_Game = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Fill = new System.Windows.Forms.Panel();
            this.pnl_Filtro = new System.Windows.Forms.Panel();
            this.gb_Filtro = new System.Windows.Forms.GroupBox();
            this.lbl_Nome = new DevExpress.XtraEditors.LabelControl();
            this.txt_Nome_Game = new DevExpress.XtraEditors.TextEdit();
            this.btn_Limpar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Pesquisar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Listar_Mortes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Log)).BeginInit();
            this.pnl_Fill.SuspendLayout();
            this.pnl_Filtro.SuspendLayout();
            this.gb_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Game.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Listar_Mortes
            // 
            this.Listar_Mortes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bol_Codigo_Morte,
            this.col_Nome_Player,
            this.col_Dano});
            this.Listar_Mortes.GridControl = this.gc_Log;
            this.Listar_Mortes.Name = "Listar_Mortes";
            // 
            // bol_Codigo_Morte
            // 
            this.bol_Codigo_Morte.Caption = "Codigo";
            this.bol_Codigo_Morte.FieldName = "Codigo_Morte";
            this.bol_Codigo_Morte.Name = "bol_Codigo_Morte";
            // 
            // col_Nome_Player
            // 
            this.col_Nome_Player.Caption = "Player";
            this.col_Nome_Player.FieldName = "Nome_Player";
            this.col_Nome_Player.Name = "col_Nome_Player";
            this.col_Nome_Player.Visible = true;
            this.col_Nome_Player.VisibleIndex = 0;
            // 
            // col_Dano
            // 
            this.col_Dano.Caption = "Dano";
            this.col_Dano.FieldName = "Dano";
            this.col_Dano.Name = "col_Dano";
            this.col_Dano.Visible = true;
            this.col_Dano.VisibleIndex = 1;
            // 
            // gc_Log
            // 
            this.gc_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.Listar_Mortes;
            gridLevelNode1.RelationName = "Level1";
            this.gc_Log.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_Log.Location = new System.Drawing.Point(0, 98);
            this.gc_Log.MainView = this.gv_Log;
            this.gc_Log.Name = "gc_Log";
            this.gc_Log.Size = new System.Drawing.Size(636, 357);
            this.gc_Log.TabIndex = 2;
            this.gc_Log.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Log,
            this.Listar_Mortes});
            // 
            // gv_Log
            // 
            this.gv_Log.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Codigo,
            this.col_Nome_Game});
            this.gv_Log.GridControl = this.gc_Log;
            this.gv_Log.Name = "gv_Log";
            // 
            // col_Codigo
            // 
            this.col_Codigo.Caption = "Código";
            this.col_Codigo.FieldName = "Codigo";
            this.col_Codigo.Name = "col_Codigo";
            // 
            // col_Nome_Game
            // 
            this.col_Nome_Game.Caption = "Nome Game";
            this.col_Nome_Game.FieldName = "Nome_Game";
            this.col_Nome_Game.Name = "col_Nome_Game";
            this.col_Nome_Game.Visible = true;
            this.col_Nome_Game.VisibleIndex = 0;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(646, 5);
            this.pnl_Top.TabIndex = 0;
            // 
            // pnl_Left
            // 
            this.pnl_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Left.Location = new System.Drawing.Point(0, 5);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(5, 460);
            this.pnl_Left.TabIndex = 1;
            // 
            // pnl_Right
            // 
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Right.Location = new System.Drawing.Point(641, 5);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(5, 460);
            this.pnl_Right.TabIndex = 2;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(5, 460);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(636, 5);
            this.pnl_Bottom.TabIndex = 3;
            // 
            // pnl_Fill
            // 
            this.pnl_Fill.Controls.Add(this.gc_Log);
            this.pnl_Fill.Controls.Add(this.pnl_Filtro);
            this.pnl_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fill.Location = new System.Drawing.Point(5, 5);
            this.pnl_Fill.Name = "pnl_Fill";
            this.pnl_Fill.Size = new System.Drawing.Size(636, 455);
            this.pnl_Fill.TabIndex = 4;
            // 
            // pnl_Filtro
            // 
            this.pnl_Filtro.Controls.Add(this.gb_Filtro);
            this.pnl_Filtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Filtro.Location = new System.Drawing.Point(0, 0);
            this.pnl_Filtro.Name = "pnl_Filtro";
            this.pnl_Filtro.Size = new System.Drawing.Size(636, 98);
            this.pnl_Filtro.TabIndex = 0;
            // 
            // gb_Filtro
            // 
            this.gb_Filtro.Controls.Add(this.lbl_Nome);
            this.gb_Filtro.Controls.Add(this.txt_Nome_Game);
            this.gb_Filtro.Controls.Add(this.btn_Limpar);
            this.gb_Filtro.Controls.Add(this.btn_Pesquisar);
            this.gb_Filtro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Filtro.Location = new System.Drawing.Point(0, 0);
            this.gb_Filtro.Name = "gb_Filtro";
            this.gb_Filtro.Size = new System.Drawing.Size(636, 98);
            this.gb_Filtro.TabIndex = 0;
            this.gb_Filtro.TabStop = false;
            this.gb_Filtro.Text = "Filtros";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Location = new System.Drawing.Point(25, 36);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(27, 13);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_Nome_Game
            // 
            this.txt_Nome_Game.Location = new System.Drawing.Point(60, 33);
            this.txt_Nome_Game.Name = "txt_Nome_Game";
            this.txt_Nome_Game.Size = new System.Drawing.Size(256, 20);
            this.txt_Nome_Game.TabIndex = 2;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.ImageOptions.Image")));
            this.btn_Limpar.Location = new System.Drawing.Point(191, 59);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(125, 33);
            this.btn_Limpar.TabIndex = 1;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.ImageOptions.Image")));
            this.btn_Pesquisar.Location = new System.Drawing.Point(60, 59);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(125, 33);
            this.btn_Pesquisar.TabIndex = 0;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // Analisador_Log_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 465);
            this.Controls.Add(this.pnl_Fill);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_Right);
            this.Controls.Add(this.pnl_Left);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Analisador_Log_Listar";
            this.Text = "Analisador de Log";
            this.Shown += new System.EventHandler(this.Analisador_Log_Listar_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Listar_Mortes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Log)).EndInit();
            this.pnl_Fill.ResumeLayout(false);
            this.pnl_Filtro.ResumeLayout(false);
            this.gb_Filtro.ResumeLayout(false);
            this.gb_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nome_Game.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_Fill;
        private System.Windows.Forms.Panel pnl_Filtro;
        private System.Windows.Forms.GroupBox gb_Filtro;
        private DevExpress.XtraEditors.SimpleButton btn_Pesquisar;
        private DevExpress.XtraEditors.SimpleButton btn_Limpar;
        private DevExpress.XtraEditors.TextEdit txt_Nome_Game;
        private DevExpress.XtraEditors.LabelControl lbl_Nome;
        private DevExpress.XtraGrid.GridControl gc_Log;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Log;
        private DevExpress.XtraGrid.Views.Grid.GridView Listar_Mortes;
        private DevExpress.XtraGrid.Columns.GridColumn bol_Codigo_Morte;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nome_Player;
        private DevExpress.XtraGrid.Columns.GridColumn col_Dano;
        private DevExpress.XtraGrid.Columns.GridColumn col_Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nome_Game;
    }
}

