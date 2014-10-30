using UnityEngine;
using System.Collections;

public class IngameGui : MonoBehaviour {

	public GameObject highScore;
	public static int totalLifes = 3;
	public static int totalScore;

	void Awake(){
		int newFontSize = 1080 / Screen.width;
		newFontSize = 72 / newFontSize;
		gameObject.guiText.fontSize = newFontSize;
	}

	public void UpdateScoreAndLives(){
		gameObject.guiText.text = "Lives: " + totalLifes + "   Score: " + totalScore;
	}

	void Update(){
		totalScore += 1;
		UpdateScoreAndLives();
	}

	public void LoseLife(){
		totalLifes -= 1;
		UpdateScoreAndLives();
	}

	public void GetLife(){
		totalLifes += 1;
		UpdateScoreAndLives();
	}

	public void ResetScoreAndLifes(){
		totalScore = 0;
	}
}
