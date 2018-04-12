using System.Collections.Generic;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Models;

namespace Storm.InterviewTest.Hearthstone.Core.Features.Cards
{
	public interface ICardSearchService
	{
		CardModel FindById(string id);
		IEnumerable<CardModel> Search(string searchTerm);
		IEnumerable<CardModel> GetHeroes();
	}
}