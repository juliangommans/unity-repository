using System.Collections;
using UnityEngine;
using System;

namespace QuestSystem{
	
	public class CollectionObjective : IQuestObjective {

		private string title;
		private string description;
		private bool isComplete;
		private bool isBonus;

		private string verb;
		private int collectionAmount;
		private int currentAmount;
		private GameObject itemToCollect;

		/// <summary>
		/// This is a constructor for the collection objective
		/// </summary>
		/// <param name="titleVerb"> Type of collection (find/gather, kill).</param>
		/// <param name="totalAmount"> Amount to collect.</param>
		/// <param name="item">Item.</param>
		/// <param name="desc">Desc.</param>
		/// <param name="bonus">If set to <c>true</c> bonus.</param>
		public CollectionObjective(string titleVerb, int totalAmount, GameObject item, string desc, bool bonus){
			title = titleVerb + " " + totalAmount + " " + item.name;
			verb = titleVerb;
			description = desc;
			itemToCollect = item;
			collectionAmount = totalAmount;
			currentAmount = 0;
			isBonus = bonus;
			isComplete = false;
		}

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

		public int CollectionAmount
		{
			get
			{
				return collectionAmount;
			}
		}

		public int CurrentAmount
		{
			get
			{
				return currentAmount;
			}
		}

		public GameObject ItemToCollect
		{
			get
			{
				return itemToCollect;
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
			if (currentAmount >= collectionAmount)
				isComplete = true;
			else
				isComplete = false;
		}
		public override string ToString ()
		{
			return currentAmount + "/" + collectionAmount + " " + itemToCollect.name + " " + verb + "ed!";
		}
	}
}