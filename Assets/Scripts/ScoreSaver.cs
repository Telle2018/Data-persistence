using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreSaver : MonoBehaviour
{
    public static ScoreSaver Instance;
    public string PlayerName;
    public string HighScorePlayer;
    public int HighScore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadHighScore();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Serializable]
    class SaveData
    {
        public string HighScorePlayer;
        public int HighScore;
    }

    public void SaveHighScore(int score)
    {
        HighScore = score;
        HighScorePlayer = PlayerName;
        SaveData data = new SaveData();
        data.HighScorePlayer = HighScorePlayer;
        data.HighScore = HighScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighScorePlayer = data.HighScorePlayer;
            HighScore = data.HighScore;
        }
    }
}
