using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collect : MonoBehaviour
{

    GameObject settings;

    Score_Handler score_handler;

    GameObject textmeshpro_score;

    TextMeshProUGUI textmeshpro_score_text;

    public void Start()
    {
        textmeshpro_score = GameObject.FindGameObjectWithTag("ScoreText");
        textmeshpro_score_text = textmeshpro_score.GetComponent<TextMeshProUGUI>();

        settings = GameObject.FindGameObjectWithTag("Settings");
        score_handler = settings.GetComponent<Score_Handler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        score_handler.scoreIncrease();
        textmeshpro_score_text.text = "Marshmallows found: " + score_handler.getScore();
             
        Destroy(gameObject);
    }
}
