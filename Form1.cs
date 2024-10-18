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
    public partial class Form1 : Form
    {
        IContactRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgListInformation();
        }

        private void dgListInformation()
        {
            dgList.AutoGenerateColumns = false;
            dgList.DataSource = repository.SelectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgListInformation();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAddEdit form1 = new FormAddEdit();
            form1.ShowDialog();
            if (form1.DialogResult == DialogResult.OK)
            {
                dgListInformation();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string FullName = dgList.CurrentRow.Cells[1].Value.ToString() + " " + dgList.CurrentRow.Cells[2].Value.ToString();
            if (dgList.CurrentRow == null)
            {
                MessageBox.Show("لطفا ستونی را انتخاب کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"آیا {FullName} حذف شود ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    repository.Delete(int.Parse(dgList.CurrentRow.Cells[0].Value.ToString()));
                    dgListInformation();
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgList.CurrentRow == null)
            {
                MessageBox.Show("لطفا ستونی را انتخاب کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ContactID = int.Parse(dgList.CurrentRow.Cells[0].Value.ToString());
                FormAddEdit frm = new FormAddEdit();
                frm.Contacid = ContactID;
                frm.ShowDialog();
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    dgListInformation();
                }

            }

            

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgList.DataSource = repository.Search(txtSearch.Text);
        }
    }
}
