using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SimpleJSON;
using UnityEngine.SceneManagement;

public class LoginViewController : MonoBehaviour {

	public string url   = "http://weavebytes.com/lplates/api.php";
	public InputField userameField;
	public InputField passwordField;

	public void Start() {
		ApiDataGenerator.getDummyReports ();
//		ApiDataGenerator.getDummyLikes ();
//		ApiDataGenerator.getDummyDislikes ();
//		ApiDataGenerator.getDummyThanks ();
	}

	public void onSignUPClick(){
		SceneManager.LoadScene ("RegisterView");
	}

	public void onLoginButtonClick() {

		WWWForm form = new WWWForm();
		form.AddField("op", "login");
		form.AddField("username", userameField.text);
		form.AddField("password", passwordField.text);
		Debug.Log ("UserName=" + userameField.text + "\npassword" + passwordField.text );
		WWW www  = new WWW(url, form);
		StartCoroutine(WaitForRequest(www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.data);
		} else 	{
			Debug.Log("WWW Error: " + www.error);
		}
	}


}
