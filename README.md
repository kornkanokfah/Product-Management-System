# Project Product Management System

  ระบบการจัดการผลิตภัฑณ์ โดยการใช้ ASP.Net Core(C#) ในการเขียนคำสั่ง และใช้ SQL Server เป็นฐานข้อมูลในการจัดเก็บรายการผลิตภัณฑ์
โดยภายในระบบจะมีฟังก์ในการ   
**1. แสดงรายการผลิตภัฑณ์ทั้งหมด**     
**2. แสดงรายละเอียดเพิ่มเติมของผลิตภัฑณ์**      
**3. ฟังก์ชั่นเพิ่มรายการผลิตภัฑณ์**   
**4. ฟังก์ชั่นแก้ไขข้อมูลของผลิตภัฑณ์**   
**5. ฟังก์ลบผลิตภัฑณ์**   
**6. ฟังก์ชั่นการตรวจสอบข้อมูลในฟอร์ม เพิ่ม และแก้ไขผลิตภัฑณ์**   


# วิธีการใช้งานโปรเจค

  ก่อนใช้โปรเจคควรติดตั้งโปรแกรม microsoft visual studio ในการรันโปรเจค .Net และดาวน์โหลดโปรเจคผ่านทาง git  
      
   **การใช้งาน**   
หลังจาก ติดตั้งโปรแกรม microsoft visual studio และดาวน์โหลดโปรเจคผ่านทาง git เรียบร้อยแล้วสามารถเปิดโปรเจคโดยกดไปที่ไฟล์ ProductMS.sln

![image](https://github.com/user-attachments/assets/90fa83c5-b21d-4a63-923e-38d6b60e99f0)


พอเปิดโปรเจคแล้ว กดรันโปรเจคไปที่ **รัน https**

![image](https://github.com/user-attachments/assets/7b498955-6f22-49dc-8433-df36f07ae32c)

  เมื่อรันโปรเจคจะพบกับหน้าแสดงรายการผลิตภัฑณ์ทั้งหมด โดยในหน้านี้จะมี    
**ฟังก์ชั่นเพิ่มรายการผลิตภัฑณ์** อยู่บน navbar ชื่อว่า Add Product   
**ฟังก์ชั่นปุ่มแสดงรายละเอียดเพิ่มเติมของผลิตภัฑณ์** ชื่อว่า Details   
**ฟังก์ชั่นปุ่มแก้ไขข้อมูลของผลิตภัฑณ์** ชื่อว่า Edit   
**ฟังก์ลบผลิตภัฑณ์** ชื่อว่า Delete   

![image](https://github.com/user-attachments/assets/7e73e621-eb92-4a21-9908-2bddad1e9f0a)

  ในหน้า **เพิ่มรายการผลิตภัฑณ์** และ **แก้ไขข้อมูลของผลิตภัฑณ์** จะมีการตรวจสอบข้อมูลว่า Product Name และ Product Description ต้องห้ามเว้นว่าง   
Price และ Stock Quantity ต้องเป็นตัวเลขที่มากกว่า 0

![image](https://github.com/user-attachments/assets/cee652f3-8b00-44c1-9d07-f5a6ee438d3b)

  ในหน้าแก้ไข้ข้อมูลเมื่อ แก้ไขข้อมูลแล้วกดปุ่ม Update Product ระบบจะพาไปที่หน้า Product พร้อมกับข้อมูลที่แก้ไข้ใหม่

![image](https://github.com/user-attachments/assets/d723d550-b64b-4de0-addb-a0ec30687517)
![image](https://github.com/user-attachments/assets/8fa1c1d8-b198-4bf4-a08b-2e41357f8355)

  เมื่อกดปุ่ม Details ระบบจะแสดงหน้า **แสดงรายละเอียดเพิ่มเติมของผลิตภัฑณ์** โดยในหน้านี้ผู้ใช้สามารถดูรายละเอียดของสินค้าเพิ่มเติมได้ 

![image](https://github.com/user-attachments/assets/da88851a-3dc9-4af3-bae0-c88cb8929d93)

เมื่อกดปุ่ม Delete ระบบจะทำการสอบถามในการตัดสินใจยืนยันลบข้อมูลก่อนทำการลบข้อมูล

![image](https://github.com/user-attachments/assets/6c3f8510-2869-4bbe-b0f1-43fd406b05fc)
![image](https://github.com/user-attachments/assets/ec29769e-e357-44e2-8dad-08c22474d762)





