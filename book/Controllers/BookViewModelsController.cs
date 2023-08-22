using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using book.Data;
using book.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace book.Controllers
{
    public class BookViewModelsController : Controller
    {

        private readonly IConfiguration _configuration;
        public BookViewModelsController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        // GET: BookViewModels
        public IActionResult Index()
        {
            return View();
        }

       
        // GET: Book/AddorEdit/
        public IActionResult AddorEdit(int? id)
        {
            BookViewModel bookViewModel = new BookViewModel();


            return View(bookViewModel);
        }

        // POST: BookViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddorEdit(int id, [Bind("BookID,Title,Author,Price")] BookViewModel bookViewModel)
        {
            

            if (ModelState.IsValid)
            {
              
                using(SqlConnection connection=new SqlConnection(_configuration.GetConnectionString("Devconnection")))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("BookAddorEdit",connection);
                    cmd.CommandType =CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Book_id", bookViewModel.BookID);
                    cmd.Parameters.AddWithValue("@Tltle", bookViewModel.Title);
                    cmd.Parameters.AddWithValue("@Author", bookViewModel.Author);
                    cmd.Parameters.AddWithValue("@price", bookViewModel.Price);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
            return View(bookViewModel);
        }

        // GET: BookViewModels/Delete/5
        public IActionResult Delete(int? id)
        {
         

            return View();
        }

        // POST: BookViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int id)
        {
          
            return RedirectToAction(nameof(Index));
        }

      
    }
}
