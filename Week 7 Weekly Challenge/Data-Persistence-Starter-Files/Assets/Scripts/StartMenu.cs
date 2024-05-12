using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;

public class StartMenu : MonoBehaviour
{
    public string playerName;
    public TextMeshProUGUI playerNameText;
    public GameObject Instance;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    [System.Serializable]
    class PlayerData
    {
        public string name;
    }
    public void SaveName()
    {
        PlayerData data = new PlayerData();
        data.name = name;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savename.json", json);   
    }
    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savename.json";
        if(File .Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);
            name = data.name;
        }
    }
}