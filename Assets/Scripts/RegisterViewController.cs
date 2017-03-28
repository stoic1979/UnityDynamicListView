using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleJSON;

public class RegisterViewController : MonoBehaviour {
	
	public string url   = "http://weavebytes.com/lplates/api.php";
	public InputField userameField;
	public InputField passwordField;
	public InputField emailField;

	public void onBackClick(){
		SceneManager.LoadScene ("LoginView");
	}

	public void onRegisterButtonClick() {
		
		WWWForm form = new WWWForm();
		form.AddField("op", "register");
		form.AddField("username", userameField.text);
		form.AddField("password", passwordField.text);
		form.AddField("email", emailField.text);
		Debug.Log ("UserName=" + userameField.text + "\npassword" + passwordField.text + "\nemail" + emailField.text );
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
