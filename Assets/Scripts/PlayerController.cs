using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField]
    private DropletBehaviour _dropletBehaviour;

    private float _InputHorizontal;
    private float _speed = 10f;



    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _dropletBehaviour.SpawnDroplet();
    }

    // Update is called once per frame
    void Update()
    {
        _InputHorizontal = Input.GetAxisRaw("Horizontal");

        if(_InputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_InputHorizontal * _speed, 0f));
        }
    }
}
