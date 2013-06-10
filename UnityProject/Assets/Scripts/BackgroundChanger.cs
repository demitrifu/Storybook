using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackgroundChanger : MonoBehaviour {
	
	public GameObject 	m_BackgroundSprite;
//	public List<string>	m_list;
	bool 				m_Toggle;
//	
	
	// Use this for initialization
	void Start () {
		
	}	
	
	// Update is called once per frame
	void Update () {	
	
	}
	
	void OnSubmit() //On submitting chat
	{	
		Debug.Log("heekowskoekw");
		
		//m_Toggle = !m_Toggle;
		
		//m_BackgroundSprite.SetActive(m_Toggle);
		
		var maxSpriteCount = m_BackgroundSprite.GetComponent<UISprite>().atlas.spriteList.Count; //Grab max sprite count in Atlas
		
		var index = Random.Range(0, maxSpriteCount);
		
		
			
		m_BackgroundSprite.GetComponent<UISprite>().spriteName = m_BackgroundSprite.GetComponent<UISprite>().atlas.spriteList[index].name;
		
	}
}