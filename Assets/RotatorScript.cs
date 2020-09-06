using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    float degRot = 0.0f;
   [SerializeField] Material MonkeyMat;
   Color defCol = new Color(0, 255, 156);

   Color [] SomeColors = {Color.red, Color.yellow, Color.green, Color.cyan, Color.blue, Color.magenta};
   int count = 0;
    void Start()
    {
        transform.rotation = Quaternion.Euler(-120.452f, 0,-9.406982f);
        MonkeyMat.color = Color.grey;
    }

    // Update is called once per frame

    void Update()
    {   
        //degRot += 1.0f;
        //transform.rotation = Quaternion.Euler(-120.452f,degRot, -9.406982f);
        transform.rotation = Quaternion.Euler(Input.mousePosition.y * -1.0f, Input.mousePosition.x * -0.3f,-9.406982f );

        if(Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }

        if(Input.GetMouseButtonDown(0)) {
            
            
            if(count >= SomeColors.Length) {
                MonkeyMat.color = Color.grey;
                count = 0;
            } else {
                MonkeyMat.color = SomeColors[count];
                count++;
            }
        } else if(Input.GetMouseButtonDown(1)) {
            MonkeyMat.color = Color.cyan;
        }
    }
}
