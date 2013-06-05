using UnityEngine;
using System.Collections;

public class BackgroundChanger : MonoBehaviour {
	
	public GameObject 	mBackgroundSprite;	
	bool 				mToggle;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {	
	
	}
	
	void OnSubmit()
	{
		Debug.Log("Helo wrold!");
		
		mToggle = !mToggle;
		
		mBackgroundSprite.SetActive(mToggle);
	}
}