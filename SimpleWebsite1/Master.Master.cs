﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleWebsite1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label label = (Label)ContentPlaceHolder1.FindControl("lblSomeMessage");
            //label.Text = "Hello from master page";
        }
    }
}