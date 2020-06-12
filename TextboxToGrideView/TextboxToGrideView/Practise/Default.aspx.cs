using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Specialized;
using System.Text;

namespace TextboxToGrideView.Practise
{
    public partial class Default : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            //dt = new DataTable();
            //DataColumn dc1 = new DataColumn("NAME");
            //DataColumn dc2 = new DataColumn("ADDRESS");
            //dt.Columns.Add(dc1);
            //dt.Columns.Add(dc2);
            //DataRow dr1 = dt.NewRow();
            //GridView1.DataSource = dt;
            //GridView1.DataBind();

            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] {
            new DataColumn("NAME"), new DataColumn("ADDRESS"),new DataColumn("roll")
        });
                ViewState["Emp"] = dt;
                this.BindGrid();

               
            }

          



        }
        protected void BindGrid()
        {
            GridView1.DataSource = (DataTable)ViewState["Emp"];
            GridView1.DataBind();
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //DataRow dr1 = dt.NewRow();
            //dr1[0] = txtName.Text;
            //dr1[1] = txtADDRESS.Text;
            //dt.Rows.Add(dr1);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();

            DataTable dt = (DataTable)ViewState["Emp"];
            dt.Rows.Add(txtName.Text.Trim(), txtADDRESS.Text.Trim(), txtRoll.Text.Trim());
            ViewState["Emp"] = dt;
            this.BindGrid();
            txtName.Text = "";
            txtADDRESS.Text = "";
            txtRoll.Text = "";


          




        }







        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  
        protected void Button1_Click(object sender, EventArgs e)
        {
           


        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
           
        }
        string str = string.Empty;
        string strname = string.Empty;
        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

            
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
          
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string empidstr = string.Empty;

            string empnamestr = string.Empty;

            foreach (GridViewRow gridrows in GridView1.Rows)

            {

                CheckBox chkbox = (CheckBox)gridrows.FindControl("CheckBox1");

                if (chkbox != null & chkbox.Checked)

                {

                 //   empidstr += gvDetails.DataKeys[gridrows.RowIndex].Value.ToString() + ',';

                    empnamestr += gridrows.Cells[3].Text + ',';

                }

            }

            empidstr = empidstr.Trim(",".ToCharArray());

            empnamestr = empnamestr.Trim(",".ToCharArray());

            lblmsg.Text =  "</b><br/>" + "Employee Name: <b>" + empnamestr + "</b>";
        }
    }
}