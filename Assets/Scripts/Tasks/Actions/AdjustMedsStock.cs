using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class AdjustMedsStock : ActionTask {

		public BBParameter<int> medsStock = 0;
		public int medsDelta = 0;
		float t;
		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {

		}

		protected override void OnUpdate() {
			t += Time.deltaTime;

			if (t > 1)
			{
				medsStock.value += medsDelta;
				t = 0;
			}
		}
	}
}