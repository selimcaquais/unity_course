using UnityEngine;

public class Planet : MonoBehaviour
{
    [Range(40,1000)]
    [Tooltip("Distance from the orbit in thousands of km")]
    public float distanceFromOrbit;
    [Range(20,200)]
    [Tooltip("Size of the planet in thousands of km")]
    public float sizeBody;

    public MeshRenderer body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     this.body = this.GetComponentInChildren<MeshRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = new Vector3(distanceFromOrbit, 0, 0);
        this.body.transform.localScale = new Vector3(this.sizeBody, this.sizeBody, this.sizeBody);
    }
}
