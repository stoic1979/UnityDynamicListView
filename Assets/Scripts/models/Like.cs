using UnityEngine;
using System.Collections;

public class Like {
	string reporterName;
	int boatId;

	public Like(string reporterName,int boatId) {
		this.reporterName  = reporterName;
		this.boatId        = boatId;
	}

	public void setReporterName(string reporterName){
		this.reporterName  = reporterName;
	}

	public string getReporterName(){
		return this.reporterName;
	}

	public void setBoatId(int boatId){
		this.boatId   = boatId;
	}

	public int getBoatId(){
		return boatId;
	}

	public void show() {
		Debug.Log ("--------------[ Like ]-----------------");
		Debug.Log (" Reporter Name . . .: " + reporterName);
		Debug.Log (" BoatId  . . . . . .: " + boatId);
		Debug.Log ("-----------------------------------------");
	}

}//Like
