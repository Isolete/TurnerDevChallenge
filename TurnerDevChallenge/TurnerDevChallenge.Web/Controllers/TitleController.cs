using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnerDevChallenge.Data.Models;
using TurnerDevChallenge.Data.ViewModels;
using TurnerDevChallenge.Data.Context;

namespace TurnerDevChallenge.Web.Controllers
{
    public class TitleController : Controller
    {
        private ITitleRepository _titleRepository;
      
        public TitleController()
        {
            this._titleRepository = new TitleRepository(new TitleContext());
        }

        public ActionResult Index()
        {
            var titles = from title in _titleRepository.GetTitles()
                        select title;
            return View(titles);
        }

        public ViewResult Details(int id)
        {
            TitleViewModel titledetails = _titleRepository.GetTitleDetailsById(id);
            return View(titledetails);
        }

        public ViewResult SearchForTitles(string titleName)
        {
            var titles = from title in _titleRepository.GetTitles()
                         select title; 

            if (!string.IsNullOrEmpty(titleName))
            {
                titles = titles.Where(t => t.TitleName.ToLower().Contains(titleName.ToLower()));
            }
            return View(titles);
        }

    }
}
