using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public GameObject popupWindow;
    public GameObject textMessage;
    float time = 3f;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        textMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showPopupWindow()
    {
        popupWindow.SetActive(true);
    }

    public void closePopupWindow()
    {
        popupWindow.SetActive(false);
    }

    public void showTextMessage()
    {
        textMessage.SetActive(true);
        Invoke("hideTextMessage", time);
    }

    public void hideTextMessage()
    {
        textMessage.SetActive(false);
    }

    public void playSound()
    {
        audioSource.Play();
    }
}
