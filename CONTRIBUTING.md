# Katkı Rehberi

Projeye katkı vermek istediğiniz için teşekkürler! Lütfen aşağıdaki adımları izleyin.

## Geliştirme Ortamı
- Windows
- Visual Studio 2019/2022 veya MSBuild
- .NET Framework 4.8 Developer Pack
- `MaterialSkin.dll` ve `MaterialSkinPath` ortam değişkeni

## Başlarken
1. Depoyu forklayın ve klonlayın.
2. Yeni bir dal açın:
   ```bash
   git checkout -b feature/kisa-aciklama
   ```
3. Değişikliklerinizi küçük ve odaklı tutun.

## Kodlama Kuralları
- Değişken, sınıf ve metot adlarını İngilizce bırakın.
- Arayüz metinleri ve açıklamalar Türkçe olabilir.
- Gereksiz kapsamlı refactor yerine, hedeflenen problemi çözen minimal değişiklik yapın.

## Doğrulama
Katkı göndermeden önce mümkünse derlemeyi doğrulayın:

```powershell
msbuild .\AutoIt3FileInstallCreator.sln /t:Build /p:Configuration=Release
```

## Pull Request Süreci
- PR açıklamasında problemi, çözümü ve etkisini kısa maddelerle yazın.
- Varsa ekran görüntüsü ekleyin.
- Güvenlik etkisi olan değişikliklerde risk ve mitigasyonu ayrıca belirtin.

## Davranış
Yapıcı, saygılı ve kapsayıcı iletişim kurun.
