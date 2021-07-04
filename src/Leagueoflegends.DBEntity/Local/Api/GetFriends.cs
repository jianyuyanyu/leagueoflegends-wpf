﻿using Leagueoflegends.DBEntity.Local.Entities;
using Leagueoflegends.DBEntity.Local.Entities.Extend;
using Leagueoflegends.DBEntity.Local.Entities.Implements;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.DBEntity.Local.Api
{
	public class GetFriends
	{
		public List<IFriendsList> Run(int mySeq)
		{
			using (var db = new RiotContext())
			{
				var users = from f in db.Friends
							where f.UserSeq == mySeq
							join u in db.Users
							on f.FriendsSeq equals u.Seq
							select new MyFriends(u);

				var source = new List<IFriendsList>();
				var general = new FriendsHeader("GENERAL");
				var offline = new FriendsHeader("OFFLINE");
				general.Children.AddRange(users);

				source.Add(general);
				source.Add(offline);

				return source;
			}
		}
	}
}
