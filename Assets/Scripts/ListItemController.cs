using UnityEngine;
using System.Collections;
using UnityEngine.UI;


/********************************************************
 * 
 * This Class include Prefab Panel's Components.
 * Panel Name : Panel_ListView .
 * 
 * ******************************************************/

public class ListItemController : MonoBehaviour {

	public Text reporterName;
	public Text boatType;
	public Text boatName;
	public Text like;
	public Text dislike;
	public Image Icon;

	public void onThankClick(string thanks) {
		Debug.Log ("Thanks" + thanks);
	}

}//ListItemController
