using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateItem : System.Web.UI.Page
{
    KetNoi db = new KetNoi();
    DateTime homNay = DateTime.Now;
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.DataSource = db.GetDataTable("SELECT * FROM tbl_Category");
            DropDownList1.DataTextField = "categoryName";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
        }
    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        try
        {
            db.ThucThiCauLenhSQL("INSERT INTO tbl_Todo(title, description, created_at) VALUES('" + txtTitle.Text + "','" + txtDescription.Text + "','" + homNay.Year.ToString() + "/" + homNay.Month.ToString() + "/" + homNay.Day.ToString() + "')");
            dt = db.GetDataTable("SELECT tbl_Todo.ID FROM tbl_Todo");
            int idTodo = 0;
            foreach (DataRow r in dt.Rows)
            {
                idTodo = int.Parse(r[0].ToString());
            }
            db.ThucThiCauLenhSQL("INSERT INTO tbl_List(todoID,categoryID) VALUES('" + idTodo.ToString() + "', '" + DropDownList1.SelectedValue.ToString() + "')");
            Response.Write("<script>alert('Tạo thành công'); window.location='Index.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>alert('Tạo thất bại'); window.location='CreateItem.aspx'</script>");
        }
    }
}