using UnityEngine;

//This is a script I got from a previous class and have been using ever since.
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    
    public AudioSource musicSource;
    public AudioSource sfxSource;
    
    public AudioClip backgroundMusic;
    public float masterVolume = 0.7f;
    
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        //If the master volume exists, set it to the saved value and set it to 0.7f if not
        if (PlayerPrefs.GetFloat("volume") == null)
        {
            PlayerPrefs.SetFloat("volume", 0.7f);
            PlayerPrefs.Save();
            masterVolume = PlayerPrefs.GetFloat("volume");
        } else {
            masterVolume = PlayerPrefs.GetFloat("volume");
        }
    }
    
    void Start()
    {
        AudioListener.volume = masterVolume;
        PlayMusic(backgroundMusic);
    }

    //Since the master volume is updated outside of this script, it checks to see if it has changed and sets it to that
    void Update()
    {
       AudioListener.volume = masterVolume; 
       PlayerPrefs.SetFloat("volume", masterVolume);
       PlayerPrefs.Save();
    }
    
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }
    
    public void PlaySoundEffect(AudioClip clip, float volume){
        if (volume == null) volume = 1f;
        float trueVolume = masterVolume * volume;
        sfxSource.PlayOneShot(clip, 1f);
    }
}