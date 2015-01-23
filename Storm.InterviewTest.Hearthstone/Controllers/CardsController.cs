using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Services;

namespace Storm.InterviewTest.Hearthstone.Controllers
{
    public class CardsController : Controller
    {
		public ActionResult Index(string q = null)
		{
			var searchService = new CardSearchService(MvcApplication.CardCache);
			var cards = searchService.Search(q);

			return View(cards);
		}
	}

	/// <summary>
	/// Make task (this is a completed solution example)
	/// </summary>
	public class CardController : Controller
	{
		public ActionResult Details(string id)
		{
			var searchService = new CardSearchService(MvcApplication.CardCache);

			var model = searchService.FindById(id);

			return View(model);
		}
	}
}