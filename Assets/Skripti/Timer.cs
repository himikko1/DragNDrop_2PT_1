using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI; 
public class Timer : MonoBehaviour {
	public static bool GameEnd=false;
	//sakas laika atskaite (0)
	public static float timeStart;	
	// tiek izvadits rezultats
	public GameObject text;			
	// uzglaba rezultatu vertibu
	private static string time;				

	void Start () {
		timeStart = 0;
		time = getTime();
		text.GetComponent<Text>().text = time;	
	}

	public static string getTime()
	{
		int sec, min, h;		//mainigie, nepieciesamie aprekinasanai
		sec = Mathf.RoundToInt(timeStart);			//noapalojam laiku
	

		h = sec / 3600;								
		sec -= h * 3600;							
		min = sec / 60;								
		sec -= min * 60;							
		time = h+":"+min+":"+sec;

		return time;									
	}
	void Update () {
		if(GameEnd==false){
		timeStart += Time.deltaTime;				
		time= getTime();								
		text.GetComponent<Text>().text = time;		
		}
	}
}
