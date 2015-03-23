using UnityEngine;
using System.Collections;

public class randomEventChanger : StateMachineBehaviour {
	public string path = "Animations/";
	Object[] events;
	Object test;
	int eventNum = 0;
	bool shuffled = false;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if(!shuffled) {
			events = Resources.LoadAll(path);
			Shuffle(events);
			shuffled = true;
		}

		Animator anim = animator.gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>();
		RuntimeAnimatorController contr = (RuntimeAnimatorController)RuntimeAnimatorController.Instantiate(events[eventNum]);
        anim.runtimeAnimatorController = contr;
        eventNum ++;
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

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

	void Shuffle(Object[] events)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < events.Length; t++ )
        {
            Object tmp = events[t];
            int r = Random.Range(t, events.Length);
            events[t] = events[r];
            events[r] = tmp;
        }
    }
}
