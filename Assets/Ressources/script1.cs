using UnityEngine;

public class script1 : MonoBehaviour
{

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0,0, this.speed);
    }
}
