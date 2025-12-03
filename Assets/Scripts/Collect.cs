using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;
using Unity.VisualScripting;

public class Collect : MonoBehaviour
{

    GameObject settings;

    Score_Handler score_handler;

    GameObject textmeshpro_score;

    TextMeshProUGUI textmeshpro_score_text;

    SFX_Player player;

    public void Start()
    {
        textmeshpro_score = GameObject.FindGameObjectWithTag("ScoreText");
        textmeshpro_score_text = textmeshpro_score.GetComponent<TextMeshProUGUI>();

        settings = GameObject.FindGameObjectWithTag("Settings");
        score_handler = settings.GetComponent<Score_Handler>();
        player = settings.GetComponent<SFX_Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        score_handler.scoreIncrease();
        textmeshpro_score_text.text = "Marshmallows found: " + score_handler.getScore() + "/14";
        player.PlayCLipAtPoint(gameObject.transform.position);

        Destroy(gameObject);
    }

}
