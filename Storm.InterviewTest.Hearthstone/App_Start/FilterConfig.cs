﻿using System.Web.Mvc;

namespace Storm.InterviewTest.Hearthstone
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
