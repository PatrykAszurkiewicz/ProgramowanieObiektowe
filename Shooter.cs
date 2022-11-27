using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject fireball, gun, effect, effectPlace;
    AttackerSpawner myLaneSpawner;
    Animator animator;

    const string PROJECTILE_PARENT_NAME = "Projectiles";
    GameObject projectileParent;

    AudioSource audioSource;

    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
        CreateProjectileParent();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough =
                (Mathf.Abs(spawner.transform.position.y - transform.position.y)
                <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }
    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void Fire()
    {
        GameObject newProjectile = Instantiate(fireball, gun.transform.position, transform.rotation) as GameObject; 
        GameObject newProjectile1 = Instantiate(effect, effectPlace.transform.position, transform.rotation) as GameObject;

        newProjectile.transform.parent = projectileParent.transform;
        newProjectile1.transform.parent = projectileParent.transform;

        audioSource.Play();
    }
    void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }


}
