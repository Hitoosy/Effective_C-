public class tuple : MonoBehaviour
{
    private int[] aa = new int[7] { 2,53,6,7,4,2,9,};

    void Start()
    {
        BubbleSort(aa);
    }

    void BubbleSort(int[] a)
    {
        bool isEnd = false;
        int finAdjust = 1;

        while(!isEnd)
        {
            bool loopSwap = false;

            for(int i = 0; i < a.Length - finAdjust; i++)
            {
                if (a[i] < a[i + 1])
                {
                    GenericUtils.Swap(ref a[i], ref a[i + 1]);
                    loopSwap = true;
                }
               
            }

            if (!loopSwap)
            {
                isEnd = true;
            }
            finAdjust++;
        }

        foreach(int i in aa)
        {
            Debug.Log(i);
        }
    }

    
    
}



public static class GenericUtils
{
    public static void Swap<T> (ref T a, ref T b)
    {
        var tmp = a;
        a = b;
        b = tmp;
    }
}
