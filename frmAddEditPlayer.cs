using System;
using System.Windows.Forms;
using WorldCup_BusinessLogic;

namespace World_Cup___PresentaionTier
{
    public partial class frmAddEditPlayer : Form
    {
        clsPlayer _Player;
        public frmAddEditPlayer(int ID)
        {
            InitializeComponent();

            _Player = clsPlayer.FindByID(ID);

        }

        private void frmAddPlayer_Load(object sender, EventArgs e)
        { 
            // Teams
            cbTeams.DataSource = clsTeam.GetAllTeams();
            cbTeams.DisplayMember = "Name";
            cbTeams.ValueMember = "ID";

            // Positions
            cbPosition.Items.Add("هجوم");
            cbPosition.Items.Add("وسط");
            cbPosition.Items.Add("دفاع");
            cbPosition.Items.Add("حارس");

            if (_Player != null)
            {
                tbFirstName.Text = _Player.FirstName;
                tbLastName.Text = _Player.LastName;
                nudKitNumber.Value = _Player.KitNumber;
                cbTeams.Text = clsTeam.GetTeamNameByID(_Player.NationalTeamID);
                tbClub.Text = _Player.Club;
                cbPosition.Text = _Player.Position;
                nudAge.Value = _Player.Age;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string FirstName = tbFirstName.Text;
            string LastName = tbLastName.Text;
            int KitNumber = (int)nudKitNumber.Value;
            int NationalTeamID = (int)cbTeams.SelectedValue;
            string Club = tbClub.Text;
            string PlayerPosition = cbPosition.SelectedItem.ToString();
            short Age = (short)nudAge.Value;

            MessageBox.Show(PlayerPosition);

            string AddResult = clsPlayer.AddNewPlayer(FirstName, LastName, KitNumber, NationalTeamID, Club, PlayerPosition, Age);

            if (AddResult == "done")
                MessageBox.Show("تمت الإضافة بنجاح", "إضافة لاعب في قاعدة البيانات");
            else
                MessageBox.Show(AddResult, "إضافة لاعب في قاعدة البيانات");

            // Reset Fields
            tbFirstName.Text = "";
            tbLastName.Text = "";
            nudKitNumber.Value = 1;
            tbClub.Text = "";
            nudAge.Value = 1;

        }
    }
}
