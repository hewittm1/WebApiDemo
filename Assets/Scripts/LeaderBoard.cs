using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : DataLoader {
    public string[] dataItems;

    private void Awake()
    {
        StartCoroutine(CheckLeaders());
    }
    private IEnumerator CheckLeaders()
    {
        yield return new WaitForSeconds(1f);
        createUserURL = "http://gamedevee.com/SchoolClass.php";
        WWW data = new WWW(createUserURL);
        yield return data;
        string dataString = data.text;
        dataItems = dataString.Split(';');
        for (int i = 0; i < dataItems.Length - 1; i++)
        {
            print("Username: " + GetDataValues(dataItems[i], "Username:"));
            print("Score: " + GetDataValues(dataItems[i++], "Score:"));
            i--;
        }
        
        //print(GetDataValues(dataItems[2], "Username:"));
    }
    string GetDataValues(string _data, string _index)
    {
        string _val = _data.Substring(_data.IndexOf(_index)+_index.Length);
        //string[] _valArr = _val.Split(':');
        if(_val.Contains("|"))
            _val = _val.Remove(_val.IndexOf("|"));
        return _val;
    }
}
