using UnityEngine;
using System.Collections;

public class SkyMOver : MonoBehaviour {

	float speed = 3f;

	void fixedUpate(){
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	}
}
