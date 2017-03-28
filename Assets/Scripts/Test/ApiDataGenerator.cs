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
//		for (int i = 0; i < lstReports.Count; i++) {
//			lstReports [i].show ();
//		}
		return lstReports;		
	}

	public static List<Like> getDummyLikes()
	{
		List<Like> likes = new List<Like> ();
		likes.Add (new Like ("Tom" ,1));
		likes.Add (new Like ("John",5));
		likes.Add (new Like ("Sam" ,3));
		likes.Add (new Like ("Davy",2));
		likes.Add (new Like ("Jack",6));

		return likes;
	}

	public static List<Dislike> getDummyDislikes()
	{
		List<Dislike> dislikes = new List<Dislike> ();
		dislikes.Add (new Dislike ("Tom" ,1));
		dislikes.Add (new Dislike ("John",5));
		dislikes.Add (new Dislike ("Sam" ,3));
		dislikes.Add (new Dislike ("Davy",2));
		dislikes.Add (new Dislike ("Jack",6));

		return dislikes;
	}

	public static List<Thank> getDummyThanks()
	{
		List<Thank> thanks = new List<Thank> ();
		thanks.Add (new Thank ("Tom" ,1));
		thanks.Add (new Thank ("John",5));
		thanks.Add (new Thank ("Sam" ,3));
		thanks.Add (new Thank ("Davy",2));
		thanks.Add (new Thank ("Jack",6));

		return thanks;
	}

}//ApiDataGenerator
