using UnityEngine;
using System.Collections;

public class waitTime : StateMachineBehaviour {
	public float time = 1.0f;
	float timer;
	GameObject sm;
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		timer = time;
		sm = GameObject.FindGameObjectWithTag("statmanager");
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		timer -= Time.deltaTime;
		
		sm.GetComponent<stats>().distance += Time.deltaTime * (sm.GetComponent<stats>().speed / time);

		if(timer <= 0){
			//boxScript bs = animator.gameObject.transform.GetChild(0).gameObject.GetComponent<boxScript>();
			//bs.setnextTrigger("nextState_01");
			//bs.pressButton();

			animator.SetTrigger("nextState_01");

		}
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
