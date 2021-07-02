using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private static AudioScript audioScript;

    void Awake()
    {
        if (audioScript == null)
        {
            audioScript = this;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
