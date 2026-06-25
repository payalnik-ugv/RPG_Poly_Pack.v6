using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioClip victory;
    [SerializeField] private AudioClip loose;
    [SerializeField] private AudioSource _audioSource;

    public static Audio instance;

    private void Awake()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Victory()
    {
        _audioSource.PlayOneShot(victory);
    }

    public void Loose()
    {
        _audioSource.PlayOneShot(loose);
    }

    public void StopAllSounds()
    {
        _audioSource.Stop();
    }
}