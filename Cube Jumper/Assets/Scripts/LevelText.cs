using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text lvlText;
    // Start is called before the first frame update
    void Start()
    {
        lvlText.text = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
