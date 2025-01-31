using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{

    public bool isShooting;
    public Transform LeftArm;
    public Animator anim;

    void Update()
    {
        anim.SetBool("IsShooting", isShooting);
    }

    void LateUpdate()
    {
        if (isShooting)
            LeftArm.transform.localRotation = Quaternion.Euler(new(0, 0, 90));
    }
}
