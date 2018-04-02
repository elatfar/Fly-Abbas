using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TombolKlik : MonoBehaviour {

	public Button Buttonpause;
	public Button Buttonresume;

	void Start(){
		Button btnpause = Buttonpause.GetComponent<Button>();
		btnpause.onClick.AddListener(PausedOnClick);
		Button btnresume = Buttonpause.GetComponent<Button>();
		btnresume.onClick.AddListener(ResumedOnClick);
	}

	void PausedOnClick(){
		//Application.isPaused = true;
		Debug.Log ("Pause");
		//if (Time.timeScale == 1) {
		//	Time.timeScale = 0;
		//}
		
	}

	void ResumedOnClick(){
		//Application.isPlaying = true;
		Debug.Log ("Resumed");
		//if (Time.timeScale == 0) {
		//	Time.timeScale = 1;
		//}
	}


}
