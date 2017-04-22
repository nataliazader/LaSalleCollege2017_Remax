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
using WinFormWebApp_Remax_Zader.DATASOURCE;

namespace WinFormWebApp_Remax_Zader.GUI
{
    public partial class frmEmployee : Form
    {
        public static List<Language> listLanguages;
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
            listLanguages = new List<Language>();
            DataSetRemax dataSetRemax = new DataSetRemax();
            DataSetRemaxTableAdapters.LanguagesTableAdapter adp = new DataSetRemaxTableAdapters.LanguagesTableAdapter();
            adp.Fill(dataSetRemax.Languages);
            cboLanguages.ValueMember = "refLanguage";
            cboLanguages.DisplayMember = "Language";
            cboLanguages.DataSource = dataSetRemax.Languages;

            cboERole.Items.Add("Admin");
            cboERole.Items.Add("Agent");
            cboERole.Text = "Agent";

            if (frmManage.mode == "edit")
            {
                Agent agent = frmManage.agent;
                txtEName.Text = agent.Name;
                txtEPhone.Text = agent.Phone;
                txtEEmail.Text = agent.Email;
                cboERole.Text = agent.Role;
                radEMale.Checked = (agent.Gender.Contains('m')) ? true : false;
                radEFemale.Checked = (agent.Gender.Contains('f')) ? true : false;
                txtEPassword.Text = agent.Password;
                txtEAddress.Text = agent.Address;
                listLanguages = agent.Languages;
                displayLang();
            }
            else
            {
                btnAdd.Enabled = btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Language lang = new Language(cboLanguages.SelectedValue.ToString(), cboLanguages.Text);
            var already = from l in listLanguages
                          where l.Id == lang.Id
                          select l;
            if (already.Count() == 0)
                listLanguages.Add(lang);
            else 
                MessageBox.Show(lang.Name + " has been already added.");
            displayLang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {           
            if (listLanguages.Count != 0)
            {
                foreach (Language lang in listLanguages)
                    if (lang.Id == lboLanguages.SelectedValue.ToString())
                    {
                        listLanguages.Remove(lang);
                        displayLang();
                        return;
                    }
            }
            else
                MessageBox.Show("The list is empty.");

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
            gender = (radEFemale.Checked) ? "f" : "m" ;
            Agent agent =(frmManage.mode =="edit")? new Agent(frmManage.agent.Id,txtEName.Text, txtEPhone.Text,txtEEmail.Text, cboERole.Text,gender,txtEAddress.Text,"1",listLanguages,txtEPassword.Text): new Agent(txtEName.Text, txtEPhone.Text, txtEEmail.Text, cboERole.Text, gender, txtEAddress.Text, "1", listLanguages, txtEPassword.Text);
            if (frmManage.mode == "add")
            {
                frmLogin.admin.Employees = Remax.TabEmployees();
                frmLogin.admin.Languages = Remax.TabLanguages();
                frmLogin.admin.AddEmployee(agent);
                EmployeeDB.UpdateEmployeesDB(frmLogin.admin.Employees, frmLogin.admin.Languages);
            }
            if (frmManage.mode == "edit")
            {
                frmLogin.admin.Employees = Remax.TabEmployees();
                frmLogin.admin.Languages = Remax.TabLanguages();
                frmLogin.admin.EditEmployee(agent);
                EmployeeDB.UpdateEmployeesDB(frmLogin.admin.Employees, frmLogin.admin.Languages);
            }
            this.Close();
        }
    }
}
