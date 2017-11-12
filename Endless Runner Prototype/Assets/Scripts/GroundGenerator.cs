using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {

	public GameObject ground;
	public GameObject grass;
	public GameObject candy;
	public GameObject snow;
	public GameObject steel;

	public Transform generatorPoint;
	public float distance;

	private List<GameObject> groundList;
	private float groundWidth;

	// Use this for initialization
	void Start () {
		groundWidth = ground.GetComponent<BoxCollider2D> ().size.x;

	
		groundList = new List<GameObject> ();
		groundList.Add (ground);
		groundList.Add (grass);
		groundList.Add (candy);
		groundList.Add (snow);
		groundList.Add (steel);	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < generatorPoint.position.x) {
			transform.position = new Vector3 (transform.position.x + groundWidth + distance, transform.position.y, transform.position.z);

			int index = Random.Range (0, 5);
			Vector3 groundPostion = new Vector3 (transform.position.x, groundList [index].transform.position.y, groundList [index].transform.position.z);
			Instantiate (groundList[index], groundPostion, transform.rotation);
		}
	}
}
