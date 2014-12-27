﻿using UnityEngine;
using System.Collections;

public class Digivolution_stats : MonoBehaviour {
	public int AgeInHour;
	public float Brains;
	public float CareMistakes;
	public int ChanceToDigivoulve;
	public float Defense;
	public float Discipline;
	public float Happiness;
	public float MaxHP;
	public float MaxMP;
	public float Offense;
	public float PoopCareMistakes;
	public float Speed;
	public float Weight;
	bool evolving;
	public float rotation_speed;
	public GameObject digivoulve;
	public GameObject curr_digimon;
	float counter = 0 ;
	GameObject[] otherCamera;
	public Camera digimonCamera;
	GameObject player_cam;

	// Use this for initialization
	void Start () {

		otherCamera = GameObject.FindGameObjectsWithTag("MainCamera");

		evolving = false;

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (digimonCamera.enabled);
		if(Brains > 30 && Defense > 30 && MaxHP > 300 )
		{

			//digimonCamera.enabled = true;
			//float x = 1*Time.deltaTime*rotation_speed;
			transform.Rotate(0,1*Time.deltaTime*rotation_speed,0); 
			//counter += 1*Time.deltaTime*rotation_speed/360;
			//Debug.Log(counter);
			//Debug.Log (digimonCamera.enabled);

		}
			//evolving = false;
			if (counter > 5)
			{
				digimonCamera.enabled = false;
				player_cam.camera.enabled = true;
				//Debug.Log (digimonCamera.enabled);
				//Debug.Log (player_cam.camera.enabled);
				Instantiate(digivoulve,transform.position,transform.rotation);
				Destroy(curr_digimon);
				
				
			}
		}
	void OnGUI() {
		Brains = GUI.HorizontalSlider(new Rect(25, 50f, 100f, 30f), Brains, 0.0F, 100.0F);
		CareMistakes = GUI.HorizontalSlider(new Rect(25, 75f, 100f, 30f), CareMistakes, 0.0F, 10.0F);
		Defense = GUI.HorizontalSlider(new Rect(25, 100f, 100f, 30f), Defense, 0.0F, 100.0F);
		MaxHP = GUI.HorizontalSlider(new Rect(25, 125f, 250, 30f), MaxHP, 0.0F, 1000.0F);

	}

}