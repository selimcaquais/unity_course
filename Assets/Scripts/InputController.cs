using UnityEngine;

public class InputController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            GameController.Instance.pause();

        if(Input.GetKeyDown(KeyCode.DownArrow))
            GameController.Instance.downSpeed();

        if(Input.GetKeyDown(KeyCode.UpArrow))
            GameController.Instance.upSpeed();

    }
}
