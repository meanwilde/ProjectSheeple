using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textChange : StateMachineBehaviour {
	public string headerText;
	public string bodyText;

	public bool button1Enabled = true;
	public string button1Text;

	public bool button2Enabled = true;
	public string button2Text;

	public bool button3Enabled = true;
	public string button3Text;

	public bool button4Enabled = true;
	public string button4Text;

	public bool button5Enabled = true;
	public string button5Text;

	public bool button6Enabled = true;
	public string button6Text;
	


	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		GameObject child = animator.gameObject.transform.GetChild(0).gameObject;
		child.GetComponent<Animator>().SetTrigger("nextEvent");

		Transform textBox = animator.gameObject.transform.GetChild(0).gameObject.transform;

		Text headerTextBox = textBox.GetChild(1).gameObject.GetComponent<Text>();
		headerTextBox.text = headerText;

		Text bodyTextBox = textBox.GetChild(2).gameObject.GetComponent<Text>();
		bodyTextBox.text = bodyText;

		Button button1 = textBox.GetChild(3).gameObject.transform.GetChild(0).GetComponent<Button>();
		button1.gameObject.SetActive(button1Enabled);
		button1.gameObject.transform.GetChild(0).GetComponent<Text>().text = button1Text;

		Button button2 = textBox.GetChild(3).gameObject.transform.GetChild(1).GetComponent<Button>();
		button2.gameObject.SetActive(button2Enabled);
		button2.gameObject.transform.GetChild(0).GetComponent<Text>().text = button2Text;

		Button button3 = textBox.GetChild(3).gameObject.transform.GetChild(2).GetComponent<Button>();
		button3.gameObject.SetActive(button3Enabled);
		button3.gameObject.transform.GetChild(0).GetComponent<Text>().text = button3Text;

		Button button4 = textBox.GetChild(3).gameObject.transform.GetChild(3).GetComponent<Button>();
		button4.gameObject.SetActive(button4Enabled);
		button4.gameObject.transform.GetChild(0).GetComponent<Text>().text = button4Text;

		Button button5 = textBox.GetChild(3).gameObject.transform.GetChild(4).GetComponent<Button>();
		button5.gameObject.SetActive(button5Enabled);
		button5.gameObject.transform.GetChild(0).GetComponent<Text>().text = button5Text;

		Button button6 = textBox.GetChild(3).gameObject.transform.GetChild(5).GetComponent<Button>();
		button6.gameObject.SetActive(button6Enabled);
		button6.gameObject.transform.GetChild(0).GetComponent<Text>().text = button6Text;

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
}
