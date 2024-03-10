Özellikler
  - Toplama, çıkartma, bölme, çarpma özelliklerini temel düzeyde yapabilir
  - Shift butonu ile butonlara 2. özellik eklenebilir

Hakkımda

-  Shift   =>    's' 
-  Cos     =>    'z' 
-  Sin     =>    'x'
-  Eşittir =>    'Enter' 
-  Ans     =>    'Sağ Ok Tuşu'
-  Silme   =>    'Backspace'
   
Versiyon 1.01 (22.02.2024)
     Hesap makinesine fiziksel tuşların bağlantısı yapıldı.
     9 tuşundaki CLR modu, "<-" tuşundaki Hk modu ile yer değiştirdi.
     Bazı tuşlar bölümü eklendi, tuşlar hakkında bilgi verildi.
     Hakkımda bölümünde tarihlerin sırası değiştirildi.

(Hotfix 14.02.2024) "-∞" sonrasında oluşabilen kritik hata düzeltildi.

Hata düzeltmesi (13.02.2024)
     0/0 yaptıktan sonra NaN hatası ardından işlem yapılmaya çalışıldığında alınan kritik hata giderildi.
     Herhangi bir sayı / 0 yapıldıktan sonra ∞ ardından işlem yapılmaya çalışıldığında alınan kritik hata giderildi.

Versiyon: 1.0 (Gold) (06.02.2024)

Projeye başlama tarihi: 02.02.2024
Projenin bitiş  tarihi:       06.02.2024

Proje geliştirilirken 0'dan çıkışına kadar eklenen özellikler;

-    Toplama, eşittir, numerik tuşlar (Button) ve Ekran (Textbox) eklendi
-    Çıkarma, Bölme ve Çarpma tuşları eklendi
-    "Hata 13" eklendi (bu hata ekranda değer girilmemesine karşın işlem yapılmaya çalışıldığında alınır)
-    Silme tuşu eklendi, bu sayede karakterler tek tek silinebilir oldu
-    Shift butonu eklendi, bu sayede bir tuşa 2. bir fonksiyon tanımlanabilir oldu (Buton_Shift metodu sayesinde değişim kolaylaştırıldı)
-    Cos ve Sin hesaplama fonksiyonluğu kazandırıldı
-    "Matematiksel hata: 11" eklendi (Shift modunda iken Cos-1 ve Sin-1'işlemlerinde 1'den büyük değer girildiğinde alınır)
-    Virgül eklendi, bu sayede ondalıklı işlemler yapılabilir oldu
-    Kontrol metotları eklendi bu sayede kodun okunurluğu arttı
-    Hakkımda sekmesi eklendi, versiyon numarası, programın özellikleri ve proje hakkında bilgilerin görüntülendiği ekran eklendi
