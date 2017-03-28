using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ReportViewController : MonoBehaviour {

	public GameObject reportPanel;
	public Button newestButton;
	public GameObject boatType;
	public GameObject boatName;
	public GameObject reporterName;
	public GameObject countLikes;
	public GameObject countDislikes;

	//public Text countThanks;
	public int rX  = 0;
	public int rY  = 0;
	public int btX = 0;
	public int btY = 0;
	public int bnX = 0;
	public int bnY = 0;
	public int lX  = 0;
	public int lY  = 0;
	public int dX  = 0;
	public int dY  = 0;


	public void onNewestButtonClick() {
		ArrayList reports = ApiDataGenerator.getDummyReports ();

		foreach (Report list in reports) {

			Vector3 posOfReporter    = 	 new Vector3 (rX,rY,0);
			Vector3 posOfBoatType    =	 new Vector3 (btX,btY,0);
			Vector3 posOfBoaName     = 	 new Vector3 (bnX,bnY,0);
			Vector3 posOfLikes       =	 new Vector3 (lX,lY,0);
			Vector3 posOfDislikes    = 	 new Vector3 (dX,dY,0);

			Debug.Log ("Panel instantiate");

     		GameObject reporter            = (GameObject)Instantiate (reporterName, transform.position, Quaternion.identity);
			GameObject typeOfBoat          = (GameObject)Instantiate (boatType, transform.position, Quaternion.identity);
			GameObject nameOBoat           = (GameObject)Instantiate (boatName, transform.position, Quaternion.identity);
			GameObject totalLikes          = (GameObject)Instantiate (countLikes, transform.position, Quaternion.identity);
			GameObject totalDislikes       = (GameObject)Instantiate (countDislikes, transform.position, Quaternion.identity);

			reporter.transform.parent      = reportPanel.transform;
			reporter.transform.position    = posOfReporter;
			reporter.transform.localScale  = new Vector3 (1,1,1);
			//reporter.GetComponent<Text> ().text = reports.getReporterName ();
			rY = rY - 300;

			nameOBoat.transform.parent      = reportPanel.transform;
			nameOBoat.transform.position    = posOfBoaName;
			nameOBoat.transform.localScale  = new Vector3 (1,1,1);
			//nameOBoat.GetComponent<Text> ().text = reports[i].getBoatType ().ToString();
			btY = btY - 300;

			typeOfBoat.transform.parent      = reportPanel.transform;
			typeOfBoat.transform.position    = posOfBoatType;
			typeOfBoat.transform.localScale  = new Vector3 (1,1,1);
			//typeOfBoat.GetComponent<Text> ().text = reports[i].getBoatName ();
			bnY = bnY - 300;

			totalLikes.transform.parent      = reportPanel.transform;
			totalLikes.transform.position    = posOfLikes;
			totalLikes.transform.localScale  = new Vector3 (1,1,1);
			//totalLikes.GetComponent<Text> ().text = reports[i].getLikeCount ().ToString();
			lY = lY - 300;

			totalDislikes.transform.parent      = reportPanel.transform;
			totalDislikes.transform.position    = posOfDislikes;
			totalDislikes.transform.localScale  = new Vector3 (1,1,1);
			//totalDislikes.GetComponent<Text> ().text = reports [i].geDislikeCount ().ToString();
			dY = dY - 300;

		}

	}

}//ReportViewController
