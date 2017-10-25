using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {
    string createUserURL = "http://gamedevee.com/InsertUser.php";
    public string CurrUser { get; set; }
    //public string inputUserName;

    //void Start()
    //{
    //    CreateUser(inputUserName);
    //}
    public void CreateUser(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        WWW www = new WWW(createUserURL, form);
        //CreateNewUserScore(username, 0);
    }
    public void CreateNewUserScore(string username, int score)
    {
        string _createUserURL = "http://gamedevee.com/InsertUserScore.php";
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("userScorePost", score);
        WWW www = new WWW(_createUserURL, form);
    }
}
