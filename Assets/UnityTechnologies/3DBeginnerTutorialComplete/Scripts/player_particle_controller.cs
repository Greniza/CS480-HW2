using UnityEngine;
using System.Collections;

public class player_particle_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public GameObject current_checkpoint;
    public double begin_shrink_distance;

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
        // LINEAR INTERPOLATION
        Vector3 pos_diff = current_checkpoint.transform.position - this.transform.position;
        // set it so it isn't pointing awkwardly upwards when close to a checkpoint
        pos_diff.y = 0;
        // face the position in question
        this.transform.rotation = Quaternion.LookRotation(pos_diff, Vector3.up);

        // Now, we scale down the particle emission based on proximity to the next checkpoint
        double distance = Vector3.Dot(pos_diff, pos_diff);
        if (distance > begin_shrink_distance * begin_shrink_distance)
        {
            this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else
        {
            float shrink_scale = (float) (distance / (begin_shrink_distance * begin_shrink_distance));
            shrink_scale = (shrink_scale + 1) / 2;
            this.transform.localScale = new Vector3(shrink_scale, 1.0f, shrink_scale);
        }

    }
}
