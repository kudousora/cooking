using UnityEngine;
using UnityEngine.SceneManagement;

public class changetime : MonoBehaviour
{
    private float step_time;    // �o�ߎ��ԃJ�E���g�p

    // Use this for initialization
    void Start()
    {
        step_time = 0.0f;       // �o�ߎ��ԏ�����
    }

    // Update is called once per frame
    void Update()
    {
        // �o�ߎ��Ԃ��J�E���g
        step_time += Time.deltaTime;

        // 3�b��ɉ�ʑJ�ځi�^�C�g���V�[���ֈړ��j
        if (step_time >= 3.0f)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}