using UnityEngine;
using System.Collections;

public class boxScript : MonoBehaviour {
	GameObject em;
	public string nextBoxTrigger;
	// Use this for initialization
	void Awake () {
		em = GameObject.FindGameObjectWithTag("eventManager");
	}
/*
	// Update is called once per frame
	void Update () {
	
	}

	public void destroyMe () {
		Destroy(this.gameObject);
		em.GetComponent<eventManagement>().nextBox();
	}
*/
	//happens when any panel button is pressed
	public void pressButton () {
		//set trigger to end panel
		this.GetComponent<Animator>().SetTrigger("buttonPress");
	}

	//set by what button was pressed, allows for branches in events
	public void setnextTrigger (string triggerName) {
		//set the variable to the choice
		nextBoxTrigger = triggerName;
	}
}

