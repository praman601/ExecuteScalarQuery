using System;
using System.Data.SqlClient;

namespace ExecuteScalarQuery
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS;Initial Catalog=product;Integrated Security=true"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select count(ProductId) from tblProduct";
                cmd.Connection = con;
                con.Open();
                int rows=(int)cmd.ExecuteScalar();
                Response.Write("the number of product id is " + rows);


            }

        }
    }
}