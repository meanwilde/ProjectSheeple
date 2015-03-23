using UnityEngine;
using System.Collections;


public class randomizeEvent : MonoBehaviour {
	public string path = "Animations/";
	Object[] events;
	Object test;
	int eventNum = 0;
	// Use this for initialization
	void Start () {
		//events = Resources.LoadAll("Animations/rdmEm");
		//test = Resources.Load("Animations/rdmEm/em_01");
		
		
	}

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
	
	// Update is called once per frame
	void Awake () {
		events = Resources.LoadAll("Animations/rdmEm");
		Animator anim = gameObject.GetComponent<Animator>();
		Shuffle(events);
		RuntimeAnimatorController contr = (RuntimeAnimatorController)RuntimeAnimatorController.Instantiate(events[0]);
        anim.runtimeAnimatorController = contr;
        eventNum ++;
	}
}
