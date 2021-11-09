using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestoyerScript : MonoBehaviour
{

	public GameObject ex;
	public Text GameOver;

	void OnTriggerEnter2D (Collider2D obj)
	{
		    int score = 0;

        switch (gameObject.tag)
        {
            case "sky":
                Destroy(obj.gameObject);
                break;

            case "runner":

                switch (obj.gameObject.tag)
                {
					case "watermelon":
						score = 5;
						break;

					case "apple":
						score = 10;
                        break;

                    case "straberry":
						score = 15;
                        break;

                    case "wolverine":
						GameOver.text = "Game Over!!";
						return;
				}

				// fall through and increment score, if the obj gameObject is not wolverine

                var s = ex.GetComponent<UImanager> ();

				s.instance.IncrementScore (score);
				Destroy (obj.gameObject);

				break;
		}      
	}

}
