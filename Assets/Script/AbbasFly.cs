using UnityEngine;
using System.Collections;

public class AbbasFly : MonoBehaviour {

	public float lari;
	public float tap;

	public GameObject Gover;
	public GameObject RetryGover;
	public GameObject HomeGover;
	public GameObject nextBtn;

	private Rigidbody2D myRigidbody;
	// Use this for initialization
	void Start () {
		
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		/*Time.timeScale = 0;
		if (nextBtn.activeInHierarchy == false) {
			Time.timeScale = 1;
		}*/
		myRigidbody.velocity = new Vector2 (lari, myRigidbody.velocity.y);
		if (Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0)){
			myRigidbody.velocity += tap * Vector2.up;
		}

	}

	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("Game Over");
		Time.timeScale = 0;
		Gover.SetActive (true);
		RetryGover.SetActive (true);
		HomeGover.SetActive (true);
	}
}
