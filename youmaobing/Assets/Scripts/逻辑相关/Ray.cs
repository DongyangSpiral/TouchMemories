//using System.Collections;
//using System.Collections.Generic;
//using Fungus;
//using UnityEngine;

//public class Ray : MonoBehaviour
//{

//    [Header("Flowchart")]
//    public Flowchart flowchart;


//    [Header("Camera")]
//    public CameraScript Main;
//    public CameraScript PhotoWall;
//    public CameraScript Wardrobe;
//    public CameraScript Piano;
//    public CameraScript Chest;
//    public GameObject MainScene;

//    public int NowLayer = 0;
//    public bool CanRay = true;

//    public GameObject MemoryInHand;
//    public GameObject MemoryInHandSwap;
//    public Wardrobe WardrobeScript;

//    public bool hasWardrobeKey = false; // 是否拥有衣柜钥匙
//    public bool hasOpenedWardrobe = false; // 是否已打开衣柜
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.K))
//        {
//            print(NowLayer);
//        }

//        if (Input.GetMouseButtonDown(0)) // 左键点击
//        {
//            // 将鼠标屏幕坐标转为世界坐标（2D）
//            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

//            // 发射2D射线（从mousePos出发，方向为零向量，即检测该点的碰撞）
//            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

//            if (hit.collider != null)
//            {
//                // 如果射线碰到2D物体，输出物体名称
//                Debug.Log("点击了2D物体: " + hit.collider.gameObject.name);

//                // 获取碰撞点坐标（2D）
//                Vector2 hitPoint = hit.point;
//                Debug.Log("碰撞点: " + hitPoint);

//                if (hit.collider.gameObject.tag == "Door" && NowLayer == 0)
//                {
//                    Debug.Log("点击了门，触发Flowchart");
//                    // 调用Flowchart中的函数
//                    flowchart.ExecuteBlock("Door");
//                }

//                else if (hit.collider.gameObject.tag == "Photo" && NowLayer == 0)
//                {
//                    Debug.Log("点击了照片，触发EnlargeableObject");
//                    print(hit.collider.enabled);
                     
//                    MainScene.SetActive(false);
//                    Main.ChangeCamera(Main, PhotoWall);
//                    NowLayer = 1;
                    
//                    print(NowLayer);
//                    flowchart.ExecuteBlock("Photo");
//                }

//                else if (hit.collider.gameObject.tag == "MemoryPhoto" && NowLayer == 1)
//                {

//                    MemoryInHand.SetActive(true);


//                    flowchart.ExecuteBlock("MemoryPhoto");


//                }
//                else if (hit.collider.gameObject.tag == "Wardrobe" && NowLayer == 0)
//                {
//                    //hit.collider.GetComponent<Collider2D>().enabled = false;
//                    MainScene.SetActive(false);
//                    NowLayer = 2; // 切换到衣柜层
//                    Main.ChangeCamera(Main, Wardrobe);
//                }
//                else if (hit.collider.gameObject.tag == "Clothes" && NowLayer == 2)
//                {
//                    flowchart.ExecuteBlock("Clothes");
//                }
//                else if (hit.collider.gameObject.tag == "Piano" && NowLayer == 0)
//                {
//                    MainScene.SetActive(false);
//                    NowLayer = 3; // 切换到钢琴层
//                    Main.ChangeCamera(Main, Piano);

//                }
//                else if (hit.collider.gameObject.tag == "WardrobeDrawer" && NowLayer == 2)
//                {
//                    flowchart.ExecuteBlock("WardrobeDrawer");
//                    if (hasWardrobeKey)
//                    {
//                        WardrobeScript.ChangeSprite();
//                        hasOpenedWardrobe = true; // 标记衣柜已打开
//                    }
//                }
//            }
//        }
//    }
//}