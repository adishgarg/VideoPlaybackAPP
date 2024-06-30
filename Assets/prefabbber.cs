using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class prefabbber : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _prefab;
    // A reference to our in-Scene clone of the prefab.
    private GameObject _instance;
    void Spawn()
    {
        // Clone the prefab and assign it to our variable.
        _instance = Instantiate(_prefab);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
