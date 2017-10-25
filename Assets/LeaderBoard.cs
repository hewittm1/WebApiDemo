using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : DataLoader {
    string createUserURL = "http://gamedevee.com/LeaderBoardPHP.php";
   // public string inputUserName;
    private void CheckLeaders()
    {
        
        //string queryString = @"SELECT VALUE contact FROM Contacts AS contact 
        //Order By contact.LastName";
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", CurrUser);
        form.AddField("userScorePost", 111111);
        WWW www = new WWW(createUserURL, form);
    }
}
