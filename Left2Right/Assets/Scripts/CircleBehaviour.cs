using UnityEditor.Build.Content;
using UnityEngine;





public class CircleBehaviour : MonoBehaviour
{
    public gm gm;

    




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.SpawnCircle();
        
        Destroy(collision.gameObject);

        gm.score++;

    }


}
