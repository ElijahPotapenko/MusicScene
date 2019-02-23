using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

/// <summary>
/// повторяющиеся звуки не воспроизводяться
/// общая отчистка клир ол
/// заругзка файлов
/// настойка громкости
/// настройка задержки 
/// сохранять
/// окрывать
/// мануал
/// найти больше звуков
/// </summary>

[Serializable]
public class SoundElder : MonoBehaviour {

	private AudioManager am;

	public bool stopPlay;

	public List<int> signa0 = new List<int>();
	public List<int> signa1 = new List<int>();
	public List<int> signa2 = new List<int>();
	public List<int> signa3 = new List<int>();
	public List<int> signa4 = new List<int>();
	public List<int> signa5 = new List<int>();
	public List<int> signa6 = new List<int>();
	public List<int> signa7 = new List<int>();
	public List<int> signa8 = new List<int>();
	public List<int> signa9 = new List<int>();
	public List<int> signa10 = new List<int>();
	public List<int> signa11 = new List<int>();
	public List<int> signa12 = new List<int>();
	public List<int> signa13 = new List<int>();
	public List<int> signa14 = new List<int>();
	public List<int> signa15 = new List<int>();
	public List<int> signa16 = new List<int>();
	public List<int> signa17 = new List<int>();
	public List<int> signa18 = new List<int>();
	public List<int> signa19 = new List<int>();
	public List<int> signa20 = new List<int>();
	public List<int> signa21 = new List<int>();
	public List<int> signa22 = new List<int>();
	public List<int> signa23 = new List<int>();
	public List<int> signa24 = new List<int>();
	public List<int> signa25 = new List<int>();
	public List<int> signa26 = new List<int>();
	public List<int> signa27 = new List<int>();

	private int delay = 3 ; // задержка для воспроизведение


	void Start () {

		am = FindObjectOfType<AudioManager>();
		
	}
	
	void Update () {


	}

	public void runFlow() // главный метод воспроизводящий всю написанную музыку
	{ 

		PrepareForRun();

		run0();
		run1(3); 
		run2(6);
		run3(9);
		run4(12);
		run5(15);
		run6(18);
		run7(21);
		//run8(delay + 3);
		//run9(delay + 3);
		//run10(delay + 3);
		//run11(delay + 3);
		//run12(delay + 3);
		//run13(delay + 3);
		//run14(delay + 3);
		//run15(delay + 3);
		//run16(delay + 3);
		//run17(delay + 3);
		//run18(delay + 3);
		//run19(delay + 3);
		//run20(delay + 3);
		//run21(delay + 3);
		//run22(delay + 3);
		//run23(delay + 3);
		//run24(delay + 3);
		//run25(delay + 3);
		//run26(delay + 3);
		//run27(delay + 3);
	}



	void run0() // воспроизводит номер столбик
	{
		
		for (int i = 0; i < signa0.Count; i++)
		{

			switch (signa0[i])
			{

				case 1: am.musicStorage[1].Play(); break;
				case 2: am.musicStorage[2].Play(); break;
				case 3: am.musicStorage[3].Play(); break;
				case 4: am.musicStorage[4].Play(); break;
				case 5: am.musicStorage[5].Play(); break;
				case 6: am.musicStorage[6].Play(); break;
				case 7: am.musicStorage[7].Play(); break;
				case 8: am.musicStorage[8].Play(); break;
				case 9: am.musicStorage[9].Play(); break;

			}


			//foreach (int sound in signa) {
			//am.musicStorage[1].Play();
			//Thread.Sleep(1000);
			//am.musicStorage[2].Play();
			//Thread.Sleep(1000);
			//	am.musicStorage[signa[0]].Play();
			//print(signa[0]);
			//Thread.Sleep(1000);
			//----------------------------------------
			//Thread.Sleep(10);`
			//am.audio1.SetActive(true);

		}

	}

	void run1(int delay)  // воспроизводит номер столбик
	{
		
		for (int i = 0; i < signa1.Count; i++)
		{

			switch (signa1[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;
				

			}
		}


	}
	
	void run2(int delay)  // воспроизводит номер столбик
	{

		for (int i = 0; i < signa2.Count; i++)
		{

			switch (signa2[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run3(int delay)  // воспроизводит номер столбик
	{

		for (int i = 0; i < signa3.Count; i++)
		{

			switch (signa3[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run4(int delay)  // воспроизводит номер столбик
	{

		for (int i = 0; i < signa4.Count; i++)
		{

			switch (signa4[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run5(int delay)  // воспроизводит номер столбик
	{

		for (int i = 0; i < signa5.Count; i++)
		{

			switch (signa5[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run6(int delay)  // воспроизводит номер столбик
	{

		for (int i = 0; i < signa6.Count; i++)
		{

			switch (signa6[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run7(int delay)  // воспроизводит номер столбик
	{

		for (int i = 0; i < signa7.Count; i++)
		{

			switch (signa7[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run8(int delay)  // воспроизводит номер столбик
	{

		for (int i = 0; i < signa8.Count; i++)
		{

			switch (signa8[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run9(int delay)  // воспроизводит номер столбик
	{

		for (int i = 0; i < signa9.Count; i++)
		{

			switch (signa9[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run10(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa10.Count; i++)
		{

			switch (signa10[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run11(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa11.Count; i++)
		{

			switch (signa11[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run12(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa12.Count; i++)
		{

			switch (signa12[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run13(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa13.Count; i++)
		{

			switch (signa13[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run14(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa14.Count; i++)
		{

			switch (signa14[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run15(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa15.Count; i++)
		{

			switch (signa15[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run16(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa16.Count; i++)
		{

			switch (signa16[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run17(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa17.Count; i++)
		{

			switch (signa17[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run18(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa18.Count; i++)
		{

			switch (signa18[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run19(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa19.Count; i++)
		{

			switch (signa19[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run20(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa20.Count; i++)
		{

			switch (signa20[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run21(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa21.Count; i++)
		{

			switch (signa21[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run22(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa22.Count; i++)
		{

			switch (signa22[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run23(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa23.Count; i++)
		{

			switch (signa23[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run24(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa24.Count; i++)
		{

			switch (signa24[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run25(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa25.Count; i++)
		{

			switch (signa25[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run26(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa26.Count; i++)
		{

			switch (signa26[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	void run27(int delay) // воспроизводит номер столбик
	{

		for (int i = 0; i < signa27.Count; i++)
		{

			switch (signa27[i])
			{

				case 1: am.musicStorage[1].PlayDelayed(delay); break;
				case 2: am.musicStorage[2].PlayDelayed(delay); break;
				case 3: am.musicStorage[3].PlayDelayed(delay); break;
				case 4: am.musicStorage[4].PlayDelayed(delay); break;
				case 5: am.musicStorage[5].PlayDelayed(delay); break;
				case 6: am.musicStorage[6].PlayDelayed(delay); break;
				case 7: am.musicStorage[7].PlayDelayed(delay); break;
				case 8: am.musicStorage[8].PlayDelayed(delay); break;
				case 9: am.musicStorage[9].PlayDelayed(delay); break;


			}
		}


	}
	


	void PrepareForRun() { // удаленгие всех серых

		signa0.Clear();

		for (int i = 0; i < am.lvl0.Count ; i++)
		{
			if (am.lvl0[i] != 0)
			{

				signa0.Add(am.lvl0[i]);
			}
			
		}

		//---------------------------------------------
		signa1.Clear();

		for (int i = 0; i < am.lvl1.Count; i++)
		{
			if (am.lvl1[i] != 0)
			{

				signa1.Add(am.lvl1[i]);
			}

		}

		//---------------------------------------------
		signa2.Clear();

		for (int i = 0; i < am.lvl2.Count; i++)
		{
			if (am.lvl2[i] != 0)
			{

				signa2.Add(am.lvl2[i]);
			}

		}//---------------------------------------------
		signa3.Clear();

		for (int i = 0; i < am.lvl3.Count; i++)
		{
			if (am.lvl3[i] != 0)
			{

				signa3.Add(am.lvl3[i]);
			}

		}//---------------------------------------------
		signa4.Clear();

		for (int i = 0; i < am.lvl4.Count; i++)
		{
			if (am.lvl4[i] != 0)
			{

				signa4.Add(am.lvl4[i]);
			}

		}//---------------------------------------------
		signa5.Clear();

		for (int i = 0; i < am.lvl5.Count; i++)
		{
			if (am.lvl5[i] != 0)
			{

				signa5.Add(am.lvl5[i]);
			}

		}//---------------------------------------------
		signa6.Clear();

		for (int i = 0; i < am.lvl6.Count; i++)
		{
			if (am.lvl6[i] != 0)
			{

				signa6.Add(am.lvl6[i]);
			}

		}//---------------------------------------------
		signa7.Clear();

		for (int i = 0; i < am.lvl7.Count; i++)
		{
			if (am.lvl7[i] != 0)
			{

				signa7.Add(am.lvl7[i]);
			}

		}//---------------------------------------------
		signa8.Clear();

		for (int i = 0; i < am.lvl8.Count; i++)
		{
			if (am.lvl8[i] != 0)
			{

				signa8.Add(am.lvl8[i]);
			}

		}//---------------------------------------------
		signa9.Clear();

		for (int i = 0; i < am.lvl9.Count; i++)
		{
			if (am.lvl9[i] != 0)
			{

				signa9.Add(am.lvl9[i]);
			}

		}//---------------------------------------------
		signa10.Clear();

		for (int i = 0; i < am.lvl10.Count; i++)
		{
			if (am.lvl10[i] != 0)
			{

				signa10.Add(am.lvl10[i]);
			}

		}//---------------------------------------------
		signa11.Clear();

		for (int i = 0; i < am.lvl11.Count; i++)
		{
			if (am.lvl11[i] != 0)
			{

				signa11.Add(am.lvl11[i]);
			}

		}//---------------------------------------------
		signa12.Clear();

		for (int i = 0; i < am.lvl12.Count; i++)
		{
			if (am.lvl12[i] != 0)
			{

				signa12.Add(am.lvl12[i]);
			}

		}//---------------------------------------------
		signa13.Clear();

		for (int i = 0; i < am.lvl13.Count; i++)
		{
			if (am.lvl13[i] != 0)
			{

				signa13.Add(am.lvl13[i]);
			}

		}//---------------------------------------------
		signa14.Clear();

		for (int i = 0; i < am.lvl14.Count; i++)
		{
			if (am.lvl14[i] != 0)
			{

				signa14.Add(am.lvl14[i]);
			}

		}//---------------------------------------------
		signa15.Clear();

		for (int i = 0; i < am.lvl15.Count; i++)
		{
			if (am.lvl15[i] != 0)
			{

				signa15.Add(am.lvl15[i]);
			}

		}//---------------------------------------------
		signa16.Clear();

		for (int i = 0; i < am.lvl16.Count; i++)
		{
			if (am.lvl16[i] != 0)
			{

				signa16.Add(am.lvl16[i]);
			}

		}//---------------------------------------------
		signa17.Clear();

		for (int i = 0; i < am.lvl17.Count; i++)
		{
			if (am.lvl17[i] != 0)
			{

				signa17.Add(am.lvl17[i]);
			}

		}//---------------------------------------------
		signa18.Clear();

		for (int i = 0; i < am.lvl18.Count; i++)
		{
			if (am.lvl18[i] != 0)
			{

				signa18.Add(am.lvl18[i]);
			}

		}//---------------------------------------------
		signa19.Clear();

		for (int i = 0; i < am.lvl19.Count; i++)
		{
			if (am.lvl19[i] != 0)
			{

				signa19.Add(am.lvl19[i]);
			}

		}//---------------------------------------------
		signa20.Clear();

		for (int i = 0; i < am.lvl20.Count; i++)
		{
			if (am.lvl20[i] != 0)
			{

				signa20.Add(am.lvl20[i]);
			}

		}
		//---------------------------------------------
		signa21.Clear();

		for (int i = 0; i < am.lvl21.Count; i++)
		{
			if (am.lvl21[i] != 0)
			{

				signa21.Add(am.lvl21[i]);
			}

		}//---------------------------------------------
		signa22.Clear();

		for (int i = 0; i < am.lvl22.Count; i++)
		{
			if (am.lvl22[i] != 0)
			{

				signa22.Add(am.lvl22[i]);
			}

		}//---------------------------------------------
		signa23.Clear();

		for (int i = 0; i < am.lvl23.Count; i++)
		{
			if (am.lvl23[i] != 0)
			{

				signa23.Add(am.lvl23[i]);
			}

		}//---------------------------------------------
		signa24.Clear();

		for (int i = 0; i < am.lvl24.Count; i++)
		{
			if (am.lvl24[i] != 0)
			{

				signa24.Add(am.lvl24[i]);
			}

		}//---------------------------------------------
		signa25.Clear();

		for (int i = 0; i < am.lvl25.Count; i++)
		{
			if (am.lvl25[i] != 0)
			{

				signa25.Add(am.lvl25[i]);
			}

		}
		//---------------------------------------------
		signa26.Clear();

		for (int i = 0; i < am.lvl26.Count; i++)
		{
			if (am.lvl26[i] != 0)
			{

				signa26.Add(am.lvl26[i]);
			}

		}//---------------------------------------------
		signa27.Clear();

		for (int i = 0; i < am.lvl27.Count; i++)
		{
			if (am.lvl27[i] != 0)
			{

				signa27.Add(am.lvl27[i]);
			}

		}

	}


	void GreatDystrybutor() {

	

	}


}
