using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {

        int playersCount = 0;
        int recordSequnce = 0;
        List<FootballPlayers> stats1Cards = new List<FootballPlayers>();
        List<FootballPlayers> stats2Cards = new List<FootballPlayers>();
        List<FootballPlayers> Stats1 = new List<FootballPlayers>();
        List<FootballPlayers> Stats2 = new List<FootballPlayers>();
        public Form1()
        {
            InitializeComponent();
            loadData();
            btnPrevious.Enabled = false;
            if (playersCount > 0)
            {
                btnNext.Enabled = true;
            }
            else
                btnNext.Enabled = false;

            GBStatistics.Visible = false;
            GBStatistics2.Visible = false;

            using(Font font = new Font (dgvData.DefaultCellStyle.Font.FontFamily, 12,FontStyle.Bold))
            {
                dgvData.Columns[0].DefaultCellStyle.Font = font;
                dgvData.Columns[1].DefaultCellStyle.Font = font;
            }
            dgvData.Columns[1].DefaultCellStyle.ForeColor = Color.Cyan;
        }

        public List<FootballPlayers> dataLists()
        {
            List<FootballPlayers> soccerPlayers = PlayerList.Players.OrderBy(x => x.Name)
                .Select((a, index) => new FootballPlayers
                {
                    Name = a.Name,
                    Country = a.Country,
                    Matches = a.Matches,
                    Goals = a.Goals,
                    Picture = a.Picture,
                    Assists = a.Assists,
                    Sequence = index + 1
                    
                }).ToList();

            return soccerPlayers;
        }

        public DataTable Table (FootballPlayers players)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Statistics");
            table.Columns.Add("Count");
            table.Rows.Add("Name", players.Name);
            table.Rows.Add("Country", players.Country);
            table.Rows.Add("Matches", players.Matches);
            table.Rows.Add("Goals", players.Goals);
            table.Rows.Add("Assists", players.Assists);

            return table;

        }

        public void loadData()
        {
            if(PlayerList.Players.Count > 0)
            {
                var result = dataLists().Where(x => x.Sequence == 1).First();
                dgvData.DataSource = Table(result);
                dgvData.ClearSelection();
                mainPictureBox.Image = Image.FromFile(result.Picture);
                playersCount = dataLists().Count();
                if(playersCount > 0)
                {
                    recordSequnce = 1;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (recordSequnce - 1 != 0)
            {
                recordSequnce = recordSequnce - 1;
                var result = dataLists().Where(x => x.Sequence == recordSequnce).First();
                dgvData.DataSource = Table(result);
                dgvData.ClearSelection();
                mainPictureBox.Image = Image.FromFile( result.Picture);
            }

            if (recordSequnce -1 == 0)
            {
                btnPrevious.Enabled = false;
            }
            if(recordSequnce <= playersCount - 1)
            {
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(recordSequnce + 1 <= playersCount)
            {
                recordSequnce += 1;
                var result = dataLists().Where(x => x.Sequence == recordSequnce).First();
                dgvData.DataSource = Table(result);
                dgvData.ClearSelection();

                mainPictureBox.Image = Image.FromFile(result.Picture);
                btnPrevious.Enabled = true;
            }
            if(recordSequnce == playersCount)
            {
                btnPrevious.Enabled = false;
            }
        }

        private void GenerateCards(object sender, EventArgs e)
        {
            GBStatistics.Visible = false;
            GBStatistics2.Visible = false;
            SelectedPictureBox.Visible = false;
            selectedPictureBox2.Visible = false;
            UpdateLabel();

            Random random = new Random();

            List<int> randomNumbers = new List<int>();

            int num;

            for(int i = 1; i <= playersCount; i++)
            {
                randomNumbers.Add(i);
            }

            for(int i = 0; i < playersCount; i++)
            {
                num = random.Next(1, randomNumbers.Count);
                if (stats1Cards.Count < playersCount / 2)
                {
                    List<FootballPlayers> cards1 = dataLists().Where(x => x.Sequence == num).ToList();
                    stats1Cards.AddRange(cards1);
                    randomNumbers.Remove(num);
                }
                else
                {
                    List<FootballPlayers> cards2 = dataLists().Where(x => x.Sequence == num).ToList();
                    stats2Cards.AddRange(cards2);
                    randomNumbers.Remove(num);
                }
            }

            btnStats1.Enabled = true;
            btnStats2.Enabled = false;

           
        }

        private void btnStats1_Click(object sender, EventArgs e)
        {
            if (stats1Cards.Count > 0)
            {
                selectedPictureBox2.Visible = false;
                GBStatistics2.Visible = false;
                GBStatistics.Visible = true;
                SelectedPictureBox.Visible = true;
                UpdateLabel();

                var data = stats1Cards.First();
                Stats1.Add(data);
                SelectedPictureBox.Image = Image.FromFile(data.Picture);
                stats1Cards.Remove(data);
                btnStats1.Enabled = false;
                btnStats2.Enabled = true;

                lblName.Text = "Name: " + data.Name;
                lblCountry.Text = "Country: " + data.Country;
                lblMatches.Text = "Matches: " + data.Matches;
                lblGoals.Text = "Goals: " + data.Goals;
                lblAssists.Text = "Assists: " + data.Assists;
            }
            else
            {
                MessageBox.Show("Nothing Left to Show");
            }
        }

        private void btnStats2_Click(object sender, EventArgs e)
        {
            if(stats2Cards.Count > 0)
            {
                selectedPictureBox2.Visible = true;
                GBStatistics2.Visible = true;
                UpdateLabel();

                var data = stats2Cards.First();
                Stats2.Add(data);
                selectedPictureBox2.Image = Image.FromFile(data.Picture);
                stats2Cards.Remove(data);
                btnStats1.Enabled = true;
                btnStats2.Enabled = false;
                labelName.Text = "Name: " + data.Name;
                labelCountry.Text = "Country: " + data.Country;
                labelMatches.Text = "Matches: " + data.Matches;
                labelGoals.Text = "Goals: " + data.Goals;
                labelAssists.Text = "Assists: " + data.Assists;

                Score();
                Stats1.Clear();
                Stats2.Clear();
            }

        }

        private void Score()
        {
            foreach(var player1 in Stats1)
            {
                foreach(var player2 in Stats2)
                {
                    if(player1.Goals != player2.Goals)
                    {
                        if(player1.Goals > player2.Goals)
                        {
                            lblGoals.ForeColor = Color.DarkGreen;
                        }
                        else
                        {
                            labelGoals.ForeColor = Color.DarkGreen;
                        }

                    }

                    if(player1.Matches != player2.Matches)
                    {
                        if(player1.Matches > player2.Matches)
                        {
                            lblMatches.ForeColor = Color.DarkGreen;

                        }
                        else
                        {
                            labelMatches.ForeColor = Color.DarkGreen;
                        }
                    }

                    if(player1.Assists != player2.Assists)
                    {
                        if(player1.Assists > player2.Assists)
                        {
                            lblAssists.ForeColor = Color.DarkGreen;
                        }
                        else
                        {
                            labelAssists.ForeColor = Color.DarkGreen;
                        }
                    }
                }
            }
        }

        private void UpdateLabel()
        {
            foreach(Control control in GBStatistics.Controls)
            {
                if (control is Label)
                    control.ForeColor = Color.Red;
            }
            foreach(Control control in GBStatistics2.Controls)
            {
                if (control is Label)
                    control.ForeColor = Color.Red;
            }
        }
    }
}
