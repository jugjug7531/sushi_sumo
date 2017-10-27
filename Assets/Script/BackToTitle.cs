using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackToTitle : MonoBehaviour {

	public void ButtonPush() {
		//タイトル画面へ
		SceneManager.LoadScene(0);
	}
}

