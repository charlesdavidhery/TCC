using UnityEngine;
using System.Collections;

public class DistanceCalc : MonoBehaviour {
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject L;


	//public GameObject atomicbomb;
	// Use this for initialization
	void Start () {
		L.SetActive(false);
     

    }
	
	// Update is called once per frame
	void Update () {


		float distance = Vector3.Distance (sphere1.transform.position, sphere2.transform.position);

		if (distance > 13) {
			Debug.Log ("Level 6");
			L.SetActive(true);
		}
		if (10 <= distance && distance < 13) {
			Debug.Log ("Level 5");
			L.SetActive(true);
			
		}
		if (8 <= distance && distance < 10) {
			Debug.Log ("Level 4");
			L.SetActive(true);	
		}
		if (6 <= distance && distance < 8) {
			Debug.Log ("Level 3");
			L.SetActive(true);
			
		}
		if (4.5 <= distance && distance < 6) {
			Debug.Log ("Level 2");
			L.SetActive(true);
			
		}
		if ( 3.0 <= distance && distance < 4.5) {
			Debug.Log ("Level 1");
			L.SetActive(true);
			
		}
		if (2.0 < distance && distance < 3.0) {
			Debug.Log ("Level 0");
			L.SetActive(true);
			
		} 
		if (2.0 > distance) {
			Debug.Log (" off");
			L.SetActive(true);
			
		} 
		Debug.Log (distance);
	}
}
