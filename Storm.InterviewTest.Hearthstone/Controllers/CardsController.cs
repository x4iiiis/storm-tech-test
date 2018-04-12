﻿using System.Web.Mvc;
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
}