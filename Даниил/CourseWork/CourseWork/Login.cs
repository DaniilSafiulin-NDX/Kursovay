using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseWork
{
    public partial class Login : Form
    {
        private 
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = LogintextBox.Text;
            string Password = PasswordtextBox.Text;
            var query = from c in db.GetWorkerTable()
                        where c.Password == Password && c.LastName == Login
                        select c.Id;
            int a = query.ToList().FirstOrDefault();
            if (a == 0)
                MessageBox.Show("Неверная фамилия или пароль", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
