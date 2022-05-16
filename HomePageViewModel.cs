using E_Shopping.DB;
using E_Shopping.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shopping.Models.Home
{
    public class HomePageViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        public IEnumerable<Tbl_Product> ListOfProducts { get; set; }
        public HomePageViewModel CreateModel()
        {
            return new HomePageViewModel
            {
                ListOfProducts = _unitOfWork.GetRepositoryInstance<Tbl_Product>().GetAllRecords()
        };
        }

    }
}