
# Virus – Antivirus Simülasyonu (Windows Forms)
 Proje Açıklaması

Bu proje, zararlı yazılımların (malware) çalışma mantığını ve antivirüslerin bu tür tehditleri nasıl etkisiz hâle getirdiğini göstermek amacıyla geliştirilmiş eğitsel bir Windows Forms simülasyonudur.
Gerçek bir virüs değildir ve sisteme kalıcı zarar vermez.

Simülasyonda:

“Virüs” butonu çalıştırıldığında fare imleci ekranın merkezine kilitlenir.

“Antivirüs” butonu çalıştırıldığında bu davranış durdurulur ve sistem normale döner.

# Teknik Çalışma Mantığı

System.Windows.Forms.Timer kullanılarak çok kısa aralıklarla (5 ms) çalışan bir payload oluşturulmuştur.

Bu payload, her tetiklendiğinde imleci ekranın tam ortasına taşır.

Antivirüs butonu, bu zamanlayıcıyı durdurarak tehdidi etkisiz hâle getirir.

Tüm işlemler uygulama içi çalışır, arka planda veya sistem seviyesinde işlem yapılmaz.
<img width="557" height="443" alt="image" src="https://github.com/user-attachments/assets/5f99a74c-59de-4aba-915a-b270bb78a492" />
<img width="558" height="448" alt="image" src="https://github.com/user-attachments/assets/a43f7052-e8c2-4210-a376-0a58761ddc25" />



🧪 Nasıl Kullanılır?
1️⃣ Virüsü Başlatma

“Infect / Virüs” butonuna tıklayın.

Fare imleci ekranın ortasına kilitlenecektir.

Ekranda kırmızı uyarı mesajı görüntülenir.

Olaylar log ekranına kaydedilir.

# Antivirüsü Çalıştırma (ÖNEMLİ)

Fare kilitlendiği için mouse ile tıklamak zorlaşabilir.

Kurtulma yöntemi:

TAB tuşuna basarak form üzerindeki butonlar arasında gezin.

Antivirüs (Clean) butonuna gel.

ENTER tuşuna bas.

Bu işlemden sonra:

Timer durdurulur

Fare serbest kalır

Sistem “GÜVENLİ” durumuna geçer

# Klavye Kısayolu Bilgisi
Tuş	İşlev
TAB	Butonlar arasında geçiş
ENTER	Seçili butonu çalıştırma

Bu özellik özellikle fare kilitliyken kurtarma senaryosunu göstermek için eklenmiştir.

# Log Sistemi

Uygulama içinde:

Virüs başlatma

Antivirüs çalıştırma

Sistem durumu
zaman damgası ile birlikte listelenir.

Bu sayede olayların sırası ve etkisi gözlemlenebilir.

# Projenin Amacı

Zararlı yazılımların davranış temelli çalışma mantığını göstermek

Antivirüslerin payload durdurma yaklaşımını öğretmek

Siber güvenlik, yazılım güvenliği ve savunma mekanizmalarına giriş sağlamak

# Güvenlik ve Etik Uyarı

Bu proje tamamen simülasyon amaçlıdır.

Gerçek sistemlere zarar verecek şekilde kullanılmamalıdır.

Eğitim, demo ve sunum amaçları dışında kullanılması önerilmez.

🛠 Kullanılan Teknolojiler

C#

.NET Framework

Windows Forms

System.Windows.Forms.Timer
