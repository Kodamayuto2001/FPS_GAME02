using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//参考文献
//http://inter-high-blog.unity3d.jp/2017/06/23/hitogata-2/

public class PlayerControl : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }
}
