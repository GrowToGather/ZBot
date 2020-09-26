﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DateBot.Base {
	/// <summary>
	/// Serializable User State. Likes, dislikes go here
	/// </summary>
	public class UserState {
		public ulong UserId { get; set; }
		public List<ulong> LikedUserIds { get; set; } = new List<ulong>();
		public List<ulong> DislikedUserIds { get; set; } = new List<ulong>();
		public List<ulong> LastMatches { get; set; } = new List<ulong>();
		public GenderEnum Gender { get; set; }
		public DateTime? LastEnteredLobbyTime { get; internal set; }
		public DateTime? EnteredPrivateRoomTime { get; internal set; }
		public int AgeOptions { get; set; }
		public bool AddTime { get; internal set; }

		public override string ToString() {
			return $"UserState {UserId} gen:{Gender} age:{AgeOptions}";
		}

		internal void AddMatch(ulong id, int max = 5) {
			LastMatches.Add(id);
			if (LastMatches.Count > max) {
				LastMatches.RemoveAt(0);
			}
		}
	}
}
