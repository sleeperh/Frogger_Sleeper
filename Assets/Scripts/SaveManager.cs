using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
public class SaveManager : MonoBehaviour
{
    public GameObject frog;
    public static bool gameLoaded = false;
    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        Vector3 frogPosition = GameObject.Find("Frog").transform.position;
        save.frogPositionX = frogPosition.x;
        save.frogPositionY = frogPosition.y;
        save.frogPositionZ = frogPosition.z;
        save.lives = PlayerPrefs.GetInt("Lives");
        save.score = PlayerPrefs.GetInt("Score");
        save.music = PlayerPrefs.GetInt("Music");

        return save;
    }
    public void SaveGame()
    {
        Save save = CreateSaveGameObject();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
        Debug.Log("Game Saved");
    }
    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            Score.CurrentScore = save.score;
            PlayerPrefs.SetInt("Lives", save.lives);
            PlayerPrefs.SetInt("Music", save.music);
            Vector3 frogPosition = new Vector3(save.frogPositionX, save.frogPositionY, save.frogPositionZ);
            frog.transform.position = frogPosition;
            Debug.Log("Game Loaded" + "Score: " + save.score);
            gameLoaded = true;
        }
        else
            Debug.Log("No game saved!");
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
        save = JSONtoSave(json);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
    }

    public Save JSONtoSave(string json)
    {
        Save save = JsonUtility.FromJson<Save>(json);
        return save;
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Intro");
    }
}
