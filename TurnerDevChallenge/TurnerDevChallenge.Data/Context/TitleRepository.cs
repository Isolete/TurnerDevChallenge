using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnerDevChallenge.Data.ViewModels;

using TurnerDevChallenge.Data.Models;

namespace TurnerDevChallenge.Data.Context
{
    public class TitleRepository : ITitleRepository
    {
        private TitleContext _context;

        public TitleRepository(TitleContext titleContext)
        {
            this._context = titleContext;
        }

        public IEnumerable<Title> GetTitles()
        {
            return _context.Titles.ToList();
        }

        public TitleViewModel GetTitleDetailsById(int id)
        {
          
            var Title = _context.Titles.Find(id);

            TitleViewModel titleDetails = new TitleViewModel();

            titleDetails.Id = Title.TitleId;
            titleDetails.TitleName = Title.TitleName;
            titleDetails.ReleaseYear = Title.ReleaseYear.ToString();

            IList<Award> AwardsList = _context.Awards.Where(r => r.TitleId == id).Where(x => x.AwardWon == true).ToList();
            AwardViewModel Awards = new AwardViewModel();

            IList<AwardViewModel> awardviewList = new List<AwardViewModel>();
            foreach (var Award in AwardsList)
            {
                AwardViewModel awardViewModel = new AwardViewModel();
                awardViewModel.Award = Award.Award1;
                awardViewModel.AwardYear = Award.AwardYear.ToString();
                awardviewList.Add(awardViewModel);
            }
            titleDetails.Awards = awardviewList;
            
           return titleDetails;

        }
   
        public Title GetTitleByID(int id)
        {
            return _context.Titles.Find(id);
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
