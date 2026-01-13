using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class AdjustCurrentCharge : ActionTask {
        public BBParameter<float> currentCharge = 0;
        public float adjustmentAmount = 0;

        //private Blackboard agentBlackboard;

        protected override string OnInit()
        {
            return null;
        }

        protected override void OnExecute()
        {

        }

        protected override void OnUpdate()
        {
            currentCharge.value += adjustmentAmount * Time.deltaTime;

        }
    }
}