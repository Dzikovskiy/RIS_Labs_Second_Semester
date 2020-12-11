using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }
        
        protected void sumBtn_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                double sum = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                ResultLb.Visible = true;
                ResultLb.Text = sum.ToString();
            }
        }

        protected void minusBtn_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                double minus = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                ResultLb.Visible = true;
                ResultLb.Text = minus.ToString();
            }
        }

        protected void mulBtn_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                double mult = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                ResultLb.Visible = true;
                ResultLb.Text = mult.ToString();
            }
        }

        protected void divBtn_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                double div = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                ResultLb.Visible = true;
                ResultLb.Text = "         " + div.ToString();
            }
        }
    }
}