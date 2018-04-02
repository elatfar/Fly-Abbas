using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] ObjectToSpawn;

	public int[] randomSecond;


	// Use this for initialization
	void Start () {
		Invoke("SpawnObject", randomSecond[Random.Range(0, randomSecond.Length)]);//panggil secara berkali2
	}


	public void SpawnObject()
	{
		int index = Random.Range(0, ObjectToSpawn.Length);
		//if (GamesManager.Instance.isGameOver) return;
		Instantiate(ObjectToSpawn[index], new Vector3(transform.position.x, transform.position.y, 9), Quaternion.identity);//rotasi gunakan quaternion.identity == 0
		Invoke("SpawnObject", randomSecond[Random.Range(0, randomSecond.Length)]);
	}
}
