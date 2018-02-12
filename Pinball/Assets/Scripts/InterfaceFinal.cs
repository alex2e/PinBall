using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InterfaceFinal : MonoBehaviour {

    public Text points;
   

	// Use this for initialization
	void Start () {
		points.text = string.Format("Points: {0}", GameManager.point);
    }
	
	public void Click()
	{
		SceneManager.LoadScene("Awake");
	}
	
	

}
