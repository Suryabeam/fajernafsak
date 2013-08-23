using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	public Transform Targetpoint;
	
	public NavMeshAgent myAg;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		myAg.SetDestination(Targetpoint.position);
	}
}
