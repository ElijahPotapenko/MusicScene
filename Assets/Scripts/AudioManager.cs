using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class AudioManager : MonoBehaviour {



	//public GameObject audio1;
	

	//dRAW----------------------------

	public GameObject orange;

	[Header("knopki")]
	public Sprite clearSprite;
	[Header("sklad spritow")]
	public List<Sprite> spriteStorage = new List<Sprite>();

	//---------------------------------------


	[Header("Айди серой кнопки")]
	public int greyid;

	[Header(" Айди ряда кнопки ")]
	public int greyLid;

    public GameObject refr;

	[Header(" kruglaja кнопкa ")]
	public AudioSource CircleM;



    public bool creation = false;

	[Header("Collections")]
	//=---------------------------------

	[Header("склад звуков")]
	public List<AudioSource> musicStorage = new List<AudioSource>();

	//----------------------------------------
	[Header("0 уровень")]
    public List<int> lvl0 = new List<int>();
	[Header("1 уровень")]
	public List<int> lvl1 = new List<int>();
	[Header("2 уровень")]
	public List<int> lvl2 = new List<int>();
	[Header("3 уровень")]
	public List<int> lvl3 = new List<int>();
	[Header("4 уровень")]
	public List<int> lvl4 = new List<int>();
	[Header("5 уровень")]
	public List<int> lvl5 = new List<int>();
	[Header("6 уровень")]
	public List<int> lvl6 = new List<int>();
	[Header("7 уровень")]
	public List<int> lvl7 = new List<int>();
	[Header("8 уровень")]
	public List<int> lvl8 = new List<int>();
	[Header("9 уровень")]
	public List<int> lvl9 = new List<int>();
	[Header("10 уровень")]
	public List<int> lvl10 = new List<int>();
	[Header("11 уровень")]
	public List<int> lvl11 = new List<int>();
	[Header("12 уровень")]
	public List<int> lvl12 = new List<int>();
	[Header("13 уровень")]
	public List<int> lvl13 = new List<int>();
	[Header("14 уровень")]
	public List<int> lvl14 = new List<int>();
	[Header("15 уровень")]
	public List<int> lvl15 = new List<int>();
	[Header("16 уровень")]
	public List<int> lvl16 = new List<int>();
	[Header("17 уровень")]
	public List<int> lvl17 = new List<int>();
	[Header("18 уровень")]
	public List<int> lvl18 = new List<int>();
	[Header("19 уровень")]
	public List<int> lvl19 = new List<int>();
	[Header("20 уровень")]
	public List<int> lvl20 = new List<int>();
	[Header("21 уровень")]
	public List<int> lvl21 = new List<int>();
	[Header("22 уровень")]
	public List<int> lvl22 = new List<int>();
	[Header("23 уровень")]
	public List<int> lvl23 = new List<int>();
	[Header("24 уровень")]
	public List<int> lvl24 = new List<int>();
	[Header("25 уровень")]
	public List<int> lvl25 = new List<int>();
	[Header("26 уровень")]
	public List<int> lvl26 = new List<int>();
	[Header("27 уровень")]
	public List<int> lvl27 = new List<int>();
	
	


	// Use this for initialization
	void Start()
    {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeCircleTest(AudioClip music) // воспроизведение
    {
        CircleM.Stop();
        CircleM.clip = music;
        CircleM.Play();


    }

	public void MusicClear(int GreyNumber,int ListNumber) // очистка одного квадратика
		{

		//case of listnumber

		switch (ListNumber) {

			case 0: lvl0.RemoveAt(GreyNumber); break;
			case 1: lvl1.RemoveAt(GreyNumber); break;
			case 2: lvl2.RemoveAt(GreyNumber); break;
			case 3: lvl3.RemoveAt(GreyNumber); break;
			case 4: lvl4.RemoveAt(GreyNumber); break;
			case 5: lvl5.RemoveAt(GreyNumber); break;
			case 6: lvl6.RemoveAt(GreyNumber); break;
			case 7: lvl7.RemoveAt(GreyNumber); break;
			case 8: lvl8.RemoveAt(GreyNumber); break;
			case 9: lvl9.RemoveAt(GreyNumber); break;
			case 10: lvl10.RemoveAt(GreyNumber); break;
			case 11: lvl11.RemoveAt(GreyNumber); break;
			case 12: lvl12.RemoveAt(GreyNumber); break;
			case 13: lvl13.RemoveAt(GreyNumber); break;
			case 14: lvl14.RemoveAt(GreyNumber); break;
			case 15: lvl15.RemoveAt(GreyNumber); break;
			case 16: lvl16.RemoveAt(GreyNumber); break;
			case 17: lvl17.RemoveAt(GreyNumber); break;
			case 18: lvl18.RemoveAt(GreyNumber); break;
			case 19: lvl19.RemoveAt(GreyNumber); break;
			case 20: lvl20.RemoveAt(GreyNumber); break;
			case 21: lvl21.RemoveAt(GreyNumber); break;
			case 22: lvl22.RemoveAt(GreyNumber); break;
			case 23: lvl23.RemoveAt(GreyNumber); break;
			case 24: lvl24.RemoveAt(GreyNumber); break;
			case 25: lvl25.RemoveAt(GreyNumber); break;
			case 26: lvl26.RemoveAt(GreyNumber); break;
			case 27: lvl27.RemoveAt(GreyNumber); break;



		}

		if (refr!= null)
		refr.GetComponent<Image>().sprite = clearSprite;
		orange.SetActive(false);

	}

    public void MusicInsesrt(int GreyNumber, int ListNumber, int MusicNumber) // вставление музочки в квадратик
    {

        switch (ListNumber)
        {
            case 0: lvl0.RemoveAt(GreyNumber);
                lvl0.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
            case 1:
                lvl1.RemoveAt(GreyNumber);
                lvl1.Insert(GreyNumber, MusicNumber); orange.SetActive(false); break;
			case 2:
				lvl2.RemoveAt(GreyNumber);
				lvl2.Insert(GreyNumber, MusicNumber); orange.SetActive(false); break;
			case 3:
				lvl3.RemoveAt(GreyNumber);
				lvl3.Insert(GreyNumber, MusicNumber); orange.SetActive(false); break;
			case 4:
				lvl4.RemoveAt(GreyNumber);
				lvl4.Insert(GreyNumber, MusicNumber); orange.SetActive(false); break;
			case 5:
				lvl5.RemoveAt(GreyNumber);
				lvl5.Insert(GreyNumber, MusicNumber); orange.SetActive(false); break;
			case 6:
				lvl6.RemoveAt(GreyNumber);
				lvl6.Insert(GreyNumber, MusicNumber); orange.SetActive(false); break;
			case 7:
				lvl7.RemoveAt(GreyNumber);
				lvl7.Insert(GreyNumber, MusicNumber); orange.SetActive(false); break;
			case 8:
				lvl8.RemoveAt(GreyNumber);
				lvl8.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 9:
				lvl9.RemoveAt(GreyNumber);
				lvl9.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 10:
				lvl10.RemoveAt(GreyNumber);
				lvl10.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 11:
				lvl11.RemoveAt(GreyNumber);
				lvl11.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 12:
				lvl12.RemoveAt(GreyNumber);
				lvl12.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 13:
				lvl13.RemoveAt(GreyNumber);
				lvl13.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 14:
				lvl14.RemoveAt(GreyNumber);
				lvl14.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 15:
				lvl15.RemoveAt(GreyNumber);
				lvl15.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 16:
				lvl16.RemoveAt(GreyNumber);
				lvl16.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 17:
				lvl17.RemoveAt(GreyNumber);
				lvl17.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 18:
				lvl18.RemoveAt(GreyNumber);
				lvl18.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 19:
				lvl19.RemoveAt(GreyNumber);
				lvl19.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 20:
				lvl20.RemoveAt(GreyNumber);
				lvl20.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 21:
				lvl21.RemoveAt(GreyNumber);
				lvl21.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 22:
				lvl22.RemoveAt(GreyNumber);
				lvl22.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 23:
				lvl23.RemoveAt(GreyNumber);
				lvl23.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 24:
				lvl24.RemoveAt(GreyNumber);
				lvl24.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 25:
				lvl25.RemoveAt(GreyNumber);
				lvl25.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 26:
				lvl26.RemoveAt(GreyNumber);
				lvl26.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;
			case 27:
				lvl27.RemoveAt(GreyNumber);
				lvl27.Insert(GreyNumber, MusicNumber); orange.SetActive(false);
				break;

			default:
                Console.WriteLine("Default case");     // ошибка
                break;



        }
		
	}

    public void ReDraw( int cbtmid) // перерисовка квадратика по ссылке
    {
      
        if ( refr!=null)
		{
			refr.GetComponent<Image>().sprite = spriteStorage[cbtmid-1]; // -1 по тому что отсчтет с нуля

        }     
    }  
}
