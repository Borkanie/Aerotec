// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Model;
using IoC;
using Jet3UpInterfaces.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace Aerotec
{
    /// <summary>
    /// Form allowing to manipulate users using a <see cref="DataGridView"/>
    /// </summary>
    public partial class EditUserForm : Form
    {
        //private List<User> people = new();
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            // Load the JSON data from the file
            //string jsonFilePath = "Resources/Controllers.json";
            IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().RevertChanges();
            var users = IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().GetUsers();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = users;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var people = IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().GetUsers();
            
            for (int i = 0; i < people.Count; i++)
            {
                if (string.IsNullOrEmpty(people[i].Id) || string.IsNullOrEmpty(people[i].Name))
                {
                    _ = MessageBox.Show("Nu puteti alsa campuri incomplete.");
                    return;
                }
            }
            IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().SaveChanges();
            _ = MessageBox.Show("Lista de controllori a fost updatata!");

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add a new empty person to the list and refresh the DataGridView
            IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().Create("Utilizator nou");
            var users = IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().GetUsers();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().GetUsers();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var people = IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().GetUsers();
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Remove the selected person(s) from the list and refresh the DataGridView
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().Destroy(people.First(x => x.Id == row.Cells[0].Value));
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().GetUsers();
                }
                else
                {
                    MessageBox.Show("Trebuie sa selectati un rand cu utilizatori, apasand pe coloana libera adiacenta, pentru a sterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error when saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
