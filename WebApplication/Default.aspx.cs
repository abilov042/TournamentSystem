using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Default : System.Web.UI.Page
    {

        private readonly ITeamTournamentService _teamTournamentService;

        public Default()
        {
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
                LoadStandings();
            }
            
        }

        private void LoadStandings()
        {
            gvTournament.DataSource = _teamTournamentService.GetDetailsDTOs();
            gvTournament.DataBind();
        }

        protected void btnAddGame_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddGame.aspx");
        }
    }
}