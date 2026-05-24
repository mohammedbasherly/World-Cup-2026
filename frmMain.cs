using System;
using System.Data;
using System.Windows.Forms;
using WorldCup_BusinessLogic;

namespace World_Cup___PresentaionTier
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void UploadDataTodgvPlayer(DataTable DataSource)
        {
            if (DataSource.Rows.Count == 0)
                return;

            dgvPlayers.DataSource = DataSource;

            dgvPlayers.Columns["ID"].Visible = false;
            dgvPlayers.Columns["NationalTeamID"].Visible = false;

            dgvPlayers.Columns["FirstName"].HeaderText = "الإسم الأول";
            dgvPlayers.Columns["LastName"].HeaderText = "إسم العائلة";
            dgvPlayers.Columns["KitNumber"].HeaderText = "رقم القميص";
            dgvPlayers.Columns["Club"].HeaderText = "النادي";
            dgvPlayers.Columns["Position"].HeaderText = "المركز";
            dgvPlayers.Columns["Age"].HeaderText = "العمر";
            dgvPlayers.Columns["TeamName"].HeaderText = "المنتخب";
            dgvPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayers.RowHeadersVisible = false;
            dgvPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlayers.MultiSelect = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Teams
            cbTeams.DataSource = clsTeam.GetAllTeams();
            cbTeams.DisplayMember = "Name";
            cbTeams.ValueMember = "ID";


            // Players
            UploadDataTodgvPlayer(clsPlayer.GetAllPlayers());

            // Search
            cbSearchByOprions.Items.Add("الإسم الأول");
            cbSearchByOprions.Items.Add("إسم العائلة");
            cbSearchByOprions.Items.Add("رقم القميص");
            cbSearchByOprions.Items.Add("المنتخب");
            cbSearchByOprions.Items.Add("النادي");
            cbSearchByOprions.Items.Add("المركز");
            cbSearchByOprions.Items.Add("العمر");
        }


        private void cbTeams_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvPlayers.DataSource = clsPlayer.GetAllPlayersWithNationalTeamID(Convert.ToInt32(cbTeams.SelectedValue));

        }

        private void btnGetAllPlayers_Click(object sender, EventArgs e)
        {
            dgvPlayers.DataSource = clsPlayer.GetAllPlayers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPlayer frm = new frmAddEditPlayer(-1);
            frm.ShowDialog();
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearchByOprions.SelectedItem == null)
                MessageBox.Show("يجب أن تحدد نوعية البحث أولا", "خطأ");
            else if (cbSearchByOprions.SelectedItem.ToString() == "الإسم الأول")
                UploadDataTodgvPlayer(clsPlayer.GetAllPlayersWithFirstName(tbSearch.Text));
            else if (cbSearchByOprions.SelectedItem.ToString() == "إسم العائلة")
                UploadDataTodgvPlayer(clsPlayer.GetAllPlayersWithLastName(tbSearch.Text));
            else if (cbSearchByOprions.SelectedItem.ToString() == "رقم القميص")
                UploadDataTodgvPlayer(clsPlayer.GetAllPlayersWithKitNumber(Convert.ToInt32(tbSearch.Text)));
            else if (cbSearchByOprions.SelectedItem.ToString() == "المنتخب")
                UploadDataTodgvPlayer(clsPlayer.GetAllPlayersWithNationalTeamID(clsTeam.GetIDOfNationalTeam(tbSearch.Text)));
            else if (cbSearchByOprions.SelectedItem.ToString() == "النادي")
                UploadDataTodgvPlayer(clsPlayer.GetAllPlayersWithClub(tbSearch.Text));
            else if (cbSearchByOprions.SelectedItem.ToString() == "المركز")
                UploadDataTodgvPlayer(clsPlayer.GetAllPlayersWithPosition(tbSearch.Text));
            else if (cbSearchByOprions.SelectedItem.ToString() == "العمر")
                UploadDataTodgvPlayer(clsPlayer.GetAllPlayersWithAge(Convert.ToInt16(tbSearch.Text)));
            
                
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPlayers.SelectedRows[0];
            int ID = Convert.ToInt32(row.Cells["ID"].Value);

            frmAddEditPlayer frm = new frmAddEditPlayer(ID);
            frm.ShowDialog();
        }

        private void cmsPlayer_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
