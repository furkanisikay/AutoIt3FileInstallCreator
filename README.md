# AutoIt3 FileInstall Creator

![C#](https://img.shields.io/badge/C%23-.NET%20Framework%204.8-239120?logo=csharp&logoColor=white)
![WinForms](https://img.shields.io/badge/UI-Windows%20Forms-0078D6)
![MaterialSkin](https://img.shields.io/badge/UI%20Theme-MaterialSkin-3F51B5)
![Lisans](https://img.shields.io/badge/Lisans-MIT-green)

## Neden Bu Proje?
AutoIt3 ile kurulum betikleri hazırlarken `FileInstall(...)` satırlarını klasör yapısına göre tek tek yazmak zaman alır ve hataya açıktır; bu proje, seçtiğiniz klasörü tarayıp hedef formatınıza uygun AutoIt3 çıktılarını otomatik üreterek tekrar eden işi azaltır, manuel hataları düşürür ve paketleme sürecini hızlandırır.

## Mimari / Özellikler
- .NET Framework 4.8 tabanlı Windows Forms masaüstü uygulaması.
- MaterialSkin ile modernleştirilmiş arayüz.
- Klasörleri rekürsif gezerek `FileInstall(...)` satırları üretme.
- İsteğe bağlı alt klasör oluşturma (`DirCreate(...)`) satırları üretme.
- Kaynak/hedef kök dizin dahil etme seçenekleri.
- Sonuç ekranında toplu kopyalama, tab ekleme/çıkarma ve boş satır temizleme araçları.

## Hızlı Başlangıç
> Aşağıdaki adımlar Windows + .NET Framework Developer Pack 4.8 yüklü bir ortam içindir.

```powershell
git clone https://github.com/furkanisikay/AutoIt3FileInstallCreator.git
cd AutoIt3FileInstallCreator
$env:MaterialSkinPath="C:\\kutuphaneler\\MaterialSkin.dll"
msbuild .\AutoIt3FileInstallCreator.sln /t:Restore,Build /p:Configuration=Release
```

## Ortam Kurulumu
1. **Gereksinimler**
   - Visual Studio 2019/2022 veya MSBuild araçları
   - .NET Framework 4.8 Developer Pack
   - `MaterialSkin.dll`
2. **Güvenli bağımlılık tanımı**
   - Projede sabit bir yerel kullanıcı yolu kaldırılmıştır.
   - `AutoIt3FileInstallCreator.csproj` dosyası artık `MaterialSkinPath` ortam değişkenini kullanır.
3. **Ortam değişkeni tanımlama (PowerShell)**
   ```powershell
   setx MaterialSkinPath "C:\\kutuphaneler\\MaterialSkin.dll"
   ```
   Yeni terminal açtıktan sonra derleme komutlarını çalıştırın.

## Güvenlik Notu (Kod Denetimi)
- Kod tabanı hardcoded şifre, API anahtarı ve token ifadeleri için taranmıştır.
- Kritik bulgu: `.csproj` içinde geliştirici makinesine ait sabit yerel yol (`...\\Furkan...`) vardı.
- Çözüm: Bağımlılık yolu `$(MaterialSkinPath)` ile ortam değişkenine taşındı.

## Refactoring Planı (Önceliklendirilmiş İlk 3 Adım)
1. **İş mantığını UI katmanından ayırın**: `KlasorCiktiOlustur` ve `CiktiOlustur` metotlarını ayrı bir servis sınıfına taşıyarak test edilebilirliği artırın.
2. **Tekrarlı satır-sonu temizliğini merkezileştirin**: `ResultForm` içindeki benzer `StringBuilder` sonlandırma kodlarını tek yardımcı metoda toplayın.
3. **Hata yönetimini güçlendirin**: Geçersiz klasör durumunda akışı `return` ile kesip gereksiz işlemleri önleyin; dosya erişim hataları için kullanıcıya açıklayıcı mesaj verin.

## Katkı
Katkı süreci için `CONTRIBUTING.md` dosyasını inceleyin.

## Lisans
Bu proje **MIT** lisansı ile yayımlanır. Ayrıntılar için `LICENSE` dosyasına bakın.
