using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

[Serializable]
public class GreyTrigger : MonoBehaviour
{

    private AudioManager am;

    public bool silence;
    public int gbtmid;
    public int glbtmid;

  
    public GameObject refr;

    // Use this for initialization
    void Start()
    {
        am = FindObjectOfType<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }
                     

    public void OnClick()
    {

        am.orange.SetActive(true);
        am.creation = true;
        am.greyid = gbtmid;
        am.greyLid = glbtmid;
        am.refr = refr;


    }
}
