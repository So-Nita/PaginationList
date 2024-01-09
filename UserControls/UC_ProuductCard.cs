 
using System.Windows.Forms;
using System;

namespace DataGridView_CS.UserControls
{
    public partial class UC_ProuductCard : UserControl
    {
        public event EventHandler ProductClicked;
        private Product _product;
        public Product Product
        {
            get { return _product; }
            set
            {
                _product = value;
                InitData();
            }
        }

        public UC_ProuductCard(Product product = null)
        {
            InitializeComponent();
            Product = product;
            btn_forBuy.Click += pictureItem_Click;
            pictureItem.Click += pictureItem_Click;
        }

        private void pictureItem_Click(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);

        }
        private void InitData()
        {
            labelNameItem.Text = Product.Name;
        }
    }
}
