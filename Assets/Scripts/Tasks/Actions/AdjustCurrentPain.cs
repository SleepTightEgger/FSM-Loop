using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class AdjustCurrentPain : ActionTask {
        public BBParameter<float> currentPain = 0;
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
            currentPain.value += adjustmentAmount * Time.deltaTime;

        }
    }
}