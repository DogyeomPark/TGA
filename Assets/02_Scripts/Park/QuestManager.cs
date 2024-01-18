using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
public class QuestManager : MonoBehaviour
{
    public TextAsset txtFile; //Jsonfile
    public GameObject jsonObject; //�Ƚᵵ ��

    public GameObject questCanvas;
    public Text questNameTxt;
    public Text goalNameTxt;
    public Text countTxt;
    public GameObject descriptionPanel;

    private void Awake()
    {
        questNameTxt = GameObject.Find("questNameTxt").GetComponent<Text>();
        goalNameTxt = GameObject.Find("goalNameTxt").GetComponent<Text>();
        countTxt = GameObject.Find("countTxt").GetComponent<Text>();
        descriptionPanel.SetActive(false);
    }
    void Start()
    {


    }


    public void InstQuest(int n)
    {
        string json = txtFile.text;
        var jsonData = JSON.Parse(json); //var�� �ǹ�: Unity���� ������ �ٰ����´�.

        int item = n; //�Ű�����

        //GameObject character = Instantiate(jsonObject);


        questNameTxt.text = (jsonData["��Ʈ1"][n]["QuestName"]);
        goalNameTxt.text = (jsonData["��Ʈ1"][n]["Goal"]);
        countTxt.text = (jsonData["��Ʈ1"][n]["Count"]);


        #region
        //character.transform.name = (jsonData["��Ʈ1"][n]["QuestName"]);
        //character.GetComponent<QuestData>().charname = (jsonData["��Ʈ1"][n]["QuestName"]);
        //character.GetComponent<QuestData>().atk = (int)(jsonData["��Ʈ1"][n]["Count"]);
        ////character.GetComponent<QuestData>().count++; //QuestData�� ī��Ʈ ����

        //character.tag = "Player"; //prefab�� �±׸� �ްž�.

        //character.transform.SetParent(questCanvas.transform); //���� questCanvas�� �θ�� �ΰ� �����ϰ� Prefab�� �¾.
        #endregion
    }


    void Update()
    {
        
    }
}
