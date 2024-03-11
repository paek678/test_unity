using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    static manager instance;
    public static manager Getinstance() { init(); return instance; }
    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void init()
    {
        if(instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go != null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<manager>();
            }
            DontDestroyOnLoad(go);
            instance = go.GetComponent<manager>();
        }
        
    }
}
