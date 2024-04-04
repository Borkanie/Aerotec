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
        private IUserContainer people;
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            // Load the JSON data from the file
            //string jsonFilePath = "Resources/Controllers.json";
            IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().RevertChanges();
            dataGridView1.DataSource = IoCContainer.Instance.Services.GetRequiredService<IUserContainer>();
        }



        private void SaveButton_Click(object sender, EventArgs e)
        {
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
            people.Add(IoCContainer.Instance.Services.GetRequiredService<IUserFactory>().Create("Utilizator nou"));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = people;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Remove the selected person(s) from the list and refresh the DataGridView
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    people.RemoveAt(row.Index);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = people;
            }
        }
    }
}
