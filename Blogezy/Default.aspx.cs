using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Threading;
using System.Web.UI.WebControls;
using Blogezy.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Blogezy
{
    public partial class _Default : Page
    {
        protected List<MainHeader> MainHeaderList { get;private set; }

        protected List<Article> ArticleList { get; private set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(GetMainHeaderListAsync));
            RegisterAsyncTask(new PageAsyncTask(GetArticlesListAsync));

        }

        private async Task GetMainHeaderListAsync()
        {
            using (ArticleDbContext articleDbContext= new ArticleDbContext())
            {
                MainHeaderList = await articleDbContext.MainHeaders.ToListAsync();
            }
          
        }

        private async Task GetArticlesListAsync()
        {
            using (ArticleDbContext articleDbContext = new ArticleDbContext())
            {
                ArticleList = await articleDbContext.Articles.ToListAsync();
            }

        }
    }
}