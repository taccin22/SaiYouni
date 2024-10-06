using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            Debug.Log(nums[i] + "\t");
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Debug.Log("Sum = " + sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, 5 };
        int min = nums[0];
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (i < min) min = nums[i];
        }
        Debug.Log("Min = " + min);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, 5 };
        int count = 0;
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0) count++;
        }
        Debug.Log("So phan tu chan = " + count);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        string[] stringList =
        {
            "String 1",
            "String 2",
            "String 3",
            "String 4",
            "String 5"
        };

        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        for (int i = 0; i < stringList.Length; i++)
        {
            Debug.Log(stringList[i] + "\n");
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        string[] stringList =
        {
            "String 1q",
            "String 2asdasd",
            "String 3zxczxczxczxczxc",
            "String 4asda",
            "String 5qwdqwdqwd"
        };
        string longestString = stringList[0];
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        for (int i = 0; i < stringList.Length; i++)
        {
            if (stringList[i].Length > longestString.Length) longestString = stringList[i];
        }
        Debug.Log("Chuoi dai nhat la: " + longestString);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, 5 };
        int sum = 0;
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0) sum += nums[i];
        }
        Debug.Log("Tong cac phan tu la so le: " + sum);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0) Debug.Log(nums[i] + "\t");
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        int[] nums = { 1, 2, 3, 4, 5 };
        int checkNum = 2;
        bool check = false;
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == checkNum) check = true;
        }
        if (check) Debug.Log("Co ton tai");
        else Debug.Log("Khong ton tai");
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, -3, 4, 5 };
        int count = 0;
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0) count++;
        }
        Debug.Log("So luong phan tu am: " + count);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 33, 4, 50 };
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 10) Debug.Log(i + "\t");
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        string[] stringList =
        {
            "String 1q",
            "String 2asdasd",
            "String 3zxczxczxczxczxc",
            "String 4asda",
            "String 5qwdqwdqwd"
        };
        string shortestString = stringList[0];
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        for (int i = 0; i < stringList.Length; i++)
        {
            if (stringList[i].Length < shortestString.Length) shortestString = stringList[i];
        }
        Debug.Log("Chuoi ngan nhat: " + shortestString);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] * 2;
            Debug.Log(nums[i] + "\t");
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, 5 };
        int largest = nums[0];
        int secondLargest = int.MinValue;
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > largest)
            {
                secondLargest = largest;
                largest = nums[i];
            }
            else if (nums[i] > secondLargest && nums[i] < largest) secondLargest = nums[i];
        }
        if (largest != secondLargest) Debug.Log("So lon thu nhi: " + secondLargest);
        else Debug.Log("Khong co phan tu lon thu hai");
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        string[] stringList =
        {
            "ABCString 1q",
            "BACString 2asdasd",
            "ACSString 3zxczxczxczxczxc",
            "CASString 4asda",
            "AAAString 5qwdqwdqwd"
        };
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        for (int i = 0; i < stringList.Length; i++)
        {
            if (stringList[i].StartsWith("A")) Debug.Log(stringList[i] + "\n");
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        string[] stringList =
        {
            "ABCString checktest 1q",
            "BACString 2asdasd",
            "ACSStringchecktest 3zxczxczxczxczxc",
            "CASString 4asda",
            "AAAString checktest5qwdqwdqwd"
        };
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        for (int i = 0; i < stringList.Length; i++)
        {
            if (stringList[i].Contains("checktest")) Debug.Log(stringList[i] + "\n");
        }
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 1, 2, 3, 4, -5 };
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0) Debug.Log(nums[i] + "\t");
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        int[] nums = { 1, 2, 2, 2, 5 };
        int checkNum = 2;
        int count = 0;
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == checkNum) count++;
        }
        Debug.Log("So lan xuat hien cua so " + checkNum + " trong mang la: " + count);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        int[] nums = { 11, 21, 3, 4, 51 };
        List<int> greaterThanTenList = new List<int>();
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 10) greaterThanTenList.Add(nums[i]);
        }

        for (int i = 0; i < greaterThanTenList.Count; i++)
        {
            Debug.Log(greaterThanTenList[i]);
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        string[] stringList =
        {
            "ABCString checktest 1q",
            "BACString 2asdasd",
            "ACSStringchecktest 3zxczxczxczxczxc",
            "CASString 4asda",
            "AAAString checktest5qwdqwdqwd"
        };
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        for (int i = 0; i < stringList.Length; i++)
        {
            if (stringList[i].Length > 5) Debug.Log(stringList[i]);
        }
    }
}
