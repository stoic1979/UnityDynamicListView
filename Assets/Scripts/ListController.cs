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
	public Button     newestReports;
	public Button     importantReports;



	//Function Called on Newest button click to show  Newest Report.
	public void onNewestClick() {

		int childs = ContentPanel.transform.childCount;

		for(int j=childs-1; j>=0; j--) {
			GameObject.Destroy(ContentPanel.transform.GetChild(j).gameObject);
		}

		ArrayList  reports  = ApiDataGenerator.getDummyReports ();
		int i     = 0;

		foreach (Report reportItem in reports)  {

			GameObject newReport = (GameObject)Instantiate(listPrefab,transform.position,Quaternion.identity);

			ListItemController controller  =  newReport.GetComponent<ListItemController>();

			controller.reporterName.text   =  reportItem.getReporterName ();
			controller.Icon.sprite         =  circleImages[i++];
			string reportId                =  reportItem.getReportId ().ToString();
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
			string countThanks             =  reportItem.getThankCount().ToString ();
			newReport.transform.parent     =  ContentPanel.transform;
			newReport.transform.localScale =  new Vector3(1,1,1);

			controller.Thank.onClick.AddListener(() => controller.OnThankClick(countThanks,reportId));
			controller.likeCount.onClick.AddListener(() => controller.onLikeClick(controller.like.text));
			controller.dislikeCount.onClick.AddListener(() => controller.onDislikeClick(controller.dislike.text));

		}
		newestReports.interactable    = false;
		importantReports.interactable = true;
	}

	public void onImportantClick() {


		int childs = ContentPanel.transform.childCount;

		for(int j=childs-1; j>=0; j--) {
			GameObject.Destroy(ContentPanel.transform.GetChild(j).gameObject);
		}


		ArrayList  reports  = ApiDataGenerator.getDummyReports ();
		int i     = 0;

		foreach (Report reportItem in reports)  {

			GameObject newReport = (GameObject)Instantiate(listPrefab,transform.position,Quaternion.identity);

			ListItemController controller  =  newReport.GetComponent<ListItemController>();

			controller.reporterName.text   =  reportItem.getReporterName ();
			controller.Icon.sprite         =  circleImages[i++];
			string reportId                =  reportItem.getReportId ().ToString();
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
			string countThanks             =  reportItem.getThankCount().ToString ();
			newReport.transform.parent     =  ContentPanel.transform;
			newReport.transform.localScale =  new Vector3(1,1,1);

			controller.Thank.onClick.AddListener(() => controller.OnThankClick(countThanks,reportId));
			controller.likeCount.onClick.AddListener(() => controller.onLikeClick(controller.like.text));
			controller.dislikeCount.onClick.AddListener(() => controller.onDislikeClick(controller.dislike.text));

		}
		newestReports.interactable    = true;
		importantReports.interactable = false;
	}

}//ListController
