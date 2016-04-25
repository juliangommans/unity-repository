using System.Collections;
using UnityEngine;
using System;

namespace QuestSystem {

	public class LocationObjective : IQuestObjective {

		private string title;
		private string description;
		private bool isComplete;
		private bool isBonus;
		private Location targetLocation; // zone, 2d or 3d coord

		public string Title
		{
			get
			{
				return title;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
		}
			
		public bool IsComplete
		{
			get
			{
				return isComplete;
			}
		}

		public bool IsBonus
		{
			get
			{
				return isBonus;
			}
		}

		public void UpdateProgress()
		{
			throw new NotImplementedException();
		}

		public void CheckProgress()
		{
			// if players location is equal/nearby our target location = mission accomplished. 
			if (Player.GetLocation.Compare (targetLocation))
				isComplete = true;
			else
				isComplete = false;
		}
	}
}