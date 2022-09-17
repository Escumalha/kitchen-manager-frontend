namespace InterfaceGrafica
{
    partial class frmShopList
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
            this.lvShopList = new System.Windows.Forms.ListView();
            this.chProdSL = new System.Windows.Forms.ColumnHeader();
            this.chQntSL = new System.Windows.Forms.ColumnHeader();
            this.btnExpt = new System.Windows.Forms.Button();
            this.lbListaShop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvShopList
            // 
            this.lvShopList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdSL,
            this.chQntSL});
            this.lvShopList.Location = new System.Drawing.Point(12, 44);
            this.lvShopList.Name = "lvShopList";
            this.lvShopList.Size = new System.Drawing.Size(423, 355);
            this.lvShopList.TabIndex = 0;
            this.lvShopList.UseCompatibleStateImageBehavior = false;
            this.lvShopList.View = System.Windows.Forms.View.Details;
            // 
            // chProdSL
            // 
            this.chProdSL.Text = "Produto";
            this.chProdSL.Width = 160;
            // 
            // chQntSL
            // 
            this.chQntSL.Text = "Quantidade";
            this.chQntSL.Width = 160;
            // 
            // btnExpt
            // 
            this.btnExpt.Location = new System.Drawing.Point(441, 376);
            this.btnExpt.Name = "btnExpt";
            this.btnExpt.Size = new System.Drawing.Size(153, 23);
            this.btnExpt.TabIndex = 1;
            this.btnExpt.Text = "Exportar lista de compras";
            this.btnExpt.UseVisualStyleBackColor = true;
            this.btnExpt.Click += new System.EventHandler(this.btnExpt_Click);
            // 
            // lbListaShop
            // 
            this.lbListaShop.AutoSize = true;
            this.lbListaShop.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbListaShop.Location = new System.Drawing.Point(12, 21);
            this.lbListaShop.Name = "lbListaShop";
            this.lbListaShop.Size = new System.Drawing.Size(121, 20);
            this.lbListaShop.TabIndex = 12;
            this.lbListaShop.Text = "Lista de compras";
            // 
            // frmShopList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 411);
            this.Controls.Add(this.lbListaShop);
            this.Controls.Add(this.btnExpt);
            this.Controls.Add(this.lvShopList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShopList";
            this.Text = "frmShopList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvShopList;
        private ColumnHeader chProdSL;
        private ColumnHeader chQntSL;
        private Button btnExpt;
        private Label lbListaShop;
    }
}