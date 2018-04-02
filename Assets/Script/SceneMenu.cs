using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour {

	/*public void exit(){
		Application.Quit;
	}*/

	public GameObject S1;
	public GameObject S2;
	public GameObject S3;
	public GameObject next;
	public int countSClick = 0;

	public void Gameplay(){
		S1.SetActive(true);
		next.SetActive(true);

	}

	public void Home(){
		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
	}

	public void Berhenti(){
		Time.timeScale = 0;
	}

	public void Lanjut(){
		Time.timeScale = 1;
	}

	public void Ulangi(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}

	public void Skip(){
		countSClick++;

		if (countSClick == 1) {
			S2.SetActive(true);
			S1.SetActive (false);
		}

		if (countSClick == 2) {
			S2.SetActive (false);
			S3.SetActive (true);
		}

		if (countSClick == 3) {
			SceneManager.LoadScene ("PlayScene", LoadSceneMode.Single);
			countSClick = 0;
		}
	}
}
