public class QuickSort
{



    public static void quickSort(int[] nums, int left, int right)
    {
        Task task = new Task(() =>
        {
        });

        if (left < +right)
        {
            int mid = partitionDoubleDirection(nums, left, right);
            quickSort(nums, left, mid - 1);
            quickSort(nums, mid + 1, right);
        }
    }

    // �ָ�������������
    static int partitionBySingleDirection(int[] a, int left, int right)
    {
        int temp, pivot;//pivot�����Ԫ
        int i, j;
        i = left;
        pivot = a[right];

        // ����
        // i��j����left��ʼ��pivot�������
        // j���������ң�û�ҵ�һ��С��pivot��ֵ�ͺ�i���н�����������i����1λ
        // ���iλ��pivot(���1λ)���н���
        for (j = left; j < right; j++)
        {
            if (a[j] < pivot)
            {  //����ֵ
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                i++;
            }
        }
        a[right] = a[i];
        a[i] = pivot;
        return i;//����Ԫ���±귵��
    }

    // �ָ������˫�����
    static int partitionDoubleDirection(int[] arr, int left, int end)
    {
        int pivot = arr[left];

        int i = left, j = end;


        // ˫��
        // pivot��������
        // j��right�����ң��ҵ�һ��С��pivotֵ�õ�j�����j��ֵ��i
        // i��left�����ң��ҵ�һ������pivotֵ��i,���i��ֵ��j
        // �ظ�ijѰ�ң�ֱ��i��j�����������ĵط������µ�pivot�ص�
        // ��pivotֵ��i
        while (i < j)
        {
            while (j > i && arr[j] > pivot)
            {
                j--;
            }

            arr[i] = arr[j];

            while (j > i && arr[i] < pivot)
            {
                i++;
            }
            arr[j] = arr[i];

        }

        arr[i] = pivot;
        return i;
    }
}

//using System.Runtime.InteropServices;

//public class QuickSort
//{
//    public static int[] quickSort(int[] arr, int left, int right)
//    {
//        if (left < right)
//        {
//            //��ȡ����Ԫ��������λ��
//            int mid = partition(arr, left, right);
//            //���зָ�
//            arr = quickSort(arr, left, mid - 1);
//            arr = quickSort(arr, mid + 1, right);
//        }
//        return arr;
//    }

//    private static int partition(int[] arr, int left, int right)
//    {


//        //ѡȡ����Ԫ��
//        int pivot = arr[left];

//        Console.WriteLine($"pivot:{pivot};left:{left};right:{right}");

//        foreach (var item in arr)
//        {
//            Console.Write($"{item}  ");
//        }
//        Console.WriteLine("-----------");
//        int i = left + 1;
//        int j = right;
//        while (true)
//        {
//            // �����ҵ���һ�����ڵ��� pivot ��Ԫ��λ��
//            while (i <= j && arr[i] <= pivot) i++;
//            // �����ҵ���һ��С�ڵ��� pivot ��Ԫ��λ��
//            while (i <= j && arr[j] >= pivot) j--;
//            if (i >= j)
//                break;
//            //��������Ԫ�ص�λ�ã�ʹ����ߵ�Ԫ�ز�����pivot,�ұߵĲ�С��pivot

//            Console.WriteLine($"i:{i};arr[i]:{arr[i]};j:{j};arr[j]:{arr[j]};pivot{pivot}");
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }
//        arr[left] = arr[j];
//        // ʹ����Ԫ�ش��������λ��
//        arr[j] = pivot;

//        foreach (var item in arr)
//        {
//            Console.Write($"{item}  ");
//        }
//        Console.WriteLine();

//        Console.WriteLine($"pivot:{j};left:{left};right:{right};mid:{j}");
//        Console.WriteLine("*****************************");


//        return j;
//    }
//}


