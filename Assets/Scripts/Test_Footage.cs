using UnityEngine;

public class Test_Footage : MonoBehaviour
{

    public GameObject text;
    public GameObject reticle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.SetActive(false);
        reticle.SetActive(false);
    }

}
