using UnityEngine;

public class checkpoint_system : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject next_checkpoint;
    public GameObject player;

    public GameObject particle_effect;

    bool has_been_played;

    void Start ()
    {
        has_been_played = false;
    }


    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            particle_effect.GetComponent<player_particle_controller>().current_checkpoint = next_checkpoint;
            // this.gameObject.SetActive(false);
            if (!has_been_played)
            {
                GetComponent<AudioSource>().Play();
                has_been_played = true;
            }

        }
    }
}
