using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OnlineShoppingCart;
using OnlineShoppingCartBLL;

namespace OnlineShoppinCart_UI
{
    public partial class Products : System.Web.UI.Page
    {
        ProductBS productBS;
        public Products()
        {
            productBS = new ProductBS();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<OnlineShoppingCart.Product> products = productBS.GetAll();
            GridView1.DataSource = products;
            GridView1.DataKeyNames = new string[] {"ProductId"};
            GridView1.DataBind();
        }
    }
}