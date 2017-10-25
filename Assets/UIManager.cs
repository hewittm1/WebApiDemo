using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : DataLoader {

    //public Button submitbtn;
    public Text inputField;
    public Text guessingField;
    public List<GameObject> goList = new List<GameObject>();

	public void SubmitUser()
    {
        //CreateUser(inputField.text);
        CurrUser = inputField.text;
        for (int i = 0; i < goList.Count; i++)
            goList[i].SetActive(!goList[i].gameObject.activeSelf);
    }
    public void CheckCipher()
    {
        CipherManager cm = GetComponent<CipherManager>();
        if (cm.Decrypt(guessingField.text))
            cm.Win(cm.Timer, CurrUser);
        else
            Debug.LogWarning("nope!! try again!");
    }
}
