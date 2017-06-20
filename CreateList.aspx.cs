using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateList : System.Web.UI.Page
{
    KetNoi db = new KetNoi();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            db.ThucThiCauLenhSQL("INSERT INTO tbl_Category (categoryName) VALUES ('" + txtCategoryName.Text + "')");
            Response.Write("<script>alert('Tạo thành công'); window.location='Index.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>alert('Tạo thất bại'); window.location='CreateList.aspx'</script>");
        }
    }
}