using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

/********************************************************
 * 
 * This Class create Dynamic Report by instantiate
 * Prefab Panel.
 * Attached to DynamicScrollView.
 * 
 * ******************************************************/




public class ListController : MonoBehaviour {

	public GameObject ContentPanel;
	public GameObject listPrefab;
	public Sprite[]   circleImages;

	ArrayList  reports;
	string     countThanks;

	public void onNewestClick() {
		
		reports   = ApiDataGenerator.getDummyReports ();
		int i     = 0;
		foreach (Report reportItem in reports)  {

			GameObject newReport = (GameObject)Instantiate(listPrefab,transform.position,Quaternion.identity);

			ListItemController controller  =  newReport.GetComponent<ListItemController>();

			Button newButton               =  newReport.GetComponent<Button> ();

			controller.reporterName.text   =  reportItem.getReporterName ();
			controller.Icon.sprite         =  circleImages[i++];
			string reportId                =  reportItem.getReportId ().ToString();
			Debug.Log ("Report ID : " + reportId);
			controller.boatName.text       =  reportItem.getBoatName ();

			int boatType                   =  reportItem.getBoatType ();
			if (boatType == 1) {
				controller.boatType.text   = "Waterpolice Officer";
			} else if (boatType == 2) {
				controller.boatType.text   = "Undercover Cop";
			} else {				
			}

			controller.like.text 		   =  reportItem.getLikeCount ().ToString ();
			controller.dislike.text 	   =  reportItem.getDislikeCount ().ToString ();
			countThanks                    =  reportItem.getThankCount().ToString ();
			//AddListener (newButton, countThanks);
			newReport.transform.parent     =  ContentPanel.transform;
			newReport.transform.localScale =  new Vector3(1,1,1);

		}
	}
	void AddListener(Button newButton ,string countThanks) { 		
		newButton.onClick.AddListener (() => onThankClick (countThanks)
		);
	}

	public void onThankClick(string thanks) {
		Debug.Log ("Thanks" + thanks);
	}

}//ListController
