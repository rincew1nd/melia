﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.Database
{
	/// <summary>
	/// A player's account.
	/// </summary>
	public class Account
	{
		/// <summary>
		/// Account id
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Account name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Account's team name
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Creates new account.
		/// </summary>
		public Account()
		{
		}

		/// <summary>
		/// Loads account with given name from database and returns it.
		/// </summary>
		/// <param name="accountName"></param>
		/// <returns></returns>
		public static Account LoadFromDb(string accountName)
		{
			return ChannelServer.Instance.Database.GetAccount(accountName);
		}

		/// <summary>
		/// Saves account database.
		/// </summary>
		public void Save()
		{
			ChannelServer.Instance.Database.SaveAccount(this);
		}
	}
}