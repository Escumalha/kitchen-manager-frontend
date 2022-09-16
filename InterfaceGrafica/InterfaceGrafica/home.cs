namespace InterfaceGrafica
{
    public partial class home : Form
    {

        private Form frmAtivo;

        public home()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelEstoque.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if(frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

   

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnShopList_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            FormShow(new frmShopList());
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            FormShow(new frmRecipes());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRmv_Click(object sender, EventArgs e)
        {

        }

        private void txtNameProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQntProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
        }

        private void lvProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelEstoque_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}