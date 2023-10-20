using Business;
using Entity;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        private BusinessPerson _businessPerson;
        private List<Person> _listPerson;
        private Person? _currentPerson;

        public frmMain()
        {
            InitializeComponent();

            this._businessPerson = new BusinessPerson();
            this._listPerson = new List<Person>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateForm())
            {
                MessageBox.Show("Some fields are not valid. Please check them before continue.");
                return;
            }

            Person person = new Person();
            person.Name = this.txtName.Text;
            person.Dni = this.txtDni.Text;
            person.BirthDate = this.pickerBOD.Value;

            if (this._currentPerson != null)
            {
                person.Id = this._currentPerson.Id;
                this._businessPerson.UpdatePerson(person);
            }
            else
            {
                this._businessPerson.AddNewPerson(person);
            }

            this.ClearForm();
            this.LoadData();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Person", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are about to delete a person, Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes && this._currentPerson != null)
            {
                this._businessPerson.DeletePersonByDni(this._currentPerson.Dni);

                this.ToggleButtonEnabled(false);
                this.ClearForm();
                this.LoadData();
            };
        }

        private void dgvPersons_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this._currentPerson = this._listPerson[e.RowIndex];

            if (this._currentPerson == null)
            {
                return;
            }

            this.txtName.Text = this._currentPerson.Name;
            this.txtDni.Text = this._currentPerson.Dni;
            this.pickerBOD.Text = this._currentPerson.BirthDate.ToString();

            this.ToggleButtonEnabled(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.ToggleButtonEnabled(false);
        }

        private void LoadData()
        {
            this._listPerson = this._businessPerson.GetAllPersons();
            this.dgvPersons.DataSource = this._listPerson;
        }

        private void ClearForm()
        {
            this._currentPerson = null;

            this.txtName.Text = "";
            this.txtDni.Text = "";
            this.pickerBOD.Text = DateTime.Now.ToString();
            this.dgvPersons.ClearSelection();
        }

        private void ToggleButtonEnabled(bool value)
        {
            this.btnClear.Enabled = value;
            this.btnDelete.Enabled = value;
        }

        private bool ValidateForm()
        {
            return true;
        }
    }
}