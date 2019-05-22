
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Text objectVisto;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray aim = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));
        RaycastHit hitInfo;
        if (Physics.Raycast(aim, out hitInfo))
        {
            string newText = hitInfo.collider.tag;
            if (newText == "Untagged" || newText == "Small1" || newText == "Small2" || newText == "Big")
            {
                objectVisto.text = "";
            }
            else
            {
                objectVisto.text = newText;
            }
        }
       
    }
}