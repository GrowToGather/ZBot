﻿using DSharpPlus.Entities;

namespace DateBot.Base {
	public struct UserStateDiscordUserPair {
		public DiscordMember User { get; set; }
		public UserState State { get; set; }
	}
}