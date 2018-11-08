using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
 

public class ChangePostProcess : MonoBehaviour
{
	public PostProcessingProfile normal, fx;
	private PostProcessingBehaviour camImageFX;
	bool isUnderwater  = false;
	// Use this for initialization
	void Start () {
		camImageFX = FindObjectOfType<PostProcessingBehaviour> ();
		SetUnderwater (true);
	}

	void SetUnderwater(bool isUnder){
		isUnderwater = isUnder;
		if (isUnderwater) {
			camImageFX.profile = fx;
		} else {
			camImageFX.profile = normal;
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag ("Player")) {
			SetUnderwater (true);
		}
	}
	
	void OnTriggerExit(Collider col)
	{
			if (col.CompareTag ("Player"))
			{
				SetUnderwater (false);
			}
	}
}