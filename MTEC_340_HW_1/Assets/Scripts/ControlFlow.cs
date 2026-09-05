using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public bool flag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (flag){
            Debug.Log("Boolean flag is set");
        } else {
            Debug.Log("Boolean flag isn\'t set");
        }
        for(int x=1; x<=10; x++){
            Debug.Log("The " + x + " power of 2 is " + Mathf.Pow(2,x));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
