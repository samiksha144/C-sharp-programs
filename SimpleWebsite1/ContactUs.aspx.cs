﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleWebsite1
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSomeMessage.Text = "Some text";

            Label lblMasterLabel = (Label)Master.FindControl("lblMessageInMaster");
            lblMasterLabel.Text = "Hello from Child page";
        }
    }
}