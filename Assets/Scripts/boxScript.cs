using UnityEngine;
using System.Collections;

public class boxScript : MonoBehaviour {
	GameObject em;
	// Use this for initialization
	void Awake () {
		em = GameObject.FindGameObjectWithTag("eventManager");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void destroyMe () {
		Destroy(this.gameObject);
		em.GetComponent<eventManagement>().nextBox();
	}

	public void pressButton () {
		this.GetComponent<Animator>().SetTrigger("buttonPress");
	}
}
