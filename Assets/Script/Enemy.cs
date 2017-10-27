using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Transform player;    //プレイヤーを代入
	public float speed = 3; //移動速度
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Sushi").transform;
	}

	// Update is called once per frame
	void Update () {
		Vector3 playerPos = player.position;    //プレイヤーの位置
		Vector3 direction = playerPos - transform.position; //方向
		direction = direction.normalized;   //単位化（距離要素を取り除く）
		if(player.position.y > 2.55){
			transform.position = transform.position + (direction * speed * Time.deltaTime);
		}
	}
}
