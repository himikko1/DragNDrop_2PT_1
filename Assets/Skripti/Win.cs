using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking.NetworkSystem;
using System;

public class Win : MonoBehaviour {

	public GameObject windowWin;
	public GameObject star1;
	public GameObject star2;
	public GameObject star3;
	public Text timer;

	[HideInInspector]
	public int masinasSkaits = 0;

	public void startOver()							//sākt spēli no jaunā
	{
		SceneManager.LoadScene("PilsetasKarte");
	}

	void Start()
	{
		windowWin.SetActive(false);					//sākumā nevar redzēt uzvaras logu
	}

	public void endGame()							//paradīt uzvaras logu
	{
		Timer.GameEnd = true;
		Debug.Log("LOG : Game ended!");
		windowWin.SetActive(true);
		timer.text = Timer.getTime();
		int sec = Convert.ToInt32(Timer.getTime());
		if(sec/60 < 2) 
		{
			star1.SetActive(true);
			star2.SetActive(true);
			star3.SetActive(true);
		}
		else if(sec/60 < 3) //2 zvaigznes
		{
			star1.SetActive(true);
			star2.SetActive(true);
			star3.SetActive(false);
		}
		else //1 zvaigzne
		{
			star1.SetActive(true);
			star2.SetActive(false);
			star3.SetActive(false);
		}
	}


}
