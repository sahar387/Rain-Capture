using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class NewBehaviourScript : MonoBehaviour
{
    // the prefab of droplet
    [SerializeField]
    private GameObject prefab;

    private bool _gameOver = false;

    public void SpawnDroplet()
    {
        Instantiate(prefab, new Vector3(Random.Range(-8f, 8f), 9f, 0f), Quaternion.identity);
    }

    //Collision detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !_gameOver)
        {
            SpawnDroplet();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Ground")
        {
            _gameOver = true;
            Debug.Log("Game Over! You Lost");
        }
    }
}
