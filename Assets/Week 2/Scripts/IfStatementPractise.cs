using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        // Nhập một số từ bàn phím
        int num = -3;

        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        string result = num > 0 ? "So duong" : num < 0 ? "So am" : "So 0";
        Debug.Log("BT1 - So da nhap: " + num + ". " + result);
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        // Nhập một số từ bàn phím
        int num = 18;
        // Kiểm tra xem số đó là số chẵn hay lẻ
        string result = num % 2 != 0 ? "So le" : "So chan";
        Debug.Log("BT2 - So da nhap: " + num + ". " + result);
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        double avg = 4.9;
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        Debug.Log("BT3 - Diem trung binh: " + avg + ". " + (avg >= 5 ? "Thi do" : "Thi truot"));
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        // Nhập hai số nguyên từ bàn phím
        int num1 = 23;
        int num2 = 5;
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        int max = num1;
        if (max < num2) max = num2;
        Debug.Log("BT4 - Hai so da nhap: " + num1 + " va " + num2 + ". " + "So lon hon la " + max);

    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        int budget = 30;
        int price = 30;
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        string result = budget >= price ? "Du tien" : "Khong du tien";
        Debug.Log("BT5 - Budget va Price lan luot la: " + budget + " va " + price + ". " + result);
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        // Nhập một năm từ bàn phím
        int year = 1999;
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        //
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Debug.Log("BT6 - Nam da nhap: " + year + " la nam nhuan."); // La nam nhuan
                }
                Debug.Log("BT6 - Nam da nhap: " + year + " khong phai nam nhuan."); // Khong phai nam nhuan
            }
            Debug.Log("BT6 - Nam da nhap: " + year + " la nam nhuan."); // La nam nhuan
        }
        Debug.Log("BT6 - Nam da nhap: " + year + " khong phai nam nhuan."); // Khong phai nam nhuan
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        // Nhập tuổi của người mua vé từ bàn phím
        int age = 12;
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        string result = age < 18 ? "Gia ve 50k" : "Gia ve 100k";
        Debug.Log("BT7 - Tuoi da nhap: " + age + ". " + result);
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        double avg = 5.5;
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        Debug.Log("BT8 - Diem trung binh: " + avg + ". " + (avg >= 9 ? "Xuat sac" : "Khong xuat sac"));
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        // Nhập ba số nguyên từ bàn phím
        int num1 = 7;
        int num2 = 3;
        int num3 = 12;
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        int max = num1;
        if (max < num2) max = num2;
        if (max < num3) max = num3;
        Debug.Log("BT9 - Ba so da nhap: " + num1 + ", " + num2 + ", " + num3 + ". " + "Max = " + max);
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        double hours = 41;
        double fixedWage = 10;
        double overTimeRate = 1.5;
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        double paid = hours <= 40 ? hours * fixedWage : 40 * fixedWage + (hours - 40) * fixedWage * overTimeRate;
        Debug.Log("BT10 - Gio lam = " + hours + "; Gio cong: " + fixedWage + "; Muc tang ca: " + overTimeRate + " -> " + "Duoc tra: " + paid);
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        int age = 19;
        bool hasMembership = false;
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        string result = (age > 18 && hasMembership) ? "IN" : "OUT";
        Debug.Log("BT11 -  Age = " + age + "; Membership: " + (!hasMembership ? "No" : "Yes") + " -> " + result);
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        double avg = 5.6;
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        string rank;
        if (avg >= 8) rank = "Xuat sac";
        else if (avg >= 5) rank = "Trung binh";
        else rank = "Yeu";
        Debug.Log("BT12 - Diem trung binh: " + avg + " -> " + rank + "\n(Chi co 3 rank: Xuat sac, Trung binh, Yeu)");
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        // Nhập số điện tiêu thụ từ bàn phím
        double consumedkWh = 120;
        double payment;
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        if (consumedkWh <= 100) payment = 1500 * consumedkWh;
        else payment = 100 * 1500 + (consumedkWh - 100) * 2000;
        Debug.Log("BT13 - Dien tieu thu = " + consumedkWh + "-> Tien dien = " + payment);
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        // Nhập số năm làm việc và đánh giá công việc
        double yearOfExp = 5.5;
        string rate = "Good";
        string result;
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        if (yearOfExp > 5 && rate == "Good") result = "Thang chuc";
        else result = "Khong thang chuc";
        Debug.Log("BT14 - So nam kinh nghiem: " + yearOfExp + ". Danh gia: " + rate + " -> " + result);

    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        // Nhập giá trị đơn hàng từ bàn phím
        double orderPrice = 510000;
        string result;
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        if (orderPrice >= 500000) result = "Freeship";
        else result = "No freeship";
        Debug.Log("BT15 - Gia tri don hang: " + orderPrice + " -> " + result);
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        // Nhập thu nhập từ bàn phím
        double income = 10000000;
        double taxRate = 0;
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        if (income > 18000000) Debug.Log("BT16 - Bai tap nay chi vi du cho thu nhap tu 5m den 18m");
        else if (income <= 18000000) taxRate = 0.15;
        else if (income <= 10000000) taxRate = 0.1;
        else if (income <= 5000000) taxRate = 0.05;
        Debug.Log("BT16 - Thu nhap = " + income + " -> Thue = " + taxRate * 100 + "%");

    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        double score1 = 5.5;
        double score2 = 9;
        double score3 = 8.5;
        double avg = (score1 + score2 + score3) / 3;
        string result = avg >= 5 ? "Dat" : "Khong dat";
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        Debug.Log("BT17 - Diem trung binh = " + avg + " -> " + result);
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        int inventoryItems = 90;
        bool hasSlot = true;
        string result;
        if (inventoryItems < 100 && hasSlot == true) result = "Co the nhap hang";
        else result = "Khong the nhap hang";
        Debug.Log("BT18 - So luong hang = " + inventoryItems + ". " + (hasSlot ? "Con cho" : "Khong con cho") + " -> " + result);
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        // Nhập một số từ bàn phím
        int num = 11;
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        Debug.Log("BT19 - So da nhap: " + num + " -> " + (num > 10 ? "Lon hon 10" : "Khong lon hon 10"));
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        int score = 6;
        bool satisfyOtherTerms = true;
        string result;
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        if (score >= 6.5 && satisfyOtherTerms == true) result = "Du dieu kien dang ky";
        else result = "Khong du dieu kien dang ky";
        Debug.Log("BT20 - Diem = " + score + ". " + (satisfyOtherTerms ? "Thoa cac dieu kien khac" : "Khong thoa cac dieu kien khac") + " -> " + result);
    }
}
