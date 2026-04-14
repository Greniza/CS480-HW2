using UnityEngine;
using System.Collections;

public class player_particle_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public GameObject current_checkpoint;

    Vector3 target_position;
    ParticleSystem directed_particles;

    void Start()
    {
        target_position = current_checkpoint.transform.position;
        directed_particles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // make a vector that points to the next checkpoint
        Vector3 pos_diff = current_checkpoint.transform.position - this.transform.position;
        // set it so it isn't pointing awkwardly upwards when close to a checkpoint
        pos_diff.y = 0;
        // face the position in question
        this.transform.rotation = Quaternion.LookRotation(pos_diff, Vector3.up);
    }
}
