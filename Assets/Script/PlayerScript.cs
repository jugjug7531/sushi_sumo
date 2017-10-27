using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	public int playerID = 1;
	public int speed;
	private Vector3 direction;
	private CharacterController cc;
	private Vector3 moveDirection;

	void Start()
	{
		cc = GetComponent<CharacterController>();
	}

	void Update()
	{
		direction.Set(Input.GetAxis("Horizontal " + playerID), 0, Input.GetAxis("Vertical " + playerID));
		Quaternion q = Quaternion.Euler(0f, -90f, 0f); // クォータニオン q
		if (direction != Vector3.zero) transform.rotation = Quaternion.LookRotation(direction)*q;
		cc.SimpleMove(direction * speed);

		if (cc.isGrounded) { //地面についているか判定
			if (Input.GetKey ( KeyCode.Joystick1Button3 )) moveDirection.y = 10; //ジャンプするベクトルの代入
		}
		moveDirection.y -= 20 * Time.deltaTime; //重力計算
		cc.Move(moveDirection * Time.deltaTime); //cubeを動かす処理
	}

	//	void OnGUI()
	//	{
	//		for (int i = (int)KeyCode.Joystick1Button0; i <= (int)KeyCode.Joystick2Button19; i++)
	//		{
	//			if (Input.GetKey((KeyCode)i)) GUILayout.Label(((KeyCode)i).ToString() + " is pressed.");
	//		}
	//	}
}