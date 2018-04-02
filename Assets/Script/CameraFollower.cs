using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {
	public Transform theCamera;


	// Update is called once per frame
	void Update () {
		theCamera.transform.position = new Vector3 (this.transform.position.x, 0, -10);
	}
}
