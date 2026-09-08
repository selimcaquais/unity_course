using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public float speed;
    private float? _previousSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Instance == null)
            Instance = this;

    }

    public void pause()
    {
        if (this.speed == 0)
        {
            this.speed = this._previousSpeed.GetValueOrDefault(1);
        } else
        {
            this._previousSpeed = this.speed;
            this.speed = 0;
        }
        
    }

    public void upSpeed()
    {
        this.speed += 1;
    }

    public void downSpeed()
    {
        this.speed -= 1;
    }
}
