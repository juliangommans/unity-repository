using System.Collections.Generic;

namespace QuestSystem{

	public class Quest{

		// Name
		// Description Summary
		// Quest Hint
		// Quest Dialog
		// sourceID
		// questID
		// chain quest and the next quest is blank
		// chainQuestId
		public Quest(){
			
		}

		// objectives
		private List<IQuestObjective> objectives;
		// Collection objectives
			// get 10 teeth
			// kill 5 hobos
		// Location objectives
			// go to area X
			// get to Z in 5 minutes
		// rewards
		// events
			// on completion
			// on failed
			// on update
		private bool IsComplete(){
			for (int i = 0; i < objectives.Count; i++) {
				if (!objectives[i].IsComplete && !objectives[i].IsBonus) {
					return false;
				}
			}
			return true;
		}

	}

}
