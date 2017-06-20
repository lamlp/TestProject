using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    KetNoi db = new KetNoi();
    DataTable dt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadData();
    }
    private void LoadData()
    {
        if (Request.QueryString["Category"] != null)
        {
            int id = int.Parse(Request.QueryString["Category"].ToString());
            dt = db.GetDataTable("SELECT tbl_Todo.* FROM tbl_List INNER JOIN tbl_Todo ON tbl_List.todoID = tbl_Todo.ID WHERE tbl_List.categoryID = '" + id +"'");
        }
        else dt = db.GetDataTable("SELECT * FROM tbl_Todo");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}