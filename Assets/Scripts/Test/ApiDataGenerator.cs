using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/********************************************************
 * 
 * This Class used to get Dummy Values for
 * Prefab Panel's Components.
 * 
 * ******************************************************/

public class ApiDataGenerator {
		
	public static ArrayList getDummyReports()
	{
		ArrayList lstReports = new ArrayList () {
			new Report ( "Tom" , 1, "WPS 32"  , 1, 12.344 , 13.344, 1  , 15, 13 ),
			new Report ( "Davy", 2, "Calpyso" , 2, 13.344 , 91.344, 5  , 10, 10 ),
			new Report ( "Sam" , 3, "WPS 20"  , 1, 12.344 , 13.344, 10 , 20, 15 ),
			new Report ( "John", 5, "WPS 25"  , 1, 12.344 , 13.344, 20 , 10, 16 ),
			new Report ( "Jack", 6, "Calpyso" , 2, 12.344 , 13.344, 12 , 2 , 9  )
		};

		return lstReports;		
	}

	public static ArrayList getDummyLikes()
	{
		ArrayList likes = new ArrayList (){
			new Like ("Tom" ,1),
			new Like ("John",5),
			new Like ("Sam" ,3),
			new Like ("Davy",2),
			new Like ("Jack",6)
		};

		return likes;
	}

	public static ArrayList getDummyDislikes()
	{
		ArrayList dislikes = new ArrayList (){
		    new Dislike ("Tom" ,1),
			new Dislike ("John",5),
			new Dislike ("Sam" ,3),
			new Dislike ("Davy",2),
			new Dislike ("Jack",6)
	};

		return dislikes;
	}

	public static ArrayList getDummyThanks()
	{
		ArrayList thanks = new ArrayList (){
			new Thank ("Tom" ,1),
			new Thank ("John",5),
			new Thank ("Sam" ,3),
			new Thank ("Davy",2),
			new Thank ("Jack",6)
		};

		return thanks;
	}

}//ApiDataGenerator
