using Microsoft.EntityFrameworkCore;
using Store.Models;
using Store.Models.Context;
using Store.Models.User;
using Store.ViewControl;

namespace Store
{
    public partial class Form1 : Form
    {

        PlaystationStoreContext context;
        CurrentUser currentuser;
        public Form1()
        {
            InitializeComponent();
            context = new PlaystationStoreContext();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnLogin(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;

            var user = context.SystemUsers
                .Where(user => (user.UserName == username && user.PassWord == password))
                .Include(r => r.Role)
                .Include(b => b.Branch)
                .Select(u => new
                {
                    Username = u.UserName
                ,
                    Role = u.Role.Name
                ,
                    BranchID = u.Branch.BranchId
                ,
                    RoleId = u.RoleId ,

                    isActive = u.isActive
                ,
                    BranchName = u.Branch.BranchName
                })
                .FirstOrDefault();

            if (user != null && user.isActive)
            {
                currentuser = CurrentUser.Instance;


                currentuser.Role = user.Role;
                currentuser.UserName = user.Username;
                currentuser.BranchId = user.BranchID;
                currentuser.RoleId = user.RoleId;
                currentuser.Branch = user.BranchName; 

                if (user.Role == "Cashier")
                //if (true)
                {

                    CashierDashboard ChDB = new CashierDashboard();
                    ChDB.Show();
                    //this.Close(); 
                }
                else if (user.Role == "Admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    //this.Close();

                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
}
