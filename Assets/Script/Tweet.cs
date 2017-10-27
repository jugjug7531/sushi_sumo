using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweet : MonoBehaviour {

	// Use this for initialization
	public void Push() {
		string format = "https://twitter.com/intent/tweet?&text={0}";
		string url = string.Format(format, WWW.EscapeURL("寿司相撲界の横綱になりました！ https://unityroom.com/games/sushi-sumou #寿司相撲 #MonoUnityGames") );
		Application.ExternalEval(string.Format("window.open('{0}','_blank')", url));
	}

}
