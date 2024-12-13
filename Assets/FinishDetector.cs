using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishDetector : MonoBehaviour
{
    public GameObject PausePanel;
    private AudioSource[] audioSources;
    public bool isOpponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PauseAllAudio()
    {
        // Update audio sources every time pause is called
        audioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audio in audioSources)
        {
            audio.Pause();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Finish") {
            if (isOpponent) {
                Debug.Log("Kamu Kalah");
                Instantiate(Resources.Load("KamuKalah"));
                Time.timeScale = 0;
                PauseAllAudio();
            }
            else
            {
                Debug.Log("Kamu Menang");
                Instantiate(Resources.Load("KamuMenang"));
                Time.timeScale = 0;
                PauseAllAudio();
            }
            Destroy(col.gameObject);
        }
    }
}
