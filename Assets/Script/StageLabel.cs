using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLabel : MonoBehaviour {
	//ラベル
	public GameObject label;
	// Use this for initialization
	void Start () {
		//現在のステージ数表示
		StartCoroutine("stageLabel");
	}
	//コルーチン
	IEnumerator stageLabel(){
		//ゲームクリアから2秒後に遷移
		yield return new WaitForSeconds(2);
		label.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
