using UnityEngine;

public class SFX_Player : MonoBehaviour
{
    public AudioClip clip;

    public float volume;

    public void PlayCLipAtPoint(Vector3 position)
    {
        Debug.Log("PLaying clip.");

        AudioSource.PlayClipAtPoint(clip, position, volume);
    }
}
