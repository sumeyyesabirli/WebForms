using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProject.Admin
{
    public partial class PackagesList : System.Web.UI.Page
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();

            }
        }
        private void BindGridView()
        {
            var packages = _context.Packages
                                   .Select(p => new
                                   {
                                       p.Id,
                                       p.Name,
                                       p.Price,
                                       p.Duration,
                                       p.Location,
                                       p.Image,
                                       p.Detail
                                   })
                                   .ToList();

            GridView1.DataSource = packages;
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Guncelle")
            {
                int paketID = Convert.ToInt32(e.CommandArgument);

                var package = _context.Packages.Find(paketID);
                if (package != null)
                {
                    hiddenPackageId.Value = package.Id.ToString();
                    txtPackageName.Text = package.Name;
                    txtPrice.Text = package.Price.ToString();
                    txtDuration.Text = package.Duration;
                    txtLocation.Text = package.Location;

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }
            }
            else if (e.CommandName == "Sil")
            {
                int paketID = Convert.ToInt32(e.CommandArgument);
                var package = _context.Packages.Find(paketID);
                if (package != null)
                {
                    _context.Packages.Remove(package);
                    _context.SaveChanges();
                }

                BindGridView();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int paketID = Convert.ToInt32(hiddenPackageId.Value);

            var package = _context.Packages.Find(paketID);
            if (package != null)
            {
                package.Name = txtPackageName.Text;
                package.Price = Convert.ToDecimal(txtPrice.Text);
                package.Duration = txtDuration.Text;
                package.Location = txtLocation.Text;

                _context.SaveChanges();
            }

            BindGridView();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "closeModal();", true);
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView();
        }
    }
}
