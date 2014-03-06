using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnerDevChallenge.Data.Models;
using TurnerDevChallenge.Data.ViewModels;

namespace TurnerDevChallenge.Data.Context
{
    public interface ITitleRepository : IDisposable
    {
        IEnumerable<Title> GetTitles();
        Title GetTitleByID(int bookId);
        TitleViewModel GetTitleDetailsById(int bookId);
    }
}
