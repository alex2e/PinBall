using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salir : MonoBehaviour {
	
	
	private void Update()
	{
		if (transform.position.z < -10)
		{
			Console.WriteLine("Hola");
			
			SceneManager.LoadScene("Final");
		}
	}
}
