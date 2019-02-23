using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class OnClickTrigger : MonoBehaviour {

    private AudioManager am;
    private GreyTrigger gt;

    public AudioClip newMusic;
    public int cbtmid;
    

	// Use this for initialization
	void Start () {
        am = FindObjectOfType<AudioManager>();
     }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnClick()
    {


		if (am.creation == true)
		{

			if (cbtmid == 51) // проверка на отчистку
			{

				am.MusicClear(am.greyid, am.greyLid);
				am.ReDraw(cbtmid);
				am.creation = false;
				am.greyid = 0;
				am.greyLid = 0;
				am.refr = null;

			}
			else // стандартное добавленик
			{


				am.MusicInsesrt(am.greyid, am.greyLid, cbtmid);
				// print("Айди серой кнопки = "+ am.greyid+ " Айди ряда кнопки =" + am.greyLid+ " Айди круглой кнопки =" + cbtmid);
				am.ReDraw(cbtmid);
				am.creation = false;
				am.greyid = 0;
				am.greyLid = 0;
				am.refr = null;
			}
		}
		else // простое воспроизведение
		if (am.creation == false) if (newMusic != null) am.ChangeCircleTest(newMusic);


    }

    }
