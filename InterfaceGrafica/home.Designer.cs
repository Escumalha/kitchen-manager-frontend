namespace InterfaceGrafica
{
    partial class home
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
            this.lvProd = new System.Windows.Forms.ListView();
            this.chProdName = new System.Windows.Forms.ColumnHeader();
            this.chProdQnt = new System.Windows.Forms.ColumnHeader();
            this.btnShopList = new System.Windows.Forms.Button();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnRecipes = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameProd = new System.Windows.Forms.TextBox();
            this.txtQntProd = new System.Windows.Forms.TextBox();
            this.lbProdName = new System.Windows.Forms.Label();
            this.lbProdQnt = new System.Windows.Forms.Label();
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.lbListaEstoq = new System.Windows.Forms.Label();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.lbQntMin = new System.Windows.Forms.Label();
            this.txtBQntMin = new System.Windows.Forms.TextBox();
            this.btnRmv = new System.Windows.Forms.Button();
            this.panelBtns.SuspendLayout();
            this.panelEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProd
            // 
            this.lvProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdName,
            this.chProdQnt});
            this.lvProd.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvProd.Location = new System.Drawing.Point(12, 43);
            this.lvProd.Name = "lvProd";
            this.lvProd.Size = new System.Drawing.Size(423, 355);
            this.lvProd.TabIndex = 0;
            this.lvProd.UseCompatibleStateImageBehavior = false;
            this.lvProd.View = System.Windows.Forms.View.Details;
            this.lvProd.SelectedIndexChanged += new System.EventHandler(this.lvProd_SelectedIndexChanged);
            // 
            // chProdName
            // 
            this.chProdName.Text = "Nome do Produto";
            this.chProdName.Width = 160;
            // 
            // chProdQnt
            // 
            this.chProdQnt.Text = "Quantidade";
            this.chProdQnt.Width = 160;
            // 
            // btnShopList
            // 
            this.btnShopList.FlatAppearance.BorderSize = 0;
            this.btnShopList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopList.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShopList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(195)))), ((int)(((byte)(164)))));
            this.btnShopList.Location = new System.Drawing.Point(119, 0);
            this.btnShopList.Name = "btnShopList";
            this.btnShopList.Size = new System.Drawing.Size(153, 41);
            this.btnShopList.TabIndex = 1;
            this.btnShopList.Text = "Lista de compras";
            this.btnShopList.UseVisualStyleBackColor = true;
            this.btnShopList.Click += new System.EventHandler(this.btnShopList_Click);
            // 
            // panelBtns
            // 
            this.panelBtns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(31)))), ((int)(((byte)(14)))));
            this.panelBtns.Controls.Add(this.btnEstoque);
            this.panelBtns.Controls.Add(this.btnRecipes);
            this.panelBtns.Controls.Add(this.btnShopList);
            this.panelBtns.Location = new System.Drawing.Point(0, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(757, 41);
            this.panelBtns.TabIndex = 1;
            this.panelBtns.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(195)))), ((int)(((byte)(164)))));
            this.btnEstoque.Location = new System.Drawing.Point(278, 0);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(113, 41);
            this.btnEstoque.TabIndex = 12;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnRecipes
            // 
            this.btnRecipes.FlatAppearance.BorderSize = 0;
            this.btnRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipes.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecipes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(195)))), ((int)(((byte)(164)))));
            this.btnRecipes.Location = new System.Drawing.Point(0, 0);
            this.btnRecipes.Name = "btnRecipes";
            this.btnRecipes.Size = new System.Drawing.Size(113, 41);
            this.btnRecipes.TabIndex = 0;
            this.btnRecipes.Text = "Receitas";
            this.btnRecipes.Click += new System.EventHandler(this.btnRecipes_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(118)))), ((int)(((byte)(86)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(545, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar produto";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNameProd
            // 
            this.txtNameProd.Location = new System.Drawing.Point(589, 43);
            this.txtNameProd.Name = "txtNameProd";
            this.txtNameProd.Size = new System.Drawing.Size(156, 22);
            this.txtNameProd.TabIndex = 4;
            this.txtNameProd.TextChanged += new System.EventHandler(this.txtNameProd_TextChanged);
            // 
            // txtQntProd
            // 
            this.txtQntProd.Location = new System.Drawing.Point(589, 72);
            this.txtQntProd.Name = "txtQntProd";
            this.txtQntProd.Size = new System.Drawing.Size(156, 22);
            this.txtQntProd.TabIndex = 5;
            this.txtQntProd.TextChanged += new System.EventHandler(this.txtQntProd_TextChanged);
            // 
            // lbProdName
            // 
            this.lbProdName.AutoSize = true;
            this.lbProdName.BackColor = System.Drawing.Color.Transparent;
            this.lbProdName.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProdName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbProdName.Location = new System.Drawing.Point(461, 42);
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(121, 20);
            this.lbProdName.TabIndex = 6;
            this.lbProdName.Text = "Nome do produto";
            // 
            // lbProdQnt
            // 
            this.lbProdQnt.AutoSize = true;
            this.lbProdQnt.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProdQnt.Location = new System.Drawing.Point(502, 72);
            this.lbProdQnt.Name = "lbProdQnt";
            this.lbProdQnt.Size = new System.Drawing.Size(80, 20);
            this.lbProdQnt.TabIndex = 7;
            this.lbProdQnt.Text = "Quantidade";
            // 
            // panelEstoque
            // 
            this.panelEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(195)))), ((int)(((byte)(164)))));
            this.panelEstoque.Controls.Add(this.lbListaEstoq);
            this.panelEstoque.Controls.Add(this.btnEditProd);
            this.panelEstoque.Controls.Add(this.lbQntMin);
            this.panelEstoque.Controls.Add(this.txtBQntMin);
            this.panelEstoque.Controls.Add(this.btnRmv);
            this.panelEstoque.Controls.Add(this.txtQntProd);
            this.panelEstoque.Controls.Add(this.lbProdQnt);
            this.panelEstoque.Controls.Add(this.btnAdd);
            this.panelEstoque.Controls.Add(this.lbProdName);
            this.panelEstoque.Controls.Add(this.txtNameProd);
            this.panelEstoque.Controls.Add(this.lvProd);
            this.panelEstoque.Font = new System.Drawing.Font("Aileron Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelEstoque.Location = new System.Drawing.Point(0, 40);
            this.panelEstoque.Name = "panelEstoque";
            this.panelEstoque.Size = new System.Drawing.Size(757, 411);
            this.panelEstoque.TabIndex = 8;
            this.panelEstoque.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEstoque_Paint);
            // 
            // lbListaEstoq
            // 
            this.lbListaEstoq.AutoSize = true;
            this.lbListaEstoq.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbListaEstoq.Location = new System.Drawing.Point(12, 20);
            this.lbListaEstoq.Name = "lbListaEstoq";
            this.lbListaEstoq.Size = new System.Drawing.Size(115, 20);
            this.lbListaEstoq.TabIndex = 11;
            this.lbListaEstoq.Text = "Lista de produtos";
            // 
            // btnEditProd
            // 
            this.btnEditProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(118)))), ((int)(((byte)(86)))));
            this.btnEditProd.FlatAppearance.BorderSize = 0;
            this.btnEditProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProd.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditProd.Location = new System.Drawing.Point(646, 170);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(99, 34);
            this.btnEditProd.TabIndex = 10;
            this.btnEditProd.Text = "Editar";
            this.btnEditProd.UseVisualStyleBackColor = false;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // lbQntMin
            // 
            this.lbQntMin.AutoSize = true;
            this.lbQntMin.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQntMin.Location = new System.Drawing.Point(534, 101);
            this.lbQntMin.Name = "lbQntMin";
            this.lbQntMin.Size = new System.Drawing.Size(130, 20);
            this.lbQntMin.TabIndex = 9;
            this.lbQntMin.Text = "Quantidade minima";
            // 
            // txtBQntMin
            // 
            this.txtBQntMin.Location = new System.Drawing.Point(670, 101);
            this.txtBQntMin.Name = "txtBQntMin";
            this.txtBQntMin.Size = new System.Drawing.Size(75, 22);
            this.txtBQntMin.TabIndex = 8;
            // 
            // btnRmv
            // 
            this.btnRmv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(118)))), ((int)(((byte)(86)))));
            this.btnRmv.FlatAppearance.BorderSize = 0;
            this.btnRmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmv.Font = new System.Drawing.Font("Goudy Old Style", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRmv.Location = new System.Drawing.Point(545, 170);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(99, 34);
            this.btnRmv.TabIndex = 3;
            this.btnRmv.Text = "Remover";
            this.btnRmv.UseVisualStyleBackColor = false;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(195)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.panelBtns);
            this.Controls.Add(this.panelEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "home";
            this.Text = "Estoque Deli";
            this.Load += new System.EventHandler(this.home_Load);
            this.panelBtns.ResumeLayout(false);
            this.panelEstoque.ResumeLayout(false);
            this.panelEstoque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvProd;
        private ColumnHeader chProdName;
        private ColumnHeader chProdQnt;
        private Button btnShopList;
        private Panel panelBtns;
        private Button btnRecipes;
        private Button btnAdd;
        private TextBox txtNameProd;
        private TextBox txtQntProd;
        private Label lbProdName;
        private Label lbProdQnt;
        private Panel panelEstoque;
        private Button btnEditProd;
        private Label lbQntMin;
        private TextBox txtBQntMin;
        private Label lbListaEstoq;
        private Button btnRmv;
        private Button btnEstoque;
    }
}