using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public static SceneChanger instanceSM;

    // Use this for initialization
    void Start()
    {
        if (intanceSM == null)
        {
            instanceSM = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(GameObject);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
        }
    }
}
