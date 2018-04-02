using UnityEngine;
using System.Collections;

public class BGlooper : MonoBehaviour {

	int jumlahBG = 2;

	void OnTriggerEnter2D(Collider2D ObjekLain){
		float widthofBGObject = ((BoxCollider2D)ObjekLain).size.x;

		Vector3 pos = ObjekLain.transform.position;

		pos.x += widthofBGObject * jumlahBG - 5f;

		ObjekLain.transform.position = pos;
	}
}
