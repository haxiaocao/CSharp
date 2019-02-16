using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Xiaocao.Asp.Demo.Controller;

namespace Xiaocao.Asp.Demo
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //on the first time to load the pages.
            if (!Page.IsPostBack)
            {
                txtName.Text = "姓名";
                txtPosition.Text = "职称";
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            txtName.Text = "姓名 ok";
            txtPosition.Text = "职称 ok";
        }

        protected void btnEnd_Click(object sender, EventArgs e)
        {

        }

        protected void linkBaidu_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("www.baidu.com");
            //Response.Redirect("www.baidu.com");
            DataInterface inf = new DataInterface();
            List<PersonInfo> list = inf.GetPersonList();
            GridDemo.DataSource = list;
            GridDemo.DataBind();  //这句一定要有

        }
    }
}