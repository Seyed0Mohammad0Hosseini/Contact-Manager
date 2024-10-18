using ContactsProject.Repository;
using ContactsProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsProject
{
    public partial class FormAddEdit : Form
    {
        IContactRepository repository;
        public int Contacid = 0;
        public FormAddEdit()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSavedInformation_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                bool isSucces;
                if (Contacid == 0)
                {
                    isSucces = repository.Insert(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtJob.Text, txtAge.Text);
                }
                else
                {
                    isSucces = repository.Update(Contacid,txtFirstName.Text,txtLastName.Text,txtEmail.Text,txtJob.Text,txtAge.Text);
                }
                if (isSucces == true)
                {
                    MessageBox.Show("اطلاعات با موفقیت ذخیره شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("دریافت اطلاعات با خطا مواجه شد لطفا دوباره انجام دهید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }
        bool ValidateInputs()
        {
            bool Valid = true;
            if (txtFirstName.Text == "")
            {
                Valid = false;
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (txtLastName.Text == "")
                {
                    Valid = false;
                    MessageBox.Show("لطفا نام خانوادگی را وارد کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtAge.Text == "")
                    {
                        Valid = false;
                        MessageBox.Show("لطفا سن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Valid = true;
                    }
                }
            }

            return Valid;
        }

        private void grbNewInformation_Enter(object sender, EventArgs e)
        {

        }

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            if (Contacid == 0)
            {
                this.Text = "افزودن شخص جدید";
            }
            else
            {
                this.Text = "ویرایش";
                DataTable dt = repository.SelectRow(Contacid);
                txtFirstName.Text = dt.Rows[0][1].ToString();
                txtLastName.Text = dt.Rows[0][2].ToString();
                txtAge.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtJob.Text = dt.Rows[0][5].ToString();
                btnSavedInformation.Text = "ویرایش";
            }
        }
    }
}
