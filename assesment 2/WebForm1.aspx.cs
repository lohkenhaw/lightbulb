using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assesment_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        int flag = 1;

        public void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (ImageButton1.ImageUrl == "~/Images/lightoff.png")
            {
                ImageButton1.ImageUrl = "~/Images/lighton.png";
            }
            else
            {
                ImageButton1.ImageUrl = "~/Images/lightoff.png";
            }

        }

    }
}