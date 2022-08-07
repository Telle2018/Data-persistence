using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSaver : MonoBehaviour
{
    public static ScoreSaver Instance;
    public string PlayerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        //LoadColor();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
