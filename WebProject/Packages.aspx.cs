using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebProject
{
    public partial class Packages : System.Web.UI.Page
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPackages(); 
            }
        }

        private void BindPackages()
        {
            var packages = _context.Packages
                                   .Select(p => new
                                   {
                                       p.Name,           
                                       p.Price,          
                                       p.Image,          
                                       p.Duration,       
                                       p.Location,       
                                       p.Detail          
                                   })
                                   .ToList();

            RepeaterPackages.DataSource = packages;
            RepeaterPackages.DataBind();
        }
    }
}
