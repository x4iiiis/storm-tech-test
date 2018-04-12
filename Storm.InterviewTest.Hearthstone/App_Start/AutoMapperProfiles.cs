﻿using AutoMapper;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards;
using Storm.InterviewTest.Hearthstone.Core.Features.Cards.Mapping;

namespace Storm.InterviewTest.Hearthstone
{
	public class AutoMapperProfiles
	{
		public static void RegisterProfiles(IHearthstoneCardCache hearthstoneCardCache)
		{
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new CardsMappingProfile(hearthstoneCardCache));
            });
		}
	}
}