using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource MusicSource;

    public int sceneid;

    public void onClick()
    {

     
        if (sceneid == 5) Application.Quit(); // Exit
       
        Application.LoadLevel(sceneid); // Get id to know what window need to be open
        MusicSource.Play();
    }
}