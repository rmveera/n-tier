using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OSCBLL;
using OSCBOL;
using OSCUI;

namespace OSCUI
{
    public partial class Products : System.Web.UI.Page
    {
        ProductBs productBs;
        public Products() {
            productBs = new ProductBs();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Product> products = productBs.GetAllProducts();
            GridView1.DataSource = products;
            GridView1.DataKeyNames = new string[] { "ProductId" };
            GridView1.DataBind();
        }
    }
}