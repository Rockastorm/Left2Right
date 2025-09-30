using UnityEngine;

public class gm : MonoBehaviour
{

    // Variable

    public GameObject Circle;
    public Vector2 location = new Vector2 (0, -9);

    public static int score;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCircle()
    {

        Instantiate(Circle, location, Circle.transform.rotation);
    
    
    
    }



}
