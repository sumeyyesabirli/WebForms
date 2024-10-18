using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebProject.Admin
{
    public partial class PackagesList : System.Web.UI.Page
    {
        private ApplicationDbContext _context;

        protected void Page_Load(object sender, EventArgs e)
        {
            _context = new ApplicationDbContext();

            if (!IsPostBack)
            {
                LoadPackages();
            }
        }

        private void LoadPackages()
        {
            try
            {
                var packages = _context.Packages.ToList();

                // GridView'e verileri bağlıyoruz
                GridView1.DataSource = packages;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Hata oluştu: " + ex.Message);
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadPackages();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadPackages();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadPackages();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int packageId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            var package = _context.Packages.FirstOrDefault(p => p.Id == packageId);

            if (package != null)
            {
                GridViewRow row = GridView1.Rows[e.RowIndex];

                var name = ((TextBox)row.Cells[1].Controls[0]).Text;
                var priceText = ((TextBox)row.Cells[2].Controls[0]).Text;
                var duration = ((TextBox)row.Cells[3].Controls[0]).Text;
                var location = ((TextBox)row.Cells[4].Controls[0]).Text;
                var detail = ((TextBox)row.Cells[5].Controls[0]).Text;

                package.Name = name;
                package.Price = decimal.Parse(priceText);
                package.Duration = duration;
                package.Location = location;
                package.Detail = detail;

                _context.SaveChanges();
            }

            GridView1.EditIndex = -1;
            LoadPackages();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int packageId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            var package = _context.Packages.FirstOrDefault(p => p.Id == packageId);

            if (package != null)
            {
                _context.Packages.Remove(package);
                _context.SaveChanges();
            }

            LoadPackages();
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
