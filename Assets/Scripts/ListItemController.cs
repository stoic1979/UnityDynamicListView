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

	public Text     reporterName;
	public Text     boatType;
	public Text 	boatName;
	public Text 	like;
	public Text 	dislike;
	public Image	Icon;
	public Button 	Thank;
	public Button 	likeCount;
	public Button 	dislikeCount;
	//public bool 	flag;


	public void OnThankClick(string thanks,string reportId ) {
		Debug.Log ("Thanks........:" + thanks);
		Debug.Log ("\nReportID ...:" + reportId);
	}

	public void onLikeClick(string likes) {
		int countLike = int.Parse(likes);
		countLike++;
		like.text  = countLike.ToString();	
	}

	public void onDislikeClick(string dislikes) {
		int countDislike = int.Parse (dislikes);
		countDislike++;
		dislike.text = countDislike.ToString();		
	}

}//ListItemController