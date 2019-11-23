using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latemERPAmateurProgrammilityOpenSource
{
    public partial class frmLogin : Form
    {
        static Layers.OtherClass.AllMessages message = new Layers.OtherClass.AllMessages();
        Layers.Data.dataConnector databaseConn = new Layers.Data.dataConnector();

        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            Layers.Bussines.BussinesKullanici bussinesKullanici = new Layers.Bussines.BussinesKullanici();
            if (bussinesKullanici.userCheck(txtUserName.Text, txtPassword.Text))
            {
                databaseConn.baglantiKapat();
                frmMain anaForm = new frmMain();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                message.UyariMesaji("Lütfen kullanıcı adı ve şifrenizi kontrol ediniz!");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            databaseConn.baglantiAc();
        }
    }
}
