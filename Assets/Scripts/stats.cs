using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class stats : MonoBehaviour {
	public int startingSheep;
	public int startingWarriors;
	public int startingFood = 150;
	public int startingMoral = 10;

	public int warriorDefense = 2;
	[HideInInspector]
	public int population;
	[HideInInspector]
	public int sheeple;
	[HideInInspector]
	public int warriors;
	[HideInInspector]
	public int defense;
	[HideInInspector]
	public int food;
	[HideInInspector]
	public int moral;


	// Use this for initialization
	void Start () {
		sheeple = startingSheep;
		warriors = startingWarriors;
		food = startingFood;
		moral = startingMoral;
	}
	
	// Update is called once per frame
	void Update () {
		population = sheeple + warriors;
		defense = warriorDefense * warriors;
	}
}
