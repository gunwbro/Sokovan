using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("노래재생");
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
