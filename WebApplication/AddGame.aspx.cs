using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class AddGame : System.Web.UI.Page
    {
        private readonly ITeamService _teamService;
        private readonly IGameService _gameService;
        private readonly ITeamTournamentService _teamTournamentService;
        public AddGame()
        {
            _teamService = new TeamManager(new EfTeamDal());
            _gameService = new GameManager(new EfGameDal());
            _teamTournamentService = new TeamTournamentManager(new EfTeamTournamentDal());
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                LoadGames();
            }
        }

        private void LoadGames()
        {
            var games = _gameService.GetGameDetailsDTOs();
            gvGames.DataSource = games;
            gvGames.DataBind();
        }

        protected void btnShowForm_Click(object sender, EventArgs e)
        {
            pnlGameForm.Visible = true;
            LoadTeams(); // Komandaları burada doldur
        }

        private void LoadTeams()
        {
            var teams = _teamService.GetAll();

            ddlTeam1.DataSource = teams;
            ddlTeam1.DataTextField = "Name";
            ddlTeam1.DataValueField = "Id";
            ddlTeam1.DataBind();

            ddlTeam2.DataSource = teams;
            ddlTeam2.DataTextField = "Name";
            ddlTeam2.DataValueField = "Id";
            ddlTeam2.DataBind();

            // Optional: DropDown başlığı əlavə et
            ddlTeam1.Items.Insert(0, new System.Web.UI.WebControls.ListItem("-- Komanda 1 seçin --", "0"));
            ddlTeam2.Items.Insert(0, new System.Web.UI.WebControls.ListItem("-- Komanda 2 seçin --", "0"));
        }


        protected void btnAddGame_Click(object sender, EventArgs e)
        {
            int team1Id = int.Parse(ddlTeam1.SelectedValue);
            int team2Id = int.Parse(ddlTeam2.SelectedValue);
            int score1 = int.Parse(txtScore1.Text);
            int score2 = int.Parse(txtScore2.Text);

            if (team1Id == team2Id)
            {
                lblMessage.Text = "Eyni komanda ilə oyun olmaz.";
                lblMessage.CssClass = "text-danger";
                return;
            }

            var game = new Game
            {
                Team1Id = team1Id,
                Team2Id = team2Id,
                Score1 = score1,
                Score2 = score2
            };

            _gameService.Add(game);


            var teamTournament1 = _teamTournamentService.FindByTeamAndTournamentId(team1Id, 1);
            var teamTournament2 = _teamTournamentService.FindByTeamAndTournamentId(team2Id, 1);

            if (score1 > score2)
            {
                teamTournament1.Score += 3;
            }
            else if (score1 < score2)
            {
                teamTournament2.Score += 3;
            }
            else
            {
                teamTournament1.Score += 1;
                teamTournament2.Score += 1;
            }

            _teamTournamentService.Update(teamTournament1);
            _teamTournamentService.Update(teamTournament2);

            pnlGameForm.Visible = false;
            LoadGames();

        }

        protected void btnBackToHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}