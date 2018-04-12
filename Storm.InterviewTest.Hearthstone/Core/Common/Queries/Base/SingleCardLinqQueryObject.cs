using System.Linq;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Domain;

namespace Storm.InterviewTest.Hearthstone.Core.Common.Queries.Base
{
	public abstract class SingleCardLinqQueryObject<T> : SingleCardQueryObject<T> where T : ICard
	{
		public override T Execute(IHearthstoneCardCache cache)
		{
			return ExecuteLinq(cache.FindAll<T>().AsQueryable());
		}

		protected abstract T ExecuteLinq(IQueryable<T> queryOver);
	}
}