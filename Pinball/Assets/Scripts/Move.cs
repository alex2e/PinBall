using System;
using System.Threading;
using System.Xml;
using UnityEngine;

public class Move : MonoBehaviour
{
	private GameObject ball;
	private AudioSource audioSource;

	// Use this for initialization
	void Start ()
	{
		ball = GameObject.FindWithTag("Ball");
		audioSource = GetComponent<AudioSource>();

	} 
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collision)
	{
		audioSource.Play();
		gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.white);
		GameManager.point++;
	}
	

	private void OnCollisionExit(Collision collision)
	{
		gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.gray);
	}
}
