using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObjects : MonoBehaviour

{


	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == "Player")
		{
			print ("Item picked up");
			Destroy(gameObject);

		}
	}
}
