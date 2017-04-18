using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryRemax;

namespace WinFormWebApp_Remax_Zader.GUI
{
    public partial class frmEmployee : Form
    {
        List<Language> listLanguages = new List<Language>();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            listLanguages = null;
            DataSetRemax dataSetRemax = new DataSetRemax();
            DataSetRemaxTableAdapters.LanguagesTableAdapter adp = new DataSetRemaxTableAdapters.LanguagesTableAdapter();
            adp.Fill(dataSetRemax.Languages);
            cboLanguages.ValueMember = "refLanguage";
            cboLanguages.DisplayMember = "Language";
            cboLanguages.DataSource = dataSetRemax.Languages;

            cboERole.Items.Add("admin");
            cboERole.Items.Add("agent");
            cboERole.Text = "agent";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listLanguages.Add(new Language(cboLanguages.SelectedValue.ToString(),cboLanguages.Text));
            displayLang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lboLanguages.SelectedValue.ToString() != "")
                foreach (Language lang in listLanguages)
                    if (lang.Id == lboLanguages.SelectedValue.ToString())
                    {
                        listLanguages.Remove(lang);
                        displayLang();
                        return;
                    }
                    else
                        MessageBox.Show("To delete, select language from the list.");

        }

        private void displayLang()
        {
            lboLanguages.DataSource = null;
            lboLanguages.DataSource = listLanguages;
            lboLanguages.DisplayMember = "Name";
            lboLanguages.ValueMember = "Id";
        }

        private void btnESave_Click(object sender, EventArgs e)
        {
            string gender="";
            gender = (cboERole.Text == "Female") ? "f" : "m" ;
            Employee emp = (cboERole.Text =="agent") ? new Agent(txtEName.Text, txtEPhone.Text,txtEEmail.Text,cboERole.Text,txtEPassword.Text,gender,txtEAddress.Text,listLanguages,txtEPassword.Text) : new Employee(txtEName.Text, txtEPhone.Text, txtEEmail.Text, cboERole.Text, txtEPassword.Text);
            frmLogin.admin.AddEmployee(emp);
        }
    }
}
