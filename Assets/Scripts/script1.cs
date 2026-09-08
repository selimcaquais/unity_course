using UnityEngine;

public class AutoRotate : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        var controller = GameObject.FindAnyObjectByType<GameController>();
        this.transform.Rotate(Vector3.up, speed * GameController.Instance.speed);
    }
}
