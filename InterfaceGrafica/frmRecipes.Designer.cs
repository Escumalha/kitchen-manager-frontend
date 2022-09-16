namespace InterfaceGrafica
{
    partial class frmRecipes
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Ingredientes", System.Windows.Forms.HorizontalAlignment.Left);
            this.lvRecipe = new System.Windows.Forms.ListView();
            this.chRecipeName = new System.Windows.Forms.ColumnHeader();
            this.chRecipeItens = new System.Windows.Forms.ColumnHeader();
            this.btnAddRec = new System.Windows.Forms.Button();
            this.btnRmvRec = new System.Windows.Forms.Button();
            this.txtBNameRec = new System.Windows.Forms.TextBox();
            this.lbNameRec = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbItensRec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvRecipe
            // 
            this.lvRecipe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRecipeName,
            this.chRecipeItens});
            this.lvRecipe.Location = new System.Drawing.Point(12, 44);
            this.lvRecipe.Name = "lvRecipe";
            this.lvRecipe.Size = new System.Drawing.Size(423, 355);
            this.lvRecipe.TabIndex = 1;
            this.lvRecipe.UseCompatibleStateImageBehavior = false;
            this.lvRecipe.View = System.Windows.Forms.View.Details;
            this.lvRecipe.SelectedIndexChanged += new System.EventHandler(this.lvRecipe_SelectedIndexChanged);
            // 
            // chRecipeName
            // 
            this.chRecipeName.Text = "Nome da Receita";
            this.chRecipeName.Width = 160;
            // 
            // chRecipeItens
            // 
            this.chRecipeItens.Text = "Itens";
            this.chRecipeItens.Width = 160;
            // 
            // btnAddRec
            // 
            this.btnAddRec.Location = new System.Drawing.Point(572, 272);
            this.btnAddRec.Name = "btnAddRec";
            this.btnAddRec.Size = new System.Drawing.Size(75, 23);
            this.btnAddRec.TabIndex = 2;
            this.btnAddRec.Text = "Adicionar";
            this.btnAddRec.UseVisualStyleBackColor = true;
            this.btnAddRec.Click += new System.EventHandler(this.btnAddRec_Click);
            // 
            // btnRmvRec
            // 
            this.btnRmvRec.Location = new System.Drawing.Point(653, 272);
            this.btnRmvRec.Name = "btnRmvRec";
            this.btnRmvRec.Size = new System.Drawing.Size(75, 23);
            this.btnRmvRec.TabIndex = 3;
            this.btnRmvRec.Text = "Remover";
            this.btnRmvRec.UseVisualStyleBackColor = true;
            this.btnRmvRec.Click += new System.EventHandler(this.btnRmvRec_Click);
            // 
            // txtBNameRec
            // 
            this.txtBNameRec.Location = new System.Drawing.Point(628, 57);
            this.txtBNameRec.Name = "txtBNameRec";
            this.txtBNameRec.Size = new System.Drawing.Size(100, 23);
            this.txtBNameRec.TabIndex = 4;
            this.txtBNameRec.TextChanged += new System.EventHandler(this.txtBNameRec_TextChanged);
            // 
            // lbNameRec
            // 
            this.lbNameRec.AutoSize = true;
            this.lbNameRec.Location = new System.Drawing.Point(634, 39);
            this.lbNameRec.Name = "lbNameRec";
            this.lbNameRec.Size = new System.Drawing.Size(94, 15);
            this.lbNameRec.TabIndex = 6;
            this.lbNameRec.Text = "Nome da receita";
            // 
            // listView1
            // 
            listViewGroup2.Header = "Ingredientes";
            listViewGroup2.Name = "lvgItens";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.Location = new System.Drawing.Point(539, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(189, 180);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lbItensRec
            // 
            this.lbItensRec.AutoSize = true;
            this.lbItensRec.Location = new System.Drawing.Point(461, 86);
            this.lbItensRec.Name = "lbItensRec";
            this.lbItensRec.Size = new System.Drawing.Size(72, 15);
            this.lbItensRec.TabIndex = 8;
            this.lbItensRec.Text = "Ingredientes";
            // 
            // frmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 411);
            this.Controls.Add(this.lbItensRec);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbNameRec);
            this.Controls.Add(this.txtBNameRec);
            this.Controls.Add(this.btnRmvRec);
            this.Controls.Add(this.btnAddRec);
            this.Controls.Add(this.lvRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecipes";
            this.Text = "frmRecipes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvRecipe;
        private ColumnHeader chRecipeName;
        private ColumnHeader chRecipeItens;
        private Button btnAddRec;
        private Button btnRmvRec;
        private TextBox txtBNameRec;
        private Label lbNameRec;
        private ListView listView1;
        private Label lbItensRec;
    }
}