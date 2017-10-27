using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Start : MonoBehaviour {

	public void ButtonPush() {
		//次のステージへ
		SceneManager.LoadScene("Stage1");
	}
}
