using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.XR;

public class PlayerSpriteSwapper : MonoBehaviour
{
    public enum SpriteOptions
    {
        hoodie,
        knight
    }

    [SerializeField]
    private SpriteOptions character;
    public int Health
    {
        get { Debug.Log("Getter called"); return 2; }
        set { Debug.Log("Setter called"); }
    }


    [Header("Sprite Renderers")]
    public SpriteRenderer Head;
    public SpriteRenderer Torso;
    public SpriteRenderer UpperLeftArm;
    public SpriteRenderer LowerLeftArm;
    public SpriteRenderer LeftHand;
    public SpriteRenderer UpperRightArm;
    public SpriteRenderer LowerRightArm;
    public SpriteRenderer RightHand;
    public SpriteRenderer UpperLeftLeg;
    public SpriteRenderer LowerLeftLeg;
    public SpriteRenderer LeftShoe;
    public SpriteRenderer UpperRightLeg;
    public SpriteRenderer LowerRightLeg;
    public SpriteRenderer RightShoe;

    private void OnValidate()
    {
        UpdateCharacter(character);
    }

    void UpdateCharacter(SpriteOptions so)
    {
        string name = so.ToString();
        print("LOADING PLAYER SPRITE: " + name);
        Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Characters/" + name);
        Head.sprite = sprites[3];
        Torso.sprite = sprites[7];
        UpperLeftArm.sprite = sprites[8];
        LowerLeftArm.sprite = sprites[4];
        LeftHand.sprite = sprites[2];
        UpperRightArm.sprite = sprites[8];
        LowerRightArm.sprite = sprites[4];
        RightHand.sprite = sprites[2];
        UpperLeftLeg.sprite = sprites[6];
        LowerLeftLeg.sprite = sprites[0];
        LeftShoe.sprite = sprites[5];
        UpperRightLeg.sprite = sprites[6];
        LowerRightLeg.sprite = sprites[0];
        RightShoe.sprite = sprites[5];



    }
}
