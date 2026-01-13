using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class MoveAndRotateTowards : ActionTask {

		public BBParameter<Transform> target;
		public BBParameter<float> moveSpeed = 5;
		public BBParameter<float> turnSpeed = 180f;
		public BBParameter<float> stoppingDistance = 0.1f;

		private Blackboard agentBlackboard;
		protected override string OnInit() 
		{
			return null;
		}

		protected override void OnUpdate() 
		{
			Vector3 direction = target.value.position - agent.transform.position;
			Quaternion rotation = Quaternion.LookRotation(direction);

			agent.transform.SetPositionAndRotation(
				agent.transform.position + moveSpeed.value * Time.deltaTime * agent.transform.forward,
				Quaternion.RotateTowards(agent.transform.rotation, rotation, turnSpeed.value * Time.deltaTime)
				);

			if (Vector3.Distance(agent.transform.position, target.value.position) < stoppingDistance.value)
			{
				EndAction(true);
			}
		}
	}
}