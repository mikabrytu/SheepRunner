using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	private float distance = 7;

	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public Transform generatorPoint;

	private List<GameObject> enemyList;

	// Use this for initialization
	void Start () {
		enemyList = new List<GameObject> ();
		enemyList.Add (enemy1);
		enemyList.Add (enemy2);
		enemyList.Add (enemy3);
		enemyList.Add (enemy4);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < generatorPoint.transform.position.x) {
			// Instantiate enemy
			int index = Random.Range(0, 4);
			Vector3 enemyPosition = new Vector3 (transform.position.x, enemyList [index].transform.position.y, enemyList [index].transform.position.z);
			Instantiate (enemyList[index], enemyPosition, transform.rotation);

			transform.position = new Vector3 (transform.position.x + distance, transform.position.y,transform.position.z);
		}
	}
}
