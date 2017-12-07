using System;

public class PseudoRandomUtility
{
    private const int MAXN = 1 << 20;

    private static int m_Seed;

    private static int m_Index = 0;
 
    /* 保证m与a互质 两个数确定随机数的均匀性*/ 
    private static int m_ParamA = 9;  // a = 4p + 1
    private static int m_ParamB = 7;  // b = 2q + 1
  
 
    //初始化随机种子
    public static void Init(int seed)
    {
        m_Seed = seed;
        m_Index = 0;
    }

    /// <summary>
    /// 随机序列Index
    /// </summary>
    /// <value>The index.</value>
    public static int Index
    {
        get
        {
            return m_Index;

        }
    }
    /// <summary>
    /// 获取下一个随机数
    /// </summary>
    /// <returns>The rand.</returns>
    public static int Rand()
    {
        m_Index++;

        m_Seed = (m_ParamA * m_Seed + m_ParamB) % MAXN;

        return m_Seed;
    }


    /// <summary>
    /// 获取第N个随机数
    /// </summary>
    /// <returns>The rand.</returns>
    /// <param name="index">Index.</param>
    public static int Rand(int index)
    {
        while(true)
        {
            if (index == m_Index)
                break;

            Rand();
        }

        return m_Seed;
    } 

}

