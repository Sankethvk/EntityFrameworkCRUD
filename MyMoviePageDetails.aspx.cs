using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataManagementMovie;
using MyMovieClassLibrary;
using System.Data.Entity;

namespace DataManagementMovie
{
    public partial class MyMoviePageDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            MoviedataEntities moviedataentities = new MoviedataEntities();
            movie movieObj = new movie();
            movieObj.Name = txtMoviename.Text;
            movieObj.MovieType = txtMovietype.Text;
            movieObj.MovieDesc = txtMoviedesc.Text;
            moviedataentities.movies.Add(movieObj);
            moviedataentities.SaveChanges();
            lblResult.Text = "movie is added succesfully !!";
            
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            MoviedataEntities moviedataentities = new MoviedataEntities();
            var result = moviedataentities.movies.ToList().Find(obj => obj.Id == Convert.ToInt32(txtEditMovieID.Text));
            txtMoviename.Text = result.Name;
            txtMovietype.Text = result.MovieType;
            txtMoviedesc.Text = result.MovieDesc;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MoviedataEntities moviedataEntities = new MoviedataEntities();
            movie movieObj = new movie();
            movieObj.Id = Convert.ToInt32(txtEditMovieID.Text);
            movieObj.Name = txtMoviename.Text;
            movieObj.MovieType = txtMovietype.Text;
            movieObj.MovieDesc = txtMoviedesc.Text;
            moviedataEntities.Entry(movieObj).State = EntityState.Modified;
            moviedataEntities.SaveChanges();
            lblResult.Text = "Movie updated successfully!!! ";

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MoviedataEntities moviedataEntities = new MoviedataEntities();
            movie movieObj = new movie();
            movieObj.Id = Convert.ToInt32(txtEditMovieID.Text);
            movieObj.Name = txtMoviename.Text;
            movieObj.MovieType = txtMovietype.Text;
            movieObj.MovieDesc = txtMoviedesc.Text;
            moviedataEntities.Entry(movieObj).State = EntityState.Deleted;
            moviedataEntities.SaveChanges();
            lblResult.Text = "movie is deleted successfully!!";

        }
    }
}