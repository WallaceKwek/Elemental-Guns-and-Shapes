using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    [SerializeField]
    private BoundsCalc testBoundsObj;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(testBoundsObj.bounds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDebugLevelGen()
    {
        Debug.Log("Works");
    }
}
