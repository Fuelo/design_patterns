using System;

namespace design_patterns
{
	public class Character
	{
		IAttackBehaviour attackBehaviour;
		IDefenseBehaviour defenseBehaviour;

		public Character (IAttackBehaviour attackBehaviour,IDefenseBehaviour defenseBehaviour)
		{
			this.attackBehaviour=attackBehaviour;
			this.defenseBehaviour=defenseBehaviour;
		}

		public void attack(){
			attackBehaviour.attack ();
		}

		public void defend(){
			defenseBehaviour.defend ();
		}

		public void setAttackBehaviour(IAttackBehaviour newAttackBehaviour){
			this.attackBehaviour = newAttackBehaviour;
		}

		public void setDefenseBehaviour(IDefenseBehaviour newDefenseBehaviour){
			this.defenseBehaviour = newDefenseBehaviour;
		}

	}
}

