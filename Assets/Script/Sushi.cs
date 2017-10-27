using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sushi : MonoBehaviour {

	// speed調整
	public float speed = 10;
	//ラベル
	public GameObject GameOverLabel;
	public GameObject GameClearLabel;
	//
	bool winflag = false;
	bool loseflag = false;

	void FixedUpdate(){
		//入力をxとzに代入
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		//rigidbodyのx軸（横）とz軸（奥）に力を加える
		rigidbody.AddForce (x * speed, 0, z * speed);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tmp = GameObject.Find("Sushi").transform.position;
		Vector3 tmp2 = GameObject.Find("Enemy").transform.position;
		//相手が落ちる前に自分が土俵から落ちたかどうかの判定
		if (tmp.y < 1 && (winflag==false)) {
			//「YOU LOSE...」表示
			GameOverLabel.SetActive(true);
			loseflag = true;
			//リスタートする
			StartCoroutine("restart");
		}
		//相手が土俵から落ちたかどうかの判定
		if (tmp2.y < 2.2 && (loseflag == false)) {
			//「YOU WIN!」表示
			GameClearLabel.SetActive(true);
			winflag = true;
			//次のステージに移動する
			StartCoroutine("nextStage");
		}

		
	}

	//コルーチンでリスタート処理
	IEnumerator restart(){
		//ゲームオーバーから4秒後にリスタート
		yield return new WaitForSeconds(4);
		//現在のシーン番号取得
		int sceneIndex = SceneManager.GetActiveScene().buildIndex;
		//現在のシーンを再読み込み
		SceneManager.LoadScene(sceneIndex);
	}
	//コルーチンで次のステージへ
	IEnumerator nextStage(){
		//ゲームクリアから4秒後に遷移
		yield return new WaitForSeconds(4);
		//現在のシーン番号取得
		int sceneIndex = SceneManager.GetActiveScene().buildIndex;
		//次のステージへ
		SceneManager.LoadScene(sceneIndex+1);
	}

}
