using UnityEngine;
using System.Collections;

public class Report {

	string      reporterName;
	int        	reportId;
	string     	boatName;
	int        	boatType;
	double      lat;
	double      lng;
	int 		cntLikes;
	int 		cntDislikes;
	int 		cntThanks;

	public Report(string reporterName,int reportId, string boatName, int boatType, double lat, double lng, int cntLikes, int cntDislikes, int cntThanks) {
		this.reporterName     = reporterName;
		this.reportId         = reportId;
		this.boatName         = boatName;
		this.boatType         = boatType;
		this.lat              = lat;
		this.lng              = lng;
		this.cntLikes         = cntLikes;
		this.cntDislikes      = cntDislikes;
		this.cntThanks        = cntThanks;
	}

	public void setReporterName(string reporterName){
		this.reporterName  = reporterName;
	}

	public string getReporterName(){
		return this.reporterName;
	}

	public void setReportId(int reportId){
		this.reportId         = reportId;
	}

	public int getReportId(){
		return this.reportId;
	}

	public void setBoatName(string boatName){
		this.boatName = boatName;
	}

	public string getBoatName(){
		return this.boatName;
	}

	public void setBoatType(int boatType){
		this.boatType = boatType;
	}

	public int getBoatType(){
		return this.boatType;
	}

	public void setLatitude(double latValue){
		this.lat = latValue;	   
	}

	public double getLatitude(){
		return this.lat;
	}

	public void setLongitude(double lngValue){
		this.lng = lngValue;	   
	}

	public double getLongitude(){
		return this.lng;
	}

	public void setLikeCount(int cntLikes){
		this.cntLikes  = cntLikes;
	}

	public int getLikeCount(){
		return this.cntLikes;
	}

	public void setDislikeCount(int cntDislikes){
		this.cntDislikes  = cntDislikes;
	}

	public int getDislikeCount(){
		return this.cntDislikes;
	}

	public void setThankCount(int cntThanks){
		this.cntThanks  = cntThanks;
	}

	public int getThankCount(){
		return this.cntThanks;
	}


	public void show() {
		Debug.Log ("--------------[ Report ]-----------------");
		Debug.Log ("Reporter Name . . : " + reporterName);
		Debug.Log ("Report Id . . . . : " + reportId);
		Debug.Log ("Boat Name . . . . : " + boatName);
		Debug.Log ("Boat Type . . . . : " + boatType);
		Debug.Log ("Latitude  . . . . : " + lat);
		Debug.Log ("Longitude . . . . : " + lng);
		Debug.Log ("Count Like. . . . : " + cntLikes);
		Debug.Log ("Count Dislike . . : " + cntDislikes);
		Debug.Log ("Count Thank . . . : " + cntThanks);
		Debug.Log ("-----------------------------------------");
	}

}//Report
