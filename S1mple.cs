using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple : MonoBehaviour
{
    public int _intValue;
    public List<int> _List;

    public float _floatValue;
    public string _stringValue;
    public bool _boolValue;
    public Vector3 _vectorValue;
    public GameObject _gameObjectValue;

    private void Start()
    {
        _intValue = 5;
        _List = new List<int>() { 1 };

        _floatValue = 3.14f;
        _stringValue = "Hello, Unity!";
        _boolValue = true;
        _vectorValue = new Vector3(1, 2, 3);
        _gameObjectValue = new GameObject("NewObject");

        Debug.Log(_intValue);
        Debug.Log(_List[0]);
        Debug.Log(_floatValue);
        Debug.Log(_stringValue);
        Debug.Log(_boolValue);
        Debug.Log(_vectorValue);
        Debug.Log(_gameObjectValue);
    }

}
