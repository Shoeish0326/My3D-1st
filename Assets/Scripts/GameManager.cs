using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] float timelimit = 60f;
    [SerializeField] Scene_Name _goscene;
    [SerializeField] Scene_Name _resultscene;
    [SerializeField] Scene_Name _titlescene;
    float _timer = 0;
    int _hp = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerController _pc = GameObject.Find("Player").GetComponent<PlayerController>();
        _hp = _pc.p_hp;
    }

    // Update is called once per frame
    void Update()
    {

        _timer += Time.deltaTime;

        if(_timer >= timelimit || _hp == 0)
        {
            SceneManager.LoadScene(_goscene.ToString());//ToString‚Íˆ—d‚¢
        }
    }

    //public void SceneChange()
    //{
    //    SceneManager.LoadScene(_scene.ToString());//ToString‚Íˆ—d‚¢

    //}
}
enum Scene_Name
{
    TitleScene,
    GameScene,
    GameOverScene,
    ResultScene,
}
