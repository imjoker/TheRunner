using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {

	public  Text       ScoreText;
	public  Text       HighScoreText;
	public  UImanager  instance;
	public  int        Score;
	public  int        HighScore;
	void start ()
	{
		Score              = 0;
		HighScore          = PlayerPrefs.GetInt ("Variabletext");
		HighScoreText.text = "High Score : " + HighScore.ToString ();
		ScoreText.text     = "Score : " + Score.ToString ();
	}
	public void IncrementScore (int i)
	{
		Score = Score + i;

		ScoreText.text = "Score : " + Score.ToString ();

		HighScore = PlayerPrefs.GetInt ("Variabletext");

		if (Score > HighScore) {

			HighScore          = Score;
			HighScoreText.text = "High Score : " + HighScore.ToString ();

			PlayerPrefs.SetInt ("Variabletext", HighScore);
		}
	}

}
