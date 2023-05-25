﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject policija;
	public GameObject ugunsdzeseji;
	public GameObject e46;
	public GameObject e61;
	public GameObject b2;
	public GameObject traktors5;
	public GameObject cementaMasina;
	public GameObject eskavators;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 policijaKoord;
    [HideInInspector]
    public Vector2 ugunsdzesejiKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 eskavatorsKoord;
    [HideInInspector]
    public Vector2 cementaMasinaKoord;
    [HideInInspector]
    public Vector2 traktors5Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 b2Koord;


    public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		atkrMKoord =
        atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord =
        atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord =
		autobuss.GetComponent<RectTransform>().localPosition;

        policijaKoord =
        policija.GetComponent<RectTransform>().localPosition;

        ugunsdzesejiKoord =
        ugunsdzeseji.GetComponent<RectTransform>().localPosition;

        e46Koord =
        e46.GetComponent<RectTransform>().localPosition;

        eskavatorsKoord =
      eskavators.GetComponent<RectTransform>().localPosition;

        b2Koord =
     b2.GetComponent<RectTransform>().localPosition;

        traktors5Koord =
     traktors5.GetComponent<RectTransform>().localPosition;

        e61Koord =
     e61.GetComponent<RectTransform>().localPosition;

        cementaMasinaKoord =
     cementaMasina.GetComponent<RectTransform>().localPosition;
    }
}
