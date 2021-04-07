using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmallShips
{
    public class ExplosionController : MonoBehaviour {

        [Tooltip("Child game objects that should be destroyed during explosion. For that 'DestroyPart(x)' will be called from animation clip.")]
        public GameObject[] removeParts;
        [Tooltip("Array of children that have animation for explosion and should explode by calling from parent animation clip.")]
        public ExplosionController[] childrenExplosion;

        Animator animator;
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        public void DestroyPart(int index)
        {
            if (removeParts != null && index >= 0 && index < removeParts.Length)
                Destroy(removeParts[index]);
            else
                Debug.LogWarning("Index is out of range in DestroPart. index: " + index);
        }

        public void StartExplosion()
        {
            if (animator == null)
                animator = GetComponent<Animator>();
            animator.SetBool("expl", true);
        }


        public void DestroyObject()
        {
            Destroy(gameObject);
        }


        public void DestroyParentObject()
        {
            Destroy(transform.parent.gameObject);
        }

        public void ChildExplosion(int index)
        {
            if (childrenExplosion != null && index >= 0 && index < childrenExplosion.Length)
                childrenExplosion[index].StartExplosion();
        }

        public void DestroyChildren()
        {
            if (removeParts != null && removeParts.Length > 0)
                foreach (GameObject child in removeParts)
                    Destroy(child);
        }


    }

}
