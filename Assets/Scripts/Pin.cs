using UnityEngine;

public class Pin : MonoBehaviour
{

    public Rigidbody rigidbody;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Pin>())
        {

            audioSource.Play();

        }
    }
}
