using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TodoElementHandler : MonoBehaviour
{

    public string Key;
    public void Delete()
    {
        //TODO: of course we need to save the state somewhere
        Debug.Log("deleting todo : " + Key);
        Destroy(gameObject);

    }
}
