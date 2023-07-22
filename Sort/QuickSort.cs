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

    // 分割操作：单向调整
    static int partitionBySingleDirection(int[] a, int left, int right)
    {
        int temp, pivot;//pivot存放主元
        int i, j;
        i = left;
        pivot = a[right];

        // 单向
        // i和j都从left开始，pivot放在最后
        // j从左向右找，没找到一个小于pivot的值就和i进行交换，交换后i自增1位
        // 最后i位和pivot(最后1位)进行交换
        for (j = left; j < right; j++)
        {
            if (a[j] < pivot)
            {  //交换值
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                i++;
            }
        }
        a[right] = a[i];
        a[i] = pivot;
        return i;//把主元的下标返回
    }

    // 分割操作：双向调整
    static int partitionDoubleDirection(int[] arr, int left, int end)
    {
        int pivot = arr[left];

        int i = left, j = end;


        // 双向
        // pivot放在最左
        // j从right向左找，找到一个小于pivot值得的j，这个j的值给i
        // i从left向右找，找到一个大于pivot值得i,这个i的值给j
        // 重复ij寻找，直到i和j相遇，相遇的地方就是新的pivot地点
        // 将pivot值给i
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
//            //获取中轴元素所处的位置
//            int mid = partition(arr, left, right);
//            //进行分割
//            arr = quickSort(arr, left, mid - 1);
//            arr = quickSort(arr, mid + 1, right);
//        }
//        return arr;
//    }

//    private static int partition(int[] arr, int left, int right)
//    {


//        //选取中轴元素
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
//            // 向右找到第一个大于等于 pivot 的元素位置
//            while (i <= j && arr[i] <= pivot) i++;
//            // 向左找到第一个小于等于 pivot 的元素位置
//            while (i <= j && arr[j] >= pivot) j--;
//            if (i >= j)
//                break;
//            //交换两个元素的位置，使得左边的元素不大于pivot,右边的不小于pivot

//            Console.WriteLine($"i:{i};arr[i]:{arr[i]};j:{j};arr[j]:{arr[j]};pivot{pivot}");
//            int temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }
//        arr[left] = arr[j];
//        // 使中轴元素处于有序的位置
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


