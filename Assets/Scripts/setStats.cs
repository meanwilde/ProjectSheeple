using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class setStats : MonoBehaviour {
	GameObject sm;
	stats smScript;

	public Text pop;
	public Text sheep;
	public Text warriors;
	public Text defense;
	public Text food;
	public Text moral;
	public Text distance;
	public Text speed;
	// Use this for initialization
	void Start () {
		sm = GameObject.FindGameObjectWithTag("statmanager");
		smScript = sm.GetComponent<stats>();

	}
	
	// Update is called once per frame
	void Update () {
		pop.text = smScript.population.ToString();
		sheep.text = smScript.sheeple.ToString();
		warriors.text = smScript.warriors.ToString();
		defense.text = smScript.defense.ToString();
		food.text = smScript.food.ToString();
		moral.text = smScript.moral.ToString();
		distance.text = smScript.distance.ToString();
		speed.text = smScript.speed.ToString();
	}
}
